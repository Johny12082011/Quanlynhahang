using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QLNH_WebAPIs.Model
{
    public class GuestTable
    {
        [Key]
        public int Id { get; set; }
        public int Name { get; set; }
        public string Phone { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public bool Deleted { get; set; }
        public virtual Status Status { get; set; } //Kiểu lookup tabel
        public virtual Guest Guest { get; set; } //Kiểu lookup tabel
    }
}
