﻿//////////////////////////////////////////////////
// WpfTableEditor
// Copyright (c) 2018 Kenjiro.Nagao
// This software is released under the MIT License.
// http://opensource.org/licenses/mit-license.php
//////////////////////////////////////////////////

using unvell.ReoGrid.WpfTableEditor.TableEditors.Core;

namespace unvell.ReoGrid.WpfTableEditor.TableEditors.ViewModels
{
    public interface IColumnViewModel
    {
        string Name { get; }

        CellBodyType DefaultCellBodyType { get; }
    }
}