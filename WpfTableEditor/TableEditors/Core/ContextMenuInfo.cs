//////////////////////////////////////////////////
// WpfTableEditor
// Copyright (c) 2018 Kenjiro.Nagao
// This software is released under the MIT License.
// http://opensource.org/licenses/mit-license.php
//////////////////////////////////////////////////

using System.Collections.Generic;
using System.Windows.Input;

namespace unvell.ReoGrid.WpfTableEditor.TableEditors.Core
{
    public class ContextMenuInfo
    {
        public string Header { get; set; }

        public ICommand Command { get; set; }

        public IEnumerable<ContextMenuInfo> Children { get; set; }
    }
}
