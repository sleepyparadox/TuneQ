using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuneQueue
{
    public static class IEnumerableControls
    {
        public static IEnumerable<Control> Children(this Control parent)
        {
            for (var i = 0; i < parent.Controls.Count; ++i)
                yield return parent.Controls[i];
        }
    }
}
