using Products.Entities;
using System.Collections.Generic;
using Products.Services.Interfaces;
using Products.Web.Models;
using MetaShare.Common.Core.CommonService;
using MetaShare.Common.Core.Entities;


namespace Products.Web.Controllers
{
	public class OrganizationController:CommonController<Organization, IOrganizationService, OrganizationModel>
	{


		protected override List<Organization> GetBySearchModel(SearchModel pagerSearchModel)
        {
	        if (pagerSearchModel == null) return this.GetPagerData(new Pager { PageIndex = 1, PageSize = PageSize });

            List<Organization> lists = this.Service.SelectBy(pagerSearchModel.Pager,new Organization { Name = pagerSearchModel.Name }, organization => organization.Name.Contains(pagerSearchModel.Name));
        return lists;
	}

}
}
