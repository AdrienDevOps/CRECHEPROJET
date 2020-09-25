using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRECHEPROJET
{
    class Gestion_Listbox
    {
        public Gestion_Listbox(string status,Point point,int nb)
        {
            ListBox list = new ListBox();
            list.Name = status.ToString() + nb.ToString();
            list.Location = point;
        }
    }
}
