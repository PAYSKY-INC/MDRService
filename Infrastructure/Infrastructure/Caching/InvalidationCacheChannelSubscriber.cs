﻿using MDRService.Application.Common.Abstracts.Caching;
using Microsoft.Extensions.Hosting;

namespace MDRService.Infrastructure.Caching
{
    public class InvalidationCacheChannelSubscriber : IHostedService
    {
        #region Dependencies
        private readonly ICrossCacheService _crossCacheService;
        #endregion

        #region Constructor
        public InvalidationCacheChannelSubscriber(ICrossCacheService crossCacheService)
        {
            _crossCacheService = crossCacheService;
        }
        #endregion

        #region Async Hosted Methods
        public Task StartAsync(CancellationToken cancellationToken)
        {
            return Task.Factory.StartNew(async () =>
            {
                await _crossCacheService.InvalidateLocalCacheBySubscibeInvalidateChannel();
            },
            cancellationToken);
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
        #endregion
    }
}
