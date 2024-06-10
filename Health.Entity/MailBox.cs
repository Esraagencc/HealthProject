using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health.Entity
{
    public class MailBox
    {
        public int? Id { get; set; }
        public string? FullName { get; set; }
        public string? SendEmail { get; set; }
        public DateTime? RandevuDate { get; set; }
        public string? Department { get; set; }
        public string? Phone { get; set; }
        public string? Message { get; set; }
    }
}
