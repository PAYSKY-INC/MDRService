using MDRService.Domain.Common;
using MDRService.Domain.Enumerations;

namespace MDRService.Domain.Entities;

public class MerchantMDRRule:Entity
{
    public MerchantMDRRuleId Id { get; private set; }
    public MDRChannelId ChannelId { get; private set; }
    public decimal MDRValue { get; private set; }
    public decimal MDRFlat { get; private set; }
    public decimal MinMDRLimits { get; private set; }
    public decimal MaxMDRLimits { get; private set; }
    public RuleType RuleType { get; private set; }

    private MerchantMDRRule() { } // For ORM

    public MerchantMDRRule(MerchantMDRRuleId id, MDRChannelId channelId, decimal mdrValue, decimal mdrFlat,
                           decimal minMDRLimits, decimal maxMDRLimits, RuleType ruleType)
    {
        Id = id;
        ChannelId = channelId;
        MDRValue = mdrValue;
        MDRFlat = mdrFlat;
        MinMDRLimits = minMDRLimits;
        MaxMDRLimits = maxMDRLimits;
        RuleType = ruleType;
    }
}