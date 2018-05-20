//////////////////////////////////////////////////
// WpfTableEditor
// Copyright (c) 2018 Kenjiro.Nagao
// This software is released under the MIT License.
// http://opensource.org/licenses/mit-license.php
//////////////////////////////////////////////////
using System.Collections.Generic;
using unvell.ReoGrid.WpfTableEditor.TableEditors.Core;
using WpfTableEditor.TableEditors.ViewModels;

namespace unvell.ReoGrid.WpfTableEditor.TableEditors.ViewModels.Core
{
    public interface IRowHeaderContextMenuInfoService
    {
        IEnumerable<ContextMenuInfo> GetRowHeaderContextMenuInfos(ITableEditorViewModel tableEditorViewModel);
    }
}
