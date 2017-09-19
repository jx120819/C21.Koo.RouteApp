using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace C21.Koo.RouteApp.SearchConditionParsingEngine
{
    /// <summary>
    /// 选项卡项目
    /// </summary>
    [Flags]
    public enum TabItem
    {
        /// <summary>
        /// 默认
        /// </summary>
        Default = 0,

        /// <summary>
        /// 最新房源
        /// </summary>
        LatestHouseResource = 1,

        /// <summary>
        /// 最新发布
        /// </summary>
        LatestRelease = 2,

        /// <summary>
        /// 房屋总价
        /// </summary>
        HouseTotalPrice = 4,

        /// <summary>
        /// 房屋单价
        /// </summary>
        HousingUnitPrice = 8,

        /// <summary>
        /// 房源面积
        /// </summary>
        HousingResourceArea = 16,

        /// <summary>
        /// 房源租金
        /// </summary>
        HousingResourceRentPrice = 32,

        /// <summary>
        /// 热门房源
        /// </summary>
        HotHousingResource = 64,

        /// <summary>
        /// 临近地铁
        /// </summary>
        NearTheSubway = 108
    }
}