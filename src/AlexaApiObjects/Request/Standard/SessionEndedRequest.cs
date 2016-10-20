using Alexa.Skills.Api.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alexa.Skills.Api
{
    public class SessionEndedRequest : SpeechletRequest
    {
        public SessionEndedRequest(string requestId, string timestamp, string locale, ReasonEnum reason, Error error)
        {
            this.requestId = requestId;
            this.timestamp = timestamp;
            this.locale = locale;
            this.error = error;
            this.reason = reason;
        }
        public ReasonEnum reason { get; set; }
        public Error error { get; set; }

        public enum ReasonEnum

        {

            NONE = 0, // default in case parsing fails

            ERROR,

            USER_INITIATED,

            EXCEEDED_MAX_REPROMPTS

        }
    }
}


