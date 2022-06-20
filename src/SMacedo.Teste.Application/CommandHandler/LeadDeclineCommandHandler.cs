using CSharpFunctionalExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SMacedo.Teste.Application.Commands;
using SMacedo.Teste.Domain.Contracts;
using SMacedo.Teste.Domain.Entities;
using SMacedo.Teste.Domain.Respositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMacedo.Teste.Application.CommandHandler
{
    public class LeadDeclineCommandHandler : IRequestHandler<LeadDeclineCommand, Result>
    {
        private readonly ILeadsContext _leadsUoW;

        public LeadDeclineCommandHandler(ILeadsContext leadsUoW)  => (_leadsUoW) = (leadsUoW);

        public async Task<Result> Handle(LeadDeclineCommand request, CancellationToken cancellationToken)
        {
            Lead? lead = await _leadsUoW.Leads.FirstOrDefaultAsync(predicate: a => a.Id == request.Id, cancellationToken: cancellationToken);

            if (lead == null)
                return Result.Failure("Id não encontrado");

            Result result = await _leadsUoW.DeclineLeadAsync(lead, cancellationToken);
            return result;
        }
    }
}
