using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfTableEditor.TableEditors.ViewModels;

namespace WpfTableEditor.Samples.ViewModels
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
