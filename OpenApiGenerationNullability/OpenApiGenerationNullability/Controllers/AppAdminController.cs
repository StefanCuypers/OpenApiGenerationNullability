using Microsoft.AspNetCore.Mvc;
using OpenApiGenerationNullability.Components.Objects;
using System.ComponentModel;

namespace OpenApiGenerationNullability.Controllers;

[ApiController]
[Route("v1/[controller]")]
public class AppAdminController : ControllerBase
{
    [HttpGet("applicationEnvironments")]
    [ProducesResponseType<AmApplicationEnvironment>(StatusCodes.Status200OK, "application/json")]
    public ActionResult<AmApplicationEnvironment> GetApplicationEnvironment()
        => Ok(new AmApplicationEnvironment());
}
