//////////////////////////////////////////////////
// WpfTableEditor
// Copyright (c) 2018 Kenjiro.Nagao
// This software is released under the MIT License.
// http://opensource.org/licenses/mit-license.php
//////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfTableEditor.TableEditors.ViewModels;

namespace WpfTableEditor
{
    class SampleTreeItemViewModel : ITreeItemViewModel
    {
        private readonly SampleTreeItem sampleTreeItem;

        public SampleTreeItemViewModel(SampleTreeItem sampleTreeItem)
        {
            this.sampleTreeItem = sampleTreeItem;
            this.Children = new ObservableCollection<ITreeItemViewModel>();
        }

        public ITreeItemViewModel Parent { get; }

        public ObservableCollection<ITreeItemViewModel> Children { get; }
    }
}
