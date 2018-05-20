//////////////////////////////////////////////////
// WpfTableEditor
// Copyright (c) 2018 Kenjiro.Nagao
// This software is released under the MIT License.
// http://opensource.org/licenses/mit-license.php
//////////////////////////////////////////////////

using System.Collections.Generic;
using System.Collections.ObjectModel;
using unvell.ReoGrid.WpfTableEditor.TableEditors.Core;

namespace unvell.ReoGrid.WpfTableEditor.TableEditors.ViewModels
{
    public interface ITableEditorViewModel
    {
        ObservableCollection<ITreeItemViewModel> RootItems { get; }

        IReadOnlyList<IColumnViewModel> ColumnHeaders { get; }

        IEnumerable<ContextMenuInfo> GetRowHeaderContextMenuInfos();
    }

    public interface ITableEditorViewModel<T> : ITableEditorViewModel
    {
        IModelService<T> ModelService { get; }
    }
}
