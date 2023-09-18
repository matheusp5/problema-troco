namespace TrocoProblem;

public class Money
{
    public Money(decimal value)
    {
        Value = value;
    }

    public decimal Value { get; set; }
    public int UsedTimes { get; set; }
}