//////////////////////////////////////////////////
// WpfTableEditor
// Copyright (c) 2018 Kenjiro.Nagao
// This software is released under the MIT License.
// http://opensource.org/licenses/mit-license.php
//////////////////////////////////////////////////
using WpfTableEditor.TableEditors.ViewModels;

namespace WpfTableEditor
{
    public interface IItemViewModelFactory<T>
    {
        ITreeItemViewModel Create(T modelItem);
    }
}