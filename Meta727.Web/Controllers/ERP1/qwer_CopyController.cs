using System.Collections.Generic;
using Meta727.Services.Interfaces.ERP1;
using Meta727.Entities.ERP1;
using Meta727.Web.Models.ERP1;
using MetaShare.Common.Core.CommonService;
using MetaShare.Common.Core.Entities;
using Meta727.Web.Models;

/*add customized code between this region*/
/*add customized code between this region*/

namespace Meta727.Web.Controllers.ERP1
{
	public class qwer_CopyController:CommonController<qwer_Copy, Iqwer_CopyService, qwer_CopyModel>
	{
		protected override string GetCurrentAreaPath()
		{
			 return "ERP1_qwer_Copy";
		}


		protected override List<qwer_Copy> GetBySearchModel(SearchModel pagerSearchModel)
        {
	        if (pagerSearchModel == null) return this.GetPagerData(new Pager { PageIndex = 1, PageSize = PageSize });

            List<qwer_Copy> lists = this.Service.SelectBy(pagerSearchModel.Pager,new qwer_Copy { Name = pagerSearchModel.Name }, qwer_Copy => qwer_Copy.Name.Contains(pagerSearchModel.Name));
        return lists;
	}

	/*add customized code between this region*/
	/*add customized code between this region*/
}
}
