using System;
namespace SnsSample.Domain.Models.Account.ValueObjects;

public readonly record struct Code
{
    public string Value { get; }
    private static readonly int maxLength = 15;

    public Code(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentNullException(nameof(value), $"'{nameof(value)}' を null または空白にすることはできません。");
        }

        if (value.Length > maxLength)
        {
            throw new ArgumentOutOfRangeException(nameof(value), $"'{nameof(value)}' を {maxLength} を超える値にすることはできません。");
        }

        Value = value;
    }
}
