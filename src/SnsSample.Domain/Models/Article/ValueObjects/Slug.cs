using System;
namespace SnsSample.Domain.Models.Article.ValueObjects;

public readonly record struct Slug
{
    public string Value { get; }
    private static readonly int MaxLength = 26;

    public Slug(string Value)
    {
        if (string.IsNullOrWhiteSpace(Value))
        {
            throw new ArgumentNullException(nameof(Value), $"'{nameof(Value)}' を null または空白にすることはできません。");
        }

        if (Value.Length > MaxLength)
        {
            throw new ArgumentOutOfRangeException(nameof(Value), $"'{nameof(Value)}' を {MaxLength}を超える値にすることはできません。");
        }

        this.Value = Value;
    }
}
