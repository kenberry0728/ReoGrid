//////////////////////////////////////////////////
// WpfTableEditor
// Copyright (c) 2018 Kenjiro.Nagao
// This software is released under the MIT License.
// http://opensource.org/licenses/mit-license.php
//////////////////////////////////////////////////

using System.Collections.Generic;

namespace unvell.ReoGrid.WpfTableEditor.Samples.Models
{
    internal class TreeItem
    {
        public string Name { get; set; }

        public object Value { get; set; }

        public bool IsConstant { get; set; }

        public List<TreeItem> Children { get; set; }
    }
}
