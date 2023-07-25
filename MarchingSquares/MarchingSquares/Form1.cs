
using System.Windows.Forms;

namespace MarchingSquares
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ColorDialog colorDialog = new ColorDialog();
        Color kalemRengi = Color.Red;
        int baslangicNokY = 0, baslangicNokX = 0;
        int noktaUzaklik = 20;
        int xEkseniNoktaSayisi = 40;
        int yEkseniNoktaSayisi = 40;
        int kalemKalinligi = 2;
        int Oran = 50;
        int[,] Terrain;
        int i = 0, j = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Dock = DockStyle.Fill;
            panel1.Dock = DockStyle.Right;

            listBox1.Items.Clear();
            Terrain = new int[yEkseniNoktaSayisi, xEkseniNoktaSayisi];
            for (int i = 0; i < yEkseniNoktaSayisi; i++)
            {
                for (int j = 0; j < xEkseniNoktaSayisi; j++)
                {
                    Random rnd = new Random();
                    if(rnd.Next(0, 100) < Oran)
                    {
                        Terrain[i, j] = 1;
                    }
                    else
                    {
                        Terrain[i, j] = 0;
                    }
                    


                    listBox1.Items.Add(Terrain[i, j]);
                }
                listBox1.Items.Add("---------");

            }

            for (i = 0; i < yEkseniNoktaSayisi - 1; i++)
            {
                for (j = 0; j < xEkseniNoktaSayisi - 1; j++)
                {
                    int durum = DurumHesapla(Terrain[i + 1, j], Terrain[i + 1, j + 1], Terrain[i, j + 1], Terrain[i, j]);
                    CizimYap(durum);
                }
            }
        }


        int DurumHesapla(int a, int b, int c, int d)
        {
            return a * 1 + b * 2 + c * 4 + d * 8;
        }

        void CizimYap(int durum)
        {
            Pen pen1 = new Pen(kalemRengi, kalemKalinligi);
            Graphics grakik = CreateGraphics();
            switch (durum)
            {
                case 0:
                    {


                    }
                    break;
                case 1:
                    {
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik / 2, (j * noktaUzaklik) + baslangicNokX, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik, (j * noktaUzaklik) + baslangicNokX);
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik, (j * noktaUzaklik) + baslangicNokX, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik / 2);
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik / 2, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik / 2, (j * noktaUzaklik) + baslangicNokX);

                    }
                    break;
                case 2:
                    {
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik / 2, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik);
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik / 2, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik);
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik / 2, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik / 2, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik);
                    }
                    break;
                case 3:
                    {
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik / 2, (j * noktaUzaklik) + baslangicNokX, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik / 2, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik);
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik / 2, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik);
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik, (j * noktaUzaklik) + baslangicNokX);
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik, (j * noktaUzaklik) + baslangicNokX, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik / 2, (j * noktaUzaklik) + baslangicNokX);

                    }
                    break;
                case 4:
                    {
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokY, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik / 2, (i * noktaUzaklik) + baslangicNokY, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik);
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokY, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik / 2, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik);
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik / 2, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik, (i * noktaUzaklik) + baslangicNokY, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik / 2);


                    }
                    break;
                case 5:
                    {
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokY, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik / 2, (i * noktaUzaklik) + baslangicNokY, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik);
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokY, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik / 2, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik);
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik / 2, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik / 2);
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik / 2, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik / 2, (j * noktaUzaklik) + baslangicNokX);
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik / 2, (j * noktaUzaklik) + baslangicNokX, (i * noktaUzaklik) + baslangicNokY, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik / 2);


                    }
                    break;
                case 6:
                    {
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokY, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik / 2, (i * noktaUzaklik) + baslangicNokY, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik);
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokY, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik);
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik / 2);
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik / 2, (i * noktaUzaklik) + baslangicNokY, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik / 2);

                    }
                    break;
                case 7:
                    {
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik / 2, (j * noktaUzaklik) + baslangicNokX, (i * noktaUzaklik) + baslangicNokY, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik / 2);
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokY, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik / 2, (i * noktaUzaklik) + baslangicNokY, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik);
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokY, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik);
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik, (j * noktaUzaklik) + baslangicNokX);
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik, (j * noktaUzaklik) + baslangicNokX, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik / 2, (j * noktaUzaklik) + baslangicNokX);


                    }
                    break;
                case 8:
                    {
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokY, (j * noktaUzaklik) + baslangicNokX, (i * noktaUzaklik) + baslangicNokY, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik / 2);
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokY, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik / 2, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik / 2, (j * noktaUzaklik) + baslangicNokX);
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik / 2, (j * noktaUzaklik) + baslangicNokX, (i * noktaUzaklik) + baslangicNokY, (j * noktaUzaklik) + baslangicNokX);

                    }
                    break;
                case 9:
                    {
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokY, (j * noktaUzaklik) + baslangicNokX, (i * noktaUzaklik) + baslangicNokY, (j * noktaUzaklik) + baslangicNokX + (noktaUzaklik / 2));
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokY, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik / 2, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik / 2);
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik / 2, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik, (j * noktaUzaklik) + baslangicNokX);
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik, (j * noktaUzaklik) + baslangicNokX, (i * noktaUzaklik) + baslangicNokY, (j * noktaUzaklik) + baslangicNokX);

                    }
                    break;
                case 10:
                    {
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokY, (j * noktaUzaklik) + baslangicNokX, (i * noktaUzaklik) + baslangicNokY, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik / 2);
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokY, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik / 2, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik / 2, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik);
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik / 2, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik);
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik / 2);
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik / 2, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik / 2, (j * noktaUzaklik) + baslangicNokX);
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik / 2, (j * noktaUzaklik) + baslangicNokX, (i * noktaUzaklik) + baslangicNokY, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik / 2);

                    }
                    break;
                case 11:
                    {
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokY, (j * noktaUzaklik) + baslangicNokX, (i * noktaUzaklik) + baslangicNokY, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik / 2);
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokY, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik / 2, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik / 2, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik);
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik / 2, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik);
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik, (j * noktaUzaklik) + baslangicNokX);
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik, (j * noktaUzaklik) + baslangicNokX, (i * noktaUzaklik) + baslangicNokY, (j * noktaUzaklik) + baslangicNokX);


                    }
                    break;
                case 12:
                    {
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokY, (j * noktaUzaklik) + baslangicNokX, (i * noktaUzaklik) + baslangicNokY, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik);
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokY, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik / 2, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik);
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik / 2, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik / 2, (j * noktaUzaklik) + baslangicNokX);
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik / 2, (j * noktaUzaklik) + baslangicNokX, (i * noktaUzaklik) + baslangicNokY, (j * noktaUzaklik) + baslangicNokX);
                    }
                    break;
                case 13:
                    {
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokY, (j * noktaUzaklik) + baslangicNokX, (i * noktaUzaklik) + baslangicNokY, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik);
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokY, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik / 2, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik);
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik / 2, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik / 2);
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik / 2, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik, (j * noktaUzaklik) + baslangicNokX);
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik, (j * noktaUzaklik) + baslangicNokX, (i * noktaUzaklik) + baslangicNokY, (j * noktaUzaklik) + baslangicNokX);
                    }
                    break;
                case 14:
                    {
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokY, (j * noktaUzaklik) + baslangicNokX, (i * noktaUzaklik) + baslangicNokY, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik);
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokY, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik);
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik / 2);
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik / 2, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik / 2, (j * noktaUzaklik) + baslangicNokX);
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik / 2, (j * noktaUzaklik) + baslangicNokX, (i * noktaUzaklik) + baslangicNokY, (j * noktaUzaklik) + baslangicNokX);
                    }
                    break;
                case 15:
                    {
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokY, (j * noktaUzaklik) + baslangicNokX, (i * noktaUzaklik) + baslangicNokY, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik);
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokY, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik);
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik, (j * noktaUzaklik) + baslangicNokX + noktaUzaklik, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik, (j * noktaUzaklik) + baslangicNokX);
                        grakik.DrawLine(pen1, (i * noktaUzaklik) + baslangicNokY + noktaUzaklik, (j * noktaUzaklik) + baslangicNokX, (i * noktaUzaklik) + baslangicNokY, (j * noktaUzaklik) + baslangicNokX);
                    }
                    break;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {



        }

        private void button3_Click(object sender, EventArgs e)
        {
            baslangicNokY = Convert.ToInt32(textBox1.Text);
            baslangicNokX = Convert.ToInt32(textBox2.Text);
            if (Convert.ToInt32(textBox3.Text) % 2 != 0)
            {
                noktaUzaklik = Convert.ToInt32(textBox3.Text) + 1;
                textBox3.Text = noktaUzaklik.ToString();
            }
            else
            {
                noktaUzaklik = Convert.ToInt32(textBox3.Text);
            }
            xEkseniNoktaSayisi = Convert.ToInt32(textBox4.Text);
            yEkseniNoktaSayisi = Convert.ToInt32(textBox5.Text);
            kalemKalinligi = Convert.ToInt32(textBox6.Text);
            Oran= Convert.ToInt32(textBox7.Text);
            kalemRengi = colorDialog.Color;
            label6.BackColor = kalemRengi;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            colorDialog.ShowDialog();
        }
    }
}