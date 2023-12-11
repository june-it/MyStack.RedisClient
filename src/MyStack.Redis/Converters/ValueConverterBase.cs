using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Microsoft.Extensions.Redis.Converters
{
    public abstract class ValueConverterBase : IValueConverter
    {
        public abstract string Prefix { get; }
        public abstract object Convert(string input);
        protected virtual string MatchValue(string pattern, string input)
        {
            var match = new Regex(pattern).Match(input);
            if (match.Success)
                return match.Value;
            return default;
        }
        protected virtual IEnumerable<string> MatchValues(string pattern, string input)
        {
            var matches = new Regex(pattern).Matches(input);
            return matches.Select(x => x.Value);
        }
    }
}
