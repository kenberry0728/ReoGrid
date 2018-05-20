//////////////////////////////////////////////////
// WpfTableEditor
// Copyright (c) 2018 Kenjiro.Nagao
// This software is released under the MIT License.
// http://opensource.org/licenses/mit-license.php
//////////////////////////////////////////////////

using System;
using unvell.ReoGrid.CellTypes;

namespace unvell.ReoGrid.WpfTableEditor.TableEditors.Core
{
    public enum CellBodyType
    {
        Default,
        Button,
        CheckBox
    }

    public static class CellBodyTypeExtensions
    {
        public static Type ToCellType(this CellBodyType cellBodyType)
        {
            switch (cellBodyType)
            {
                case CellBodyType.Button:
                    return typeof(ButtonCell);
                case CellBodyType.CheckBox:
                    return typeof(CheckBoxCell);
                case CellBodyType.Default:
                default:
                    return typeof(CellBody);
            }
        }
    }
}
