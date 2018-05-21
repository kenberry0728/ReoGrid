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
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static unvell.ReoGrid.Data.AutoColumnFilter;

namespace unvell.ReoGrid.WPF
{
    /// <summary>
    /// Interaction logic for FilterGUI.xaml
    /// </summary>
    public partial class FilterGUI : UserControl
    {
        private readonly AutoColumnFilterBody headerBody;

        public FilterGUI(AutoColumnFilterBody headerBody)
        {
            InitializeComponent();
            this.headerBody = headerBody;
        }
        
        private void AtoZButtonClick(object sender, RoutedEventArgs e)
        {
            var worksheet = this.headerBody.ColumnHeader.Worksheet;
            worksheet.SortColumn(headerBody.ColumnHeader.Index, headerBody.autoFilter.ApplyRange, SortOrder.Ascending);
        }

        private void ZtoAButtonClick(object sender, RoutedEventArgs e)
        {
            var worksheet = this.headerBody.ColumnHeader.Worksheet;
            worksheet.SortColumn(headerBody.ColumnHeader.Index, headerBody.autoFilter.ApplyRange, SortOrder.Descending);
        }
    }
}
