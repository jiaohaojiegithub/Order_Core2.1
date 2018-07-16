using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.EntityFrameworkCore;
using Order_Core2.APIDBModels.Model;
namespace Order_Core2.APIDBModels
{
    public class APIDBContext: DbContext
    {
        public APIDBContext(DbContextOptions<APIDBContext> options) : base(options)
        {
            //连接到数据服务器
        }
        public DbSet<User_Login> User_Logins { get; set; }
    }
}
