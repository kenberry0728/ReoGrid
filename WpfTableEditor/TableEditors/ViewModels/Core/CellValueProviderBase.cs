//////////////////////////////////////////////////
// WpfTableEditor
// Copyright (c) 2018 Kenjiro.Nagao
// This software is released under the MIT License.
// http://opensource.org/licenses/mit-license.php
//////////////////////////////////////////////////
using WpfTableEditor.TableEditors.ViewModels;

namespace unvell.ReoGrid.WpfTableEditor.Samples.ViewModels
{
    public abstract class CellValueProviderBase<T, U> : ICellValueProvider
        where T : class,ITreeItemViewModel
    {
        public object GetValue(ITreeItemViewModel treeItemViewModel)
        {
            return this.GetValue(treeItemViewModel as T);
        }
        
        public void SetValue(ITreeItemViewModel treeItemViewModel, object value)
        {
            this.SetValue(treeItemViewModel as T, (U)value);
        }

        protected abstract object GetValue(T treeItemViewModel);

        protected abstract void SetValue(T treeItemViewModel, U value);
    }
}
