using CSharpFunctionalExtensions;
using MediatR;
using SMacedo.Teste.Application.Mappers;
using SMacedo.Teste.Application.Querys;
using SMacedo.Teste.Application.ViewModels;
using SMacedo.Teste.Domain.Contracts;
using SMacedo.Teste.Domain.Entities;
using SMacedo.Teste.Domain.Respositories;

namespace SMacedo.Teste.Application.QueryHandler
{
    public class LeadsInvitedQueryHandler : IRequestHandler<LeadsInvitedQuery, Result<IEnumerable<LeadInvitedViewModel>>>
    {
        private readonly ILeadsContext _leadsUoW;

        public LeadsInvitedQueryHandler(ILeadsContext leadsUoW) => _leadsUoW = leadsUoW;

        public async Task<Result<IEnumerable<LeadInvitedViewModel>>> Handle(LeadsInvitedQuery request, CancellationToken cancellationToken)
        {
            try
            {
                IEnumerable<Lead> leads = await _leadsUoW.GetInvitedLeadsAsync();
                return Result.Success(leads.ToLeadInvitedViewModel());
            }
            catch
            {
                //Todo: Log Error
                return Result.Failure<IEnumerable<LeadInvitedViewModel>>("Ocorreu um erro de validação.");
            }
        }
    }
}
