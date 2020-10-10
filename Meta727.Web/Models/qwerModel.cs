using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Meta727.Entities;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Meta727.Web.Models
{
	public class qwerModel: CommonModel<qwer>
	{
		public string Price {get; set;}
		public bool Phone {get; set;}
		public int Num {get; set;}

		public override void PopulateFrom(qwer entity)
		{
			if (entity == null) return;
			base.PopulateFrom(entity);

			this.Price = entity.Price;
			this.Phone = entity.Phone;
			this.Num = entity.Num;
			/*add customized code between this region*/
			/*add customized code between this region*/
		}

		public override void PopulateTo(qwer entity)
		{
			if (entity == null) return;
			base.PopulateTo(entity);

			entity.Price = this.Price;

			entity.Phone = this.Phone;

			entity.Num = this.Num;

			/*add customized code between this region*/
			/*add customized code between this region*/
		}
	/*add customized code between this region*/
	/*add customized code between this region*/
	}
}
