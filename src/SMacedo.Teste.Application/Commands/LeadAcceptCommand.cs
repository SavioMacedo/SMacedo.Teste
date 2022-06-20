using CSharpFunctionalExtensions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMacedo.Teste.Application.Commands
{
    public class LeadAcceptCommand:IRequest<Result>
    {
        public int Id { get; init; }

        public LeadAcceptCommand(int id)
        {
            Id = id;
        }
    }
}
