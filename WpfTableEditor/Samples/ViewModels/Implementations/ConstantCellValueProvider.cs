//////////////////////////////////////////////////
// WpfTableEditor
// Copyright (c) 2018 Kenjiro.Nagao
// This software is released under the MIT License.
// http://opensource.org/licenses/mit-license.php
//////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfTableEditor;
using WpfTableEditor.TableEditors.ViewModels;

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
