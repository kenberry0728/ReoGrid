using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTableEditor.TableEditors.ViewModels
{
    public interface ITreeItemViewModel
    {
        ITreeItemViewModel Parent { get; }
        
        ObservableCollection<ITreeItemViewModel> Children { get; }

        IList<ICellValueProvider> CellValueProviders { get; }
    }
}
