using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRECHEPROJET
{
    partial class acceuil
    { 
         public Color GetColorBoutton()
        {
            if (ReelArriver != null)
                if (ReelDepart != null)
                    return Color.Cyan;
                else
                    return Color.Green;
            else
                return Color.Gray;
        }
        public string GetTextBoutton()
        {
            if (ReelArriver != null)
                if (ReelDepart != null)
                    return contrat.enfant.NomEnfant + "   " + contrat.enfant.PrenomEnfant + "\n" + "\n" + "\n" + PrevuArriver.Value.ToShortTimeString() + "          " + ReelArriver.Value.ToShortTimeString() + "\n" + PrevuDepart.Value.ToShortTimeString() + "          " + ReelDepart.Value.ToShortTimeString();

                else
                return contrat.enfant.NomEnfant + "   " + contrat.enfant.PrenomEnfant + "\n" + "\n" + "\n" + PrevuArriver.Value.ToShortTimeString() + "          " + ReelArriver.Value.ToShortTimeString() + "\n" + PrevuDepart.Value.ToShortTimeString() + "          " + "00:00";

            else
                return contrat.enfant.NomEnfant + "   " + contrat.enfant.PrenomEnfant + "\n" + "\n" + "\n" + PrevuArriver.Value.ToShortTimeString() + "          " + "00:00" + "\n" + PrevuDepart.Value.ToShortTimeString() + "          " + "00:00";
        }
        public void Updateacceuil(bool verif, mydbEntities Bdd)
        {
            foreach (acceuil acceuil in Bdd.acceuil.ToList()) 
            {
                if (acceuil.IDacceuil == IDacceuil)
                    if (verif)
                        acceuil.ReelDepart = DateTime.Now;
                    else
                        acceuil.ReelArriver = DateTime.Now;
                    Bdd.SaveChanges();              
            }
        }
    }
}
