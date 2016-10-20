using Alexa.Skills.Api.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alexa.Skills.Api
{

    public class LaunchRequest : SpeechletRequest
    {
        public LaunchRequest(string requestId, string timestamp, string locale)
        {
            this.requestId = requestId;
            this.timestamp = timestamp;
            this.locale = locale;
        }

    }
}
