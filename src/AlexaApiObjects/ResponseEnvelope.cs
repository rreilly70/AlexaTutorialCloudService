using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alexa.Skills.Api
{
    public class ResponseEnvelope
    {
        public ResponseEnvelope()
        {
        }
        public string version { get; set; }
        public Dictionary<string,object> sessionAttributes { get; set; } = new Dictionary<string, object>();

        public Response response { get; set; } = new Response();
    }
}
