using MetaShare.Common.Core.Daos;
using Meta727.Entities.ERP1;
using Meta727.Daos.Interfaces.ERP1;
using Meta727.TestData.ERP1;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Meta727.Daos.Mocks.ERP1
{
	public class qwer_CopyDaoMock : MockDao<qwer_Copy>, Iqwer_CopyDao
	{
		public qwer_CopyDaoMock() : base(qwer_CopyTestData.Createqwer_Copy())
		{
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
