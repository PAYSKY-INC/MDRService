using MDRService.Domain.Common;
using MDRService.Domain.Entities;

namespace MDRService.Domain.DomainEvents;

public record MDRCalculatedDomainEvent(Transaction Transaction, MDRResult MDRResult) : BaseDomainEvent;