//////////////////////////////////////////////////
// WpfTableEditor
// Copyright (c) 2018 Kenjiro.Nagao
// This software is released under the MIT License.
// http://opensource.org/licenses/mit-license.php
//////////////////////////////////////////////////
using System.Collections.Generic;
using System.Collections.ObjectModel;
using unvell.ReoGrid.WpfTableEditor.TableEditors.ViewModels.Core;
using WpfTableEditor.TableEditors.ViewModels;

namespace WpfTableEditor
{
    internal class TreeItemViewModel : ITreeItemViewModel
    {
        private readonly TreeItem model;

        public TreeItemViewModel(TreeItem model)
        {
            this.Children = new ObservableCollection<ITreeItemViewModel>();
            this.model = model;
            this.ColomnProperties = new ColumnProperties(
                this,
                nameof(this.Name),
                nameof(this.Value),
                nameof(this.IsConstant));
        }

        public ITreeItemViewModel Parent { get; }

        public ObservableCollection<ITreeItemViewModel> Children { get; }

        public string Name
        {
            get
            {
                return this.model.Name;
            }

            set
            {
                this.model.Name = value;
            }
        }

        public object Value
        {
            get
            {
                return this.model.Value;
            }

            set
            {
                this.model.Value = value;
            }
        }

        public bool IsConstant
        {
            get
            {
                return this.model.IsConstant;
            }

            set
            {
                this.model.IsConstant = value;
            }
        }

        public ColumnProperties ColomnProperties { get; }
    }
}
