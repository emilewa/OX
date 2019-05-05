using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OX
{
    

    public partial class Form1 : Form
    {
        public int idgracza = 1;
        public int[] gra = new int[10];
        public int wygrana;
        public Form1()
        {
            InitializeComponent();
            nowagra();
        }
        private Boolean sprawdz()
        {
           Boolean odp = false;

            for(int i=1,j=1; i<=3; i++)
            {
                
                if (gra[j] == gra[j + 1] && gra[j + 1] == gra[j + 2] && gra[j]!=0)
                    odp = true;
                else
                if (gra[i] == gra[i + 3] && gra[i + 3] == gra[i + 6] && gra[i]!=0)
                    odp = true;

                j = j + 3;
            }

            if (gra[1] == gra[5] && gra[5] == gra[9] && gra[1] != 0)
                    odp = true;
            if (gra[3] == gra[5] && gra[5] == gra[7] && gra[7] != 0)
                    odp = true;

            return odp;
        }

        private void nowagra()
        {
            for (int i = 1; i<=9 ; ++i)
            {
                gra[i] = 0;

            }

            p1.Text = " ";
            p2.Text = " ";
            p3.Text = " ";
            p4.Text = " ";
            p5.Text = " ";
            p6.Text = " ";
            p7.Text = " ";
            p8.Text = " ";
            p9.Text = " ";

            p1.BackgroundImage = null;
            p2.BackgroundImage = null;
            p3.BackgroundImage = null;
            p4.BackgroundImage = null;
            p5.BackgroundImage = null;
            p6.BackgroundImage = null;
            p7.BackgroundImage = null;
            p8.BackgroundImage = null;
            p9.BackgroundImage = null;

            p1.Enabled = true;
            p2.Enabled = true;
            p3.Enabled = true;
            p4.Enabled = true;
            p5.Enabled = true;
            p6.Enabled = true;
            p7.Enabled = true;
            p8.Enabled = true;
            p9.Enabled = true;

            label1.ForeColor = Color.Black;
            label1.Text = "Ruch gracza: " + idgracza;
        }

        private Boolean remis()
        {
            Boolean stan = true;
            for(int i = 1; i<=9; ++i)
            {
                if (gra[i] == 0) stan = false;
            }
            return stan;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nowagra();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nieklik()
        {
            p1.Enabled = false;
            p2.Enabled = false;
            p3.Enabled = false;
            p4.Enabled = false;
            p5.Enabled = false;
            p6.Enabled = false;
            p7.Enabled = false;
            p8.Enabled = false;
            p9.Enabled = false;
        }

        public Image O = new Bitmap(@"C:\\Users\\Emilia\\Documents\\Visual Studio 2015\\Projects\\Gra_OX\\OX\\omin.png");
        public Image X = new Bitmap(@"C:\\Users\\Emilia\\Documents\\Visual Studio 2015\\Projects\\Gra_OX\\OX\\xmin.png");

        private void obr(string x)
        {

            
        }


        private void p1_Click(object sender, EventArgs e)
        {
    

            gra[1] = idgracza;
            p1.Text = "" + gra[1];
            if (idgracza == 1)
                p1.BackgroundImage = O;
            else p1.BackgroundImage = X;
            if (sprawdz())
            {
                label1.BorderStyle = BorderStyle.Fixed3D;
                label1.ForeColor = Color.Blue;
                label1.Text = "Wygrywa gracz "+idgracza+" !!!";
                nieklik();
            }
            else
            {
            if (idgracza == 1)
                idgracza = 2;
            else idgracza = 1;
            label1.Text = "Ruch gracza: " + idgracza;
            p1.Enabled = false;
            }

            if (remis())
                label1.Text = "Remis ;/";



        }

        private void p2_Click(object sender, EventArgs e)
        {
            
            

            gra[2] = idgracza;
            p2.Text = "" + gra[2];
            if (idgracza == 1)
                p2.BackgroundImage = O;
            else p2.BackgroundImage = X;
            if (sprawdz())
            {
                label1.BorderStyle = BorderStyle.Fixed3D;
                label1.ForeColor = Color.Blue;
                label1.Text = "Wygrywa gracz " + idgracza + " !!!";
                nieklik();
            }
            else
            {
                if (idgracza == 1)
                idgracza = 2;
                else idgracza = 1;
                label1.Text = "Ruch gracza: " + idgracza;
                p2.Enabled = false;
                if (remis())
                label1.Text = "Remis ;/";
            }
            

        }

        private void p3_Click(object sender, EventArgs e)
        {
            gra[3] = idgracza;
            p3.Text = "" + gra[3];
            if (idgracza == 1)
                p3.BackgroundImage = O;
            else p3.BackgroundImage = X;
            if (sprawdz())
            {
                label1.BorderStyle = BorderStyle.Fixed3D;
                label1.ForeColor = Color.Blue;
                label1.Text = "Wygrywa gracz " + idgracza + " !!!";
                nieklik();
            }
            else
            {
                 if (idgracza == 1)
                    idgracza = 2;
                    else idgracza = 1;
                label1.Text = "Ruch gracza: " + idgracza;
                p3.Enabled = false;
                if (remis())
                label1.Text = "Remis ;/";
            }

            
        }

        private void p4_Click(object sender, EventArgs e)
        {
            gra[4] = idgracza;
            p4.Text = "" + gra[4];
            if (idgracza == 1)
                p4.BackgroundImage = O;
            else p4.BackgroundImage = X;
            if (sprawdz())
            {
                label1.BorderStyle = BorderStyle.Fixed3D;
                label1.ForeColor = Color.Blue;
                label1.Text = "Wygrywa gracz " + idgracza + " !!!";
                nieklik();
            }
            else
            {
                if (idgracza == 1)
                    idgracza = 2;
                    else idgracza = 1;
                label1.Text = "Ruch gracza: " + idgracza;
                p4.Enabled = false;
                if (remis())
                label1.Text = "Remis ;/";

            }

            
        }

        private void p5_Click(object sender, EventArgs e)
        {
            gra[5] = idgracza;
            p5.Text = "" + gra[5];
            if (idgracza == 1)
                p5.BackgroundImage = O;
            else p5.BackgroundImage = X;
            if (sprawdz())
            {
                label1.BorderStyle = BorderStyle.Fixed3D;
                label1.ForeColor = Color.Blue;
                label1.Text = "Wygrywa gracz " + idgracza + " !!!";
                nieklik();
            }
            else
            {
               if (idgracza == 1)
                    idgracza = 2;
                else idgracza = 1;
                label1.Text = "Ruch gracza: " + idgracza;
                p5.Enabled = false;
                if (remis())
                label1.Text = "Remis ;/";
            }

            
        }

        private void p6_Click(object sender, EventArgs e)
        {
            gra[6] = idgracza;
            p6.Text = "" + gra[6];
            if (idgracza == 1)
                p6.BackgroundImage = O;
            else p6.BackgroundImage = X;
            if (sprawdz())
            {
                label1.BorderStyle = BorderStyle.Fixed3D;
                label1.ForeColor = Color.Blue;
                label1.Text = "Wygrywa gracz " + idgracza + " !!!";
                nieklik();
            }
            else
            {
                if (idgracza == 1)
                    idgracza = 2;
                else idgracza = 1;
                label1.Text = "Ruch gracza: " + idgracza;
                p6.Enabled = false;
                if (remis())
                label1.Text = "Remis ;/";
            }

            

        }

        private void p7_Click(object sender, EventArgs e)
        {
            gra[7] = idgracza;
            p7.Text = ""+gra[7];
            if (idgracza == 1)
                p7.BackgroundImage = O;
            else p7.BackgroundImage = X;
            if (sprawdz())
            {
                label1.BorderStyle = BorderStyle.Fixed3D;
                label1.ForeColor = Color.Blue;
                label1.Text = "Wygrywa gracz " + idgracza + " !!!";
                nieklik();
            }
            else
            {
                if (idgracza == 1)
                    idgracza = 2;
                else idgracza = 1;
                label1.Text = "Ruch gracza: " + idgracza;
                p7.Enabled = false;
                if (remis())
                label1.Text = "Remis ;/";
            }

       
        }

        private void p8_Click(object sender, EventArgs e)
        {
            gra[8] = idgracza;
            p8.Text = "" + gra[8];
            if (idgracza == 1)
                p8.BackgroundImage = O;
            else p8.BackgroundImage = X;
            if (sprawdz())
            {
                label1.BorderStyle = BorderStyle.Fixed3D;
                label1.ForeColor = Color.Blue;
                label1.Text = "Wygrywa gracz " + idgracza + " !!!";
                nieklik();
            }
            else
            {
                if (idgracza == 1)
                     idgracza = 2;
                    else idgracza = 1;
                label1.Text = "Ruch gracza: " + idgracza;
                 p8.Enabled = false;
                if (remis())
                label1.Text = "Remis ;/";
            }
            

        }

        private void p9_Click(object sender, EventArgs e)
        {

            gra[9] = idgracza;
            p9.Text = "" + gra[9];
            if (idgracza == 1)
                p9.BackgroundImage = O;
            else p9.BackgroundImage = X;
            if (sprawdz())
            {
                label1.BorderStyle = BorderStyle.Fixed3D;
                label1.ForeColor = Color.Blue;
                label1.Text = "Wygrywa gracz " + idgracza + " !!!";
                nieklik();
            }
            else
            {
            if (idgracza == 1)
                idgracza = 2;
            else idgracza = 1;
                label1.Text = "Ruch gracza: " + idgracza;
                p9.Enabled = false;
                if (remis())
                label1.Text = "Remis ;/";
            }
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
