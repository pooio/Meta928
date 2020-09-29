using System.Collections.Generic;
using MetaShare.Common.Core.Entities;
using Meta727.Entities;
using MetaShare.Common.Core.Services;
using Meta727.Daos.Interfaces;
using Meta727.Services.Interfaces;

/*add customized code between this region*/
/*add customized code between this region*/

namespace Meta727.Services
{
	public class qwerService : Service<qwer>, IqwerService
	{
		public qwerService() : base(typeof (IqwerDao))
		{
		}
		/*add customized code between this region*/
		/*add customized code between this region*/

	}
}
