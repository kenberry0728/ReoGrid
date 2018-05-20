//////////////////////////////////////////////////
// WpfTableEditor
// Copyright (c) 2018 Kenjiro.Nagao
// This software is released under the MIT License.
// http://opensource.org/licenses/mit-license.php
//////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unvell.ReoGrid.WpfTableEditor.Samples.Core;
using WpfTableEditor;

namespace unvell.ReoGrid.WpfTableEditor.Samples.ModelServices
{
    internal class ModelService : IModelService<TreeItem>
    {
        private readonly List<TreeItem> members;
        private readonly ITreeItemFactory<TreeItem> treeItemFactory;

        public ModelService(
            IEnumerable<TreeItem> initialMembers,
            ITreeItemFactory<TreeItem> treeItemFactory)
        {
            this.members = initialMembers.ToList();
            this.treeItemFactory = treeItemFactory;
        }

        public event NotifyCollectionChangedEventHandler CollectionChanged;

        public IEnumerable<TreeItem> Members => members;

        public TreeItem InsertNewItem(int index)
        {
            var newItem = this.treeItemFactory.CreateNew();
            this.members.Insert(index, newItem);

            var args = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, new List<TreeItem>() { newItem }, index);
            this.CollectionChanged(this, args);
            return newItem;
        }
    }
}
