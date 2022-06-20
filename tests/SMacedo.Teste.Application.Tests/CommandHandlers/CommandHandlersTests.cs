using CSharpFunctionalExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Moq;
using Moq.EntityFrameworkCore;
using SMacedo.Teste.Application.CommandHandler;
using SMacedo.Teste.Application.Commands;
using SMacedo.Teste.Application.Tests.Fixtures;
using SMacedo.Teste.Domain.Contracts;
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
    public class CommandHandlersTests
    {
        private readonly RequestFixtures _fixture;

        public CommandHandlersTests(RequestFixtures fixture)
        {
            _fixture = fixture;
        }

        [Fact(DisplayName = "Aceita um lead com sucesso.")]
        public async Task LeadAccept_Handle_Success()
        {
            //Arrange
            IQueryable<Lead> leadsMockData = _fixture.GetLeads();
            _fixture.ContextMock.Setup(a => a.SaveChangesAsync(It.IsAny<CancellationToken>())).ReturnsAsync(1);
            _fixture.ContextMock.Setup(a => a.Leads).ReturnsDbSet(leadsMockData);

            LeadAcceptCommandHandler handler = _fixture.GetLeadAcceptCommandHandler();
            leadsMockData.FirstOrDefault()!.Price = 600;
            int id = leadsMockData.FirstOrDefault()!.Id;
            LeadAcceptCommand request = new(id);

            //Act
            Result result = await handler.Handle(request, CancellationToken.None);

            //Assert
            Assert.True(result.IsSuccess);
        }

        [Fact(DisplayName = "Aceita um lead não existente.")]
        public async Task LeadAccept_Handle_NotFound()
        {
            //Arrange
            IQueryable<Lead> leadsMockData = _fixture.GetLeads();
            _fixture.ContextMock.Setup(a => a.SaveChangesAsync(It.IsAny<CancellationToken>())).ReturnsAsync(1);
            _fixture.ContextMock.Setup(a => a.Leads).ReturnsDbSet(leadsMockData);

            LeadAcceptCommandHandler handler = _fixture.GetLeadAcceptCommandHandler();
            LeadAcceptCommand request = new(It.IsAny<int>());

            //Act
            Result result = await handler.Handle(request, CancellationToken.None);

            //Assert
            Assert.True(result.IsFailure);
            Assert.Contains("Id não encontrado", result.Error);
        }

        [Fact(DisplayName = "Aceita um lead com erro ao gravar.")]
        public async Task LeadAccept_Handle_Error()
        {
            //Arrange
            IQueryable<Lead> leadsMockData = _fixture.GetLeads();
            _fixture.ContextMock.Setup(a => a.SaveChangesAsync(It.IsAny<CancellationToken>())).ReturnsAsync(0);
            _fixture.ContextMock.Setup(a => a.Leads).ReturnsDbSet(leadsMockData);

            LeadAcceptCommandHandler handler = _fixture.GetLeadAcceptCommandHandler();
            leadsMockData.FirstOrDefault()!.Price = 600;
            int id = leadsMockData.FirstOrDefault()!.Id;
            LeadAcceptCommand request = new(id);

            //Act
            Result result = await handler.Handle(request, CancellationToken.None);

            //Assert
            Assert.True(result.IsFailure);
            Assert.Contains("Ocorreu um erro ao gravar os dados.", result.Error);
        }

        [Fact(DisplayName = "Declina um lead com sucesso.")]
        public async Task LeadDecline_Handle_Success()
        {
            //Arrange
            IQueryable<Lead> leadsMockData = _fixture.GetLeads();
            _fixture.ContextMock.Setup(a => a.SaveChangesAsync(It.IsAny<CancellationToken>())).ReturnsAsync(1);
            _fixture.ContextMock.Setup(a => a.Leads).ReturnsDbSet(leadsMockData);

            LeadDeclineCommandHandler handler = _fixture.GetLeadDeclineCommandHandler();
            leadsMockData.FirstOrDefault()!.Price = 600;
            int id = leadsMockData.FirstOrDefault()!.Id;
            LeadDeclineCommand request = new(id);

            //Act
            Result result = await handler.Handle(request, CancellationToken.None);

            //Assert
            Assert.True(result.IsSuccess);
        }

        [Fact(DisplayName = "Declina um lead não existente.")]
        public async Task LeadDecline_Handle_NotFound()
        {
            //Arrange
            IQueryable<Lead> leadsMockData = _fixture.GetLeads();
            _fixture.ContextMock.Setup(a => a.SaveChangesAsync(It.IsAny<CancellationToken>())).ReturnsAsync(1);
            _fixture.ContextMock.Setup(a => a.Leads).ReturnsDbSet(leadsMockData);

            LeadDeclineCommandHandler handler = _fixture.GetLeadDeclineCommandHandler();
            LeadDeclineCommand request = new(It.IsAny<int>());

            //Act
            Result result = await handler.Handle(request, CancellationToken.None);

            //Assert
            Assert.True(result.IsFailure);
            Assert.Contains("Id não encontrado", result.Error);
        }

        [Fact(DisplayName = "Declina um lead com erro ao gravar.")]
        public async Task LeadDecline_Handle_Error()
        {
            //Arrange
            IQueryable<Lead> leadsMockData = _fixture.GetLeads();
            _fixture.ContextMock.Setup(a => a.SaveChangesAsync(It.IsAny<CancellationToken>())).ReturnsAsync(0);
            _fixture.ContextMock.Setup(a => a.Leads).ReturnsDbSet(leadsMockData);

            LeadDeclineCommandHandler handler = _fixture.GetLeadDeclineCommandHandler();
            leadsMockData.FirstOrDefault()!.Price = 600;
            int id = leadsMockData.FirstOrDefault()!.Id;
            LeadDeclineCommand request = new(id);

            //Act
            Result result = await handler.Handle(request, CancellationToken.None);

            //Assert
            Assert.True(result.IsFailure);
            Assert.Contains("Ocorreu um erro ao gravar os dados.", result.Error);
        }
    }
}
