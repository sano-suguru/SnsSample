using System;
namespace SnsSample.Domain.Models.Account.ValueObjects;

public readonly record struct Location
{
    public string Value { get; }
    private static readonly int maxLength = 30;

    public Location(string value)
    {
        if (value.Length > maxLength)
        {
            throw new ArgumentOutOfRangeException(nameof(value), $"'{nameof(value)}' を {maxLength} を超える値にすることはできません。");
        }

        Value = value;
    }
}

