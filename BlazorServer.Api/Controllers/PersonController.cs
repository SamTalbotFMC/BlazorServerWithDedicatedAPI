using BlazorServer.Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorServer.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PersonController : ControllerBase
	{
		[HttpGet]
		public async Task<ActionResult<IEnumerable<Person>>> GetComponentTransactions()
		{
			var list = new List<Person>();
			list.Add(new Person { Id = 1, FirstName = "Sam", LastName = "Talbot" });
			return list;
		}
	}
}
