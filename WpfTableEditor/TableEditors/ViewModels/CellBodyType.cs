using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTableEditor.TableEditors.ViewModels
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
                    return typeof(unvell.ReoGrid.CellTypes.ButtonCell);
                case CellBodyType.CheckBox:
                    return typeof(unvell.ReoGrid.CellTypes.CheckBoxCell);
                case CellBodyType.Default:
                default:
                    return typeof(unvell.ReoGrid.CellTypes.CellBody);
            }
        }
    }
}
