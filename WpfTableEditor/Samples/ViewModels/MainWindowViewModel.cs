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
