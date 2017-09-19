using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Routing;

namespace C21.Koo.RouteApp.SearchConditionParsingEngine
{
    public class SearchConditionRouteConstraint : IRouteConstraint
    {
        private Regex _regex;

        public SearchConditionRouteConstraint(string pattern)
        {
            _regex = new Regex(pattern);
        }

        public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
        {
            if (values.ContainsKey(parameterName))
            {
                var dictValue = values[parameterName].ToString();

                return _regex.IsMatch(dictValue);
            }
            return false;
        }
    }
}