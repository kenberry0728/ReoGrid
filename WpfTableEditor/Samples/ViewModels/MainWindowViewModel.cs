//////////////////////////////////////////////////
// WpfTableEditor
// Copyright (c) 2018 Kenjiro.Nagao
// This software is released under the MIT License.
// http://opensource.org/licenses/mit-license.php
//////////////////////////////////////////////////

using unvell.ReoGrid.WpfTableEditor.TableEditors.ViewModels;

namespace unvell.ReoGrid.WpfTableEditor.Samples.ViewModels
{
    internal class MainWindowViewModel
    {
        public MainWindowViewModel(ITableEditorViewModel tableEditorViewModel)
        {
            this.TableEditorViewModel = tableEditorViewModel;
        }

        public ITableEditorViewModel TableEditorViewModel { get; }
    }
}
