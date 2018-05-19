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
    public class ColumnProperties : IColumnProperties
    {
        private readonly object parent;
        private List<PropertyInfo> propertyInfos;

        public int Count => this.propertyInfos.Count;

        public ColumnProperties(
            object propertyParent,
            params string[] propertyNames)
        {
            this.parent = propertyParent;
            var type = propertyParent.GetType();
            this.propertyInfos = propertyNames.Select(s => type.GetProperty(s)).ToList();

            var notifyPropertyChanged = this.parent as INotifyPropertyChanged;
            if (notifyPropertyChanged != null)
            {
                notifyPropertyChanged.PropertyChanged += PropertyChanged;
            }
        }

        private void PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            
        }

        public object this[int i]
        {
            get { return this.propertyInfos[i].GetValue(this.parent); }
            set { this.propertyInfos[i].SetValue(this.parent, value); }
        }
    }
}
