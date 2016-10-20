using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alexa.Skills.Api
{
    public class Response
    {
        public Response()
        {
        }
        public OutputSpeech outputSpeech { get; set; } 
        public Card card { get; set; }
        public Reprompt reprompt { get; set; }
        public bool shouldEndSession { get; set; } = true;

    }
}
