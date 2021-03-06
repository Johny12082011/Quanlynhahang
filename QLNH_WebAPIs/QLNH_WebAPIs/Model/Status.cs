using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QLNH_WebAPIs.Model
{
    public class Status
    {
        [Key]
        public int Id { get; set; }
        public int Name { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public bool Deleted { get; set; }
        public virtual UnitType UnitType { get; set; }
    }
}
