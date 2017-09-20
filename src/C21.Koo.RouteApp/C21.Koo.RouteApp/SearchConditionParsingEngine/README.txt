

解析引擎定义
-----------------------------------------------------------------------------------------
	
	key             dataType            description			regexConstraint
	----------------------------------------------------------------------------------
	{district}      string              地区
	{tradingarea}   string              商圈
	{subway}        int                 地铁线              
	{station}       int                 地铁站
	{condition}     string              查询条件			^([Pp][AaBb])|[a-zA-Z]+[0-9]+
	{keyword}       string              搜索关键词
	


路由示例
-----------------------------------------------------------------------------------------
	e.g.
	routes.MapRoute(
	    name: "zufang_by_district_tradingarea_condition_keyword",
	    url: "zufang/{district}-{tradingarea}/{condition}rs{keyword}",
	    defaults: new { controller = "controllerName", action = "actionName", searchMode = SearchMode.ByDistrictAndTradingArea }
		//optional: ,constraints: new { condition = new SearchConditionRouteConstraint("^([Pp][AaBb])|[a-zA-Z]+[0-9]+") }
	);