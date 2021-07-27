using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmptyWebApp
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class MyHeaderMiddleware
    {
        private readonly RequestDelegate _next;

        public MyHeaderMiddleware(RequestDelegate next, ILogger<MyHeaderMiddleware> logger)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {
            httpContext.Response.Headers.Add("mycustomheader", "my header value");
            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class MyHeaderMiddlewareExtensions
    {
        public static IApplicationBuilder UseMyHeaderMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MyHeaderMiddleware>();
        }
    }
}
