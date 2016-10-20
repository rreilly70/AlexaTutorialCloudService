using Alexa.Skills.Api.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alexa.Skills.Api
{
    public class Play
    { 
            public Play()
            {
                this.type = "AudioPlayer.Play";
            }
            public string type { get; }
            public string playBehavior { get; set; }
            public AudioItem audioItem { get; set; } = new AudioItem();
        }
    
}
