using MetaShare.Common.Core.Daos;
using Meta727.Entities;
using Meta727.Daos.Interfaces;
using Meta727.TestData;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Meta727.Daos.Mocks
{
	public class qwerDaoMock : MockDao<qwer>, IqwerDao
	{
		public qwerDaoMock() : base(qwerTestData.Createqwer())
		{
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
