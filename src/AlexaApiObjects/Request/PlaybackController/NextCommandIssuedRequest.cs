
using Alexa.Skills.Api.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alexa.Skills.Api
{
        public class NextCommandIssued : SpeechletRequest
        {
            public string type { get; } = "PlaybackController.NextCommandIssued";

        }
    
}
