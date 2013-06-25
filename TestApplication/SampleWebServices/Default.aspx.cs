using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;
namespace SampleWebServices
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //WebRequest webreq = WebRequest.Create("http://192.168.43.155:50921/UserInterface.asmx/Authendication");
            //webreq.Method = "POST";
            //webreq.ContentType = "text/json";

            //using (var streamWriter = new StreamWriter(webreq.GetRequestStream()))
            //{
            //    //string json = "{ \"method\": \"send\", " +
            //    //                  "  \"params\": [ " +
            //    //                  "             \"IPutAGuidHere\", " +
            //    //                  "             \"msg@MyCompany.com\", " +
            //    //                  "             \"MyTenDigitNumberWasHere\", " +
            //    //                  "             \"" + message + "\" " +
            //    //                  "             ] " +
            //    //                  "}";
            //    string json = "";

            //    streamWriter.Write(json);
            //}
            //var httpResponse = (HttpWebResponse)webreq.GetResponse();
            //using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            //{
            //    var responseText = streamReader.ReadToEnd();
            //    //Now you have your response.
            //    //or false depending on information in the response
            //}

        }
    }
}
