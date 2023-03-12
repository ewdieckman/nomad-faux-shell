using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EosFauxShell
{
    public class NomadLabel :Label
    {
        public NomadLabel()
        {
            Font = new Font("Tahoma", 8F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(174, 174, 174);
        }
    }

}
