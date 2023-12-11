using System;
using System.Collections.Generic;

namespace Microsoft.Extensions.Redis.Converters
{
    /// <summary>
    /// Represents a multi line character converter
    /// </summary>
    public class BulkStringValueConverter : ValueConverterBase
    { 
        public override string Prefix => "$"; 
        public override object Convert(string input)
        {
            if (string.IsNullOrEmpty(input)) throw new ArgumentNullException(nameof(input), "The value to be converted cannot be empty");

            var lengthValue = MatchValue("(?<=\\$)(-)?(\\d+)(?=\\\r\\\n)", input);
            if (!int.TryParse(lengthValue, out var length))
                return null;
            if (length == -1)
                return null;
            else if (length == 0)
                return string.Empty;
            else
            {
                List<string> strings = new List<string>();
                foreach (var item in MatchValues("(?<=\\\r\\\n)(.*?)(?=\\\r\\\n)", input))
                {
                    strings.Add(item);
                }
                return string.Join("\r\n", strings);
            }
        }
    }
}
