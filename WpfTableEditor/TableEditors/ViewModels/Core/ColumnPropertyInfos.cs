//////////////////////////////////////////////////
// WpfTableEditor
// Copyright (c) 2018 Kenjiro.Nagao
// This software is released under the MIT License.
// http://opensource.org/licenses/mit-license.php
//////////////////////////////////////////////////

using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace unvell.ReoGrid.WpfTableEditor.TableEditors.ViewModels.Core
{
    public class ColumnPropertyInfos<T>
    {
        public ColumnPropertyInfos(params string[] propertyNames)
        {
            var type = typeof(T);
            this.PropertyInfos = propertyNames.Select(s => type.GetProperty(s)).ToList();
        }

        public List<PropertyInfo> PropertyInfos { get; }

        public int Count => this.PropertyInfos.Count;
    }
}
