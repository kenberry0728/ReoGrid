//////////////////////////////////////////////////
// WpfTableEditor
// Copyright (c) 2018 Kenjiro.Nagao
// This software is released under the MIT License.
// http://opensource.org/licenses/mit-license.php
//////////////////////////////////////////////////

using unvell.ReoGrid.WpfTableEditor.TableEditors.Core;

namespace unvell.ReoGrid.WpfTableEditor.TableEditors.ViewModels
{
    internal class ColumnHeaderViewModel : IColumnViewModel
    {
        public ColumnHeaderViewModel(string name, CellBodyType defaultCellBodyType = CellBodyType.Default)
        {
            this.Name = name;
            this.DefaultCellBodyType = defaultCellBodyType;
        }

        public string Name { get; }

        public CellBodyType DefaultCellBodyType { get; }
    }
}
