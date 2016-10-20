using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alexa.Skills.Api
{
    public class Context
    {
        public static Context FromJObject(JObject obj)
        {
            Context context = new Context();
            if (obj != null)
            {
                context.System = System.FromJObject(obj.Value<JObject>("System"));
                context.AudioPlayer = AudioPlayer.FromJObject(obj.Value<JObject>("AudioPlayer"));
            }
            return context;
        }
        public System System { get; set; } = new System();
        public AudioPlayer AudioPlayer { get; set; } = new AudioPlayer();
    }
}
