//////////////////////////////////////////////////
// WpfTableEditor
// Copyright (c) 2018 Kenjiro.Nagao
// This software is released under the MIT License.
// http://opensource.org/licenses/mit-license.php
//////////////////////////////////////////////////
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace unvell.ReoGrid.WpfTableEditor.TableEditors.ViewModels.Core
{
    public class ColumnProperties<T> : IColumnProperties
    {
        private readonly object parent;
        private readonly ColumnPropertyInfos<T> columnPropertyInfos;

        public int Count => this.columnPropertyInfos.Count;

        public ColumnProperties(
            object propertyParent,
            ColumnPropertyInfos<T> columnPropertyInfos)
        {
            this.parent = propertyParent;
            this.columnPropertyInfos = columnPropertyInfos;

            var notifyPropertyChanged = this.parent as INotifyPropertyChanged;
            if (notifyPropertyChanged != null)
            {
                notifyPropertyChanged.PropertyChanged += PropertyChanged;
            }
        }

        private void PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            
        }

        public void SetValue(object sender, int index, object value)
        {
            throw new NotImplementedException();
        }

        public object this[int i]
        {
            get { return this.columnPropertyInfos.PropertyInfos[i].GetValue(this.parent); }
            set { this.columnPropertyInfos.PropertyInfos[i].SetValue(this.parent, value); }
        }
    }
}
