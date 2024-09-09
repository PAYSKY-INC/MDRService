using MDRService.Domain.Common;

namespace MDRService.Application.Common.Abstracts.DomainEvent
{
    public interface IDomainEventService
    {
        Task Publish(BaseDomainEvent domainEvent);
    }
}
