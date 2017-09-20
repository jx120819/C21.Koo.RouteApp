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

            /*
                zufang/{district}/{condition}rs{keyword}
                zufang/{district}/rs{keyword}
                zufang/{district}/{condition}
                zufang/{district}/
                ershoufang/{district}-{tradingarea}/{condition}rs{keyword}
                ershoufang/{district}-{tradingarea}/rs{keyword}
                ershoufang/{district}-{tradingarea}/{condition}
                ershoufang/{district}-{tradingarea}/
                ershoufang/{district}/{condition}rs{keyword}
                ershoufang/{district}/rs{keyword}
                ershoufang/{district}/{condition}
                ershoufang/{district}/
                ditiefang/{subway}-{station}/{condition}rs{keyword}
                ditiefang/{subway}-{station}/rs{keyword}
                ditiefang/{subway}-{station}/{condition}
                ditiefang/{subway}-{station}/
                ditiefang/{subway}/{condition}rs{keyword}
                ditiefang/{subway}/rs{keyword}
                ditiefang/{subway}/{condition}
                ditiefang/{subway}/
                ditiezufang/{subway}-{station}/{condition}rs{keyword}
                ditiezufang/{subway}-{station}/rs{keyword}
                ditiezufang/{subway}-{station}/{condition}
                ditiezufang/{subway}-{station}/
                ditiezufang/{subway}/{condition}rs{keyword}
                ditiezufang/{subway}/rs{keyword}
                ditiezufang/{subway}/{condition}
                ditiezufang/{subway}/
             */


            routes.MapRoute(
                name: "zufang_by_district_tradingarea_condition_keyword",
                url: "zufang/{district}-{tradingarea}/{condition}rs{keyword}",
                defaults: new { controller = "House", action = "Index", searchMode = SearchMode.ByDistrictAndTradingArea }
            );

            routes.MapRoute(
                name: "zufang_by_district_tradingarea_onlyKeyword",
                url: "zufang/{district}-{tradingarea}/rs{keyword}",
                defaults: new { controller = "House", action = "Index", searchMode = SearchMode.ByDistrictAndTradingArea }
            );

            routes.MapRoute(
                name: "zufang_by_district_tradingarea_condition",
                url: "zufang/{district}-{tradingarea}/{condition}",
                defaults: new { controller = "House", action = "Index", searchMode = SearchMode.ByDistrictAndTradingArea }
            );

            routes.MapRoute(
                name: "zufang_by_district_tradingarea",
                url: "zufang/{district}-{tradingarea}/",
                defaults: new { controller = "House", action = "Index", searchMode = SearchMode.ByDistrictAndTradingArea }
            );

            routes.MapRoute(
                name: "zufang_by_district_condition_keyword",
                url: "zufang/{district}/{condition}rs{keyword}",
                defaults: new { controller = "House", action = "Index", searchMode = SearchMode.OnlyDistrict }
            );

            routes.MapRoute(
                name: "zufang_by_district_onlyKeyword",
                url: "zufang/{district}/rs{keyword}",
                defaults: new { controller = "House", action = "Index", searchMode = SearchMode.OnlyDistrict }
            );

            routes.MapRoute(
                name: "zufang_by_district_condition",
                url: "zufang/{district}/{condition}",
                defaults: new { controller = "House", action = "Index", searchMode = SearchMode.OnlyDistrict }
            );

            routes.MapRoute(
                name: "zufang_by_condition_keyword",
                url: "zufang/{condition}rs{keyword}",
                defaults: new { controller = "House", action = "Index", searchMode = SearchMode.Default }
            );

            routes.MapRoute(
                name: "zufang_by_onlyKeyword",
                url: "zufang/rs{keyword}",
                defaults: new { controller = "House", action = "Index", searchMode = SearchMode.Default }
            );

            routes.MapRoute(
                name: "zufang_by_onlyCondition",
                url: "zufang/{condition}",
                defaults: new { controller = "House", action = "Index", searchMode = SearchMode.Default },
                constraints: new { condition = new SearchConditionRouteConstraint("^([Pp][AaBb])|[a-zA-Z]+[0-9]+") }
            );

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
