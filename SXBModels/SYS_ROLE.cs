using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SXBModels
{
    /// <summary>
    /// 角色
    /// </summary>
    public partial class SYS_ROLE
    {
        #region 属性
        public string ROW_ID { get; set; }

        /// <summary>
        /// 角色编码
        /// </summary>
        public string ROLECODE { get; set; }

        /// <summary>
        /// 角色名称
        /// </summary>
        public string ROLENAME { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public Nullable<System.DateTime> CREATEDATE { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        public string CREATEUSER { get; set; }
        /// <summary>
        /// 最后更新时间
        /// </summary>
        public Nullable<System.DateTime> LASTDATE { get; set; }
        /// <summary>
        /// 最后更新人
        /// </summary>
        public string LASTUSER { get; set; }
        /// <summary>
        /// 1可用0不可用-1删除
        /// </summary>
        public Nullable<int> ENABLEFLAG { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string REMARK { get; set; } 

        #endregion

        /// <summary>
        /// 用户列表
        /// </summary>
        public ICollection<SYS_USER> SysUsers { get; set; }
    }
}
