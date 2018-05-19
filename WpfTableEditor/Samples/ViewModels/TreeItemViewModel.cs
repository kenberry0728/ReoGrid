﻿//////////////////////////////////////////////////
// WpfTableEditor
// Copyright (c) 2018 Kenjiro.Nagao
// This software is released under the MIT License.
// http://opensource.org/licenses/mit-license.php
//////////////////////////////////////////////////
using System.Collections.Generic;
using System.Collections.ObjectModel;
using unvell.ReoGrid.WpfTableEditor.Samples.ViewModels;
using WpfTableEditor.TableEditors.ViewModels;

namespace WpfTableEditor
{
    internal class TreeItemViewModel : ITreeItemViewModel
    {
        public TreeItemViewModel(ItemViewModel itemViewModel)
        {
            this.ItemViewModel = itemViewModel;
            this.Children = new ObservableCollection<ITreeItemViewModel>();
            this.CellValueProviders = new List<ICellValueProvider>
            {
                new NameCellValueProvider(),
                new ValueCellValueProvider(),
                new ConstantCellValueProvider()
            };
        }

        public ITreeItemViewModel Parent { get; }

        public ObservableCollection<ITreeItemViewModel> Children { get; }

        public IList<ICellValueProvider> CellValueProviders { get; }

        public ItemViewModel ItemViewModel { get; }
    }
}
