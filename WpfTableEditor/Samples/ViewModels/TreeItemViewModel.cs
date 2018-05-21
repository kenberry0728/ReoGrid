//////////////////////////////////////////////////
// WpfTableEditor
// Copyright (c) 2018 Kenjiro.Nagao
// This software is released under the MIT License.
// http://opensource.org/licenses/mit-license.php
//////////////////////////////////////////////////

using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using unvell.ReoGrid.WpfTableEditor.Annotations;
using unvell.ReoGrid.WpfTableEditor.Samples.Models;
using unvell.ReoGrid.WpfTableEditor.TableEditors.ViewModels;
using unvell.ReoGrid.WpfTableEditor.TableEditors.ViewModels.Core;

namespace unvell.ReoGrid.WpfTableEditor.Samples.ViewModels
{
    internal class TreeItemViewModel : ITreeItemViewModel, INotifyPropertyChanged
    {
        private readonly TreeItem model;

        public TreeItemViewModel(
            TreeItem model,
            ColumnPropertyInfos<TreeItemViewModel> columnPropertyInfos,
            ITreeItemViewModel parent = null)
        {
            this.Parent = parent;
            this.Children = new ObservableCollection<ITreeItemViewModel>();
            this.model = model;
            this.ColomnProperties = new ColumnProperties<TreeItemViewModel>(this, columnPropertyInfos);
        }

        public event PropertyChangedEventHandler PropertyChanged;

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
                this.OnPropertyChanged(nameof(this.Name));
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
                this.OnPropertyChanged(nameof(this.Value));

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
                this.OnPropertyChanged(nameof(this.IsConstant));

            }
        }

        public IColumnProperties ColomnProperties { get; }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
