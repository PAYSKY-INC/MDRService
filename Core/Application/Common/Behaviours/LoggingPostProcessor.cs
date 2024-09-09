using MDRService.Application.Common.Messaging;
using System.Diagnostics;

namespace MDRService.Application.Common.Behaviours
{
    public class LoggingPostProcessor<TRequest> : IRequestPostProcessor<TRequest>
        where TRequest : notnull, IBaseCommand
    {
        public Task Handle(TRequest request, CancellationToken cancellationToken)
        {
            Debug.WriteLine("Post processor");

            return Task.CompletedTask;
        }
    }
}
