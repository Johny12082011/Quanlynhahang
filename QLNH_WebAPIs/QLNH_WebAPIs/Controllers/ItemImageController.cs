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
    public class ItemImageController : ControllerBase
    {
        private readonly ApplicationDbContext _context; //{get;set;}
        public ItemImageController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<ItemImage> Get()
        {
            return _context.ItemImage.ToList();  //Tên User --> khai báo Folder Data  public DbSet<User> User { get; set; }
        }
    }
}
