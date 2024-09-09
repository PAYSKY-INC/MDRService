using MDRService.Application.Common.Abstracts.Account;
using MDRService.Application.Common.Abstracts.Persistence;
using MDRService.Infrastructure.Identity;
using MDRService.Persistence.EF.Configurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace MDRService.Persistence.EF
{
    public sealed class ApplicationDbContext : IdentityUserContext<ApplicationUser>, IApplicationDbContext
    {
        #region Properties

        private ICurrentUser CurrentUserService { get; }
        public IServiceProvider ServiceProvider { get; }

        #endregion Properties

        #region Constructor

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options,
                         ICurrentUser currentUserService,
                         IServiceProvider serviceProvider) : base(options)
        {
            CurrentUserService = currentUserService;
            ServiceProvider = serviceProvider;
        }

        #endregion Constructor

        #region On Model Creating

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);
            builder.ConfigureIdentity();
        }

        #endregion On Model Creating

        #region Save Changes

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            return await base.SaveChangesAsync(cancellationToken);
        }

        #endregion Save Changes
    }
}