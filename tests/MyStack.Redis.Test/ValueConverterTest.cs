using Microsoft.Extensions.Redis.Converters;

namespace MyStack.Redis.Test
{
    public class ValueConverterTest : TestBase
    {
        [Test]
        public void Integer()
        {
            IntegerValueConverter converter = new IntegerValueConverter();
            var value = converter.Convert(":1000\r\n");
            Assert.That(value, Is.EqualTo("1000"));
        }
        [Test]
        public void SimpleString()
        {
            SimpleStringConverter converter = new SimpleStringConverter();
            var value = converter.Convert("+OK\r\n");
            Assert.That(value, Is.EqualTo("OK"));
        }
        [Test]
        public void Error()
        {
            ErrorValueConverter converter = new ErrorValueConverter();
            var value = (RedisCommandError)converter.Convert("-ERR unknown command 'helloworld'\r\n-WRONGTYPE Operation against a key holding the wrong kind of value\r\n");
            Assert.That(value.Error, Is.EqualTo("unknown command 'helloworld'"));
            Assert.That(value.ErrorType, Is.EqualTo("Operation against a key holding the wrong kind of value"));
        }
        [Test]
        public void BulkString()
        {
            BulkStringValueConverter converter = new BulkStringValueConverter();
            // 字符串
            var value = converter.Convert("$5\r\nhello\r\n");
            Assert.That(value, Is.EqualTo("hello"));
            // 空字符串
            value = converter.Convert("$0\r\n\r\n");
            Assert.That(value, Is.EqualTo(""));
            // null
            value = converter.Convert("$-1\r\n");
            Assert.IsNull(value);
        }

        [Test]
        public void Array()
        {
            ArrayValueConverter converter = new ArrayValueConverter();
            // 空数组
            var value = (List<object>)converter.Convert("*0\r\n");
            Assert.That(value.Count, Is.EqualTo(0));
            // 字符串数组
            value = (List<object>)converter.Convert("*2\r\n$3\r\nfoo\r\n$3\r\nbar\r\n");
            Assert.That(value.Count, Is.EqualTo(2));
            Assert.That(value[0], Is.EqualTo("foo"));
            Assert.That(value[1], Is.EqualTo("bar"));
            // 混合类型数组
            value = (List<object>)converter.Convert("*5\r\n:1\r\n:2\r\n:3\r\n:4\r\n$6\r\nfoobar\r\n");
            Assert.That(value.Count, Is.EqualTo(5));
            Assert.That(value[0], Is.EqualTo("1"));
            Assert.That(value[4], Is.EqualTo("foobar"));
            // 二维数组 
            value = (List<object>)converter.Convert("*2\r\n*3\r\n:1\r\n:2\r\n:3\r\n*2\r\n+Hello\r\n-World\r\n");
            Assert.That(value.Count, Is.EqualTo(2));
            Assert.That(((List<object>)value[0]).Count, Is.EqualTo(3));
            Assert.That(((List<object>)value[1])[0], Is.EqualTo("Hello"));

        }
    }
}
