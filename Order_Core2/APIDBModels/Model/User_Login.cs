using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Order_Core2.APIDBModels.Model
{
    public class User_Login
    {
        public int User_Login_ID { get; set; }
        public string User_Login_Name { get; set; }
        public string User_Login_EmailAddress { get; set; }
        public string User_Login_PassWord { get; set; }
        public string User_Login_Sex { get; set; }
        public int User_Login_Right { get; set; }
        public bool User_Login_State { get; set; }
        public Guid User_Login_Guid { get; set; }
        public DateTime User_Login_CreatDT { get; set; }
    }
}
