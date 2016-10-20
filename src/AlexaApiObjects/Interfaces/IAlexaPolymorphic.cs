using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alexa.Skills.Api.Interfaces
{
    public interface IAlexaPolymorphic
    {
        string type { get; }
    }
}
