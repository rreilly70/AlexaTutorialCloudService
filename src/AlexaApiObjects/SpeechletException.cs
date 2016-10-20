using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alexa.Skills.Api
{
    public class SpeechletException : Exception

    {

        public SpeechletException() : base()
        {



        }



        public SpeechletException(string message) : base(message)
        {



        }



        public SpeechletException(string message, Exception cause) : base(message, cause)
        {



        }

    }
}
