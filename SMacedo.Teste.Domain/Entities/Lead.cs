using SMacedo.Teste.Domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMacedo.Teste.Domain.Entities
{
    public class Lead
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreateDate { get; set; }
        public string Suburb { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Category { get; set; }
        public LeadStatus LeadStatus { get; set; }
    }
}
