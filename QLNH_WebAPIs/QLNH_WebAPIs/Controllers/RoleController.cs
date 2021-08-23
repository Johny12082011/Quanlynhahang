using Microsoft.AspNetCore.Mvc;
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
    public class RoleController : ControllerBase
    {
        private readonly ApplicationDbContext _context; //{get;set;}
        public RoleController(ApplicationDbContext context)
        {
            _context = context;
        }
        /// <summary>
        /// Lay tat ca danh sach Role
        /// </summary>
        /// <returns>Danh sach Role</returns>
        [HttpGet]
        public IEnumerable<Role> Get()
        {
            return _context.Role.ToList();  //Tên User --> khai báo Folder Data  public DbSet<User> User { get; set; }
        }

        /// <summary>
        /// Lay Role voi Id
        /// </summary>
        /// <returns>Danh sach Role</returns>
        /// <para name=""Id> Tham sao la Id cua Role</para>
        [HttpGet("Id")]
        public Role Get([FromQuery] int Id)
        {
            return _context.Role.Where(e=> e.Id == Id).FirstOrDefault();  //Tên User --> khai báo Folder Data  public DbSet<User> User { get; set; }
        }

        ///Them Role moi
        [HttpPost]
        public Role Post([FromQuery] Role role)
        {
            _context.Role.Add(role);
            _context.SaveChanges();
            return role;
        }


    }
}
