using CSharpFunctionalExtensions;
using MediatR;
using SMacedo.Teste.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMacedo.Teste.Application.Querys
{
    public class LeadsAcceptedQuery: IRequest<Result<IEnumerable<LeadAcceptedViewModel>>>
    {
    }
}
