using CSharpFunctionalExtensions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMacedo.Teste.Application.Commands
{
    public class LeadDeclineCommand: IRequest<Result>
    {
        public int Id { get; init; }
        public LeadDeclineCommand(int id)
        {
            Id = id;
        }
    }
}
