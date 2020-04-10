using MetaShare.Common.Core.Daos;
using Products.Entities;
using Products.Daos.Interfaces;
using Products.TestData;

namespace Products.Daos.Mocks
{
	public class OrganizationDaoMock : MockDao<Organization>, IOrganizationDao
	{
		public OrganizationDaoMock() : base(OrganizationTestData.CreateOrganization())
		{
		}
	}
}
