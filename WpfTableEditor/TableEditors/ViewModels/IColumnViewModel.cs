namespace WpfTableEditor.TableEditors.ViewModels
{
    public interface IColumnViewModel
    {
        string Name { get; }

        CellBodyType DefaultCellBodyType { get; }
    }
}