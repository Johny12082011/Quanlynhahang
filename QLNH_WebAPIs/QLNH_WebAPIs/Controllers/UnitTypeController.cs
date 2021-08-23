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
    public class UnitTypeController : ControllerBase
    {
        private readonly ApplicationDbContext _context; //{get;set;}
        public UnitTypeController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<UnitType> Get()  //User --> lấy trong Model/Item
        {
            return _context.UnitType.ToList();  //Tên User --> khai báo Folder Data  public DbSet<User> User { get; set; }
        }
    }
}
