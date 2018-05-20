//////////////////////////////////////////////////
// WpfTableEditor
// Copyright (c) 2018 Kenjiro.Nagao
// This software is released under the MIT License.
// http://opensource.org/licenses/mit-license.php
//////////////////////////////////////////////////

using System.Collections.ObjectModel;
using unvell.ReoGrid.WpfTableEditor.TableEditors.ViewModels.Core;

namespace unvell.ReoGrid.WpfTableEditor.TableEditors.ViewModels
{
    public interface ITreeItemViewModel
    {
        ITreeItemViewModel Parent { get; }

        ObservableCollection<ITreeItemViewModel> Children { get; }

        IColumnProperties ColomnProperties { get;}
    }
}
