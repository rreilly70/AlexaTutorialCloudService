using Alexa.Skills.Api.Interfaces;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alexa.Skills.Api
{
    public class RequestEnvelope
    {
        public static RequestEnvelope FromJObject(JObject obj)
        {
            if(obj == null)
            {
                throw new SpeechletException("Request content is empty");
            }

            RequestEnvelope requestEnvelope = new RequestEnvelope();
            requestEnvelope.version = obj.Value<string>("version");
            requestEnvelope.context = Context.FromJObject(obj.Value<JObject>("context"));
            requestEnvelope.session = Session.FromJObject(obj.Value<JObject>("session"));
            JObject requestJson = obj.Value<JObject>("request");
            string requestType = requestJson.Value<string>("type");
            string requestId = requestJson.Value<string>("requestId");
            string timestamp = requestJson.Value<string>("timestamp");
            string locale = requestJson.Value<string>("locale");

            SpeechletRequest request;
            switch (requestType)
            {

                case "LaunchRequest":

                    request = new LaunchRequest(requestId, timestamp, locale);

                    break;

                case "IntentRequest":

                    request = new IntentRequest(requestId, timestamp,locale,

                        Intent.FromJson(requestJson.Value<JObject>("intent")));

                    break;

                case "SessionEndedRequest":

                    SessionEndedRequest.ReasonEnum reason;

                    Enum.TryParse<SessionEndedRequest.ReasonEnum>(requestJson.Value<string>("reason"), out reason);

                    request = new SessionEndedRequest(requestId, timestamp, locale, reason,Error.FromJObject(requestJson.Value<JObject>("error")));

                    break;
                // Implment AudioPlayer, PlaybackController and System Requests

                default:

                    throw new ArgumentException("JObject");

            }
            requestEnvelope.request = request;
            return requestEnvelope;
        }
        public string version { get; set; }
        public Session session { get; set; } = new Session();

        public Context context { get; set; } = new Context();

        public SpeechletRequest request { get; set; }


    }
}
