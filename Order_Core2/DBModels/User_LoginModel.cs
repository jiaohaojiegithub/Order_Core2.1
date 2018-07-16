using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Order_Core2.DBModels
{
    public class User_LoginModel
    {
        //public int User_Login_ID { get; set; }
        [Required]
        public string User_Login_Name { get; set; }
        [DataType(DataType.EmailAddress,ErrorMessage ="请输入正确的电子邮件地址")]
        public string User_Login_EmailAddress { get; set; }
        [Required]
        public string User_Login_PassWord { get; set; }
        public string User_Login_Sex { get; set; }
        public int User_Login_Right { get; set; }
        public bool User_Login_State { get; set; }
        //public Guid User_Login_Guid { get; set; }
        //public DateTime User_Login_CreatDT { get; set; }
    }
}
