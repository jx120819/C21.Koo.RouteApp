using C21.Koo.RouteApp.SearchConditionParsingEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace C21.Koo.RouteApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //true
            routes.MapRoute(
                name: "zufang_by_district_tradingarea_condition_keyword",
                url: "zufang/{district}-{tradingarea}/{condition}rs{keyword}",
                defaults: new { controller = "House", action = "Index", searchMode = SearchMode.ByDistrictAndTradingArea }
            );

            //true
            routes.MapRoute(
                name: "zufang_by_district_tradingarea_onlyKeyword",
                url: "zufang/{district}-{tradingarea}/rs{keyword}",
                defaults: new { controller = "House", action = "Index", searchMode = SearchMode.ByDistrictAndTradingArea }
            );

            //true
            routes.MapRoute(
                name: "zufang_by_district_tradingarea_condition",
                url: "zufang/{district}-{tradingarea}/{condition}",
                defaults: new { controller = "House", action = "Index", searchMode = SearchMode.ByDistrictAndTradingArea }
            );

            //true
            routes.MapRoute(
                name: "zufang_by_district_tradingarea",
                url: "zufang/{district}-{tradingarea}/",
                defaults: new { controller = "House", action = "Index", searchMode = SearchMode.ByDistrictAndTradingArea }
            );

            //true
            routes.MapRoute(
                name: "zufang_by_district_condition_keyword",
                url: "zufang/{district}/{condition}rs{keyword}",
                defaults: new { controller = "House", action = "Index", searchMode = SearchMode.OnlyDistrict }
            );

            //true
            routes.MapRoute(
                name: "zufang_by_district_onlyKeyword",
                url: "zufang/{district}/rs{keyword}",
                defaults: new { controller = "House", action = "Index", searchMode = SearchMode.OnlyDistrict }
            );

            //true
            routes.MapRoute(
                name: "zufang_by_district_condition",
                url: "zufang/{district}/{condition}",
                defaults: new { controller = "House", action = "Index", searchMode = SearchMode.OnlyDistrict }
            );

            //true
            routes.MapRoute(
                name: "zufang_by_onlyKeyword",
                url: "zufang/rs{keyword}",
                defaults: new { controller = "House", action = "Index", searchMode = SearchMode.Default }
            );

            //true
            routes.MapRoute(
                name: "zufang_by_condition_keyword",
                url: "zufang/{condition}rs{keyword}",
                defaults: new { controller = "House", action = "Index", searchMode = SearchMode.Default }
            );

            //true???
            routes.MapRoute(
                name: "zufang_by_onlyCondition",
                url: "zufang/{condition}",
                defaults: new { controller = "House", action = "Index", searchMode = SearchMode.Default },
                //constraints: new { condition = "^([Pp][AaBb])|[a-zA-Z]+[0-9]+" }
                constraints: new { condition = new SearchConditionRouteConstraint("^([Pp][AaBb])|[a-zA-Z]+[0-9]+") }
            );

            //true
            routes.MapRoute(
                name: "zufang_by_district",
                url: "zufang/{district}/",
                defaults: new { controller = "House", action = "Index", searchMode = SearchMode.OnlyDistrict }
            );

            //
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
