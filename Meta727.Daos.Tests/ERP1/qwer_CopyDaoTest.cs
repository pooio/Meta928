using System.Collections.Generic;
using NUnit.Framework;
using System;
using Meta727.Daos.Interfaces.ERP1;
using Meta727.Daos.DataSchema.ERP1;
using Meta727.TestData.ERP1;
using Meta727.Daos.Tests.Common;
using Meta727.Entities.ERP1;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Meta727.Daos.Tests.ERP1
{
	public class qwer_CopyDaoTest : CommonDaoTest<qwer_Copy, Iqwer_CopyDao, qwer_CopyDdlBuilder>
	{
		public qwer_CopyDaoTest() : base(qwer_CopyTestData.Createqwer_Copy())
		{
		}

		[TestCase]
		public void SelectAllTest()
		{
			Assert.AreEqual(qwer_CopyTestData.qwer_CopyCount, this.Dao.SelectAll(this.Context).Count);
		}

		[TestCase]
		public void SelectByIdTest()
		{
			qwer_Copy item = qwer_CopyTestData.Createqwer_Copy1();
			qwer_Copy find = this.Dao.SelectById(this.Context, item);

			Assert.AreEqual(item.Id, find.Id);
			qwer_CopyTestData.AssertAreEqual(item, find);
		}

		[TestCase]
		public void InsertTest()
		{
			qwer_Copy item = new qwer_Copy
			{
				Phone = false, 
				Price = string.Empty, 
				Name = string.Empty, 
				Num = 0, 
				Description = string.Empty, 
			};
			int affectedRows = this.Dao.Insert(this.Context, item);
			Assert.AreEqual(1, affectedRows);

			qwer_Copy find = this.Dao.SelectById(this.Context, item);
			qwer_CopyTestData.AssertAreEqual(item, find);

			List<qwer_Copy> items = this.Dao.SelectAll(this.Context);
			Assert.AreEqual(qwer_CopyTestData.qwer_CopyCount + 1, items.Count);
		}

		[TestCase]
		public void UpdateTest()
		{
			qwer_Copy item = qwer_CopyTestData.Createqwer_Copy1();
			qwer_Copy beforeUpdate = this.Dao.SelectById(this.Context, item);
			Assert.IsNotNull(beforeUpdate);
			beforeUpdate.Phone = false;

			this.Dao.Update(this.Context, beforeUpdate);

			qwer_Copy afterUpdate = this.Dao.SelectById(this.Context, beforeUpdate);
			qwer_CopyTestData.AssertAreEqual(beforeUpdate, afterUpdate);
		}

		[TestCase]
		public void DeleteTest()
		{
			qwer_Copy item = qwer_CopyTestData.Createqwer_Copy1();
			qwer_Copy beforedelete = this.Dao.SelectById(this.Context, item);
			Assert.IsNotNull(beforedelete);

			int affectedRows = this.Dao.Delete(this.Context, beforedelete);
			Assert.AreEqual(1, affectedRows);

			qwer_Copy afterDelete = this.Dao.SelectById(this.Context, beforedelete);
			Assert.IsNull(afterDelete);

			List<qwer_Copy> items = this.Dao.SelectAll(this.Context);
			Assert.AreEqual(qwer_CopyTestData.qwer_CopyCount - 1, items.Count);
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
