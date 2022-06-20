using AutoFixture;
using CSharpFunctionalExtensions;
using MediatR;
using Moq;
using SMacedo.Teste.Application.ViewModels;
using SMacedo.Teste.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SMacedo.Teste.Presentation.Tests.Fixtures

{
    [CollectionDefinition(nameof(ControllerFixturesCollection))]
    public class ControllerFixturesCollection: ICollectionFixture<ControllerFixture> { }

    public class ControllerFixture
    {
        private readonly Fixture _autoFixture;

        public ControllerFixture()
        {
            _autoFixture = new Fixture();
            _autoFixture.Behaviors.Remove(new ThrowingRecursionBehavior());
            _autoFixture.Behaviors.Add(new OmitOnRecursionBehavior());
        }

        public LeadsController GetLeadsController(Mock<IMediator> mediatorMock)
        {
            return new(mediatorMock.Object);
        }

        public Result<IEnumerable<LeadInvitedViewModel>> GetLeadInvitedViewModels_Success()
        {
            return Result.Success(_autoFixture.CreateMany<LeadInvitedViewModel>(5));
        }

        public Result<IEnumerable<LeadInvitedViewModel>> GetLeadInvitedViewModels_Failure()
        {
            return Result.Failure<IEnumerable<LeadInvitedViewModel>>("Error");
        }

        public Result<IEnumerable<LeadAcceptedViewModel>> GetLeadAcceptedViewModels_Success()
        {
            return Result.Success(_autoFixture.CreateMany<LeadAcceptedViewModel>(5));
        }

        public Result<IEnumerable<LeadAcceptedViewModel>> GetLeadAcceptedViewModels_Failure()
        {
            return Result.Failure<IEnumerable<LeadAcceptedViewModel>>("Error");
        }
    }
}
