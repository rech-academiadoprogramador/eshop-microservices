namespace Ordering.Domain.ValueObjects;
public record OrderId
{
    public Guid Value { get; }
    private OrderId(Guid value) => Value = value;
    public static OrderId Of(Guid value)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (value == Guid.Empty)
        {
            throw new DomainException("OrderId cannot be empty.");
        }

        return new OrderId(value);
    }

    public static implicit operator Guid(OrderId self) => self.Value;

    public static explicit operator OrderId(Guid value) => new OrderId(value);
}
