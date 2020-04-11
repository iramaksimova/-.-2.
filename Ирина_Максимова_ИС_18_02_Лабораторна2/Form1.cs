using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ирина_Максимова_ИС_18_02_Лабораторна2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RASSCHITAT_Click(object sender, EventArgs e)
        {
            double Edin = Convert.ToDouble(Number.Text);


            switch (Konvert1.SelectedIndex)
            {
                case 0:
                    if (Konvert2.SelectedIndex == 0)
                    {

                        MessageBox.Show(Edin.ToString() + " MM");
                    }

                    if (Konvert2.SelectedIndex == 1)
                    {
                        double PHEP = Edin / 100;

                        MessageBox.Show(PHEP.ToString() + " CM");
                    }
                    if (Konvert2.SelectedIndex == 2)
                    {
                        double HEp = Edin / 10000;
                        MessageBox.Show(HEp.ToString() + " DM");
                    }

                    if (Konvert2.SelectedIndex == 3)
                    {
                        double NET = Edin / 1000000;
                        MessageBox.Show(NET.ToString() + " M");
                    }
                    if (Konvert2.SelectedIndex == 4)
                    {
                        double pimp = Edin / 100000000;
                        MessageBox.Show(pimp.ToString() + " A");
                    }

                    if (Konvert2.SelectedIndex == 5)
                    {
                        double MEG = Edin / 10000000000;
                        MessageBox.Show(MEG.ToString() + " ГА");
                    }
                    if (Konvert2.SelectedIndex == 6)
                    {
                        double Drag = Edin / 1000000000000;
                        MessageBox.Show(Drag.ToString() + " KM");
                    }




                    break;
                case 1:
                    if (Konvert2.SelectedIndex == 0)
                    {
                        double X = Edin * 100;

                        MessageBox.Show(X.ToString() + " MM");
                    }

                    if (Konvert2.SelectedIndex == 1)
                    {


                        MessageBox.Show(Edin.ToString());
                    }
                    if (Konvert2.SelectedIndex == 2)
                    {
                        double HEp = Edin / 100;
                        MessageBox.Show(HEp.ToString() + " DM");
                    }

                    if (Konvert2.SelectedIndex == 3)
                    {
                        double NET = Edin / 10000;
                        MessageBox.Show(NET.ToString() + " M");
                    }
                    if (Konvert2.SelectedIndex == 4)
                    {
                        double pimp = Edin / 1000000;
                        MessageBox.Show(pimp.ToString() + " A");
                    }

                    if (Konvert2.SelectedIndex == 5)
                    {
                        double MEG = Edin / 100000000;
                        MessageBox.Show(MEG.ToString() + " ГА");
                    }
                    if (Konvert2.SelectedIndex == 6)
                    {
                        double Drag = Edin / 10000000000;
                        MessageBox.Show(Drag.ToString() + " KM");
                    }




                    break;
                case 2:
                    if (Konvert2.SelectedIndex == 0)
                    {
                        double X = Edin * 10000;

                        MessageBox.Show(Edin.ToString() + " MM");
                    }

                    if (Konvert2.SelectedIndex == 1)
                    {
                        double PHEP = Edin * 100;

                        MessageBox.Show(PHEP.ToString() + " CM");
                    }
                    if (Konvert2.SelectedIndex == 2)
                    {

                        MessageBox.Show(Edin.ToString() + "DM");
                    }

                    if (Konvert2.SelectedIndex == 3)
                    {
                        double NET = Edin / 100;
                        MessageBox.Show(NET.ToString() + " M");
                    }
                    if (Konvert2.SelectedIndex == 4)
                    {
                        double pimp = Edin / 10000;
                        MessageBox.Show(pimp.ToString() + " A");
                    }

                    if (Konvert2.SelectedIndex == 5)
                    {
                        double MEG = Edin / 1000000;
                        MessageBox.Show(MEG.ToString() + " ГА");
                    }
                    if (Konvert2.SelectedIndex == 6)
                    {
                        double Drag = Edin / 100000000;
                        MessageBox.Show(Drag.ToString() + " KM");
                    }




                    break;

                case 3:
                    if (Konvert2.SelectedIndex == 0)
                    {
                        double X = Edin * 1000000;
                        MessageBox.Show(X.ToString() + " MM");
                    }

                    if (Konvert2.SelectedIndex == 1)
                    {
                        double PHEP = Edin * 10000;

                        MessageBox.Show(PHEP.ToString() + " CM");
                    }
                    if (Konvert2.SelectedIndex == 2)
                    {
                        double HEp = Edin * 100;
                        MessageBox.Show(HEp.ToString() + " DM");
                    }

                    if (Konvert2.SelectedIndex == 3)
                    {

                        MessageBox.Show(Edin.ToString() + " M");
                    }
                    if (Konvert2.SelectedIndex == 4)
                    {
                        double pimp = Edin / 100;
                        MessageBox.Show(pimp.ToString() + " A");
                    }

                    if (Konvert2.SelectedIndex == 5)
                    {
                        double MEG = Edin / 10000;
                        MessageBox.Show(MEG.ToString() + " ГА");
                    }
                    if (Konvert2.SelectedIndex == 6)
                    {
                        double Drag = Edin / 1000000;
                        MessageBox.Show(Drag.ToString() + " KM");
                    }




                    break;

                case 4:
                    if (Konvert2.SelectedIndex == 0)
                    {
                        double X = Edin * 100000000;
                        MessageBox.Show(X.ToString() + " MM");
                    }

                    if (Konvert2.SelectedIndex == 1)
                    {
                        double PHEP = Edin * 1000000;

                        MessageBox.Show(PHEP.ToString() + " CM");
                    }
                    if (Konvert2.SelectedIndex == 2)
                    {
                        double HEp = Edin * 10000;
                        MessageBox.Show(HEp.ToString() + " DM");
                    }

                    if (Konvert2.SelectedIndex == 3)
                    {
                        double NET = Edin * 100;
                        MessageBox.Show(NET.ToString() + " M");
                    }
                    if (Konvert2.SelectedIndex == 4)
                    {

                        MessageBox.Show(Edin.ToString() + " A");
                    }

                    if (Konvert2.SelectedIndex == 5)
                    {
                        double MEG = Edin / 100;

                        MessageBox.Show(MEG.ToString() + " ГА");
                    }
                    if (Konvert2.SelectedIndex == 6)
                    {
                        double Drag = Edin / 10000;
                        MessageBox.Show(Drag.ToString() + " KM");
                    }




                    break;

                case 5:
                    if (Konvert2.SelectedIndex == 0)
                    {
                        double X = Edin * 10000000000;

                        MessageBox.Show(X.ToString() + " MM");
                    }

                    if (Konvert2.SelectedIndex == 1)
                    {
                        double PHEP = Edin * 100000000;

                        MessageBox.Show(PHEP.ToString() + " CM");
                    }
                    if (Konvert2.SelectedIndex == 2)
                    {
                        double HEp = Edin * 1000000;
                        MessageBox.Show(HEp.ToString() + " DM");
                    }

                    if (Konvert2.SelectedIndex == 3)
                    {
                        double NET = Edin * 10000;
                        MessageBox.Show(NET.ToString() + " M");
                    }
                    if (Konvert2.SelectedIndex == 4)
                    {
                        double pimp = Edin * 100;
                        MessageBox.Show(pimp.ToString() + " A");
                    }

                    if (Konvert2.SelectedIndex == 5)
                    {
                        MessageBox.Show(Edin.ToString() + " ГА");
                    }
                    if (Konvert2.SelectedIndex == 6)
                    {
                        double Drag = Edin * 100;
                        MessageBox.Show(Drag.ToString() + " KM");
                    }




                    break;
            }

        }

        private void Konvert1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

        
    

