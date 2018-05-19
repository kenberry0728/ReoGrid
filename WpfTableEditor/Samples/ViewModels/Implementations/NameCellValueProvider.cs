﻿//////////////////////////////////////////////////
// WpfTableEditor
// Copyright (c) 2018 Kenjiro.Nagao
// This software is released under the MIT License.
// http://opensource.org/licenses/mit-license.php
//////////////////////////////////////////////////
using WpfTableEditor;

namespace unvell.ReoGrid.WpfTableEditor.Samples.ViewModels
{
    internal class NameCellValueProvider : CellValueProviderBase<TreeItemViewModel, string>
    {
        protected override object GetValue(TreeItemViewModel treeItemViewModel)
        {
            return treeItemViewModel.ItemViewModel.Name;
        }

        protected override void SetValue(TreeItemViewModel treeItemViewModel, string value)
        {
            treeItemViewModel.ItemViewModel.Name = value;
        }
    }
}
