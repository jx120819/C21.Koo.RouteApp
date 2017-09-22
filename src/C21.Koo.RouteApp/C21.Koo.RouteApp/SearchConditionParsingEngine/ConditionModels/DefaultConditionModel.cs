using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace C21.Koo.RouteApp.SearchConditionParsingEngine
{
    /// <summary>
    /// 默认的搜索条件模型
    /// </summary>
    public class DefaultConditionModel
    {
#if DEBUG
        public string AAAroute { get; set; }
#endif

        /// <summary>
        /// 获取或设置 搜索模式
        /// </summary>
        public SearchMode SearchMode { get; internal set; }

        /// <summary>
        /// 获取或设置 地区
        /// </summary>
        public string District { get; set; }

        /// <summary>
        /// 获取或设置 商圈
        /// </summary>
        public string TradingArea { get; set; }

        /// <summary>
        /// 获取或设置 地铁
        /// </summary>
        public int? Subway { get; set; }

        /// <summary>
        /// 获取或设置 地铁站
        /// </summary>
        public int? SubwayStation { get; set; }

        /// <summary>
        /// 获取或设置 搜索关键词
        /// </summary>
        public string Keyword { get; set; }

        /// <summary>
        /// 获取或设置 价格条件
        /// </summary>
        public MultipleScopeGroupConditionModel PriceCondition { get; set; } = new MultipleScopeGroupConditionModel();

        /// <summary>
        /// 获取或设置 面积条件
        /// </summary>
        public MultipleScopeGroupConditionModel AreaCondition { get; set; } = new MultipleScopeGroupConditionModel();

        /// <summary>
        /// 获取或设置 
        /// </summary>
        public MultipleConditionModel FloorAgeCondition { get; set; } = new MultipleConditionModel();

        /// <summary>
        /// 获取或设置 
        /// </summary>
        public MultipleConditionModel HouseTypeCondition { get; set; } = new MultipleConditionModel();

        /// <summary>
        /// 获取或设置 
        /// </summary>
        public MultipleConditionModel FeatureTagCondition { get; set; } = new MultipleConditionModel();

        /// <summary>
        /// 获取或设置 朝向
        /// </summary>
        public string Orientation { get; set; }

        /// <summary>
        /// 获取或设置 装修
        /// </summary>
        public string Decoration { get; set; }

        /// <summary>
        /// 获取或设置 付款方式
        /// </summary>
        public string PaymentType { get; set; }

        /// <summary>
        /// 获取或设置 楼层
        /// </summary>
        public string Floor { get; set; }

        /// <summary>
        /// 获取或设置 楼龄
        /// </summary>
        public string FloorAge { get; set; }

        /// <summary>
        /// 获取或设置 房屋类型
        /// </summary>
        public string RoomType { get; set; }

        /// <summary>
        /// 获取或设置 当前页码
        /// </summary>
        public int PageIndex { get; set; } = 1;

        /// <summary>
        /// 获取或设置 选项卡选项
        /// </summary>
        public TabItem TabIndex { get; set; }

        /// <summary>
        /// 获取或设置 选项卡排序方向
        /// </summary>
        public SortDirection TabSortDirection { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}