﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alexa.Skills.Api
{
    public class Intent
    {

        /// <summary>

        /// 

        /// </summary>

        /// <param name="json"></param>

        /// <returns></returns>

        public static Intent FromJson(JObject json)
        {

            var slots = new Dictionary<string, Slot>();

            if (json["slots"] != null && json.Value<JObject>("slots").HasValues)
            {

                foreach (var slot in json.Value<JObject>("slots").Children())
                {

                    slots.Add(slot.Value<JProperty>().Name, Slot.FromJson(slot.Value<JProperty>().Value as JObject));

                }

            }



            return new Intent
            {

                Name = json.Value<string>("name"),

                Slots = slots

            };

        }



        public virtual string Name
        {

            get;

            set;

        }



        public virtual Dictionary<string, Slot> Slots
        {

            get;

            set;

        }
    }
}
