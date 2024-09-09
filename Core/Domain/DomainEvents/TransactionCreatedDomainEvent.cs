using MDRService.Domain.Common;
using MDRService.Domain.Entities;

namespace MDRService.Domain.DomainEvents;

public record TransactionCreatedDomainEvent(Transaction Transaction) : BaseDomainEvent;