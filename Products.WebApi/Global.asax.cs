using System.Configuration;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using MetaShare.Common.Core.Daos;
using MetaShare.Common.Core.Daos.SqlServer;
using Products.Daos;
using Products.Services;
namespace Products.WebApi
{
 
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            string connectionString = ConfigurationManager.ConnectionStrings["Products"].ConnectionString;
DaoFactory.Instance.ConnectionStringBuilder = new ConnectionStringBuilder(connectionString, typeof(SqlContext)){SqlDialectType = typeof(SqlServerDialect), SqlDialectVersionType = typeof(SqlServerDialectVersion)};

            RegisterDaos.RegisterAll(DaoFactory.Instance.ConnectionStringBuilder.SqlDialectType, DaoFactory.Instance.ConnectionStringBuilder.SqlDialectVersionType);
            RegisterServices.RegisterAll();

            //var format = GlobalConfiguration.Configuration.Formatters;
            //format.XmlFormatter.SupportedMediaTypes.Clear();
        }
    }
}