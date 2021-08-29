using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Net;

namespace Api.Calculo.Filters
{
    public class ExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            context.Result = new JsonResult(new { context.Exception.Message, Details = context.Exception.StackTrace?.Split(Environment.NewLine) })
            {
                StatusCode = (int)HttpStatusCode.InternalServerError
            };
        }
    }
}
