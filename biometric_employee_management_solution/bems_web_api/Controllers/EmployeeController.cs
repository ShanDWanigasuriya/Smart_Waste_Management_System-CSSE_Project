using bems_core_domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bems_core_web_api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class EmployeeController : ControllerBase
	{
		[HttpPost("Register")]
		public async Task<IActionResult> Register(Employee employee)
		{
			return Ok();
		}

		[HttpGet("GetEmployeeByDeviceId")]
		public async Task<IActionResult> GetEmployeeByDeviceId(string deviceId)
		{
			return Ok(new Employee());
		}
	}
}
