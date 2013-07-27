using System;
using System.Web.Http;

namespace CISH6510.AddressBook.Web
{
	public class WebApplication : System.Web.HttpApplication
	{
		protected void Application_Start(object sender, EventArgs e)
		{
			WebApiConfig.Register(GlobalConfiguration.Configuration);
		}
	}
}