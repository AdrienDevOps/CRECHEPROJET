using Org.BouncyCastle.Asn1.Crmf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRECHEPROJET
{
    public partial class Form1 : Form
    {
  
        private int nbcreche=1;
        private creche creche;
        public List<Control> ButtonEnfants = new List<Control>();
        public Control ButtonEnfant;
        private List<string> DateDeNaissanceValue= new List<string>();
        private int H=0, L=0;
        public mydbEntities Bdd;
        public Button boutonchoisie;
  
        public Form1()
        {
            InitializeComponent();
            Bdd = new mydbEntities();
        }
       
        private void ChangeCreche()
        {
            //Affichage et Mise à jour  des Unités de la crèche, de la couleur arrière plan)
            CrecheAffiche.Text = creche.ToString();
            UniteList.TabPages.Clear();
            int UniteNumero = 0;
            H = 0;
            L = 0;
            foreach (unite unite in creche.unite.ToList())
            {
                UniteList.TabPages.Add(unite.ToString());
                UniteList.TabPages[UniteNumero].BackColor = unite.GetColor();
                //je selectionne les contrats de l'unité
                foreach (contrat contrat in Bdd.contrat.ToList())
                {                    
                    if(contrat.IDUnite== unite.IDUnite)
                    {
                        var acceuilsAttendus = from acceuil in contrat.acceuil
                                               where acceuil.PrevuArriver.Value.Date == DateTime.Now.Date
                                               select acceuil;
                        foreach (acceuil acceuil in acceuilsAttendus.ToList())
                        {
                            CreateButton(acceuil);
                        }
                    }
                }
                // je selectionne les contrats à l'ordre du jour
                UniteNumero += 1;
            }     
        }
        private void CreateButton(acceuil acceuil)
        {
            ButtonEnfant = new Button();
            ButtonEnfant.BackColor = acceuil.GetColorBoutton();
            ButtonEnfant.Text = acceuil.GetTextBoutton();
            ButtonEnfant.Width = 150;
            ButtonEnfant.Height = 85;
            ButtonEnfant.Location = new Point(H , L );
            ButtonEnfant.Tag = acceuil;
            ButtonEnfant.Click += ClicK_Buttun ;
            Label Labelprevu = new Label() ;
            ButtonEnfant.Controls.Add(Labelprevu) ;;
            Labelprevu.Height = 13;
            Labelprevu.Text = "Prévu         Reel" ;
            Labelprevu.Location = new Point(30, 34);
            Labelprevu.Font = new Font(this.Font.Name, 7);
            if(H==620)
            {
                L += 90;
                H = 0;       
            }
            else
             H += 155;          
            UniteList.SelectedTab.Controls.Add(ButtonEnfant);          
        }

        private void ClicK_Buttun(object sender, EventArgs e)
        {
            boutonchoisie = (Button)sender;
            UniteList.Enabled = false;
            CrecheAffiche.Enabled = false;
            MotDePasse.Show();           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Initialisation
            temps.Text = DateTime.Now.ToShortTimeString();
            creche = Bdd.creche.Distinct().First();
            ChangeCreche();
        }
        //Timeur qui actualise l'horloge
        private void timer_Tick(object sender, EventArgs e)
        {
            temps.Text = DateTime.Now.ToShortTimeString();
        }

        private void ValideMdp(object sender, EventArgs e)
        {
            acceuil test = (acceuil)(boutonchoisie.Tag);
            int verif = 0;
            while (DateDeNaissanceValue.Count < 8)
                DateDeNaissanceValue.Add("o");
            foreach (enfant gosse in Bdd.enfant.ToList())
            {
                if (gosse.IDenfant == test.contrat.enfant.IDenfant)
                { 
                    if (DateDeNaissanceValue[0] == "0")
                        DateDeNaissanceValue[0] = "";
                    if (DateDeNaissanceValue[2] == "0")
                        DateDeNaissanceValue[2] = "";
                    if (gosse.Datedenaissance.Value.Year.ToString() == (DateDeNaissanceValue[4] + DateDeNaissanceValue[5] + DateDeNaissanceValue[6] + DateDeNaissanceValue[7]) && gosse.Datedenaissance.Value.Month.ToString() == (DateDeNaissanceValue[2] + DateDeNaissanceValue[3]) && gosse.Datedenaissance.Value.Day.ToString() == DateDeNaissanceValue[0] + DateDeNaissanceValue[1])
                    {
                        MessageBox.Show("Connection Réussi !");
                        if (boutonchoisie.BackColor == Color.Green)
                        {
                            boutonchoisie.BackColor = Color.Cyan;
                            verif = 1;
                            test.ReelDepart = DateTime.Now;
                            boutonchoisie.Text = test.contrat.enfant.NomEnfant + "   " + test.contrat.enfant.PrenomEnfant + "\n" + "\n" + "\n" + test.PrevuArriver.Value.ToShortTimeString() + "          " + test.ReelArriver.Value.ToShortTimeString() + "\n" + test.PrevuDepart.Value.ToShortTimeString() + "          " + test.ReelDepart.Value.ToShortTimeString();
                        }
                        else if (boutonchoisie.BackColor == Color.Gray)
                        {
                            verif = 2;
                            boutonchoisie.BackColor = Color.Green;
                            test.ReelArriver = DateTime.Now;
                            boutonchoisie.Text = test.contrat.enfant.NomEnfant + "   " + test.contrat.enfant.PrenomEnfant + "\n" + "\n" + "\n" + test.PrevuArriver.Value.ToShortTimeString() + "          " + test.ReelArriver.Value.ToShortTimeString() + "\n" + test.PrevuDepart.Value.ToShortTimeString() + "          " + "00:00";
                        }
                        MotDePasse.Hide();
                        UniteList.Enabled = true;
                        CrecheAffiche.Enabled = true;
                        
                    }
                    else
                        MessageBox.Show("Mauvaise Date De naissance");
                    BoiteADate.Text = "";
                    DateDeNaissanceValue.Clear();
                }
            }
            foreach (acceuil acceuil in Bdd.acceuil.ToList())
            {
                if (acceuil.IDacceuil == test.IDacceuil)
                {
                    if (verif == 1)
                        acceuil.ReelDepart = DateTime.Now;
                    if (verif==2)
                        acceuil.ReelArriver = DateTime.Now;
                    Bdd.SaveChanges();
                }
            }
        }

        private void FermeMotDePasse(object sender, MouseEventArgs e)
        {
            MotDePasse.Hide();
            UniteList.Enabled = true;
            CrecheAffiche.Enabled = true;

        }
        private void DateDeNaissancemodif(string nb)
        {

            if (BoiteADate.Text.Count() == 2 || BoiteADate.Text.Count() == 7)
                BoiteADate.Text += " / " + nb;    
            else if (BoiteADate.Text.Count() < 14)
                BoiteADate.Text += nb;
            DateDeNaissanceValue.Add(nb);
        }
        private void b1_Click(object sender, EventArgs e)
        {
            DateDeNaissancemodif("1");
        }

        private void b2_Click(object sender, EventArgs e)
        {
            DateDeNaissancemodif("2");
        }

        private void b3_Click(object sender, EventArgs e)
        {
            DateDeNaissancemodif("3");
        }

        private void b4_Click(object sender, EventArgs e)
        {
            DateDeNaissancemodif("4");
        }

        private void b5_Click(object sender, EventArgs e)
        {
            DateDeNaissancemodif("5");
        }

        private void b6_Click(object sender, EventArgs e)
        {
            DateDeNaissancemodif("6");
        }

        private void b7_Click(object sender, EventArgs e)
        {
            DateDeNaissancemodif("7");
        }

        private void b8_Click(object sender, EventArgs e)
        {
            DateDeNaissancemodif("8");
        }

        private void b9_Click(object sender, EventArgs e)
        {
            DateDeNaissancemodif("9");
        }

        private void b0_Click(object sender, EventArgs e)
        {
            DateDeNaissancemodif("0");
        }

        private void bsupp_Click(object sender, EventArgs e)
        {
            BoiteADate.Text = "";
            DateDeNaissanceValue.Clear();
        }

        private void FermerMotDePasse_Click(object sender, EventArgs e)
        {

        }

        private void TDB_Click(object sender, EventArgs e)
        {
            //Génération du tableau de bord
            TableauDeBord tableauDeBord = new TableauDeBord(UniteList,creche,Bdd);
            tableauDeBord.Show();
        }

        private void CrecheAffiche_Click(object sender, EventArgs e)
        {
           //Chaque fois que je change de Crèche
           creche = Bdd.creche.Find(nbcreche);
           ChangeCreche();
           if (nbcreche >= Bdd.creche.Count())
               nbcreche = 1;
           else
           nbcreche += 1;
        }
    }
}
