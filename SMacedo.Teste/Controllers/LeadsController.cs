using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SMacedo.Teste.Application.ViewModels;

namespace SMacedo.Teste.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeadsController : ControllerBase
    {
        [HttpGet]
        [Route("invited")]
        public IActionResult GetInvited()
        {
            IList<LeadInvitedViewModel> result = new List<LeadInvitedViewModel>();
            result.Add(new LeadInvitedViewModel
            {
                Category = "Painters",
                CreateDate = "January 4 @ 2:37 pm",
                Description = "Need to paint something, pliz.",
                FirstName = "Savio",
                Id = 250,
                Location = "Brazil, 240 St.",
                Price = 36.20
            });

            return Ok(result);
        }

        [HttpGet]
        [Route("accepted")]
        public IActionResult GetAccepted()
        {
            IList<LeadAcceptedViewModel> result = new List<LeadAcceptedViewModel>();
            result.Add(new LeadAcceptedViewModel
            {
                Category = "Painters",
                CreateDate = "January 4 @ 2:37 pm",
                Description = "Need to paint something, pliz.",
                FirstName = "Savio",
                Id = 250,
                Location = "Brazil, 240 St.",
                Price = 36.20,
                Phone = "+553299999876",
                Email = "teste@email.com"
            });

            return Ok(result);
        }
    }
}
