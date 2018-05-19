//////////////////////////////////////////////////
// WpfTableEditor
// Copyright (c) 2018 Kenjiro.Nagao
// This software is released under the MIT License.
// http://opensource.org/licenses/mit-license.php
//////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unvell.ReoGrid.WpfTableEditor.Samples.ViewModels;
using unvell.ReoGrid.WpfTableEditor.TableEditors.ViewModels.Core;

namespace WpfTableEditor.TableEditors.ViewModels
{
    public interface ITreeItemViewModel
    {
        ITreeItemViewModel Parent { get; }

        ObservableCollection<ITreeItemViewModel> Children { get; }

        ColumnProperties ColomnProperties { get;}
    }
}
