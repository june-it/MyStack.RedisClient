using System.Collections.Generic;
using System.Linq;

namespace Microsoft.Extensions.Redis.Converters
{ 
    public class ArrayValueConverter : ValueConverterBase
    { 
        public override string Prefix => "*"; 
        public override object Convert(string input)
        {
            var lengthValue = MatchValue("(?<=\\^*)(-)?(\\d+)(?=\\\r\\\n)", input);
            if (!int.TryParse(lengthValue, out var length))
                return null;
            if (length == -1)
                return null;
            else if (length == 0)
                return new List<object>();
            else
            {
                string[] arguments = input.Substring(lengthValue.Length + 3).Split("\r\n");
                return Recursively(arguments)?.ToList();
            }
        }
        private bool IsMatchValue(string input, char value) => input.StartsWith(value);

        private IList<object> Recursively(string[] arguments)
        {
            var items = new List<object>();
            for (int i = 0; i < arguments.Length; i++)
            {
                // Integer/simple string/ error
                if (IsMatchValue(arguments[i], ':') || IsMatchValue(arguments[i], '+') || IsMatchValue(arguments[i], '-'))
                {
                    items.Add(arguments[i][1..]);
                }
                // multi string
                else if (IsMatchValue(arguments[i], '$'))
                {
                    i++;
                    items.Add(arguments[i]);
                }
                // array
                else if (IsMatchValue(arguments[i], '*'))
                {
                    var childLength = int.Parse(arguments[i][1..]);
                    var children = arguments.Skip(i + 1).Take(childLength).ToArray();
                    items.Add(Recursively(children));
                    i += childLength;
                }
            }
            return items;
        }
    }
}
