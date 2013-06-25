using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Script.Services;
using System.Runtime.Serialization.Json;
using System.Web.Script.Serialization;
namespace SampleWebServices
{
    /// <summary>
    /// Summary description for UserInterface
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    //[ScriptService]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class UserInterface : System.Web.Services.WebService
    {

        //[WebMethod]
        ////[ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        //public static string Authendication(string Param)
        //{
        //    JavaScriptSerializer js = new JavaScriptSerializer();
        //    //ResponceData data = js.Deserialize<ResponceData>(Param);
        //    ResponceData resdata = new ResponceData();
        //    resdata.tag = "login";
        //    resdata.success = 1;
        //    resdata.error = 0;
        //    resdata.uid = "4f074eca601fb8.88015924";
        //    resdata.user.name = "Ravi Prajapat";
        //    resdata.user.email = "ravi@gmail.com";
        //    resdata.user.created_at = "2012-01-07 01:03:53";
        //    resdata.user.updated_at = null;
        //    return new JavaScriptSerializer().Serialize(resdata).ToString();

        //}
        [WebMethod]
        public string Add(string a)
        {
            return "From web services call";
        } 

    }

    public class User
    {
        public string name { get; set; }
        public string email { get; set; }
        public string passowrd { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
    }
    public class ResponceData
    {
        public string tag { get; set; }
        public int success { get; set; }
        public int error { get; set; }
        public string error_msg { get; set; }
        public string uid { get; set; }
        public User user { get; set; }
    }
}
