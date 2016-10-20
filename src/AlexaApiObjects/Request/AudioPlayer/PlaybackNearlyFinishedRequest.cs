using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alexa.Skills.Api.Interfaces;
using Newtonsoft.Json;


namespace Alexa.Skills.Api
{
    public class PlaybackNearlyFinishedRequest : SpeechletRequest, IAudioPlayerRequest
    {
        public string type { get; } = "AudioPlayer.PlaybackNearlyFinished";
        public string token { get; set; }
        public string offsetInMilliseconds { get; set; }
        
    }
}
