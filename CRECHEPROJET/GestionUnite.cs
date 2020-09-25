using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CRECHEPROJET
{
    partial class unite
    {
        public override string ToString()
        {
            return this.NomUnite;
        }
        public Color GetColor()
        {
            return Color.FromArgb (this.AlphaUnite, this.RougeUnite, this.VertUnite, this.Bleu_Unite);
            
        }
        
    }
}
