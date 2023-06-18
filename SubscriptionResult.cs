using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class SubscriptionResult
    {
        public bool IsSuccessful { get; set; }
        public string ResultMsg { get; set; }


        public SubscriptionResult(bool isSuccessful, string resultMsg)
        {
            this.IsSuccessful = isSuccessful;
            this.ResultMsg = resultMsg;
        }

    }
}
