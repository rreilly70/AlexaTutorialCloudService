
using Alexa.Skills.Api.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alexa.Skills.Api
{

        public class ExceptionEncounteredRequest : SpeechletRequest
        {
            public string type { get; } = "System.ExceptionEncountered";

            public Error error { get; set; } 

            public Cause casue { get; set; }
        }
    
}
