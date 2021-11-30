using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetailAssest.Middlewares
{

    public class CustomExceptionMiddleware
    {
        //  private readonly ConfigServerData configServer;
        private readonly ILogger logger;
        private readonly RequestDelegate next;
        public CustomExceptionMiddleware(RequestDelegate next, IConfiguration configuration, ILoggerFactory loggerFactory)
        {
            // configServer = configuration.Get<ConfigServerData>();
            logger = loggerFactory.CreateLogger<CustomExceptionMiddleware>();
            this.next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            string errorMessage = string.IsNullOrEmpty(ex.Message) ? ex.InnerException.Message : ex.Message;
            logger.LogError("Source ----> " + ex.Source);
            logger.LogError("ErrorMessage--------------->" + errorMessage + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss.fff tt"));
            var code = 500;


            var result = JsonConvert.SerializeObject(new
            {
                Message = "Internal server error"
            });
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)code;
            logger.LogError(context.Request.Path + "-" + ex.StackTrace + "-" + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss.fff tt"));
            return context.Response.WriteAsync(result);
        }
    }



}

