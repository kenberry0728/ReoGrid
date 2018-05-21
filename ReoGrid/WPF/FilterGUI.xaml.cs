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
using System.Windows.Controls.Primitives;
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
    public partial class ColumnFilterContextMenu : UserControl
    {
        private readonly AutoColumnFilterBody headerBody;

        private ColumnFilterContextMenu(AutoColumnFilterBody headerBody)
        {
            this.InitializeComponent();
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

        private static Popup popupSingleton;

        internal static void ShowFilterPanel(
            AutoColumnFilterBody headerBody,
            Point point)
        {
            if (popupSingleton != null)
            {
                popupSingleton.IsOpen = false;
                popupSingleton.StaysOpen = false;
                popupSingleton = null;
            }

            var popup = new Popup
            {
                Child = new ColumnFilterContextMenu(headerBody),
                Placement = PlacementMode.Mouse,
                IsOpen = true,
                StaysOpen = true
            };

            // TODO : CLose when click outside
            popup.Child.Focus();
            DependencyPropertyChangedEventHandler handler = null;
            handler = (x, y) =>
            {
                popup.IsOpen = false;
                popup.StaysOpen = false;
                popup.IsKeyboardFocusWithinChanged -= handler;
                popupSingleton = null;
            };

            popup.IsKeyboardFocusWithinChanged += handler;
            popupSingleton = popup;
        }
    }
}
