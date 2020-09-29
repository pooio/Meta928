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
		public bool Phone {get; set;}

		public override void PopulateFrom(qwer entity)
		{
			if (entity == null) return;
			base.PopulateFrom(entity);

			this.Phone = entity.Phone;
			/*add customized code between this region*/
			/*add customized code between this region*/
		}

		public override void PopulateTo(qwer entity)
		{
			if (entity == null) return;
			base.PopulateTo(entity);

			entity.Phone = this.Phone;

			/*add customized code between this region*/
			/*add customized code between this region*/
		}
	/*add customized code between this region*/
	/*add customized code between this region*/
	}
}
