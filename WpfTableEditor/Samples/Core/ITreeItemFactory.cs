//////////////////////////////////////////////////
// WpfTableEditor
// Copyright (c) 2018 Kenjiro.Nagao
// This software is released under the MIT License.
// http://opensource.org/licenses/mit-license.php
//////////////////////////////////////////////////

namespace unvell.ReoGrid.WpfTableEditor.Samples.Core
{
    internal interface ITreeItemFactory<T>
    {
        T CreateNew();
    }
}
