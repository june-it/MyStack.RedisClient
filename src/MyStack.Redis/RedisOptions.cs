using System.Collections.Generic;

namespace Microsoft.Extensions.Redis
{
    /// <summary>
    /// 表示Redis配置项
    /// </summary>
    public class RedisOptions
    {
        /// <summary>
        /// 获取服务器节点列表
        /// </summary> 
        public List<RedisNode> Nodes { get; set; } = new List<RedisNode>();
        /// <summary>
        /// 获取默认数据库
        /// </summary>
        public int DefaultDatabase { get; set; }
        /// <summary>
        /// 获取密码
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 获取缓存键前缀
        /// </summary>
        public string KeyPrefix { get; set; }
        /// <summary>
        /// 获取超时时间
        /// </summary>
        public int Timeout { get; set; }
    }

}
