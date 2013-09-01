using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeChatServiceSDK
{
    public class TextResponse : BaseResponseMessage
    {
        public override MessageType Type { get { return MessageType.TEXT; } }

        public String Content { get; set; }
    }
}
