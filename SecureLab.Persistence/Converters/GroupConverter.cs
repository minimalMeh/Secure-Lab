using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Text;

namespace SecureLab.Persistence.Converters
{
    public class Converter
    {
        protected internal static ValueConverter GroupConverter =
            new ValueConverter<string[], string> (v => string.Join(";", v), v => v.Split(";", StringSplitOptions.RemoveEmptyEntries));
    }
}
