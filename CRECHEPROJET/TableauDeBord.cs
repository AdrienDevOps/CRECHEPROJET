using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRECHEPROJET
{
    public partial class TableauDeBord : Form
    {
        //public ListBox EnfantsPresent;        
        private TabControl tab;
        private creche creche1;
        public mydbEntities mydb;

        public TableauDeBord(TabControl tab , creche creche,mydbEntities d)
        {
            InitializeComponent();
            this.tab = tab;
            creche1 = creche;
            mydb = d;
        }


        private void Chargement(object sender, EventArgs e)
        {
            int nb = 0;
            foreach (unite unite in creche1.unite)
            {

                UniteListe.TabPages.Add(unite.ToString());
                UniteListe.TabPages[nb].BackColor = unite.GetColor();

                //Constructeur ListBox et Label -->  Présent
                ListBox EnfantsPresent = new ListBox();
                EnfantsPresent.Name = "Présent" + nb.ToString();
                UniteListe.TabPages[nb].Controls.Add(EnfantsPresent);
                EnfantsPresent.Location = new Point(20, 30);

                Label labelpresent = new Label();
                labelpresent.Name = "labelpresent" + nb.ToString();
                UniteListe.TabPages[nb].Controls.Add(labelpresent);
                labelpresent.Location = new Point(30, 10);

                //Constructeur ListBox et label --> Attendu
                ListBox EnfantAttendu = new ListBox();
                EnfantAttendu.Name = "Attendu" + nb.ToString();
                UniteListe.TabPages[nb].Controls.Add(EnfantAttendu);
                EnfantAttendu.Location = new Point(150, 30);

                Label labelAttendu = new Label();
                labelAttendu.Name = "labelAttendu" + nb.ToString();
                UniteListe.TabPages[nb].Controls.Add(labelAttendu);
                labelAttendu.Location = new Point(160, 10);

                //Constructeur ListBox et label --> Absent
                ListBox EnfantsAbsent = new ListBox();
                EnfantsAbsent.Name = "Absent" + nb.ToString();
                UniteListe.TabPages[nb].Controls.Add(EnfantsAbsent);
                EnfantsAbsent.Location = new Point(280, 30);

                Label labelAbsent = new Label();
                labelAbsent.Name = "labelAbsent" + nb.ToString();
                UniteListe.TabPages[nb].Controls.Add(labelAbsent);
                labelAbsent.Location = new Point(290, 10);
                //Constructeur ListBox et label --> Parti
                ListBox EnfantsParti = new ListBox();
                EnfantsParti.Name = "Parti" + nb.ToString();
                UniteListe.TabPages[nb].Controls.Add(EnfantsParti);
                EnfantsParti.Location = new Point(410, 30);

                Label labelParti = new Label();
                labelParti.Name = "labelParti" + nb.ToString();
                UniteListe.TabPages[nb].Controls.Add(labelParti);
                labelParti.Location = new Point(420, 10);

                //Constructeur ListBox et label --> En Avance
                ListBox EnfantsAvance = new ListBox();
                EnfantsAvance.Name = "Avance" + nb.ToString();
                UniteListe.TabPages[nb].Controls.Add(EnfantsAvance);
                EnfantsAvance.Location = new Point(540, 30);

                Label labelAvance = new Label();
                labelAvance.Name = "labelAvance" + nb.ToString();
                UniteListe.TabPages[nb].Controls.Add(labelAvance);
                labelAvance.Location = new Point(550, 10);
                //Constructeur ListBox et label --> En Retard
                ListBox EnfantsRetard = new ListBox();
                EnfantsRetard.Name = "Retard" + nb.ToString();
                UniteListe.TabPages[nb].Controls.Add(EnfantsRetard);
                EnfantsRetard.Location = new Point(670, 30);

                Label labelRetard = new Label();
                labelRetard.Name = "labelAvance" + nb.ToString();
                UniteListe.TabPages[nb].Controls.Add(labelRetard);
                labelRetard.Location = new Point(680, 10);


                //ajouts enfants TOUS
                foreach (Button button in tab.TabPages[nb].Controls)
                {
                    if (button.BackColor == Color.Green)
                    {   //Présent
                        EnfantsPresent.Items.Add(((acceuil)button.Tag).contrat.enfant.NomEnfant.ToString() + " " + ((acceuil)button.Tag).contrat.enfant.PrenomEnfant.ToString());
                    }
                    if (button.BackColor==Color.Gray && ((acceuil)button.Tag).PrevuDepart <= DateTime.Now)
                    {   //Attendu
                        EnfantAttendu.Items.Add(((acceuil)button.Tag).contrat.enfant.NomEnfant.ToString() + " " + ((acceuil)button.Tag).contrat.enfant.PrenomEnfant.ToString());
                    }
                    if (button.BackColor == Color.Gray && ((acceuil)button.Tag).PrevuDepart < DateTime.Now)
                    {   //Absent
                        EnfantsAbsent.Items.Add(((acceuil)button.Tag).contrat.enfant.NomEnfant.ToString() + " " + ((acceuil)button.Tag).contrat.enfant.PrenomEnfant.ToString());
                    }
                    if (button.BackColor==Color.Cyan)
                    {   //Partis
                        EnfantsParti.Items.Add(((acceuil)button.Tag).contrat.enfant.NomEnfant.ToString() + " " + ((acceuil)button.Tag).contrat.enfant.PrenomEnfant.ToString());
                    }
                    if (button.BackColor == Color.Green && ((acceuil)button.Tag).PrevuArriver < ((acceuil)button.Tag).ReelArriver)
                    {   //En avance
                        EnfantsAvance.Items.Add(((acceuil)button.Tag).contrat.enfant.NomEnfant.ToString() + " " + ((acceuil)button.Tag).contrat.enfant.PrenomEnfant.ToString());
                    }
                    if (button.BackColor == Color.Gray && ((acceuil)button.Tag).PrevuArriver < DateTime.Now && ((acceuil)button.Tag).PrevuDepart > DateTime.Now)
                    {   //En Retard
                        EnfantsRetard.Items.Add(((acceuil)button.Tag).contrat.enfant.NomEnfant.ToString() + " " + ((acceuil)button.Tag).contrat.enfant.PrenomEnfant.ToString());
                    }
                }
                //Ecriture Label TOUS
                labelpresent.Text  = "Présent: "   + EnfantsPresent.Items.Count;
                labelAttendu.Text  = "Attendu: "   + EnfantAttendu.Items.Count;
                labelAbsent.Text   = "Absent: "    + EnfantsAbsent.Items.Count;
                labelParti.Text    = "Parti: "     + EnfantsParti.Items.Count;
                labelAvance.Text   = "En Avance: " + EnfantsAvance.Items.Count;
                labelRetard.Text   = "En Retard: " + EnfantsRetard.Items.Count;


                //Construteur Label pour le total Prevu par unité
                Label labeltotalprevu = new Label();
                labeltotalprevu.Name = "labeltotalprevu" + nb.ToString();
                UniteListe.TabPages[nb].Controls.Add(labeltotalprevu);
                labeltotalprevu.Location = new Point(30, 200);
                labeltotalprevu.Width = 200;
                //labeltotalprevu.Text = "Total d'heure prévue ce mois : 0";

                //Construteur Label pour le total Effectues par unité
                Label labeltotalreel = new Label();
                labeltotalreel.Name = "labeltotalprevu" + nb.ToString();
                UniteListe.TabPages[nb].Controls.Add(labeltotalreel);
                labeltotalreel.Location = new Point(280, 200);
                labeltotalreel.Width = 200;
                //labeltotalreel.Text = "Total d'heure effectuées ce mois : 0 ";

                //Calcul des totaux Prévu et Effectues
                double totalprevu = 0, totalreel = 0;
                foreach (acceuil acceuil in mydb.acceuil)
                {
                    if (acceuil.PrevuArriver.Value.Month==DateTime.Now.Month && acceuil.contrat.unite == unite)
                    {
                        if (acceuil.ReelDepart != null && acceuil.ReelArriver != null)
                        {   //calcul total Effectues
                            TimeSpan tempsReel = (DateTime)acceuil.ReelDepart - (DateTime)acceuil.ReelArriver;
                            totalreel += Convert.ToInt32(tempsReel.TotalHours);
                            if (tempsReel.Minutes > 0 && tempsReel.Minutes <= 30)
                                totalreel += 0.5;
                            else if (tempsReel.Minutes > 30 && tempsReel.Minutes <= 59)
                                totalreel += 1;
                        }
                        if (acceuil.PrevuDepart != null && acceuil.PrevuArriver != null)
                        {   //Calcul total Prévu
                            TimeSpan tempsprevu = (DateTime)acceuil.PrevuDepart - (DateTime)acceuil.PrevuArriver;
                            totalprevu += Convert.ToInt32(tempsprevu.TotalHours);
                            if (tempsprevu.Minutes > 0 && tempsprevu.Minutes <= 30)
                                totalprevu += 0.5;
                            else if (tempsprevu.Minutes > 30 && tempsprevu.Minutes <= 59)
                                totalprevu += 1;
                        }    
                    }               
                }
                //Affichage Total Prévu et Effectues
                    labeltotalreel.Text = "Total d'heure effectuées ce mois : " + totalreel.ToString();
                    labeltotalprevu.Text = "Total d'heure prévue ce mois :" + totalprevu.ToString();
                nb += 1;            
            }

            //Création ListBox avec Totals des Enfants par ordre Alphabétique
            foreach (enfant enfant in mydb.enfant)
                EnfantsTotal.Items.Add(enfant.NomEnfant + " " + enfant.PrenomEnfant);
            EnfantsTotal.Sorted = true;
        }

        private void EnfantDetail_Click(object sender, EventArgs e)
        {
            double TotalR=0, TotalP=0;
            foreach (acceuil acceuil in mydb.acceuil)
            {
                string gosse = acceuil.contrat.enfant.NomEnfant + " " + acceuil.contrat.enfant.PrenomEnfant;
                if (acceuil.PrevuArriver.Value.Month == DateTime.Now.Month && gosse ==EnfantsTotal.SelectedItem.ToString())
                {
                    if (acceuil.ReelDepart != null && acceuil.ReelArriver != null)
                    {   //calcul total Effectues De l'enfant
                        TimeSpan tempsReel = (DateTime)acceuil.ReelDepart - (DateTime)acceuil.ReelArriver;
                        TotalR += Convert.ToInt32(tempsReel.TotalHours);
                        if (tempsReel.Minutes > 0 && tempsReel.Minutes <= 30)
                            TotalR += 0.5;
                        else if (tempsReel.Minutes > 30 && tempsReel.Minutes <= 59)
                            TotalR += 1;
                    }
                    if (acceuil.PrevuDepart != null && acceuil.PrevuArriver != null)
                    {   //calcul total Prevu de l'enfant
                        TimeSpan tempsprevu = (DateTime)acceuil.PrevuDepart - (DateTime)acceuil.PrevuArriver;
                        TotalP += Convert.ToInt32(tempsprevu.TotalHours);
                       if (tempsprevu.Minutes > 0 && tempsprevu.Minutes <= 30)
                            TotalP += 0.5;
                       else if (tempsprevu.Minutes > 30 && tempsprevu.Minutes <= 59)
                            TotalP += 1;
                }
            }
                texteeffectuees.Text = TotalR.ToString();
                Texteprevue.Text = TotalP.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
          
        }
    }
}

