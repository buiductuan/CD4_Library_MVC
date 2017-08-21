using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Tables;
namespace Library.Models
{
    public class LoginModels
    {
        public string username { get; set; }
        public string password { get; set; }

        LibDBContext db;
        public LoginModels()
        {
            db = new LibDBContext();
        }

        public bool isLogin(string username, string password)
        {
            var result = db.sys_users.Where(u => u.UserName == username && u.Password == password).Count();
            if (result > 0)
                return true;
            else
                return false;
        }
    }
}