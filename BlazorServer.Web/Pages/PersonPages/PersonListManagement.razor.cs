using BlazorServer.Core.Models;

namespace BlazorServer.Web.Pages.PersonPages
{
	public partial class PersonListManagement
	{
		public List<Person> PersonList { get; set; } = default!;

		protected override Task OnAfterRenderAsync(bool firstRender)
		{
			if(firstRender)
			{
				PersonList = new List<Person>();
				PersonList.Add(new Person() { Id = 1, FirstName = "Jared", LastName = "Talbot" });
			}
			return base.OnAfterRenderAsync(firstRender);
		}
	}
}
