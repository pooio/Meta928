using System.Configuration;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using MetaShare.Common.Core.Daos;
using MetaShare.Common.Core.Daos.SqlServer;
using Meta727.Daos;
using Meta727.Services;
/*add customized code between this region*/
/*add customized code between this region*/
namespace Meta727.WebApi
{
 
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            string connectionString = ConfigurationManager.ConnectionStrings["Meta727"].ConnectionString;
DaoFactory.Instance.ConnectionStringBuilder = new ConnectionStringBuilder(connectionString, typeof(SqlContext)){SqlDialectType = typeof(SqlServerDialect), SqlDialectVersionType = typeof(SqlServerDialectVersion)};

            RegisterDaos.RegisterAll(DaoFactory.Instance.ConnectionStringBuilder.SqlDialectType, DaoFactory.Instance.ConnectionStringBuilder.SqlDialectVersionType);
            RegisterServices.RegisterAll();

            //var format = GlobalConfiguration.Configuration.Formatters;
            //format.XmlFormatter.SupportedMediaTypes.Clear();
/*add customized code between this region*/
/*add customized code between this region*/
        }
    }
}