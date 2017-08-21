var DmBmController = {
    init: function () {
        DmBmController.registerEvent();
    },
    registerEvent: function () {
        //LoadData
        function LoadData() {
            var temp = '';
            var sl_parent = '<option value="0">-- Chọn danh mục cha --</option>';
            $('#datatable tbody').html("");
            $('#dm_parent').html("");
            $.getJSON('/AdminCP/DmBm/getList', function (data) {
                $.each(data, function (i, item) {
                    $.each(item, function (index, data) {
                        temp += '<tr><td>' + data.ky_hieu + '</td><td>' + data.ten + '</td><td>' + data.ghi_chu + '</td><td><input type=\"checkbox\"' + (data.active == true ? "checked=\"checked\"" : "") + ' disabled/></td><td><a href="#" data-id=' + data.ma + ' class="btn_update">Sửa</a> | <a  data-id=' + data.ma + ' class="btn_detail" href="#">Chi tiết</a> | <a  data-id=' + data.ma + ' class="btn_delete" href="#">Xóa</a></td></tr>';
                        sl_parent += '<option value="' + data.ma + '">'+data.ten+'</option>';
                    });
                });
                $('#datatable tbody').append(temp);
                $('#dm_parent').append(sl_parent);
            });
        };
        LoadData();

        function CloseModal() {
            $('.modal').hide();
        };

        $('.modal-footer button').click(function () {
            CloseModal();
        });

        //get update
        $(document).delegate('.btn_update','click', function (e) {
            e.preventDefault();
            var id = $(this).data("id");
            $('#update_modal').show();

            $.get("/AdminCP/DmBm/getARecord?id=" + id, function (data) {
                var dm = data.split("#");
                $('#ID_hide').val(dm[0]);
                $('#ten').val(dm[1]);
                $('#kyhieu').val(dm[2]);
                $('#ghi_chu').val(dm[3]);
                if (dm[4] == "True") {
                    $('#actived').attr("checked", "checked");
                }
            });
        });
        // get Detail
        $(document).delegate('.btn_detail','click', function (e) {
            e.preventDefault();
            var id = $(this).data("id");
            $('#update_modal').hide();
            $('#detail_modal').show();

            $.get("/AdminCP/DmBm/getADetail?id=" + id, function (data) {
                var dm = data.split("#");

                $('#ten_detail').text(dm[0]);
                $('#ky_hieu_detail').text(dm[1]);
                $('#ghi_chu_detail').text(dm[2]);
                if (dm[3] == "True") {
                    $('#active_detail').attr("checked", "checked");
                }
                $('#ma_parent_detail').text(dm[4]);
                $('#username_detail').text(dm[5]);
                $('#edit_date_detail').text(dm[6]);
                $('#table_name_detail').text(dm[7]);
                $('#last_code_detail').text(dm[8]);                
            });
        });

        //post update
        $('#btn_update_modal').off('click').on('click', function (e) {
            e.preventDefault();
            var ma = $('#ID_hide').val();
            var ten = $("#ten").val();
            var ky_hieu = $("#kyhieu").val();
            var ghichu = $('#ghi_chu').val();
            var active = $("#actived").is(':checked');
            var bm = { ma: ma, ten: ten, ky_hieu: ky_hieu, ghi_chu: ghichu, active: active };
            $.post("/AdminCP/DmBm/postUpdate", bm, function (data) {
                if (data) {
                    CloseModal();
                    bootbox.alert('Cập nhật bản ghi thành công !!!');
                    LoadData();
                }
            });
        });
        
        //Post Create 
        $('#btn_create_modal').off('click').on('click', function (e) {
            e.preventDefault();
            var ma = $('#ma').val();
            var ten = $('#cten').val();
            var ky_hieu = $('#cky_hieu').val();
            var ghi_chu = $('#cghi_chu').val();
            var active = $('#cactived').is(':checked');
            var ma_parent = $('#dm_parent').find(":selected").val();
            var data = {
                ma: ma,
                ten: ten,
                ky_hieu: ky_hieu,
                ma_parent : ma_parent,
                ghi_chu: ghi_chu,
                active: active,
            };
            console.log(data);
            if (ma != "" && ten !="" && ky_hieu!="") {
                $.post("/AdminCP/DmBm/postCreate",
                    data, function (result) {
                        if (result ==true) {
                            CloseModal();
                            bootbox.alert("Thêm mới danh mục thành công !!!");
                            LoadData();
                        } else {
                            CloseModal();
                            bootbox.alert("Có lỗi xảy ra !!!");
                            LoadData();
                        }
                });
            }
        });
        //delete
        $(document).delegate('.btn_delete', 'click', function (e) {
            e.preventDefault();
            var ma = $(this).data('id');
            bootbox.confirm({
                title: "Xóa bản ghi này ?",
                message: "Bạn có muốn xóa bản ghi này không ? Thao tác này không thể phục hồi.",
                buttons: {
                    cancel: {
                        label: 'Cancel'
                    },
                    confirm: {
                        label: 'OK'
                    }
                },
                callback: function (result) {
                    if (result) {
                        $.get('/AdminCP/DmBm/getDelete?id=' + ma, function (data) {
                            if (data) {
                                bootbox.alert('Xóa thành công bản ghi');
                                LoadData();
                            }
                        });
                    }
                }
            });
        });
    }
};

DmBmController.init();