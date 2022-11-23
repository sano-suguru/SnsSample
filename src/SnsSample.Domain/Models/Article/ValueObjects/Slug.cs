using System.Text.RegularExpressions;

namespace SnsSample.Domain.Models.Article.ValueObjects;

public readonly record struct Slug
{
    public string Value { get; }
    private static readonly int MaxLength = 26;

    public Slug(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentNullException(nameof(value), $"'{nameof(value)}' を null または空白にすることはできません。");
        }

        if (value.Length > MaxLength)
        {
            throw new ArgumentOutOfRangeException(nameof(value), $"'{nameof(value)}' を {MaxLength}を超える値にすることはできません。");
        }

        if (!Regex.IsMatch(value, @"^[0-9a-zA-Z]+$"))
        {
            throw new ArgumentException($"'{nameof(value)}' を 半角英数字以外の値にすることはできません。", nameof(value));
        }

        this.Value = value;
    }
}
