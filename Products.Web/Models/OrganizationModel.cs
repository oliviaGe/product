using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Products.Entities;

namespace Products.Web.Models
{
	public class OrganizationModel: CommonModel<Organization>
	{

		public override void PopulateFrom(Organization entity)
		{
			if (entity == null) return;
			base.PopulateFrom(entity);

		}

		public override void PopulateTo(Organization entity)
		{
			if (entity == null) return;
			base.PopulateTo(entity);

		}
	}
}
