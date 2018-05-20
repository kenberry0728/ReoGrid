//////////////////////////////////////////////////
// WpfTableEditor
// Copyright (c) 2018 Kenjiro.Nagao
// This software is released under the MIT License.
// http://opensource.org/licenses/mit-license.php
//////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using unvell.ReoGrid.WpfTableEditor.Samples.Core;
using unvell.ReoGrid.WpfTableEditor.TableEditors.Core;
using unvell.ReoGrid.WpfTableEditor.TableEditors.ViewModels.Core;
using WpfTableEditor.TableEditors.ViewModels;

namespace WpfTableEditor
{
    public class TableEditorViewModel<T> : ITableEditorViewModel<T>
    {
        private readonly IItemViewModelFactory<T> itemViewModelFactory;
        private readonly IRowHeaderContextMenuInfoService rowHeaderContextMenuInfoService;

        public TableEditorViewModel(
            IEnumerable<ITreeItemViewModel> rootItems,
            IReadOnlyList<IColumnViewModel> columnHeaders,
            IModelService<T> modelService,
            IItemViewModelFactory<T> itemViewModelFactory,
            IRowHeaderContextMenuInfoService rowHeaderContextMenuInfoService = null)
        {
            this.RootItems = new ObservableCollection<ITreeItemViewModel>(rootItems);
            this.ColumnHeaders = (columnHeaders);
            this.ModelService = modelService;
            this.itemViewModelFactory = itemViewModelFactory;
            this.ModelService.CollectionChanged += this.CollectionChanged;
            this.rowHeaderContextMenuInfoService = rowHeaderContextMenuInfoService;
        }

        private void CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch(e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    var addedViewModels = e.NewItems.OfType<T>().Select(this.itemViewModelFactory.Create);
                    var startIndex = e.NewStartingIndex;
                    foreach (var item in addedViewModels)
                    {
                        this.RootItems.Insert(startIndex++, item);
                    }

                    break;
            }
        }

        public ObservableCollection<ITreeItemViewModel> RootItems { get; }

        public IReadOnlyList<IColumnViewModel> ColumnHeaders { get; }

        public IModelService<T> ModelService { get; }

        public IEnumerable<ContextMenuInfo> GetRowHeaderContextMenuInfos()
        {
            return this.rowHeaderContextMenuInfoService == null
                   ? Enumerable.Empty<ContextMenuInfo>()
                   : this.rowHeaderContextMenuInfoService.GetRowHeaderContextMenuInfos(this);
        }
    }
}
