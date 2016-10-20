using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alexa.Skills.Api
{
    public class Error 
    {

        public static Error FromJObject(JObject obj)
        {
            TypeEnum type;
            Enum.TryParse(obj.Value<string>("error"), out type);
            Error error = new Error();
            error.type = type;
            error.message = obj.Value<string>("message");
            return error;
        }

        public TypeEnum type { get; set; }
        public string message { get; set; }

        public enum TypeEnum

        {

            NONE = 0, // default in case parsing fails

            INVALID_RESPONSE,

            DEVICE_COMMUNICATION_ERROR,

            INTERNAL_ERROR,

        }
    }
}
