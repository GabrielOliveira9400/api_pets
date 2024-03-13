using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Pets.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
    }
}
