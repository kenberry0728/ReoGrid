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
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using unvell.ReoGrid.WpfTableEditor.Samples.Implementations;
using unvell.ReoGrid.WpfTableEditor.Samples.ModelServices;
using unvell.ReoGrid.WpfTableEditor.Samples.ViewModels.Implementations;
using unvell.ReoGrid.WpfTableEditor.Samples.ViewModels.Menus;
using unvell.ReoGrid.WpfTableEditor.TableEditors.ViewModels.Core;
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
            this.InitializeComponent();
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
                new TreeItem() { Name = "Dummy1" },
                new TreeItem() { Name = "Dummy2" }
            };

            var sampleItemFactory = new TreeItemFactory();
            var sampleModelService = new ModelService(samples, sampleItemFactory);

            var columnPropertyInfos = new ColumnPropertyInfos<TreeItemViewModel>(
                nameof(TreeItemViewModel.Name),
                nameof(TreeItemViewModel.Value),
                nameof(TreeItemViewModel.IsConstant));

            var sampleViewModelFactory = new TreeItemViewModelFactory(columnPropertyInfos);
            var sampleViewModels = samples.Select(sampleViewModelFactory.Create);

            var tableEditorViewModel = new TableEditorViewModel<TreeItem>(
                sampleViewModels,
                culumnHeaderViewModels,
                sampleModelService,
                sampleViewModelFactory,
                new RowHeaderContextMenuInfoService());
            this.DataContext = new MainWindowViewModel(tableEditorViewModel);
        }
    }
}
