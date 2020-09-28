using MetaShare.Common.Core.Daos;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Meta727.Daos.Mocks
{
	public class RegisterDaoMocks
	{
		public static void RegisterAll()
		{
			Register(DaoFactory.Instance, true);
		}

		public static void UnRegisterAll()
		{
			Register(DaoFactory.Instance, false);
		}

		public static void Register(DaoFactory factory, bool isRegister)
		{
			/*add customized code between this region*/
			/*add customized code between this region*/
		}
	}
}
