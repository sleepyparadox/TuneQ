using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public static class IEnumerableControls
{
    public static IEnumerable<Control> GetChildren(this Control parent)
    {
        for (var i = 0; i < parent.Controls.Count; ++i)
            yield return parent.Controls[i];
    }
}
