using MDRService.Domain.Common;
using MDRService.Domain.DomainEvents;

namespace MDRService.Domain.Entities;

public class Merchant : Entity, IAggregateRoot
{
    public MerchantId Id { get; private set; }
    public bool IsMDRExceptional { get; private set; }
    public SettlementId SettlementId { get; private set; }
    private List<MerchantMDRRule> _mdrRules = new List<MerchantMDRRule>();
    public IReadOnlyCollection<MerchantMDRRule> MDRRules => _mdrRules.AsReadOnly();

    private Merchant()
    { } // For ORM

    public Merchant(MerchantId id, bool isMdrExceptional, SettlementId settlementId)
    {
        Id = id;
        IsMDRExceptional = isMdrExceptional;
        SettlementId = settlementId;
    }

    public void AddMDRRule(MerchantMDRRule rule)
    {
        _mdrRules.Add(rule);
        AddDomainEvent(new MerchantMDRRuleAddedDomainEvent(this, rule));
    }
}