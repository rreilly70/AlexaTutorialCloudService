using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alexa.Skills.Api
{
    public class User
    {
        public static User FromJObject(JObject obj)
        {
            User user = new User();
            user.userId = obj.Value<string>("userId");
            user.accessToken = obj.Value<string>("accessToken");
            return user;
        }

        public string userId { get; set; }
        public string accessToken { get; set; }
    }
}
