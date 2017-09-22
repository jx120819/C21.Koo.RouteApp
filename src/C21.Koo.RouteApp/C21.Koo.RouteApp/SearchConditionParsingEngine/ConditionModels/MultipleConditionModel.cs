using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace C21.Koo.RouteApp.SearchConditionParsingEngine
{
    public class MultipleConditionModel : List<string>
    {
        /// <summary>
        /// 添加选项
        /// </summary>
        /// <param name="tagId"></param>
        public new void Add(string tagId)
        {
            if (!base.Contains(tagId))
            {
                base.Add(tagId);
            }
        }
    }
}