//////////////////////////////////////////////////
// WpfTableEditor
// Copyright (c) 2018 Kenjiro.Nagao
// This software is released under the MIT License.
// http://opensource.org/licenses/mit-license.php
//////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unvell.ReoGrid.WpfTableEditor.TableEditors.Core;
using unvell.ReoGrid.WpfTableEditor.TableEditors.ViewModels.Core;
using WpfTableEditor.TableEditors.ViewModels;

namespace WpfTableEditor
{
    public class TableEditorViewModel : ITableEditorViewModel
    {
        private readonly IRowHeaderContextMenuInfoService rowHeaderContextMenuInfoService;

        public TableEditorViewModel(
            IEnumerable<ITreeItemViewModel> rootItems,
            IReadOnlyList<IColumnViewModel> columnHeaders,
            IRowHeaderContextMenuInfoService rowHeaderContextMenuInfoService = null)
        {
            this.RootItems = new ObservableCollection<ITreeItemViewModel>(rootItems);
            this.ColumnHeaders = (columnHeaders);
            this.rowHeaderContextMenuInfoService = rowHeaderContextMenuInfoService;
        }

        public ObservableCollection<ITreeItemViewModel> RootItems { get; }

        public IReadOnlyList<IColumnViewModel> ColumnHeaders { get; }

        public IEnumerable<ContextMenuInfo> GetRowHeaderContextMenuInfos()
        {
            return this.rowHeaderContextMenuInfoService == null
                   ? Enumerable.Empty<ContextMenuInfo>()
                   : this.rowHeaderContextMenuInfoService.GetRowHeaderContextMenuInfos();
        }
    }
}
