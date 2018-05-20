//////////////////////////////////////////////////
// WpfTableEditor
// Copyright (c) 2018 Kenjiro.Nagao
// This software is released under the MIT License.
// http://opensource.org/licenses/mit-license.php
//////////////////////////////////////////////////
using System;
using System.Windows.Input;
using unvell.ReoGrid.WpfTableEditor.TableEditors.ViewModels.Core;
using WpfTableEditor.TableEditors.ViewModels;

namespace unvell.ReoGrid.WpfTableEditor.Samples.ViewModels.Commands
{
    internal class InsertCommand : ICommand
    {
        private readonly ITableEditorViewModel tableEditorViewModel;

        public InsertCommand(ITableEditorViewModel tableEditorViewModel)
        {
            this.tableEditorViewModel = tableEditorViewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var parameter = parameter as RowHeaderContextParameter;
        }
    }
}
