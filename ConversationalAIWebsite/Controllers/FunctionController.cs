﻿
using AiPocWebsiteTemplateWithBackend.API.Config;
using AiPocWebsiteTemplateWithBackend.Business;
using AiPocWebsiteTemplateWithBackend.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AiPocWebsiteTemplateWithBackend.Controllers
{

    // PLEASE NOTE: This API is intended to be used in a somewhat unorthodox manner, in that, not only is it capable
    // of receiving requests from the client, but it is also capable of being called from the IntelligenceHub via
    // tool calls returned from the AI

    [ApiController]
    [Route("[controller]")]
    [Authorize(Policy = AuthPolicies.FunctionCallingAuthPolicy)] // uncomment to enforce basic auth
    public class FunctionController : ControllerBase
    {
        private readonly IAuthLogic _authLogic;
        private readonly IPromptFlowLogic _promptFlowLogic;

        public FunctionController(IAuthLogic authLogic, IPromptFlowLogic promptLogic)
        {
            _authLogic = authLogic;
            _promptFlowLogic = promptLogic;
        }

        // Add methods here and create a corresponding tool to execute code with the AI models.

        // Alternatively, you can define tools to target other APIs and return the HttpResponse to the calling client.
        // See the read me file's section on tool calling for more details.

        [HttpGet("Test")]
        public async Task<IActionResult> Test()
        {
            try
            {
                var result = await _promptFlowLogic.Test();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Something went wrong when authenticating");
            }
        }
    }
}