//////////////////////////////////////////////////
// WpfTableEditor
// Copyright (c) 2018 Kenjiro.Nagao
// This software is released under the MIT License.
// http://opensource.org/licenses/mit-license.php
//////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unvell.ReoGrid.WpfTableEditor.Samples.ViewModels.Commands;
using unvell.ReoGrid.WpfTableEditor.TableEditors.Core;
using unvell.ReoGrid.WpfTableEditor.TableEditors.ViewModels.Core;

namespace unvell.ReoGrid.WpfTableEditor.Samples.ViewModels.Menus
{
    internal class RowHeaderContextMenuInfoService : IRowHeaderContextMenuInfoService
    {
        public IEnumerable<ContextMenuInfo> GetRowHeaderContextMenuInfos()
        {
            yield return new ContextMenuInfo("Insert", new InsertCommand());
        }
    }
}
