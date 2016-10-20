
using Alexa.Skills.Api.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alexa.Skills.Api
{ 
    public class IntentRequest : SpeechletRequest
    {

        public IntentRequest(string requestId, string timestamp, string locale,Intent intent)
        {
            this.requestId = requestId;
            this.timestamp = timestamp;
            this.locale = locale;
            this.intent = intent;
        }
        public Intent intent { get; set; } 

    }
}
