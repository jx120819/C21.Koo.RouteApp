using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace C21.Koo.RouteApp.SearchConditionParsingEngine
{
    public class SearchConditionModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            if (bindingContext.ModelType != typeof(DefaultConditionModel))
            {
                return null;
            }

            RouteValueDictionary values = controllerContext.RouteData.Values;

            HttpRequestBase request = controllerContext.HttpContext.Request;

            bool settedPageIndex = false;

            if (!values.ContainsKey("searchMode"))
            {
                throw new Exception("'searchMode' is not defined in routing.");
            }

            SearchMode searchMode = (SearchMode)values["searchMode"];

            DefaultConditionModel conditionModel = new DefaultConditionModel();

#if DEBUG
            conditionModel.AAAroute = ((Route)controllerContext.RouteData.Route).Url;
#endif

            switch (searchMode)
            {
                case SearchMode.OnlyDistrict:
                    {
                        var districtValue = values["district"];
                        if (districtValue != null)
                        {
                            conditionModel.District = districtValue.ToString();
                        }
                        break;
                    }
                case SearchMode.OnlySubway:
                    {
                        var subwayValue = values["subway"];
                        int subway;
                        if (!int.TryParse(subwayValue.ToString(), out subway))
                        {
                            throw new Exception("'subway' value format error.");
                        }
                        conditionModel.Subway = subway;
                        break;
                    }
                case SearchMode.ByDistrictAndTradingArea:
                    {
                        var districtValue = values["district"];
                        if (districtValue != null)
                        {
                            conditionModel.District = districtValue.ToString();
                        }

                        var tradingAreaValue = values["tradingarea"];
                        if (districtValue != null)
                        {
                            conditionModel.TradingArea = tradingAreaValue.ToString();
                        }
                        break;
                    }
                case SearchMode.BySubwayAndStation:
                    {
                        var subwayValue = values["subway"];
                        int subway;
                        if (!int.TryParse(subwayValue.ToString(), out subway))
                        {
                            throw new Exception("'subway' value format error.");
                        }

                        var stationValue = values["station"];
                        int station;
                        if (!int.TryParse(stationValue.ToString(), out station))
                        {
                            throw new Exception("'station' value format error.");
                        }

                        conditionModel.Subway = subway;
                        conditionModel.SubwayStation = station;
                        break;
                    }
            }

            if (values.ContainsKey("condition"))
            {
                string input = values["condition"].ToString();
                foreach (Match matchItem in Regex.Matches(input, "[Pp][Bb]|([a-z]+\\d+)"))
                {
                    #region //多选 + 自定义
                    {
                        //价格多选 + 自定义
                        Match matched = Regex.Match(matchItem.Value, "^(s|bs|es)\\d+$");
                        if (matched.Success)
                        {
                            int prefixLen = 2;
                            int minValue;
                            if (matchItem.Value.StartsWith("bs") && int.TryParse(matched.Value.Substring(prefixLen), out minValue))
                            {
                                conditionModel.PriceCondition.MinValue = minValue;
                                continue;
                            }

                            int maxValue;
                            if (matchItem.Value.StartsWith("es") && int.TryParse(matched.Value.Substring(prefixLen), out maxValue))
                            {
                                conditionModel.PriceCondition.MaxValue = maxValue;
                                continue;
                            }

                            conditionModel.PriceCondition.Add(matched.Value);
                            continue;
                        }
                    }

                    {
                        //面积多选 + 自定义
                        Match matched = Regex.Match(matchItem.Value, "^(a|ba|ea)\\d+$");
                        if (matched.Success)
                        {
                            int prefixLen = 2;
                            int minValue;
                            if (matchItem.Value.StartsWith("ba") && int.TryParse(matched.Value.Substring(prefixLen), out minValue))
                            {
                                conditionModel.AreaCondition.MinValue = minValue;
                                continue;
                            }

                            int maxValue;
                            if (matchItem.Value.StartsWith("ea") && int.TryParse(matched.Value.Substring(prefixLen), out maxValue))
                            {
                                conditionModel.AreaCondition.MaxValue = maxValue;
                                continue;
                            }

                            conditionModel.AreaCondition.Add(matched.Value);
                            continue;
                        }
                    }
                    #endregion

                    #region //多选
                    {
                        //房龄
                        Match matched = Regex.Match(matchItem.Value, "^(y)\\d+$");
                        if (matched.Success)
                        {
                            conditionModel.FloorAgeCondition.Add(matched.Value);
                            continue;
                        }
                    }

                    {
                        //房型
                        Match matched = Regex.Match(matchItem.Value, "^(f)\\d+$");
                        if (matched.Success)
                        {
                            conditionModel.HouseTypeCondition.Add(matched.Value);
                            continue;
                        }
                    }

                    {
                        //特色标签
                        Match matched = Regex.Match(matchItem.Value, "^(e|g|h|k|l|v)\\d+$");
                        if (matched.Success)
                        {
                            conditionModel.FeatureTagCondition.Add(matched.Value);
                            continue;
                        }
                    }
                    #endregion

                    #region //单选
                    {
                        //
                        Match matched = Regex.Match(matchItem.Value, "^(o)\\d+$");
                        if (matched.Success)
                        {
                            conditionModel.Orientation = matched.Value;
                            continue;
                        }
                    }

                    {
                        //
                        Match matched = Regex.Match(matchItem.Value, "^(d)\\d+$");
                        if (matched.Success)
                        {
                            conditionModel.Decoration = matched.Value;
                            continue;
                        }
                    }

                    {
                        //
                        Match matched = Regex.Match(matchItem.Value, "^(z)\\d+$");
                        if (matched.Success)
                        {
                            conditionModel.PaymentType = matched.Value;
                            continue;
                        }
                    }

                    {
                        //
                        Match matched = Regex.Match(matchItem.Value, "^(c)\\d+$");
                        if (matched.Success)
                        {
                            conditionModel.Floor = matched.Value;
                            continue;
                        }
                    }

                    {
                        //
                        Match matched = Regex.Match(matchItem.Value, "^(y)\\d+$");
                        if (matched.Success)
                        {
                            conditionModel.FloorAge = matched.Value;
                            continue;
                        }
                    }

                    {
                        //
                        Match matched = Regex.Match(matchItem.Value, "^(t)\\d+$");
                        if (matched.Success)
                        {
                            conditionModel.RoomType = matched.Value;
                            continue;
                        }
                    }
                    #endregion

                    {
                        //选项卡和排序
                        Match matched = Regex.Match(matchItem.Value, "^[Pp][\\d+Bb]$");
                        if (matched.Success)
                        {
                            int prefixLen = 1;

                            var tabValue = matched.Value.Substring(prefixLen);

                            //解析选中的选项卡
                            switch (tabValue)
                            {
                                case "1":
                                    conditionModel.TabIndex = TabItem.LatestHouseResource | TabItem.LatestRelease;
                                    break;

                                case "2":
                                case "3":
                                    conditionModel.TabIndex = TabItem.HouseTotalPrice;
                                    break;

                                case "4":
                                case "5":
                                    conditionModel.TabIndex = TabItem.HousingUnitPrice;
                                    break;

                                case "6":
                                case "7":
                                    conditionModel.TabIndex = TabItem.HousingResourceArea;
                                    break;

                                case "8":
                                case "9":
                                    conditionModel.TabIndex = TabItem.HousingResourceRentPrice;
                                    break;

                                case "A":
                                    conditionModel.TabIndex = TabItem.HotHousingResource;
                                    break;

                                case "B":
                                    conditionModel.TabIndex = TabItem.NearTheSubway;
                                    break;

                                default:
                                    break;
                            }

                            //解析排序
                            switch (tabValue)
                            {
                                case "2":
                                case "4":
                                case "6":
                                case "8":
                                    conditionModel.TabSortDirection = SortDirection.Asc;
                                    break;

                                default:
                                    conditionModel.TabSortDirection = SortDirection.Desc;
                                    break;
                            }
                        }
                    }

                    {
                        //分页
                        if (!settedPageIndex)
                        {
                            Match matched = Regex.Match(matchItem.Value, "^(pg|PG)\\d+$");
                            if (matched.Success)
                            {
                                int prefixLen = 2;
                                int pageIndex;
                                if (int.TryParse(matched.Value.Substring(prefixLen), out pageIndex))
                                {
                                    conditionModel.PageIndex = pageIndex;
                                }
                                continue;
                            }
                        }
                    }

                    {
                        //搜索关键词
                        if (values.ContainsKey("keyword"))
                        {
                            conditionModel.Keyword = values["keyword"].ToString();
                            continue;
                        }
                    }
                }
            }

            return conditionModel;
        }
    }
}