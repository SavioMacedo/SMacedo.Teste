﻿using CSharpFunctionalExtensions;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SMacedo.Teste.Application.Commands;
using SMacedo.Teste.Application.Querys;
using SMacedo.Teste.Application.ViewModels;
using System.Collections.Generic;

namespace SMacedo.Teste.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeadsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LeadsController(IMediator mediator) => _mediator = mediator;

        [HttpGet]
        [Route("invited")]
        public async Task<IActionResult> GetInvitedAsync()
        {
            Result<IEnumerable<LeadInvitedViewModel>> result = await _mediator.Send(new LeadsInvitedQuery());

            return (result.IsSuccess) ? Ok(result.Value) : BadRequest(result.Error);
        }

        [HttpGet]
        [Route("accepted")]
        public async Task<IActionResult> GetAcceptedAsync()
        {
            Result<IEnumerable<LeadAcceptedViewModel>> result = await _mediator.Send(new LeadsAcceptedQuery());

            return (result.IsSuccess) ? Ok(result.Value) : BadRequest(result.Error);
        }

        [HttpPost]
        [Route("accept/{id}")]
        public async Task<IActionResult> PostAccept(int id)
        {
            Result result = await _mediator.Send(new LeadAcceptCommand(id));

            return (result.IsSuccess) ? Ok() : BadRequest(result.Error);
        }

        [HttpPost]
        [Route("decline/{id}")]
        public async Task<IActionResult> PostDecline(int id)
        {
            Result result = await _mediator.Send(new LeadDeclineCommand(id));

            return (result.IsSuccess) ? Ok() : BadRequest(result.Error);
        }
    }
}
