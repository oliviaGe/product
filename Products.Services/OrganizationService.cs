using System.Collections.Generic;
using MetaShare.Common.Core.Entities;
using Products.Entities;
using MetaShare.Common.Core.Services;
using Products.Daos.Interfaces;
using Products.Services.Interfaces;


namespace Products.Services
{
	public class OrganizationService : Service<Organization>, IOrganizationService
	{
		public OrganizationService() : base(typeof (IOrganizationDao))
		{
		}

	}
}
