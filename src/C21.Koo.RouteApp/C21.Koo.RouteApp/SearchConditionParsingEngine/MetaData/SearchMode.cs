using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace C21.Koo.RouteApp.SearchConditionParsingEngine
{
    /// <summary>
    /// 搜索模式
    /// </summary>
    public enum SearchMode
    {
        /// <summary>
        /// 默认
        /// </summary>
        Default = 0,

        /// <summary>
        /// 仅地区
        /// </summary>
        OnlyDistrict = 1,

        /// <summary>
        /// 仅地铁
        /// </summary>
        OnlySubway = 2,

        /// <summary>
        /// 仅小区
        /// </summary>
        OnlyCommunity = 3,

        /// <summary>
        /// 地区和商圈
        /// </summary>
        ByDistrictAndTradingArea = 4,

        /// <summary>
        /// 地铁和地铁站
        /// </summary>
        BySubwayAndStation = 5,
    }
}