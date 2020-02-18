using System;
using System.Collections.Generic;
using System.Net;
using TechnicalRadiation.Models;
using TechnicalRadiation.Models.Exceptions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;

namespace TechnicalRadiation.WebApi.ExceptionHandlerExtensions
{
    public static class ExceptionHandlerExtensions
    {
        public static void UseGlobalExceptionHandler(this IApplicationBuilder app)
        {
            // TODO: Implement
            app.UseExceptionHandler(error =>
            {
                error.Run(async context =>
                {
                    // Retrive the exception handler feature
                    var exceptionHandlerFeature = context.Features.Get<IExceptionHandlerFeature>();
                    var exception = exceptionHandlerFeature.Error;
                    var statusCode = (int)HttpStatusCode.InternalServerError;

                    context.Response.ContentType = "application/json";
                    context.Response.StatusCode = statusCode;

                    if (exception is ResourceNotFoundException)
                    {
                        statusCode = (int)HttpStatusCode.NotFound;
                    }
                    if (exception is ModelFormatException)
                    {
                        statusCode = (int)HttpStatusCode.PreconditionFailed;
                    }
                    else if (exception is ArgumentOutOfRangeException)
                    {
                        statusCode = (int)HttpStatusCode.BadRequest;
                    }

                    var exceptionModel = new ExceptionModel
                    {
                        StatusCode = statusCode,
                        ExceptionMessage = exception.Message,
                        StackTrace = exception.StackTrace
                    };

                    await context.Response.WriteAsync(exceptionModel.ToString());
                });
            });
        }
    }
}