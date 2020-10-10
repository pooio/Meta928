using System;
using System.Collections.Generic;
using NUnit.Framework;
using Meta727.Entities.ERP1;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Meta727.TestData.ERP1
{
	public class qwer_CopyTestData
	{
		public const int qwer_CopyCount = 3;
		/*add customized code between this region*/
		/*add customized code between this region*/

		 public static List<qwer_Copy> Createqwer_Copy()
		{
			return new List<qwer_Copy>
			{
				Createqwer_Copy1(),
				Createqwer_Copy2(),
				Createqwer_Copy3(),
			};
		}

		 public static qwer_Copy Createqwer_Copy1()
		{
			return new qwer_Copy
			{
					Id = 1, 
					Phone = false, 
					Price = string.Empty, 
					Name = string.Empty, 
					Num = 0, 
					Description = string.Empty, 
			};
		}
		 public static qwer_Copy Createqwer_Copy2()
		{
			return new qwer_Copy
			{
					Id = 2, 
					Phone = false, 
					Price = string.Empty, 
					Name = string.Empty, 
					Num = 0, 
					Description = string.Empty, 
			};
		}
		 public static qwer_Copy Createqwer_Copy3()
		{
			return new qwer_Copy
			{
					Id = 3, 
					Phone = false, 
					Price = string.Empty, 
					Name = string.Empty, 
					Num = 0, 
					Description = string.Empty, 
			};
		}
		public static void AssertAreEqual(qwer_Copy expected, qwer_Copy actual)
		{
			Assert.AreEqual(expected.Phone, actual.Phone);
			Assert.AreEqual(expected.Price, actual.Price);
			Assert.AreEqual(expected.Name, actual.Name);
			Assert.AreEqual(expected.Num, actual.Num);
			Assert.AreEqual(expected.Description, actual.Description);
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
