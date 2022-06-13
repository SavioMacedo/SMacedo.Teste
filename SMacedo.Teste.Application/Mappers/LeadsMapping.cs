using SMacedo.Teste.Application.ViewModels;
using SMacedo.Teste.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMacedo.Teste.Application.Mappers
{
    public static class LeadsMapping
    {
        public static IEnumerable<LeadInvitedViewModel> ToLeadInvitedViewModel(this IEnumerable<Lead> leads)
        {
            return leads.Select(a => new LeadInvitedViewModel
            {
                Category = a.Category,
                Description = a.Description,
                CreateDate = a.CreateDate.ToString("MMMM dd yyyy @ t"),
                FirstName = a.FirstName,
                Id = a.Id,
                Location = a.Suburb,
                Price = a.Price
            });
        }

        public static IEnumerable<LeadAcceptedViewModel> ToLeadAcceptedViewModel(this IEnumerable<Lead> leads)
        {
            return leads.Select(a => new LeadAcceptedViewModel
            {
                Category = a.Category,
                Description = a.Description,
                CreateDate = a.CreateDate.ToString("MMMM dd yyyy @ t"),
                FirstName = a.FirstName,
                Id = a.Id,
                Location = a.Suburb,
                Price = a.Price,
                Email = a.Email,
                Phone = a.Phone
            });
        }
    }
}
