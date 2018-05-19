using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfTableEditor.TableEditors.ViewModels;

namespace WpfTableEditor
{
    internal class MainWindowViewModel
    {
        public MainWindowViewModel(ITableEditorViewModel tableEditorViewModel)
        {
            TableEditorViewModel = tableEditorViewModel;
        }

        public ITableEditorViewModel TableEditorViewModel { get; }
    }
}
