using API.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace API.Controllers
{
    public abstract class AlunoPrincipalController : ControllerBase
    {
        protected IActionResult ApiResponse<T>(T data, string message = null)
        {
            var response = new ApiResponse<T>
            {
                Sucess = true,
                Message = message,
                Data = data
            };
            return Ok(response);
        }


        protected IActionResult ApiBadRequestResponse(ModelStateDictionary modelState, string message = "invalido")
        {

            return BadRequest(message);

        }
    }
}
