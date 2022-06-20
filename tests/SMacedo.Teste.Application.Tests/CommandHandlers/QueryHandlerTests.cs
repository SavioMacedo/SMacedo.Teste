using CSharpFunctionalExtensions;
using Moq.EntityFrameworkCore;
using SMacedo.Teste.Application.QueryHandler;
using SMacedo.Teste.Application.Querys;
using SMacedo.Teste.Application.Tests.Fixtures;
using SMacedo.Teste.Application.ViewModels;
using SMacedo.Teste.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SMacedo.Teste.Application.Tests.CommandHandlers
{
    [Collection(nameof(RequestFixturesCollection))]
    public class QueryHandlerTests
    {
        private readonly RequestFixtures _fixture;

        public QueryHandlerTests(RequestFixtures fixture)
        {
            _fixture = fixture;
        }

        [Fact(DisplayName = "Retorna leads aceitos com sucesso.")]
        public async Task LeadAccept_Handle_Success()
        {
            //Arrange
            IQueryable<Lead> leadsMockData = _fixture.GetLeads();
            _fixture.ContextMock.Setup(a => a.Leads).ReturnsDbSet(leadsMockData);

            LeadsAcceptedQueryHandler handler = _fixture.GetLeadsAcceptedQueryHandler();
            LeadsAcceptedQuery request = new();

            //Act
            Result<IEnumerable<LeadAcceptedViewModel>> result = await handler.Handle(request, CancellationToken.None);

            //Assert
            Assert.True(result.IsSuccess);
            Assert.NotNull(result.Value);
        }

        [Fact(DisplayName = "Retorna leads enviados com sucesso.")]
        public async Task LeadInvited_Handle_Success()
        {
            //Arrange
            IQueryable<Lead> leadsMockData = _fixture.GetLeads();
            _fixture.ContextMock.Setup(a => a.Leads).ReturnsDbSet(leadsMockData);

            LeadsInvitedQueryHandler handler = _fixture.GetLeadsInvitedQueryHandler();
            LeadsInvitedQuery request = new();

            //Act
            Result<IEnumerable<LeadInvitedViewModel>> result = await handler.Handle(request, CancellationToken.None);

            //Assert
            Assert.True(result.IsSuccess);
            Assert.NotNull(result.Value);
        }
    }
}
