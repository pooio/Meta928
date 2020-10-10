using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Meta727.Entities.ERP1;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Meta727.Web.Models.ERP1
{
	public class qwer_CopyModel: CommonModel<qwer_Copy>
	{
		public bool Phone {get; set;}
		public string Price {get; set;}
		public int Num {get; set;}

		public override void PopulateFrom(qwer_Copy entity)
		{
			if (entity == null) return;
			base.PopulateFrom(entity);

			this.Phone = entity.Phone;
			this.Price = entity.Price;
			this.Num = entity.Num;
			/*add customized code between this region*/
			/*add customized code between this region*/
		}

		public override void PopulateTo(qwer_Copy entity)
		{
			if (entity == null) return;
			base.PopulateTo(entity);

			entity.Phone = this.Phone;

			entity.Price = this.Price;

			entity.Num = this.Num;

			/*add customized code between this region*/
			/*add customized code between this region*/
		}
	/*add customized code between this region*/
	/*add customized code between this region*/
	}
}
