using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health.Entity
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Branch { get; set; }
        public string ImageUrl { get; set; }
        public bool Status { get; set; }
    }
}
