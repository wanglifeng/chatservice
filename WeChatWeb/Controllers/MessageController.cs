using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeChatServiceSDK;

namespace WeChatWeb.Controllers
{
    public class MessageController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string body)
        {
            var client = new RestClient();
            var req = new RestRequest();
            req.Method = Method.POST;
            req.Resource = System.Configuration.ConfigurationManager.AppSettings["MessageServiceUrl"];
            var rsp = client.Execute(req);
            if (rsp.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var t = ResponseFactory.GetResponse(rsp.Content);

                return new ContentResult() { Content = Models.WeChatResponseMessage.GetMessage(t).ConvertToWeiChatResponse(), ContentType = "application/xml" };
            }
            else
            {
                return new ContentResult() { Content = "Service Unavailable", ContentType = "application/xml" };
            }
        }

    }
}
