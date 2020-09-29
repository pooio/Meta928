using System.Collections.Generic;
using NUnit.Framework;
using System;
using Meta727.Daos.Interfaces;
using Meta727.Daos.DataSchema;
using Meta727.TestData;
using Meta727.Daos.Tests.Common;
using Meta727.Entities;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Meta727.Daos.Tests
{
	public class qwerDaoTest : CommonDaoTest<qwer, IqwerDao, qwerDdlBuilder>
	{
		public qwerDaoTest() : base(qwerTestData.Createqwer())
		{
		}

		[TestCase]
		public void SelectAllTest()
		{
			Assert.AreEqual(qwerTestData.qwerCount, this.Dao.SelectAll(this.Context).Count);
		}

		[TestCase]
		public void SelectByIdTest()
		{
			qwer item = qwerTestData.Createqwer1();
			qwer find = this.Dao.SelectById(this.Context, item);

			Assert.AreEqual(item.Id, find.Id);
			qwerTestData.AssertAreEqual(item, find);
		}

		[TestCase]
		public void InsertTest()
		{
			qwer item = new qwer
			{
				Name = string.Empty, 
				Phone = false, 
				Description = string.Empty, 
			};
			int affectedRows = this.Dao.Insert(this.Context, item);
			Assert.AreEqual(1, affectedRows);

			qwer find = this.Dao.SelectById(this.Context, item);
			qwerTestData.AssertAreEqual(item, find);

			List<qwer> items = this.Dao.SelectAll(this.Context);
			Assert.AreEqual(qwerTestData.qwerCount + 1, items.Count);
		}

		[TestCase]
		public void UpdateTest()
		{
			qwer item = qwerTestData.Createqwer1();
			qwer beforeUpdate = this.Dao.SelectById(this.Context, item);
			Assert.IsNotNull(beforeUpdate);
			beforeUpdate.Name = string.Empty;

			this.Dao.Update(this.Context, beforeUpdate);

			qwer afterUpdate = this.Dao.SelectById(this.Context, beforeUpdate);
			qwerTestData.AssertAreEqual(beforeUpdate, afterUpdate);
		}

		[TestCase]
		public void DeleteTest()
		{
			qwer item = qwerTestData.Createqwer1();
			qwer beforedelete = this.Dao.SelectById(this.Context, item);
			Assert.IsNotNull(beforedelete);

			int affectedRows = this.Dao.Delete(this.Context, beforedelete);
			Assert.AreEqual(1, affectedRows);

			qwer afterDelete = this.Dao.SelectById(this.Context, beforedelete);
			Assert.IsNull(afterDelete);

			List<qwer> items = this.Dao.SelectAll(this.Context);
			Assert.AreEqual(qwerTestData.qwerCount - 1, items.Count);
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
