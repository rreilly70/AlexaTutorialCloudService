using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Text;
using Alexa.Skills.Api;
using Newtonsoft.Json.Linq;

namespace AlexaSkillSample
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class AlexaJWTMiddleware
    {
        private readonly RequestDelegate _next;

        public AlexaJWTMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {

            if (!context.Request.Headers.Keys.Contains("Authorization"))
            {
                // Keep the original stream in a separate
                // variable to restore it later if necessary.
                var stream = context.Request.Body;

                // Optimization: don't buffer the request if
                // there was no stream or if it is rewindable.
                if (stream == Stream.Null || stream.CanSeek)
                {
                    await _next(context);

                    return;
                }

                try
                {
                    using (var buffer = new MemoryStream())
                    {
                        // Copy the request stream to the memory stream.
                        await stream.CopyToAsync(buffer);
                        byte[] bodyBuffer = new byte[buffer.Length];
                        buffer.Position = 0L;
                        buffer.Read(bodyBuffer, 0, bodyBuffer.Length);
                        string body = Encoding.UTF8.GetString(bodyBuffer);

                        RequestEnvelope AlexaRequest = RequestEnvelope.FromJObject(JObject.Parse(body));
                        if (AlexaRequest?.session?.user?.accessToken != null)
                        {
                            context.Request.HttpContext.Request.Headers["Authorization"] = "Bearer " + AlexaRequest.session.user.accessToken;
                        }

                        // Rewind the memory stream.
                        buffer.Position = 0L;

                        // Replace the request stream by the memory stream.
                        context.Request.Body = buffer;

                        // Invoke the rest of the pipeline.
                        await _next(context);
                    }
                }

                finally
                {
                    // Restore the original stream.
                    context.Request.Body = stream;
                }
            }

            await _next(context);
            return;
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class AlexaJWTMiddlewareExtensions
    {
        public static IApplicationBuilder UseAlexaJWTMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<AlexaJWTMiddleware>();
        }
    }
}
