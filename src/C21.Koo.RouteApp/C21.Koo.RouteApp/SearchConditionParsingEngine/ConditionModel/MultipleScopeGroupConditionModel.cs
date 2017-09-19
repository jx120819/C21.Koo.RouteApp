using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace C21.Koo.RouteApp.SearchConditionParsingEngine
{
    public class MultipleScopeGroupConditionModel : ScopeConditionModel
    {
        private List<string> _container = new List<string>();

        /// <summary>
        /// 添加选项
        /// </summary>
        /// <param name="tagId"></param>
        public void Add(string tagId)
        {
            if (!_container.Contains(tagId))
            {
                _container.Add(tagId);
            }
        }

        /// <summary>
        /// 获取所有选项
        /// </summary>
        public List<string> Options
        {
            get
            {
                return _container;
            }
        }
    }
}