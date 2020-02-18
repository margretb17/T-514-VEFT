using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Primitives;

namespace TechnicalRadiation.WebApi.Attributes
{
    public class AuthorizationAttribute : ActionFilterAttribute
    {
        private readonly string authorizationStr = "Bearer TechnicalRadiationAssignmentKeyForAuthorization278378yo";
         public override void OnActionExecuted(ActionExecutedContext context)
         {
             StringValues token;
             string authToken = context.HttpContext.Request.Headers["Authorization"];
             if(authToken == authorizationStr)
             {
                 Console.WriteLine("You are authorized!");
             }
             else if(token != authorizationStr)
             {
                 context.Result = new StatusCodeResult(401);
                 Console.WriteLine("You are not authorized!");
             }
            Console.WriteLine(context.HttpContext.Request.Path);
         }
    }
}