using Hesabdari.Core.Domain.Exceptions;
using Hesabdari.Sample.Core.Domain.Pepole.ValueObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hesabdari.Sample.EndPoints.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PepoleController : ControllerBase
    {
        [HttpGet("CheckValueObject")]
        public IActionResult CheckFirstNameValueObject(string firstName)
        {
            FirstName fname1 = new(firstName);
            FirstName fname2 = new(firstName);
            return Ok(fname1 == fname2);
        }

        [HttpGet("ExceptionCheck")]
        public IActionResult CheckFirstNameValueObject()
        {
            try
            {
                FirstName firstName = new("d");
            }
            catch (InvalidValueObjectStateException ex)
            {

                return Ok(ex.ToString());
            }
            return BadRequest();
        }
    }
}
