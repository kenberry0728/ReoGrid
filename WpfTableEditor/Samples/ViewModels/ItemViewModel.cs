//////////////////////////////////////////////////
// WpfTableEditor
// Copyright (c) 2018 Kenjiro.Nagao
// This software is released under the MIT License.
// http://opensource.org/licenses/mit-license.php
//////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfTableEditor;

namespace unvell.ReoGrid.WpfTableEditor.Samples.ViewModels
{
    internal class ItemViewModel
    {
        private readonly TreeItem model;

        public ItemViewModel(TreeItem model)
        {
            this.model = model;
        }

        public string Name
        {
            get { return model.Name; }
            set { this.model.Name = value; }
        }
    }
}
