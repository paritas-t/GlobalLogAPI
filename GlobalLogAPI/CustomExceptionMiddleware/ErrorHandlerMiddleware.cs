using Contracts;
using GlobalLogAPI.CustomExceptionMiddleware;
using GlobalLogAPI.Models;
using GlobalLogAPI.Models.DB;
using System.Net;
using System.Text.Json;
using static GlobalLogAPI.Extensions.CommonResultAPI;

namespace GlobalLogAPI
{
    public class ErrorHandlerMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILoggerManager _logger;
        public ErrorHandlerMiddleware(RequestDelegate next, ILoggerManager logger)
        {
            _next = next;
            _logger = logger;
        }
        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception error)
            {
                _logger.LogError($"Somthing went wrong : {error}");
                await HandleExceptionAsync(context, error);
            }
        }
        /// <summary>
        /// Error Message ที่แจ้งกลับ
        /// </summary>
        /// <param name="context"></param>
        /// <param name="error"></param>
        /// <returns></returns>
        private async Task HandleExceptionAsync(HttpContext context, Exception error)
        {
            context.Response.ContentType = "application/json";
            var response = context.Response;
            UUBillingEntity db = new UUBillingEntity();
            var errorResponse = new ErrorDetails
            {
                StatusCode = (int)HttpStatusCode.InternalServerError
            };

            switch (error)
            {
                case ApplicationException ex:
                    if (ex.Message.Contains("Invalid token"))
                    {
                        response.StatusCode = (int)HttpStatusCode.Forbidden;
                        errorResponse.Message = ex.Message;
                        break;
                    }
                    response.StatusCode = (int)HttpStatusCode.BadRequest;
                    errorResponse.Message = ex.Message;
                break;
                //ไม่เจอข้อมูล
                case KeyNotFoundException ex:
                    response.StatusCode = (int)HttpStatusCode.NotFound;
                    errorResponse.Message = ex.Message;
                    break;

                default:
                    response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    errorResponse.Message = "Internal Server Error Check Log";
                    break;
            }
            _logger.LogError(error.Message);
            var result = JsonSerializer.Serialize(errorResponse);
           

            await context.Response.WriteAsync(result);

        }
    }
}
