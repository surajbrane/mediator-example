using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MediatorExample.Api.Common
{
    public static class Extensions
    {
        public static IActionResult Ok<TReq, TRes>(this IRequestHandler<TReq, TRes> handler, object value)
            where TReq : IRequest<TRes>
            where TRes : IActionResult
        { 
            return  new OkObjectResult(value); 
        }
    }
}
