using Alexa.Skills.Api.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alexa.Skills.Api
{

        public class Stop : IAlexaPolymorphic
        {

            public Stop()
            {
                this.type = "AudioPlayer.Stop";
            }
            public string type { get; }
        }
    
}
