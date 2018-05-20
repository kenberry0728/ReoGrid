//////////////////////////////////////////////////
// WpfTableEditor
// Copyright (c) 2018 Kenjiro.Nagao
// This software is released under the MIT License.
// http://opensource.org/licenses/mit-license.php
//////////////////////////////////////////////////

using unvell.ReoGrid.WpfTableEditor.Samples.Core;
using unvell.ReoGrid.WpfTableEditor.Samples.Models;

namespace unvell.ReoGrid.WpfTableEditor.Samples.Implementations
{
    internal class TreeItemFactory : ITreeItemFactory<TreeItem>
    {
        public TreeItem CreateNew()
        {
            return new TreeItem();
        }
    }
}
