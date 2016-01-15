using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstViewerWebApp
{
  /// <summary>
  /// Model class required to deserialize the JSON response
  /// </summary>
  public class Models
  {
    public class AccessToken
    {
      public string token_type { get; set; }
      public int expires_in { get; set; }
      public string access_token { get; set; }
    }

    public class UploadBucket
    {
      public string bucket_key { get; set; }
      public List<UploadItem> objects { get; set; }
    }

    public class UploadItem
    {
      public string id { get; set; }
      public string key { get; set; }
      public string sha_1 { get; set; }
      public string size { get; set; }
      public string contentType { get; set; }
      public string location { get; set; }
    }
  }
}