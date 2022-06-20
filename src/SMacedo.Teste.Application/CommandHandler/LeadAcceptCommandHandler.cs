using CSharpFunctionalExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SMacedo.Teste.Application.Commands;
using SMacedo.Teste.Application.Notifications;
using SMacedo.Teste.Domain.Contracts;
using SMacedo.Teste.Domain.Entities;
using SMacedo.Teste.Domain.Respositories;

namespace SMacedo.Teste.Application.CommandHandler
{
    public class LeadAcceptCommandHandler : IRequestHandler<LeadAcceptCommand, Result>
    {
        private readonly ILeadsContext _leadsUoW;
        private readonly IMediator _mediator;

        public LeadAcceptCommandHandler(ILeadsContext leadsUoW, IMediator mediator) => (_leadsUoW, _mediator) = (leadsUoW, mediator);

        public async Task<Result> Handle(LeadAcceptCommand request, CancellationToken cancellationToken)
        {
            Lead? lead = await _leadsUoW.Leads.FirstOrDefaultAsync(predicate: a => a.Id == request.Id, cancellationToken: cancellationToken);
            
            if (lead == null)
                return Result.Failure("Id não encontrado");

            Result result = await _leadsUoW.AcceptLeadAsync(lead, cancellationToken);

            if(result.IsSuccess)
            {
                await _mediator.Publish(new EmailNotification($"Lead aceitado {lead.Id}", lead.Email, "lead aceitado"), cancellationToken);
                return result;
            }

            return result;
        }
    }
}
