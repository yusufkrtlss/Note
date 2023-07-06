using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.EntityLayer.Concrete
{
    public class TreeViewNode
    {
        public string Id { get; set; }
        public string Parent { get; set; }
        public string Text { get; set; }
    }
}
