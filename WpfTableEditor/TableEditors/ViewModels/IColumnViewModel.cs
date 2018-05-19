//////////////////////////////////////////////////
// WpfTableEditor
// Copyright (c) 2018 Kenjiro.Nagao
// This software is released under the MIT License.
// http://opensource.org/licenses/mit-license.php
//////////////////////////////////////////////////
namespace WpfTableEditor.TableEditors.ViewModels
{
    public interface IColumnViewModel
    {
        string Name { get; }

        CellBodyType DefaultCellBodyType { get; }
    }
}