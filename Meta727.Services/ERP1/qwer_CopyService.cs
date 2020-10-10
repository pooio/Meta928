using System.Collections.Generic;
using MetaShare.Common.Core.Entities;
using Meta727.Entities.ERP1;
using MetaShare.Common.Core.Services;
using Meta727.Daos.Interfaces.ERP1;
using Meta727.Services.Interfaces.ERP1;

/*add customized code between this region*/
/*add customized code between this region*/

namespace Meta727.Services.ERP1
{
	public class qwer_CopyService : Service<qwer_Copy>, Iqwer_CopyService
	{
		public qwer_CopyService() : base(typeof (Iqwer_CopyDao))
		{
		}
		/*add customized code between this region*/
		/*add customized code between this region*/

	}
}
