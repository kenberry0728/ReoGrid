﻿//////////////////////////////////////////////////
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
        public ContextMenuInfo(string header, ICommand command)
        {
            this.Header = header;
            this.Command = command;
        }

        public ContextMenuInfo(string header, ICommand command, IEnumerable<ContextMenuInfo> children)
        {
            this.Header = header;
            this.Command = command;
        }

        public string Header { get; }

        public ICommand Command { get; }

        public IEnumerable<ContextMenuInfo> Children { get; set; }
    }
}
