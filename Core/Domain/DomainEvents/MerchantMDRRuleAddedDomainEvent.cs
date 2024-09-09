using MDRService.Domain.Common;
using MDRService.Domain.Entities;

namespace MDRService.Domain.DomainEvents;

public record MerchantMDRRuleAddedDomainEvent(Merchant Merchant, MerchantMDRRule Rule) : BaseDomainEvent;