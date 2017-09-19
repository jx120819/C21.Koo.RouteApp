using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace C21.Koo.RouteApp.SearchConditionParsingEngine
{
    public class ScopeConditionModel
    {
        /// <summary>
        /// 获取或设置 最小值
        /// </summary>
        public int? MinValue { get; set; }

        /// <summary>
        /// 获取或设置 最大值
        /// </summary>
        public int? MaxValue { get; set; }

        /// <summary>
        /// 获取或设置 范围值是否有效
        /// </summary>
        public bool IsScopeValid
        {
            get
            {
                return (MinValue.HasValue && MaxValue.HasValue && MaxValue.Value > MinValue.Value);
            }
        }
    }
}