//////////////////////////////////////////////////
// WpfTableEditor
// Copyright (c) 2018 Kenjiro.Nagao
// This software is released under the MIT License.
// http://opensource.org/licenses/mit-license.php
//////////////////////////////////////////////////
using System;
using System.Windows.Input;

namespace unvell.ReoGrid.WpfTableEditor.TableEditors.Core
{
    internal class DelegateCommand : ICommand
    {
        private readonly ICommand command;
        private readonly Func<object> getParameter;

        public DelegateCommand(ICommand command, Func<object> getParameter)
        {
            this.command = command;
            this.getParameter = getParameter;
            command.CanExecuteChanged += this.OriginalCanExecuteChanged;
        }

        private void OriginalCanExecuteChanged(object sender, EventArgs e)
        {
            this.CanExecuteChanged(sender, e);
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return this.command.CanExecute(this.getParameter());
        }

        public void Execute(object parameter)
        {
            this.command.Execute(this.getParameter());
        }
    }
}
