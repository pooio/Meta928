using System.Web.Mvc;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Meta727.Web.Controllers.ERP1
{
	public class ERP1AreaRegistration:AreaRegistration
	{
		public override void RegisterArea(AreaRegistrationContext context)
		{
			context.MapRoute(
			"ERP1",
			"ERP1/{controller}/{action}/{id}",
			new {action = "Index", id = UrlParameter.Optional},
			namespaces:new[]  {"Meta727.Web.Controllers.ERP1"});
		}

		public override string AreaName
		{
			get { return "ERP1"; }
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
