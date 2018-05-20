//////////////////////////////////////////////////
// WpfTableEditor
// Copyright (c) 2018 Kenjiro.Nagao
// This software is released under the MIT License.
// http://opensource.org/licenses/mit-license.php
//////////////////////////////////////////////////

using System.Collections.Generic;
using System.Collections.Specialized;

namespace unvell.ReoGrid.WpfTableEditor.TableEditors.Core
{
    public interface IModelService<T>
    {
        IEnumerable<T> Members { get; }

        T InsertNewItem(object sender,int index);

        event NotifyCollectionChangedEventHandler CollectionChanged;
    }
}
