using System;
using System.Web.Http;
using System.Collections.Generic;
using Products.Entities;
using Products.Services.Interfaces;
using Products.WebApi.Models;

namespace Products.WebApi.Controllers
{
	public class OrganizationApiController : CommonApiController<Organization, IOrganizationService>
	{


	}
}
