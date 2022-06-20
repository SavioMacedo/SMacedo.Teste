using CSharpFunctionalExtensions;
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

        public static async Task<Result> DeclineLeadAsync(this ILeadsContext context, Lead lead, CancellationToken cancellationToken)
        {
            lead.LeadStatus = Entities.Enums.LeadStatus.Declined;
            context.Leads.Update(lead);
            int result = await context.SaveChangesAsync(cancellationToken);
            return (result == 1) ? Result.Success() : Result.Failure("Ocorreu um erro ao gravar os dados.");
        }

        public static async Task<Result> AcceptLeadAsync(this ILeadsContext context, Lead lead, CancellationToken cancellationToken)
        {
            lead.LeadStatus = Entities.Enums.LeadStatus.Accepted;

            if (lead.Price > 500)
            {
                lead.Price -= (lead.Price * 0.1);
            }

            context.Leads.Update(lead);
            int result = await context.SaveChangesAsync(cancellationToken);
            return (result == 1) ? Result.Success() : Result.Failure("Ocorreu um erro ao gravar os dados.");
        }
    }
}
