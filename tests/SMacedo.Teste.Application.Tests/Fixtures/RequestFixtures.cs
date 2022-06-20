using AutoFixture;
using MediatR;
using Moq;
using SMacedo.Teste.Application.CommandHandler;
using SMacedo.Teste.Application.QueryHandler;
using SMacedo.Teste.Domain.Contracts;
using SMacedo.Teste.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SMacedo.Teste.Application.Tests.Fixtures
{
    [CollectionDefinition(nameof(RequestFixturesCollection))]
    public class RequestFixturesCollection: ICollectionFixture<RequestFixtures> { }
    public class RequestFixtures
    {
        private Fixture _autoFixture;

        public Mock<ILeadsContext> ContextMock { get; }

        public RequestFixtures() 
        {
            ContextMock = new Mock<ILeadsContext>();
            _autoFixture = new();
        }

        public LeadAcceptCommandHandler GetLeadAcceptCommandHandler()
        {
            return GetLeadAcceptCommandHandler(new Mock<IMediator>(), ContextMock);
        }

        private LeadAcceptCommandHandler GetLeadAcceptCommandHandler(Mock<IMediator> mediatorMock, Mock<ILeadsContext> contextMock)
        {
            return new(contextMock.Object, mediatorMock.Object);
        }

        public LeadDeclineCommandHandler GetLeadDeclineCommandHandler()
        {
            return GetLeadDeclineCommandHandler(ContextMock);
        }

        private LeadDeclineCommandHandler GetLeadDeclineCommandHandler(Mock<ILeadsContext> contextMock)
        {
            return new(contextMock.Object);
        }

        public IQueryable<Lead> GetLeads()
        {
            return _autoFixture.CreateMany<Lead>(200).AsQueryable();
        }

        public LeadsAcceptedQueryHandler GetLeadsAcceptedQueryHandler()
        {
            return new(ContextMock.Object);
        }

        public LeadsInvitedQueryHandler GetLeadsInvitedQueryHandler()
        {
            return new(ContextMock.Object);
        }
    }
}
