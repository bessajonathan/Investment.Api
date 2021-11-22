

using Investment.Common.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;

namespace Investment.Api.Filters
{
    public class ExceptionFilter: ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            context.HttpContext.Response.ContentType = "application/json";
            context.HttpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            ErrorResponse response = new ErrorResponse
            {
                Title = "Error",
                StatusCode = (int)HttpStatusCode.InternalServerError,
                Data = context.Exception.Message
            };


            if (context.Exception is NotFoundException)
            {
                response.Title = "Warning";
                response.StatusCode = (int)HttpStatusCode.NotFound;
                response.Data = context.Exception.Message;
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.NotFound;
            }

            context.Result = new JsonResult(
                new
                {
                    Title = response.Title,
                    StatusCode = response.StatusCode,
                    Data = response.Data
                });
        }
    }
}
