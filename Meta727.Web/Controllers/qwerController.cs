using Meta727.Entities;
using System.Collections.Generic;
using Meta727.Services.Interfaces;
using Meta727.Web.Models;
using MetaShare.Common.Core.CommonService;
using MetaShare.Common.Core.Entities;

/*add customized code between this region*/
/*add customized code between this region*/

namespace Meta727.Web.Controllers
{
	public class qwerController:CommonController<qwer, IqwerService, qwerModel>
	{


		protected override List<qwer> GetBySearchModel(SearchModel pagerSearchModel)
        {
	        if (pagerSearchModel == null) return this.GetPagerData(new Pager { PageIndex = 1, PageSize = PageSize });

            List<qwer> lists = this.Service.SelectBy(pagerSearchModel.Pager,new qwer { Name = pagerSearchModel.Name }, qwer => qwer.Name.Contains(pagerSearchModel.Name));
        return lists;
	}

	/*add customized code between this region*/
	/*add customized code between this region*/
}
}
