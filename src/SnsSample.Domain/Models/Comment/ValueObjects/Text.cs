namespace SnsSample.Domain.Models.Comment.ValueObjects;

public readonly record struct Text
{
    public string Value { get; }
    private static readonly int maxLength = 140;

    public Text(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            throw new ArgumentNullException(nameof(value), $"'{nameof(value)}' を NULL または空にすることはできません。");
        }

        if (value.Length > maxLength)
        {
            throw new ArgumentOutOfRangeException(nameof(value), $"'{nameof(value)}' を {maxLength} を超える値にすることはできません。");
        }

        Value = value;
    }
}
