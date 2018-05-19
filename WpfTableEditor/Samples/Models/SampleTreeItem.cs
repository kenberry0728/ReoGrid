using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTableEditor
{
    internal class SampleTreeItem
    {
        public string Name { get; set; }

        public List<SampleTreeItem> Children { get; set; }
    }
}
