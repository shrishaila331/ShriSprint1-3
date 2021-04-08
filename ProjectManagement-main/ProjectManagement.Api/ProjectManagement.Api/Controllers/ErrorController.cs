using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectManagement.Api.Models;

namespace ProjectManagement.Api.Controllers
{

    public class ErrorController : ControllerBase
    {
        [Route("error")]
        public ErrorModel Error()
        {
            var context = HttpContext.Features.Get<IExceptionHandlerFeature>();
            var exception = context.Error; 
            Response.StatusCode = 500;
            return new ErrorModel(exception);
        }
    }
}
