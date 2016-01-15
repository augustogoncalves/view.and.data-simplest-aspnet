using RestSharp;
using System;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

namespace FirstViewerWebApp
{
  public partial class SamplePage : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void viewModel_Click(object sender, EventArgs e)
    {
      // 1. Authenticate with Autodesk 
      Util.Authenticate();

      // 2. Show an existing model or update a new one?
      if (!string.IsNullOrWhiteSpace(modelURN.Text))
        ShowModel(modelURN.Text);
      else
        ShowModel(UploadModel());
    }

    private void ShowModel(string urn)
    {
      // Register a client side script to load the model (URN)
      ClientScript.RegisterStartupScript(this.GetType(), "showModel",
        string.Format("<script language='javascript'>showModel('{0}');</script>", urn));
    }

    private string UploadModel()
    {
      string urn = Util.Upload(fileToUpload.PostedFile);
      modelURN.Text = urn;
      return urn;
    }
  }
}