//////////////////////////////////////////////////
// WpfTableEditor
// Copyright (c) 2018 Kenjiro.Nagao
// This software is released under the MIT License.
// http://opensource.org/licenses/mit-license.php
//////////////////////////////////////////////////
using System;
using System.Windows.Input;
using unvell.ReoGrid.WpfTableEditor.TableEditors.ViewModels;
using unvell.ReoGrid.WpfTableEditor.TableEditors.ViewModels.Core;

namespace unvell.ReoGrid.WpfTableEditor.Samples.ViewModels.Commands
{
    internal class InsertNewItemCommand<T> : ICommand
    {
        private readonly ITableEditorViewModel<T> tableEditorViewModel;

        public InsertNewItemCommand(ITableEditorViewModel<T> tableEditorViewModel)
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
            var rowHeaderContextMenuParameter = parameter as RowHeaderContextMenuParameter;
            if (rowHeaderContextMenuParameter == null)
            {
                return;
            }

            this.tableEditorViewModel.ModelService.InsertNewItem(this.tableEditorViewModel, rowHeaderContextMenuParameter.Index);
        }
    }
}
