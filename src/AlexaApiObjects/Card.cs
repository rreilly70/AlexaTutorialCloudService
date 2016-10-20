using Alexa.Skills.Api.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alexa.Skills.Api
{
    public class Card : IAlexaPolymorphic
    {
        public string type { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public string text { get; set; }
        public Image image { get; set; } = new Image();
    }
}
