using Microsoft.AspNetCore.Mvc;

namespace ERS.Studies.FullDotNetCore.API.Controllers.Base
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class ControllerDefault : Controller
    {
    }
}
