using System;
using System.Collections.Generic;
using NUnit.Framework;
using Meta727.Entities;
using Meta727.TestData;
using Meta727.Services.Tests.Common;
using Meta727.Services.Interfaces;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Meta727.Services.Tests
{

	[TestFixture]
	public class qwerServiceTest : CommonServiceTest<qwer, IqwerService>
	{
		[TestCase]
		public void SelectAllTest()
		{
			List<qwer> items = this.Service.SelectAll();
			Assert.AreEqual(qwerTestData.qwerCount, items.Count);
		}

		[TestCase]
		public void SelectByTest()
		{
			qwer itemTest = qwerTestData.Createqwer1();

			List<qwer> find = this.Service.SelectBy(new qwer {Phone = itemTest.Phone}, new List<string> {"Phone"});
			Assert.IsNotNull(find);

			foreach (qwer item in find)
			{
				Assert.AreEqual(itemTest.Phone, item.Phone);
			}
		}

		[TestCase]
		public void SelectByIdTest()
		{
			qwer itemTest = qwerTestData.Createqwer1();

			qwer find = this.Service.SelectById(new qwer {Id = itemTest.Id});
			Assert.IsNotNull(find);

			qwerTestData.AssertAreEqual(itemTest, find);
		}

		[TestCase]
		public void DeleteTest()
		{
			qwer itemTest = qwerTestData.Createqwer2();
			int affectedRows = this.Service.Delete(itemTest, true);

			List<qwer> items = this.Service.SelectAll();
			Assert.AreEqual(items.Count, qwerTestData.qwerCount - 1);
			Assert.AreEqual(-1, affectedRows);
		}

		[TestCase]
		public void InsertTest()
		{
			qwer itemTest = new qwer
			{
				Phone = false, 
				Description = string.Empty, 
				Name = string.Empty, 
			};

			int affectedRows = this.Service.Insert(itemTest, true);

			List<qwer> items = this.Service.SelectAll();
			Assert.AreEqual(items.Count, qwerTestData.qwerCount + 1);
			Assert.AreEqual(1, affectedRows);
		}

		[TestCase]
		public void UpdateTest()
		{
			qwer itemTest = qwerTestData.Createqwer1();

			qwer beforeUpdate = this.Service.SelectById(new qwer {Id = itemTest.Id});
			beforeUpdate.Phone = false ;
			this.Service.Update(beforeUpdate, true);

			qwer afterUpdate = this.Service.SelectById(new qwer {Id = itemTest.Id});
			qwerTestData.AssertAreEqual(beforeUpdate, afterUpdate);
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}

}
