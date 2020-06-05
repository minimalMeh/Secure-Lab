using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;

namespace SecureLab.Persistence.Converters
{
    public class Converter
    {
        protected internal static ValueConverter StringParseConverter =
            new ValueConverter<string[], string>(v => string.Join(";", v), v => v.Split(";", StringSplitOptions.RemoveEmptyEntries));
    }
}
