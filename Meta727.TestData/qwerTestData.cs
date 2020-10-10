using System;
using System.Collections.Generic;
using NUnit.Framework;
using Meta727.Entities;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Meta727.TestData
{
	public class qwerTestData
	{
		public const int qwerCount = 3;
		/*add customized code between this region*/
		/*add customized code between this region*/

		 public static List<qwer> Createqwer()
		{
			return new List<qwer>
			{
				Createqwer1(),
				Createqwer2(),
				Createqwer3(),
			};
		}

		 public static qwer Createqwer1()
		{
			return new qwer
			{
					Id = 1, 
					Price = string.Empty, 
					Description = string.Empty, 
					Phone = false, 
					Name = string.Empty, 
					Num = 0, 
			};
		}
		 public static qwer Createqwer2()
		{
			return new qwer
			{
					Id = 2, 
					Price = string.Empty, 
					Description = string.Empty, 
					Phone = false, 
					Name = string.Empty, 
					Num = 0, 
			};
		}
		 public static qwer Createqwer3()
		{
			return new qwer
			{
					Id = 3, 
					Price = string.Empty, 
					Description = string.Empty, 
					Phone = false, 
					Name = string.Empty, 
					Num = 0, 
			};
		}
		public static void AssertAreEqual(qwer expected, qwer actual)
		{
			Assert.AreEqual(expected.Price, actual.Price);
			Assert.AreEqual(expected.Description, actual.Description);
			Assert.AreEqual(expected.Phone, actual.Phone);
			Assert.AreEqual(expected.Name, actual.Name);
			Assert.AreEqual(expected.Num, actual.Num);
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
