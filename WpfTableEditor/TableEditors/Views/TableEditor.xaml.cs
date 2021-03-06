﻿//////////////////////////////////////////////////
// WpfTableEditor
// Copyright (c) 2018 Kenjiro.Nagao
// This software is released under the MIT License.
// http://opensource.org/licenses/mit-license.php
//////////////////////////////////////////////////

using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using unvell.ReoGrid.Events;
using unvell.ReoGrid.WpfTableEditor.TableEditors.Core;
using unvell.ReoGrid.WpfTableEditor.TableEditors.ViewModels;
using unvell.ReoGrid.WpfTableEditor.TableEditors.ViewModels.Core;

namespace unvell.ReoGrid.WpfTableEditor.TableEditors.Views
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
            this.InitializeComponent();

            this.reoGridControl.SheetTabNewButtonVisible = false;
            this.reoGridControl.SheetTabVisible = false;
            this.worksheet = this.reoGridControl.Worksheets[0];
            this.worksheet.RowsFiltered += OnRowsFilterd;

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
            if (rootItem.ColomnProperties.Count <= column)
            {
                Debug.Assert(false, "Out of Range");
                return;
            }

            rootItem.ColomnProperties[column] = e.Cell.Data;
        }

        private void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.viewModel = e.NewValue as ITableEditorViewModel;

            this.worksheet.Rows = this.viewModel.RootItems.Count;
            this.worksheet.Columns = this.viewModel.ColumnHeaders.Count;

            this.worksheet.CreateColumnFilter(0, this.viewModel.ColumnHeaders.Count - 1, -1);

            for (var i = 0; i < this.viewModel.ColumnHeaders.Count; i++)
            {
                SetColumnHeaderProperties(this.worksheet.ColumnHeaders[i], this.viewModel.ColumnHeaders[i]);
            }

            var contextMenu = new ContextMenu();
            contextMenu.Items.Add(new MenuItem { Header = "Test" });

            this.reoGridControl.ContextMenu = contextMenu;
            this.reoGridControl.ColumnHeaderContextMenu = contextMenu;
            this.reoGridControl.RowHeaderContextMenu = this.viewModel.GetRowHeaderContextMenuInfos().CreateMenu(this.CreateRowHeaderContextMenuParameter);
            this.reoGridControl.CellsContextMenu = contextMenu;

            this.UpdateAllCellDataFromViewModel();
            this.UpdateSubscriptions();
        }

        private RowHeaderContextMenuParameter CreateRowHeaderContextMenuParameter()
        {
            return new RowHeaderContextMenuParameter
            {
                Index = this.worksheet.SelectionRange.Row
            };
        }

        private void UpdateAllCellDataFromViewModel()
        {
            this.worksheet.CellDataChanged -= this.CellDataChanged;

            var data = new object[this.viewModel.RootItems.Count, this.viewModel.ColumnHeaders.Count];
            for (var i = 0; i < this.viewModel.RootItems.Count; i++)
            {
                var item = this.viewModel.RootItems[i];
                for (int j = 0; j < item.ColomnProperties.Count; j++)
                {
                    data[i, j] = item.ColomnProperties[j];
                }
            }

            this.worksheet.SetRangeData(
                new RangePosition(0, 0, this.viewModel.RootItems.Count, this.viewModel.ColumnHeaders.Count),
                data);

            this.worksheet.CellDataChanged += this.CellDataChanged;
        }

        private void UpdateCellDataFromViewModel(int startRow, int rows)
        {
            this.worksheet.CellDataChanged -= this.CellDataChanged;

            var value = new object[rows, this.viewModel.ColumnHeaders.Count];
            for (int i =0; i < rows; i++)
            {
                var item = this.viewModel.RootItems[startRow + i];
                for (int j = 0; j < item.ColomnProperties.Count; j++)
                {
                    value[i, j] = item.ColomnProperties[j];
                }
            }

            this.worksheet.SetRangeData(
                new RangePosition(startRow, 0, rows, this.viewModel.ColumnHeaders.Count),
                value);

            this.worksheet.CellDataChanged += this.CellDataChanged;
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
                oldRootItems.CollectionChanged -= this.RootItemsCollectionChanged;
            }

            this.viewModel.RootItems.CollectionChanged += this.RootItemsCollectionChanged;
        }

        private void RootItemsCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    this.worksheet.InsertRows(e.NewStartingIndex, e.NewItems.Count);
                    this.UpdateCellDataFromViewModel(e.NewStartingIndex, e.NewItems.Count);
                    break;
                case NotifyCollectionChangedAction.Remove:
                case NotifyCollectionChangedAction.Replace:
                case NotifyCollectionChangedAction.Move:
                case NotifyCollectionChangedAction.Reset:
                    throw new NotImplementedException();
            }
        }

        private void OnRowsFilterd(object sender, EventArgs eventArgs)
        {
            // TODO:
        }
    }
}
