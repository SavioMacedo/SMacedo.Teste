using Microsoft.EntityFrameworkCore;
using SMacedo.Teste.Domain.Contracts;
using SMacedo.Teste.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMacedo.Teste.Domain.Respositories
{
    public static class LeadRepository
    {
        public static async Task<IEnumerable<Lead>> GetInvitedLeadsAsync(this ILeadsContext context)
        {
            return await context.Leads.Where(a => a.LeadStatus == Entities.Enums.LeadStatus.Invited).AsNoTracking().ToListAsync();
        }

        public static async Task<IEnumerable<Lead>> GetAcceptedLeadsAsync(this ILeadsContext context)
        {
            return await context.Leads.Where(a => a.LeadStatus == Entities.Enums.LeadStatus.Accepted).AsNoTracking().ToListAsync();
        }
    }
}
