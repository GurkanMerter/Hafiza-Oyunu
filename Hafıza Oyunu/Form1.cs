using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Hafıza_Oyunu
{
    public partial class Form1 : Form
    {
        int[] Dizi = new int[36];
        string[] ResimDizi = new string[18];
        Button[,] btndizi = new Button[6, 6];
        
        int ZorlukKatsayısı;
        List<string> BulunanResimler = new List<string>();
        int TiklanmaKontrol = 0;
        Button ilkButton = new Button(); 
        Button ikinciButton = new Button();
     
        

        public Form1()
        {
            InitializeComponent();
        }

        private void BaslatButon_Click(object sender, EventArgs e)
        {

            if (RadioKolay.Checked == true)
            {
                label2.Text = "Kolay Seçtiniz";
                BulunanResimler.Clear();
                ZorlukKatsayısı = 2;
                timer1.Interval = 1000;
            }
            else if (RadioOrta.Checked == true)
            {
                label2.Text = "Orta Seçtiniz";
                BulunanResimler.Clear();
                ZorlukKatsayısı = 4;
                timer1.Interval = 500;
            }
            else if (RadioZor.Checked == true)
            {
                label2.Text = "Zor Seçtiniz";
                BulunanResimler.Clear();
                ZorlukKatsayısı = 6;
                timer1.Interval = 200;
            }

            ResimDiziOlustur();
            DiziOlustur(ZorlukKatsayısı * ZorlukKatsayısı);
            ButonOlustur(ZorlukKatsayısı);
            BaslatButon.Enabled = false;
            RadioKolay.Enabled = false;
            RadioOrta.Enabled = false;
            RadioZor.Enabled = false;
            YenidenBasla.Enabled = true;
            
        }

        private void YenidenBasla_Click(object sender, EventArgs e)
        {
            BaslatButon.Enabled = true;
            RadioKolay.Checked = false;
            RadioOrta.Checked = false;
            RadioZor.Checked = false;
            RadioKolay.Enabled = true;
            RadioOrta.Enabled = true;
            RadioZor.Enabled = true;
            YenidenBasla.Enabled = false;
            label2.Text = "";
            panel1.Controls.Clear();

        }

        public void ButonOlustur(int x)
        {

            int DiziDekiSayi, index = 0;

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {

                    DiziDekiSayi = Dizi[index];
                    index++;
                    btndizi[i, j] = new Button();
                    btndizi[i, j].Size = new Size(150, 110);
                    btndizi[i, j].BackgroundImage = global::Hafıza_Oyunu.Properties.Resources.kartarkasi;
                    btndizi[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                    btndizi[i, j].FlatStyle = FlatStyle.Flat;
                    btndizi[i, j].Name = DiziDekiSayi.ToString();
                    btndizi[i, j].Click += new EventHandler(tiklanmaController);
                    btndizi[i, j].Location = new Point(150 * (j), 110 * (i));
                    panel1.Controls.Add(btndizi[i, j]);
                }
            }
        }

        private void tiklanmaController(object sender, EventArgs e)
        {
            Button button = sender as Button;
            
            button.BackgroundImage = Image.FromFile(ResimDizi[Convert.ToInt32(button.Name)]);
            button.BackgroundImageLayout = ImageLayout.Stretch;
            button.Enabled = false;
            TiklanmaKontrol++;
            if (TiklanmaKontrol < 2)
            {
                ilkButton = button;

            }
            else if (TiklanmaKontrol == 2)
            {
                TiklanmaKontrol = 0;
                ikinciButton = button;
                if (ilkButton.Name==ikinciButton.Name)
                {
                    BulunanResimler.Add(ikinciButton.Name);
                    SonucKontrol();
                }
                else
                {
                    ButonlariKapat();
                    timer1.Start();
                }

            }

        }

        public void YanlisFotoyuKapat()
        {
            ilkButton.BackgroundImage = global::Hafıza_Oyunu.Properties.Resources.kartarkasi;
            ikinciButton.BackgroundImage = global::Hafıza_Oyunu.Properties.Resources.kartarkasi;
        }
        public void ButonlariAc()
        {
            for (int i = 0; i < ZorlukKatsayısı; i++)
            {
                for (int j = 0; j < ZorlukKatsayısı; j++)
                {
                    if (!BulunanResimler.Contains(btndizi[i, j].Name))
                    {
                        btndizi[i, j].Enabled = true;
                    }

                }
            }
        }

        public void ButonlariKapat()
        {

            for (int i = 0; i < ZorlukKatsayısı; i++)
            {
                for (int j = 0; j < ZorlukKatsayısı; j++)
                {
                    btndizi[i, j].Enabled = false;
                }
            }
        }
        public void SonucKontrol()
        {
            if (BulunanResimler.Count == (ZorlukKatsayısı * ZorlukKatsayısı) / 2)
            {
                MessageBox.Show("Tebrikler Oyunu Bitirdiniz.");
            }
        }

        public void DiziOlustur(int y)
        {

            Random random = new Random();
            for (int i = 0; i < y; i++)
            {
                if (i == 0)
                {
                    Dizi[i] = random.Next(0, (y / 2));
                }
                else
                {
                    int sayac = 0;
                    int randomsayi2 = random.Next(0, (y / 2));
                    for (int j = 0; j < i; j++)
                    {
                        if (Dizi[j] == randomsayi2)
                        {
                            sayac++;
                        }
                    }
                    if (sayac < 2)
                    {
                        Dizi[i] = randomsayi2;
                    }
                    else
                    {
                        i = i - 1;
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            YanlisFotoyuKapat();
            ButonlariAc();
        }  
        public void ResimDiziOlustur()
        {

            ResimDizi[0] = @"C:\Users\MONSTER\source\repos\Hafıza Oyunu\Hafıza Oyunu\Resimler\aslan.png";
            ResimDizi[1] = @"C:\Users\MONSTER\source\repos\Hafıza Oyunu\Hafıza Oyunu\Resimler\at.png";
            ResimDizi[2] = @"C:\Users\MONSTER\source\repos\Hafıza Oyunu\Hafıza Oyunu\Resimler\ayı.png";
            ResimDizi[3] = @"C:\Users\MONSTER\source\repos\Hafıza Oyunu\Hafıza Oyunu\Resimler\balina.png";
            ResimDizi[4] = @"C:\Users\MONSTER\source\repos\Hafıza Oyunu\Hafıza Oyunu\Resimler\black jaguar.png";
            ResimDizi[5] = @"C:\Users\MONSTER\source\repos\Hafıza Oyunu\Hafıza Oyunu\Resimler\civciv.png";
            ResimDizi[6] = @"C:\Users\MONSTER\source\repos\Hafıza Oyunu\Hafıza Oyunu\Resimler\davuk.png";
            ResimDizi[7] = @"C:\Users\MONSTER\source\repos\Hafıza Oyunu\Hafıza Oyunu\Resimler\geyik.png";
            ResimDizi[8] = @"C:\Users\MONSTER\source\repos\Hafıza Oyunu\Hafıza Oyunu\Resimler\inek.png";
            ResimDizi[9] = @"C:\Users\MONSTER\source\repos\Hafıza Oyunu\Hafıza Oyunu\Resimler\kaplan.png";
            ResimDizi[10] = @"C:\Users\MONSTER\source\repos\Hafıza Oyunu\Hafıza Oyunu\Resimler\karides.png";
            ResimDizi[11] = @"C:\Users\MONSTER\source\repos\Hafıza Oyunu\Hafıza Oyunu\Resimler\kartal.png";
            ResimDizi[12] = @"C:\Users\MONSTER\source\repos\Hafıza Oyunu\Hafıza Oyunu\Resimler\Kedi.jpg";
            ResimDizi[13] = @"C:\Users\MONSTER\source\repos\Hafıza Oyunu\Hafıza Oyunu\Resimler\köpke.png";
            ResimDizi[14] = @"C:\Users\MONSTER\source\repos\Hafıza Oyunu\Hafıza Oyunu\Resimler\kurt.png";
            ResimDizi[15] = @"C:\Users\MONSTER\source\repos\Hafıza Oyunu\Hafıza Oyunu\Resimler\panda.png";
            ResimDizi[16] = @"C:\Users\MONSTER\source\repos\Hafıza Oyunu\Hafıza Oyunu\Resimler\penguen.png";
            ResimDizi[17] = @"C:\Users\MONSTER\source\repos\Hafıza Oyunu\Hafıza Oyunu\Resimler\tilki.png";
        }

    }
}