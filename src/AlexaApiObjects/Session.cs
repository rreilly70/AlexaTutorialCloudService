using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Linq;

namespace Alexa.Skills.Api
{
    public class Session
    {
        public static Session FromJObject(JObject obj)
        {
            Session session = new Session();
            session._new = obj.Value<bool>("new");
            session.sessionId = obj.Value<string>("sessionId");
            session.user = User.FromJObject(obj.Value<JObject>("user"));
            session.application = Application.FromJObject(obj.Value<JObject>("application"));
            var attributes = new Dictionary<string, string>();
            var jsonAttributes = obj.Value<JObject>("attributes");
            if (jsonAttributes != null)
            {
                foreach (var attrib in jsonAttributes.Children())
                {
                    attributes.Add(attrib.Value<JProperty>().Name, attrib.Value<JProperty>().Value.ToString());
                }
            }
            session.attributes = attributes;
            return session;
        }
        [JsonProperty("new")]
        public bool _new { get; set; }
        public string sessionId { get; set; }
        public virtual Dictionary<string, string> attributes { get; set;}
        public Application application { get; set; } = new Application();

        public User user { get; set; } = new User();

    }
}
