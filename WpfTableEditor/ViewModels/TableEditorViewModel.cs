using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfTableEditor.TableEditors.ViewModels;

namespace WpfTableEditor
{
    public class TableEditorViewModel : ITableEditorViewModel
    {
        public TableEditorViewModel(
            IEnumerable<ITreeItemViewModel> rootItems,
            IReadOnlyList<IColumnViewModel> columnHeaders)
        {
            this.RootItems = new ObservableCollection<ITreeItemViewModel>(rootItems);
            this.ColumnHeaders = (columnHeaders);
        }

        public ObservableCollection<ITreeItemViewModel> RootItems { get; }

        public IReadOnlyList<IColumnViewModel> ColumnHeaders { get; }
    }
}
