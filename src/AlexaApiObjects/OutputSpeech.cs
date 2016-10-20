using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alexa.Skills.Api
{
    public class OutputSpeech 
    {
        public string type { get; set; }
        public string text { get; set; }
        public string ssml { get; set; }
    }
}
