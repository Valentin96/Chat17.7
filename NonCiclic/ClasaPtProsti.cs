
using Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NonCiclic
{
   public   class ClasaPtProsti
    {
        public ListBox tare()
        {
            FormServer fs = new FormServer();
          ListBox list =  fs.getListaClienti();
            return list;
        }
}
}
