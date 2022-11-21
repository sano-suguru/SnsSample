namespace SnsSample.Domain.Models.Account.ValueObjects;

public readonly record struct Introduction
{
    public string Value { get; }
    private static readonly int maxLength = 160;

    public Introduction(string value)
    {
        if (value.Length > maxLength)
        {
            throw new ArgumentOutOfRangeException(nameof(value), $"'{nameof(value)}' を {maxLength} を超える値にすることはできません。");
        }

        Value = value;
    }
}
