using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Alexa.Skills.Api;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AlexaTutorialCloudService.Controllers
{
    [Route("api/[controller]")]
    public class HelloController : Controller
    {

        // POST api/values
        [Authorize]
        [HttpPost]
        public ResponseEnvelope Post([FromBody]JObject request)
        {
           // JObject RequestJO = JObject.Parse(request);
            RequestEnvelope RE = RequestEnvelope.FromJObject(request);
            ResponseEnvelope Response = new ResponseEnvelope();
            Response.version = "1.0.0";
            Response.sessionAttributes.Add("TestAttribute", new { value = "helloAttribute" });
            Response.response.outputSpeech = new OutputSpeech();
            Response.response.outputSpeech.type = "PlainText";
            var IR = (IntentRequest)RE.request;
            Response.response.outputSpeech.text = "Hello " + IR.intent.Slots.FirstOrDefault(s => s.Key == "FirstName").Value.Value;
            Response.response.shouldEndSession = true;
            return Response;
        }

    }
}
