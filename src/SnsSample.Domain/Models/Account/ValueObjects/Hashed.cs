using System.Text.RegularExpressions;

namespace SnsSample.Domain.Models.Account.ValueObjects;

public readonly record struct Hashed
{
    public string Value { get; }
    private static readonly int maxLength = 64;

    public Hashed(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentNullException(nameof(value), $"'{nameof(value)}' を null または空白にすることはできません。");
        }

        if (value.Length > maxLength)
        {
            throw new ArgumentOutOfRangeException(nameof(value), $"'{nameof(value)}' を {maxLength} を超える値にすることはできません。");
        }

        if (!Regex.IsMatch(value, @"^[0-9a-zA-Z]+$"))
        {
            throw new ArgumentException($"'{nameof(value)}' を 半角英数字以外の値にすることはできません。", nameof(value));
        }

        Value = value;
    }
}
