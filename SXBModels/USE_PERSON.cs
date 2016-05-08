using System;

namespace SXBModels
{

    /// <summary>
    /// 人员表
    /// </summary>
    public partial class USE_PERSON
    {
        public string ROW_ID { get; set; }

        /// <summary>
        /// 人名
        /// </summary>
        public string PERSONNAME { get; set; }

        /// <summary>
        /// 编号
        /// </summary>
        public string PSERSONCODE { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public string SEX { get; set; }

        /// <summary>
        /// 生日
        /// </summary>
        public Nullable<DateTime> BIRTHDAY { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        public string CITYS { get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        public string PROVINCE { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public string ADDRESS { get; set; }

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
    }
}
