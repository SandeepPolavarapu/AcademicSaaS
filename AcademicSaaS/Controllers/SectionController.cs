using AcademicSaaS.Models.Request;
using AcademicSaaS.Models.Response;
using AcademicSaaS.Validators;
using Microsoft.AspNetCore.Mvc;

namespace AcademicSaaS.Controllers
{
    [Route("api/Section")]
    [Consumes("application/json")]
    [Produces("application/json")]
    [ProducesResponseType(typeof(ApiResponse), (int)System.Net.HttpStatusCode.OK)]
    [ProducesResponseType(typeof(int), (int)System.Net.HttpStatusCode.BadRequest)]
    [ProducesResponseType(typeof(int), (int)System.Net.HttpStatusCode.Unauthorized)]
    [ProducesResponseType(typeof(int), (int)System.Net.HttpStatusCode.Forbidden)]
    public class SectionController : Controller
    {
        // POST: api/Section
        [HttpPost]
        [RequestValidationFilter]
        public void Post([FromBody]SectionRequest request)
        {
        }
    }
}
