using System;

namespace Microsoft.Extensions.Redis.Converters
{
    public class ErrorValueConverter : ValueConverterBase
    {
        public override string Prefix => "-";
        public override object Convert(string input)
        {
            if (string.IsNullOrEmpty(input)) throw new ArgumentNullException(nameof(input), "The value to be converted cannot be empty"); 
            return MatchValue("(?<=-ERR\\W)(.*?)(?=\\\r\\\n)", input);
        }
    }
}
