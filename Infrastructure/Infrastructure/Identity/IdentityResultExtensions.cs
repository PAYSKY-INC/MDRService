using MDRService.Application.Common.Errors;
using MDRService.Application.Common.Messaging;
using Microsoft.AspNetCore.Identity;

namespace MDRService.Infrastructure.Identity
{
    public static class IdentityResultExtensions
    {
        public static Response<bool> ToApplicationResult(this IdentityResult result)
        {

            var errors = result.Errors
                 .Select(e => new { e.Code, e.Description })
                 .ToDictionary(e => e.Code, e => e.Description);

            return result.Succeeded
                ? Response.Success(true)
                : Response.Failure(SecurityAccessErrors.CreationUserFailed(errors));
        }
    }
}