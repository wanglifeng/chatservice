using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

namespace WeChatWeb.Models
{
    public class WeChatResponseTextMessage : WeChatResponseMessage
    {
        public String Content { get; set; }

        protected override void WriteOthers(XmlWriter xw)
        {
            xw.WriteStartElement("MsgType");
            xw.WriteCData("Text");
            xw.WriteEndElement();

            xw.WriteStartElement("Content");
            xw.WriteCData(Content);
            xw.WriteEndElement();
        }
    }
}