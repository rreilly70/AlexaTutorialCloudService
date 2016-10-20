using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alexa.Skills.Api
{
    public class Application
    {
        public static Application FromJObject(JObject obj)
        {
            Application application = new Application();
            application.applicationId = obj.Value<string>("applicationId");
            return application;
        }
        public string applicationId { get; set; }
    }
}
