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
using System.Windows.Input;
using WpfTableEditor.TableEditors.ViewModels;

namespace unvell.ReoGrid.WpfTableEditor.Samples.ViewModels.Commands.Implementations
{
    internal class ViewModelCommandFactory
    {
        public ICommand CreateInsertCommand(ITableEditorViewModel tableEditorViewModel)
        {
            return new InsertCommand(tableEditorViewModel);
        }
    }
}
