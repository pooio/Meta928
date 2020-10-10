using System.Web.Http;
using System.Web.Mvc;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Meta727.WebApi.Controllers.ERP1
{
	public class ERP1AreaRegistration:AreaRegistration
	{
		public override void RegisterArea(AreaRegistrationContext context)
		{
			context.Routes.MapHttpRoute(
			name:"ERP1",
			routeTemplate:"ERP1/{controller}/{action}/{id}",
			defaults:new 
			{
				area = "ERP1",
				action = "Index",
				id = UrlParameter.Optional,
				namespaceName = new[] {"Meta727.WebApi.Controllers.ERP1"}
			});
		}

		public override string AreaName
		{
			get { return "ERP1"; }
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
