using System;
using System.Collections.Generic;

namespace Microsoft.Extensions.Redis
{
    /// <summary>
    /// Represents a Redis command interface
    /// </summary>
    /// <typeparam name="TResult">The type of result in the command</typeparam>
    /// <typeparam name="TValueConverter">The converter type that  the result in the command</typeparam>
    public abstract class CommandBase<TResult, TValueConverter> : ICommand<TResult>
        where TValueConverter : IValueConverter
    {
        private static Dictionary<string, Type> _converters = new Dictionary<string, Type>();
        private readonly string _command;
        private readonly object[] _arguments;
        public CommandBase(string command, params object[] arguments)
        {
            _command = command ?? throw new ArgumentNullException(nameof(command), "Command name cannot be empty");
            _arguments = arguments;
            _converters = new Dictionary<string, Type>()
            {
            };
            ValueConverter = Activator.CreateInstance<TValueConverter>();
        }
        /// <summary>
        /// Get the specified result converter
        /// </summary>
        protected TValueConverter ValueConverter { get; }
        /// <summary>
        /// Get the text of the command
        /// </summary>
        public string CommandText => string.Format("{0} {1}\r\n", _command, string.Join(" ", _arguments));
        /// <summary>
        /// Convert response results
        /// </summary>
        /// <param name="responseText">Response Text</param>
        /// <returns></returns>
        public virtual TResult Parse(string responseText)
        {
            var value = ValueConverter.Convert(responseText);
            if (value == null)
                return default;
            return ChangeType(value);
        }
        /// <summary>
        /// Perform type conversion on processed values
        /// </summary>
        /// <param name="value">Processed value</param>
        /// <returns></returns>
        protected virtual TResult ChangeType(object value)
        {
            var valueType = value.GetType();
            if (valueType.IsAssignableFrom(typeof(IConvertible)))
            {
                return (TResult)Convert.ChangeType(value, valueType);
            }
            return (TResult)value;
        }
        /// <summary>
        /// Gets the version number of an Command
        /// </summary>
        public virtual Version Version => new Version(1, 0, 0);
    }

}
