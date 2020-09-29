using MetaShare.Common.Core.CommonService;
using Meta727.Services.Interfaces;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Meta727.Services
{
	public class RegisterServices
	{
		public static void RegisterAll()
		{
			Register(ServiceFactory.Instance, true);
		}

		public static void UnRegisterAll()
		{
			Register(ServiceFactory.Instance, false);
		}

		public static void Register(ServiceFactory factory, bool isRegister)
		{
			factory.Register(typeof(IqwerService), new qwerService(), isRegister);
			/*add customized code between this region*/
			/*add customized code between this region*/
		}
	}
}
