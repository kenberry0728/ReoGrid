using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfTableEditor.Samples.ViewModels;
using WpfTableEditor.TableEditors.ViewModels;

namespace WpfTableEditor
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);

            var culumnHeaderViewModels = new[]
            {
                new ColumnHeaderViewModel("Name"),
                new ColumnHeaderViewModel("Value"),
                new ColumnHeaderViewModel("Constant", CellBodyType.CheckBox),
            };

            var samples = new[] 
            {
                new SampleTreeItem() { Name = "Dummy1" },
                new SampleTreeItem() { Name = "Dummy2" }
            };

            var sampleViewModels = samples.Select(s => new SampleTreeItemViewModel(s));

            var tableEditorViewModel = new TableEditorViewModel(sampleViewModels, culumnHeaderViewModels);
            this.DataContext = new MainWindowViewModel(tableEditorViewModel);
        }
    }
}
