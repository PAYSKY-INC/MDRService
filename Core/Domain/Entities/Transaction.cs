using MDRService.Domain.Common;
using MDRService.Domain.DomainEvents;
using MDRService.Domain.Enumerations;
using MediatR;

namespace MDRService.Domain.Entities;

public record TransactionId(long Value);
public record MerchantId(int Value);
public record SettlementId(int Value);
public record MerchantMDRRuleId(int Value);
public record MDRChannelId(int Value);
public record Money(decimal Amount, string Currency);

public class Transaction : Entity, IAggregateRoot
{
    public TransactionId Id { get; private set; }
    public MerchantId MerchantId { get; private set; }
    public Money Amount { get; private set; }
    public TransactionType Type { get; private set; }
    public DateTime Date { get; private set; }

    private Transaction()
    { } // For ORM

    public Transaction(TransactionId id, MerchantId merchantId, Money amount, TransactionType type, DateTime date)
    {
        Id = id;
        MerchantId = merchantId;
        Amount = amount;
        Type = type;
        Date = date;

        AddDomainEvent(new TransactionCreatedDomainEvent(this));
    }

    public void CalculateMDR(MDRResult mdrResult)
    {
        // Apply MDR calculation logic here
        AddDomainEvent(new MDRCalculatedDomainEvent(this, mdrResult));
    }
}

public class MDRResult
{
    public Money MDRValue { get; }
    public Money MaxMDRLimit { get; }
    public Money MinMDRLimit { get; }
    public Money MDRFlat { get; }
    public string CalculationMethod { get; }
    public Money CalculatedValue { get; }

    public MDRResult(Money mdrValue, Money maxMDRLimit, Money minMDRLimit, Money mdrFlat, string calculationMethod, Money calculatedValue)
    {
        MDRValue = mdrValue;
        MaxMDRLimit = maxMDRLimit;
        MinMDRLimit = minMDRLimit;
        MDRFlat = mdrFlat;
        CalculationMethod = calculationMethod;
        CalculatedValue = calculatedValue;
    }
}