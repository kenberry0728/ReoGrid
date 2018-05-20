//////////////////////////////////////////////////
// WpfTableEditor
// Copyright (c) 2018 Kenjiro.Nagao
// This software is released under the MIT License.
// http://opensource.org/licenses/mit-license.php
//////////////////////////////////////////////////

namespace unvell.ReoGrid.WpfTableEditor.TableEditors.ViewModels.Core
{
    public interface IColumnProperties
    {
        object this[int i] { get; set; }

        int Count { get; }
    }
}