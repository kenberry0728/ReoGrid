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

namespace WpfTableEditor.TableEditors.ViewModels
{
    public interface ITableEditorViewModel
    {
        ObservableCollection<ITreeItemViewModel> RootItems { get; }

        IReadOnlyList<IColumnViewModel> ColumnHeaders { get; }
    }
}
