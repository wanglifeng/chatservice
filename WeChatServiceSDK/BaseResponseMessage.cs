using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeChatServiceSDK
{
    public abstract class BaseResponseMessage
    {
        public int ErrorCode { get; set; }
        public String ErrorMessage { get; set; }

        public String From { get; set; }
        public String To { get; set; }
        public DateTime Time { get; set; }

        public abstract MessageType Type { get; }
    }
}
