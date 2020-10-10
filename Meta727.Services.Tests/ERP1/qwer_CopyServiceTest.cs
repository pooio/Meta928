using System;
using System.Collections.Generic;
using NUnit.Framework;
using Meta727.Entities.ERP1;
using Meta727.TestData.ERP1;
using Meta727.Services.Tests.Common;
using Meta727.Services.Interfaces.ERP1;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Meta727.Services.Tests.ERP1
{

	[TestFixture]
	public class qwer_CopyServiceTest : CommonServiceTest<qwer_Copy, Iqwer_CopyService>
	{
		[TestCase]
		public void SelectAllTest()
		{
			List<qwer_Copy> items = this.Service.SelectAll();
			Assert.AreEqual(qwer_CopyTestData.qwer_CopyCount, items.Count);
		}

		[TestCase]
		public void SelectByTest()
		{
			qwer_Copy itemTest = qwer_CopyTestData.Createqwer_Copy1();

			List<qwer_Copy> find = this.Service.SelectBy(new qwer_Copy {Phone = itemTest.Phone}, new List<string> {"Phone"});
			Assert.IsNotNull(find);

			foreach (qwer_Copy item in find)
			{
				Assert.AreEqual(itemTest.Phone, item.Phone);
			}
		}

		[TestCase]
		public void SelectByIdTest()
		{
			qwer_Copy itemTest = qwer_CopyTestData.Createqwer_Copy1();

			qwer_Copy find = this.Service.SelectById(new qwer_Copy {Id = itemTest.Id});
			Assert.IsNotNull(find);

			qwer_CopyTestData.AssertAreEqual(itemTest, find);
		}

		[TestCase]
		public void DeleteTest()
		{
			qwer_Copy itemTest = qwer_CopyTestData.Createqwer_Copy2();
			int affectedRows = this.Service.Delete(itemTest, true);

			List<qwer_Copy> items = this.Service.SelectAll();
			Assert.AreEqual(items.Count, qwer_CopyTestData.qwer_CopyCount - 1);
			Assert.AreEqual(-1, affectedRows);
		}

		[TestCase]
		public void InsertTest()
		{
			qwer_Copy itemTest = new qwer_Copy
			{
				Phone = false, 
				Price = string.Empty, 
				Name = string.Empty, 
				Num = 0, 
				Description = string.Empty, 
			};

			int affectedRows = this.Service.Insert(itemTest, true);

			List<qwer_Copy> items = this.Service.SelectAll();
			Assert.AreEqual(items.Count, qwer_CopyTestData.qwer_CopyCount + 1);
			Assert.AreEqual(1, affectedRows);
		}

		[TestCase]
		public void UpdateTest()
		{
			qwer_Copy itemTest = qwer_CopyTestData.Createqwer_Copy1();

			qwer_Copy beforeUpdate = this.Service.SelectById(new qwer_Copy {Id = itemTest.Id});
			beforeUpdate.Phone = false ;
			this.Service.Update(beforeUpdate, true);

			qwer_Copy afterUpdate = this.Service.SelectById(new qwer_Copy {Id = itemTest.Id});
			qwer_CopyTestData.AssertAreEqual(beforeUpdate, afterUpdate);
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}

}
