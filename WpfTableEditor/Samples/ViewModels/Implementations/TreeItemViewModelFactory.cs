//////////////////////////////////////////////////
// WpfTableEditor
// Copyright (c) 2018 Kenjiro.Nagao
// This software is released under the MIT License.
// http://opensource.org/licenses/mit-license.php
//////////////////////////////////////////////////
using unvell.ReoGrid.WpfTableEditor.TableEditors.ViewModels.Core;
using WpfTableEditor;
using WpfTableEditor.TableEditors.ViewModels;

namespace unvell.ReoGrid.WpfTableEditor.Samples.ViewModels.Implementations
{
    internal class TreeItemViewModelFactory : IItemViewModelFactory<TreeItem>
    {
        private readonly ColumnPropertyInfos<TreeItemViewModel> columnPropertyInfos;

        public TreeItemViewModelFactory(ColumnPropertyInfos<TreeItemViewModel> columnPropertyInfos)
        {
            this.columnPropertyInfos = columnPropertyInfos;
        }

        public ITreeItemViewModel Create(TreeItem model)
        {
            return new TreeItemViewModel(model, this.columnPropertyInfos);
        }
    }
}
