using Microsoft.AspNetCore.Authorization;

namespace MDRService.Infrastructure.Identity
{
    public class PermissionRequirement : IAuthorizationRequirement
    {
        public string Permission { get; }
        public PermissionRequirement(string permission)
        {
            Permission = permission;
        }

    }
}