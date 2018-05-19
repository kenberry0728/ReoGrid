//////////////////////////////////////////////////
// WpfTableEditor
// Copyright (c) 2018 Kenjiro.Nagao
// This software is released under the MIT License.
// http://opensource.org/licenses/mit-license.php
//////////////////////////////////////////////////
using WpfTableEditor.TableEditors.ViewModels;

namespace unvell.ReoGrid.WpfTableEditor.Samples.ViewModels
{
    public interface ICellValueProvider
    {
        object GetValue(ITreeItemViewModel treeItemViewModel);

        void SetValue(ITreeItemViewModel treeItemViewModel, object value);
    }

    public interface ICellValueProvider<T, U> where T : ITreeItemViewModel
    {
        object GetValue(T treeItemViewModel);

        void SetValue(T treeItemViewModel, U value);
    }
}
