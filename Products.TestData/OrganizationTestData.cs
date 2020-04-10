using System;
using System.Collections.Generic;
using NUnit.Framework;
using Products.Entities;

namespace Products.TestData
{
	public class OrganizationTestData
	{
		public const int OrganizationCount = 3;

		 public static List<Organization> CreateOrganization()
		{
			return new List<Organization>
			{
				CreateOrganization1(),
				CreateOrganization2(),
				CreateOrganization3(),
			};
		}

		 public static Organization CreateOrganization1()
		{
			return new Organization
			{
					Id = 1, 
					Description = string.Empty, 
					Name = string.Empty, 
			};
		}
		 public static Organization CreateOrganization2()
		{
			return new Organization
			{
					Id = 2, 
					Description = string.Empty, 
					Name = string.Empty, 
			};
		}
		 public static Organization CreateOrganization3()
		{
			return new Organization
			{
					Id = 3, 
					Description = string.Empty, 
					Name = string.Empty, 
			};
		}
		public static void AssertAreEqual(Organization expected, Organization actual)
		{
			Assert.AreEqual(expected.Description, actual.Description);
			Assert.AreEqual(expected.Name, actual.Name);
		}
	}
}
