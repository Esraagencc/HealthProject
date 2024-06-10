using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health.Entity
{
    public class Doctor
    {
        public int Id { get; set; }

        [DisplayName("Ad Soyad")]
        public string Name { get; set; }
        [DisplayName("Resim")]
        public string ImagePath { get; set; }
        public bool Status { get; set; }

        public int BranchId { get; set; }
        public Branch Branch { get; set; }
    }
}
