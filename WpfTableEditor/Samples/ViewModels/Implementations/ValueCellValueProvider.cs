//////////////////////////////////////////////////
// WpfTableEditor
// Copyright (c) 2018 Kenjiro.Nagao
// This software is released under the MIT License.
// http://opensource.org/licenses/mit-license.php
//////////////////////////////////////////////////
using WpfTableEditor;

namespace unvell.ReoGrid.WpfTableEditor.Samples.ViewModels
{
    internal class ValueCellValueProvider : CellValueProviderBase<TreeItemViewModel, object>
    {
        protected override object GetValue(TreeItemViewModel treeItemViewModel)
        {
            return treeItemViewModel.ItemViewModel.Value;
        }

        protected override void SetValue(TreeItemViewModel treeItemViewModel, object value)
        {
            treeItemViewModel.ItemViewModel.Value = value;
        }
    }
}
