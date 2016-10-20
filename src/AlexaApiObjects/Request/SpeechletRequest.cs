using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alexa.Skills.Api.Interfaces
{
    public abstract class SpeechletRequest
    {
        public string timestamp { get; set; }
        public string requestId { get; set; }
        public string locale { get; set; }
    }
}
