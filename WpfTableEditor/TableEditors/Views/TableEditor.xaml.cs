﻿//////////////////////////////////////////////////
// WpfTableEditor
// Copyright (c) 2018 Kenjiro.Nagao
// This software is released under the MIT License.
// http://opensource.org/licenses/mit-license.php
//////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
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
using unvell.ReoGrid;
using unvell.ReoGrid.Events;
using WpfTableEditor.TableEditors.ViewModels;

namespace WpfTableEditor.TableEditors
{
    /// <summary>
    /// TableEditor.xaml の相互作用ロジック
    /// </summary>
    public partial class TableEditor : UserControl
    {
        private readonly Worksheet worksheet;
        private ITableEditorViewModel viewModel;

        public TableEditor()
        {
            InitializeComponent();

            this.reoGridControl.SheetTabNewButtonVisible = false;
            this.reoGridControl.SheetTabVisible = false;

            this.worksheet = this.reoGridControl.Worksheets[0];
            this.worksheet.CellDataChanged += CellDataChanged;

            this.DataContextChanged += this.OnDataContextChanged;
        }

        private void CellDataChanged(object sender, CellEventArgs e)
        {
            var row = e.Cell.Row;
            var column = e.Cell.Column;

            if (this.viewModel.RootItems.Count <= row)
            {
                Debug.Assert(false, "Out of Range");
                return;
            }

            var rootItem = this.viewModel.RootItems[row];
            if (rootItem.CellValueProviders.Count <= column)
            {
                Debug.Assert(false, "Out of Range");
                return;
            }

            var valueProvider = rootItem.CellValueProviders[column];
            valueProvider.SetValue(rootItem, e.Cell.Data);
        }

        private void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.viewModel = e.NewValue as ITableEditorViewModel;

            this.worksheet.Rows = this.viewModel.RootItems.Count;
            this.worksheet.Columns = this.viewModel.ColumnHeaders.Count;

            for (var i = 0; i < this.viewModel.ColumnHeaders.Count; i++)
            {
                SetColumnHeaderProperties(this.worksheet.ColumnHeaders[i], this.viewModel.ColumnHeaders[i]);
            }

            for (var i = 0; i < this.viewModel.RootItems.Count; i++)
            {
                var item = this.viewModel.RootItems[i];
                for (int j = 0; j < item.CellValueProviders.Count; j++)
                {
                    this.worksheet[i, j] = item.CellValueProviders[j].GetValue(item);
                }
            }

            UpdateSubscriptions();
        }

        private static void SetColumnHeaderProperties(ColumnHeader columnHeader, IColumnViewModel columnHeaderViewModel)
        {
            if (columnHeaderViewModel.Name != null)
            {
                columnHeader.Text = columnHeaderViewModel.Name;
            }

            columnHeader.DefaultCellBody = columnHeaderViewModel.DefaultCellBodyType.ToCellType();
        }

        private void UpdateSubscriptions()
        {
            if (this.viewModel == null)
            {
                return;
            }

            var oldRootItems = this.viewModel.RootItems;
            if (oldRootItems != null)
            {
                oldRootItems.CollectionChanged -= RootItemsCollectionChanged;
            }

            this.viewModel.RootItems.CollectionChanged += RootItemsCollectionChanged;
        }

        private void RootItemsCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                case NotifyCollectionChangedAction.Remove:
                case NotifyCollectionChangedAction.Replace:
                case NotifyCollectionChangedAction.Move:
                case NotifyCollectionChangedAction.Reset:
                    throw new NotImplementedException();
            }
        }
    }
}
