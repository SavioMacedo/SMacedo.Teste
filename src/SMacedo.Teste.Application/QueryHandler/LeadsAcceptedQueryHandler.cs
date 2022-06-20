using CSharpFunctionalExtensions;
using MediatR;
using SMacedo.Teste.Application.Mappers;
using SMacedo.Teste.Application.Querys;
using SMacedo.Teste.Application.ViewModels;
using SMacedo.Teste.Domain.Contracts;
using SMacedo.Teste.Domain.Entities;
using SMacedo.Teste.Domain.Respositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMacedo.Teste.Application.QueryHandler
{
    public class LeadsAcceptedQueryHandler : IRequestHandler<LeadsAcceptedQuery, Result<IEnumerable<LeadAcceptedViewModel>>>
    {
        private readonly ILeadsContext _leadsUoW;

        public LeadsAcceptedQueryHandler(ILeadsContext leadsUoW) => _leadsUoW = leadsUoW;

        public async Task<Result<IEnumerable<LeadAcceptedViewModel>>> Handle(LeadsAcceptedQuery request, CancellationToken cancellationToken)
        {
            IEnumerable<Lead> leads = await _leadsUoW.GetAcceptedLeadsAsync();
            return Result.Success(leads.ToLeadAcceptedViewModel());
        }
    }
}
