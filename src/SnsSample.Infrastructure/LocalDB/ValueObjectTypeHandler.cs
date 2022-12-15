using System.Data;
using Dapper;
using SnsSample.Domain.Abstractions;

namespace SnsSample.Infrastructure.LocalDB;

public class ValueObjectTypeHandler<T> : SqlMapper.TypeHandler<ValueObject<T>> where T : notnull
{
    public override ValueObject<T> Parse(object value)
    {
        return new ValueObject<T>((T)value);
    }

    public override void SetValue(IDbDataParameter parameter, ValueObject<T> value)
    {
        parameter.DbType = value.Value switch
        {
            int => DbType.Int32,
            long => DbType.Int64,
            double => DbType.Double,
            char => DbType.String,
            DateTime => DbType.DateTime,
            string => DbType.String,
            bool => DbType.Boolean,
            _ => throw new ArgumentOutOfRangeException(nameof(value), $"DBの型にマッピングできません。型：{typeof(T)}")
        }; ;
        parameter.Value = value.Value;
    }
}
