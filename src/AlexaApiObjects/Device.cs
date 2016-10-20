using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Alexa.Skills.Api
{
    public class Device
    {
        public static Device FromJObject(JObject obj)
        {
            Device device = new Device();
            device.supportedInterfaces = obj.Value<JObject>("supportedInterfaces");
            return device;
        }
        public JObject supportedInterfaces { get; set; } 

        public List<string> getInterfaces()
        {
            List<string> retval = new List<string>();
            foreach(var child in this.supportedInterfaces.Children())
            {
                retval.Add(child.Path);
            }
            return retval;
        }
    }
}
