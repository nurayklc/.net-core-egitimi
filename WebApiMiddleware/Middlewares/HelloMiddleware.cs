using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace WebApiMiddleware.Middlewares 
{

    public class HelloMiddleware{
        private readonly RequestDelegate _next;
        public HelloMiddleware(RequestDelegate next){
            _next = next;
        }

        public async Task Invoke(HttpContext context){
            Console.WriteLine("Hello Middleware");
            await _next.Invoke(context);
            Console.WriteLine("Bye Middleware");
        }
    }

    public static class HelloMiddlewareExtension{
        public static IApplicationBuilder UseHello(this IApplicationBuilder builder){
            return builder.UseMiddleware<HelloMiddleware>();
        }
    }
}