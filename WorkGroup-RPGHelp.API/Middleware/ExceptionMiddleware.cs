using System.Text.Json;
using WorkGroup_RPGHelp.BLL.Exceptions;
using WorkGroup_RPGHelp.BLL.Services;
using WorkGroup_RPGHelp.BLL.Services.Interfaces;
using WorkGroup_RPGHelp.DAL.Contexts;
using WorkGroup_RPGHelp.DAL.Repositories.Interfaces;

namespace WorkGroup_RPGHelp.API.Middleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _requestDelegate;

        public ExceptionMiddleware(RequestDelegate requestDelegate)
        {
            _requestDelegate = requestDelegate;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _requestDelegate(context);
            }

            catch (Exception ex)
            {
                await HandleException(context, ex);
            }
        }

        public async Task HandleException(HttpContext context, Exception ex)
        {
            context.Response.ContentType = "application/json";

            int statusCode = 400;

            switch (ex)
            {
                case RPGHelpException e:
                    await SendResponse(context, e);
                    break;
                case Exception:
                    statusCode = 500;
                    context.Response.StatusCode = statusCode;

                    var respons = new
                    {
                        message = ex.Message,
                    };

                    var jsResponse = JsonSerializer.Serialize(respons);

                    await context.Response.WriteAsync(jsResponse);
                    break;

                default:
                    throw new Exception("ERROR");
            }
        }

        public async Task SendResponse(HttpContext context, RPGHelpException ex)
        {
            context.Response.StatusCode = ex.StatusCode;

            var response = new
            {
                content = ex.Content
        };

            var jsResponse = JsonSerializer.Serialize(response);

            await context.Response.WriteAsync(jsResponse);
        }
    }
}
