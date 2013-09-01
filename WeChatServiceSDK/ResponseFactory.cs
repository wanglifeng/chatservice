using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WeChatServiceSDK
{
    public class ResponseFactory
    {
        public static BaseResponseMessage GetResponse(string content)
        {
            if (content.IndexOf("\"Type\":0") > -1)
            {
                return JsonConvert.DeserializeObject<TextResponse>(content);
            }
            return null;
        }
    }
}
