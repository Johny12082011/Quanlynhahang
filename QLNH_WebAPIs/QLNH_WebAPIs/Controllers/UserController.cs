using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using QLNH_WebAPIs.Data;
using QLNH_WebAPIs.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLNH_WebAPIs.Controllers 
{
    [ApiController]
    [Route("[Controller]")]  // --> tên API là tên Controller
    public class UserController : ControllerBase
    {
        private readonly ApplicationDbContext _context; //{get;set;}
        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<User> Get()  //User --> lấy trong Model/Item
        {
            return _context.User.ToList();  //Tên User --> khai báo Folder Data  public DbSet<User> User { get; set; }
        }
        /// <summary>
        /// Lay User voi Id
        /// </summary>
        /// <returns>Danh sach User</returns>
        /// <para name=""Id> Tham sao la Id cua User</para>
        [HttpGet("Id")]
        public User Get([FromQuery] int Id)
        {
            return _context.User.Where(e => e.Id == Id).FirstOrDefault();  //Tên User --> khai báo Folder Data  public DbSet<User> User { get; set; }
        }

        ///Them Role moi
        [HttpPost]
        public User Post([FromQuery] User user)
        {
            _context.User.Add(user);
            _context.SaveChanges();
            return user;
        }
    }
}
