using RestSharp;
using System.Web.Script.Services;
using System.Web.Services;

namespace FirstViewerWebApp
{
  /// <summary>
  /// Summary description for auth
  /// </summary>
  [WebService(Namespace = "http://tempuri.org/")]
  [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
  [System.ComponentModel.ToolboxItem(false)]
  // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
  [System.Web.Script.Services.ScriptService]
  public class auth : System.Web.Services.WebService
  {
    [WebMethod(EnableSession = true)]
    public void GetToken()
    {
      Context.Response.Write(Util.Token);
    }

    [WebMethod(EnableSession = true)]
    public void RefreshToken()
    {
      Util.Authenticate(); // get a new token
      Context.Response.Write(Util.Token);
    }
  }
}
