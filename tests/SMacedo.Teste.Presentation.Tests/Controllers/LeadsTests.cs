using CSharpFunctionalExtensions;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Moq;
using SMacedo.Teste.Application.Commands;
using SMacedo.Teste.Application.Querys;
using SMacedo.Teste.Controllers;
using SMacedo.Teste.Presentation.Tests.Fixtures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SMacedo.Teste.Presentation.Tests.Controllers
{
    [Collection(nameof(ControllerFixturesCollection))]
    public class LeadsTests
    {
        private readonly ControllerFixture _fixture;

        public LeadsTests(ControllerFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact(DisplayName = "Obtem com sucesso os leads com status invited.")]
        public async Task LeadController_GetInvited_OkStatus()
        {
            //Arrange
            Mock<IMediator> mediatorMockr = new();
            mediatorMockr.Setup(a => a.Send(It.IsAny<LeadsInvitedQuery>(), CancellationToken.None)).ReturnsAsync(_fixture.GetLeadInvitedViewModels_Success);
            LeadsController controller = _fixture.GetLeadsController(mediatorMockr);

            //Act
            IActionResult result = await controller.GetInvitedAsync();

            //Assert
            OkObjectResult objectResult = Assert.IsType<OkObjectResult>(result);
            Assert.Equal(200, objectResult.StatusCode);
            Assert.NotNull(objectResult.Value);
        }

        [Fact(DisplayName = "Obtem com erro de requisição os leads com status invited.")]
        public async Task LeadController_GetInvited_BadRequestStatus()
        {
            //Arrange
            Mock<IMediator> mediatorMockr = new();
            mediatorMockr.Setup(a => a.Send(It.IsAny<LeadsInvitedQuery>(), CancellationToken.None)).ReturnsAsync(_fixture.GetLeadInvitedViewModels_Failure);
            LeadsController controller = _fixture.GetLeadsController(mediatorMockr);

            //Act
            IActionResult result = await controller.GetInvitedAsync();

            //Assert
            BadRequestObjectResult objectResult = Assert.IsType<BadRequestObjectResult>(result);
            Assert.Equal(400, objectResult.StatusCode);
            Assert.NotNull(objectResult.Value);
        }

        [Fact(DisplayName = "Obtem com erro de requisição os leads com status accepted.")]
        public async Task LeadController_GetAccepted_OkStatus()
        {
            //Arrange
            Mock<IMediator> mediatorMockr = new();
            mediatorMockr.Setup(a => a.Send(It.IsAny<LeadsAcceptedQuery>(), CancellationToken.None)).ReturnsAsync(_fixture.GetLeadAcceptedViewModels_Success);
            LeadsController controller = _fixture.GetLeadsController(mediatorMockr);

            //Act
            IActionResult result = await controller.GetAcceptedAsync();

            //Assert
            OkObjectResult objectResult = Assert.IsType<OkObjectResult>(result);
            Assert.Equal(200, objectResult.StatusCode);
            Assert.NotNull(objectResult.Value);
        }

        [Fact(DisplayName = "Obtem com erro de requisição os leads com status accepted.")]
        public async Task LeadController_GetAccepted_BadRequestStatus()
        {
            //Arrange
            Mock<IMediator> mediatorMockr = new();
            mediatorMockr.Setup(a => a.Send(It.IsAny<LeadsAcceptedQuery>(), CancellationToken.None)).ReturnsAsync(_fixture.GetLeadAcceptedViewModels_Failure);
            LeadsController controller = _fixture.GetLeadsController(mediatorMockr);

            //Act
            IActionResult result = await controller.GetAcceptedAsync();

            //Assert
            BadRequestObjectResult objectResult = Assert.IsType<BadRequestObjectResult>(result);
            Assert.Equal(400, objectResult.StatusCode);
            Assert.NotNull(objectResult.Value);
        }

        [Fact(DisplayName = "Executa o aceite do lead com sucesso.")]
        public async Task LeadController_PostAccept_OkStatus()
        {
            //Arrange
            Mock<IMediator> mediatorMockr = new();
            mediatorMockr.Setup(a => a.Send(It.IsAny<LeadAcceptCommand>(), CancellationToken.None)).ReturnsAsync(Result.Success);
            LeadsController controller = _fixture.GetLeadsController(mediatorMockr);

            //Act
            IActionResult result = await controller.PostAccept(It.IsAny<int>());

            //Assert
            OkResult objectResult = Assert.IsType<OkResult>(result);
            Assert.Equal(200, objectResult.StatusCode);
        }

        [Fact(DisplayName = "Executa o aceite do lead com erro.")]
        public async Task LeadController_PostAccept_BadRequestStatus()
        {
            //Arrange
            Mock<IMediator> mediatorMockr = new();
            mediatorMockr.Setup(a => a.Send(It.IsAny<LeadAcceptCommand>(), CancellationToken.None)).ReturnsAsync(Result.Failure("Error"));
            LeadsController controller = _fixture.GetLeadsController(mediatorMockr);

            //Act
            IActionResult result = await controller.PostAccept(It.IsAny<int>());

            //Assert
            BadRequestObjectResult objectResult = Assert.IsType<BadRequestObjectResult>(result);
            Assert.Equal(400, objectResult.StatusCode);
        }

        [Fact(DisplayName = "Executa o declinio do lead com sucesso.")]
        public async Task LeadController_PostDecline_OkStatus()
        {
            //Arrange
            Mock<IMediator> mediatorMockr = new();
            mediatorMockr.Setup(a => a.Send(It.IsAny<LeadDeclineCommand>(), CancellationToken.None)).ReturnsAsync(Result.Success);
            LeadsController controller = _fixture.GetLeadsController(mediatorMockr);

            //Act
            IActionResult result = await controller.PostDecline(It.IsAny<int>());

            //Assert
            OkResult objectResult = Assert.IsType<OkResult>(result);
            Assert.Equal(200, objectResult.StatusCode);
        }

        [Fact(DisplayName = "Executa o declinio do lead com erro.")]
        public async Task LeadController_PostDecline_BadRequestStatus()
        {
            //Arrange
            Mock<IMediator> mediatorMockr = new();
            mediatorMockr.Setup(a => a.Send(It.IsAny<LeadDeclineCommand>(), CancellationToken.None)).ReturnsAsync(Result.Failure("Error"));
            LeadsController controller = _fixture.GetLeadsController(mediatorMockr);

            //Act
            IActionResult result = await controller.PostDecline(It.IsAny<int>());

            //Assert
            BadRequestObjectResult objectResult = Assert.IsType<BadRequestObjectResult>(result);
            Assert.Equal(400, objectResult.StatusCode);
        }
    }
}
