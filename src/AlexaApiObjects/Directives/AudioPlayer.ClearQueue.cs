using Alexa.Skills.Api.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alexa.Skills.Api
    { 
        public class ClearQueue 
        {
            public string type { get; } = "AudioPlayer.ClearQueue";
            public string clearBehavior { get; set; }
        }
    }

