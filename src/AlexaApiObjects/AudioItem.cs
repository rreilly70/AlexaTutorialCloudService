using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alexa.Skills.Api
{
    public class AudioItem
    {
        public AudioItem()
        {
        }
        public AlexaStream stream { get; set; } = new AlexaStream();
    }
    public class AlexaStream
    {
        public string url { get; set; }
        public string token { get; set; }
        public string expectedPreviousToken { get; set; }
        public long offsetInMilliseconds { get; set; }
    }
}
