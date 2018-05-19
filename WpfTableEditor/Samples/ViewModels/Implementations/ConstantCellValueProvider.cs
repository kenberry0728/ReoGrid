//////////////////////////////////////////////////
// WpfTableEditor
// Copyright (c) 2018 Kenjiro.Nagao
// This software is released under the MIT License.
// http://opensource.org/licenses/mit-license.php
//////////////////////////////////////////////////
using WpfTableEditor;

namespace unvell.ReoGrid.WpfTableEditor.Samples.ViewModels
{
    internal class ConstantCellValueProvider : CellValueProviderBase<TreeItemViewModel, bool>
    {
        protected override object GetValue(TreeItemViewModel treeItemViewModel)
        {
            return treeItemViewModel.ItemViewModel.IsConstant;
        }

        protected override void SetValue(TreeItemViewModel treeItemViewModel, bool value)
        {
            treeItemViewModel.ItemViewModel.IsConstant = value;
        }
    }
}
