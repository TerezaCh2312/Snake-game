using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using System.Collections.Generic;

namespace snake_game
{
    public partial class Form1 : Form
    {
        private enum StavHry { Menu, Hra, Konec }
        private StavHry aktualniStav = StavHry.Menu;
        private game hra;
        private int skore = 0;
        private int velikostCtverce = 60;

        private Brush brushHlava = Brushes.DarkGreen;
        private Brush brushTelo = Brushes.Green;
        private Brush brushOcas = Brushes.LimeGreen;
        private Color barvaHadaCista = Color.Green;
        private Color barvaPozadi = Color.White;
        private string nazevRychlosti = "ZaË·teËnÌk";
        private string nazevBarvyHada = "Zelen·";

        // pokus o leosi nacitani a mensi lagovani
        private Dictionary<Point, Image> hlavySmer = new Dictionary<Point, Image>();
        private Dictionary<Point, Image> telaSmer = new Dictionary<Point, Image>();
        private Dictionary<Point, Image> ocasySmer = new Dictionary<Point, Image>();

        private Image obrazekJablka = Resource1.jablicko;
        
        private Bitmap mrizkaPozadi;
        private Font fontNadpis;
        private Font fontMaly;
        private Font fontSkore;

        public Form1()
        {
            InitializeComponent();
            hra = new game();

            //automaticky fullscreen
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;

            this.DoubleBuffered = true;
            this.KeyPreview = true;

            timer1.Interval = 200;
            
            fontNadpis = new Font("Arial", 60, FontStyle.Bold);
            fontMaly = new Font("Arial", 18, FontStyle.Bold);
            fontSkore = new Font("Arial", 16, FontStyle.Bold);
            
            PripravOtoceneObrazky(Resource1.hlava_zelena, Resource1.telo_zelena, Resource1.ocas_zelena);                        
            VytvorMrizku();
        }

        private void VytvorMrizku()
        {
            mrizkaPozadi = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            using (Graphics g = Graphics.FromImage(mrizkaPozadi))
            {
                using (Pen p = new Pen(Color.FromArgb(40, Color.Gray)))
                {
                    for (int i = 0; i <= mrizkaPozadi.Width; i += velikostCtverce)
                    {
                        g.DrawLine(p, i, 0, i, mrizkaPozadi.Height);
                    }
                    for (int j = 0; j <= mrizkaPozadi.Height; j += velikostCtverce)
                    {
                        g.DrawLine(p, 0, j, mrizkaPozadi.Width, j);
                    }
                }
            }
        }

        // pokus o zmenseni lagovani
        private void PripravOtoceneObrazky(Image hlava, Image telo, Image ocas)
        {
            hlavySmer.Clear();
            telaSmer.Clear();
            ocasySmer.Clear();

            Point[] smery =
            {
                new Point(0, 1),
                new Point(0, -1),
                new Point(1, 0),
                new Point(-1, 0)
            };

            foreach (Point s in smery)
            {
                hlavySmer[s] = OtocObrazekZnovu(hlava, s);
                telaSmer[s] = OtocObrazekZnovu(telo, s);
                ocasySmer[s] = OtocObrazekZnovu(ocas, s);
            }
        }

        private Image OtocObrazekZnovu(Image img, Point smer)
        {
            if (img == null)
            {
                return null;
            }

            Image kopie = (Image)img.Clone();

            if (smer.Y == 1)
            {
                return kopie; // Dol˘ (origin·l)
            }
            if (smer.Y == -1)
            {
                kopie.RotateFlip(RotateFlipType.Rotate180FlipNone);
            }
            else if (smer.X == -1)
            {
                kopie.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }
            else if (smer.X == 1)
            {
                kopie.RotateFlip(RotateFlipType.Rotate270FlipNone);
            }
            return kopie;
        }


        private void n·povÏdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = "VÕTEJTE VE HÿE HAD!\n\n" +
                          "OVL¡D¡NÕ:\n" +
                          "ï äipky: Pohyb hada do stran\n" +
                          "ï Enter: SpuötÏnÌ hry / Restart po proh¯e\n" +
                          "ï R: N·vrat do hlavnÌho menu k nastavenÌ\n" +
                          "ï Esc: UkonËenÌ aplikace\n\n" +
                          "PRAVIDLA:\n" +
                          "ï SbÌrejte jablÌËka.\n" +
                          "ï Nenaraûte do vlastnÌho tÏla!\n" +
                          "ï V Klasik reûimu nenaraûte do zdi.";
            MessageBox.Show(text, "N·povÏda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void zaË·teËnÌkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 200;
            nazevRychlosti = "ZaË·teËnÌk";
            pictureBox1.Invalidate();
        }

        private void pokroËil˝ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 90;
            nazevRychlosti = "PokroËil˝";
            pictureBox1.Invalidate();
        }

        private void expertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 50;
            nazevRychlosti = "Expert";
            pictureBox1.Invalidate();
        }

        private void ukonËitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void resetovatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            aktualniStav = StavHry.Menu;
            pictureBox1.Invalidate();
        }

        // barvy hada
        private void zelen·ToolStripMenuItem_Click(object sender, EventArgs e) => NastavVzhled(Brushes.DarkGreen, Brushes.Green, Brushes.LimeGreen, Color.Green, "Zelen·");
        private void Ëerven·ToolStripMenuItem_Click(object sender, EventArgs e) => NastavVzhled(Brushes.DarkRed, Brushes.Red, Brushes.IndianRed, Color.Red, "»erven·");
        private void modr·ToolStripMenuItem_Click(object sender, EventArgs e) => NastavVzhled(Brushes.DarkBlue, Brushes.Blue, Brushes.DeepSkyBlue, Color.Blue, "Modr·");
        private void ûlut·ToolStripMenuItem_Click(object sender, EventArgs e) => NastavVzhled(Brushes.Orange, Brushes.Yellow, Brushes.Gold, Color.Yellow, "élut·");
        private void fialov·ToolStripMenuItem_Click(object sender, EventArgs e) => NastavVzhled(Brushes.Purple, Brushes.MediumPurple, Brushes.Violet, Color.Purple, "Fialov·");
        private void Ëern·ToolStripMenuItem_Click(object sender, EventArgs e) => NastavVzhled(Brushes.Black, Brushes.DimGray, Brushes.Gray, Color.Black, "»ern·");

        // barvy pozadi
        private void bÌl·ToolStripMenuItem_Click(object sender, EventArgs e) { barvaPozadi = Color.White; pictureBox1.Invalidate(); }
        private void Ëern·ToolStripMenuItem1_Click(object sender, EventArgs e) { barvaPozadi = Color.Black; pictureBox1.Invalidate(); }
        private void zelen·ToolStripMenuItem1_Click(object sender, EventArgs e) { barvaPozadi = Color.LightGreen; pictureBox1.Invalidate(); }
        private void modr·ToolStripMenuItem1_Click(object sender, EventArgs e) { barvaPozadi = Color.LightBlue; pictureBox1.Invalidate(); }
        private void Ëerven·ToolStripMenuItem1_Click(object sender, EventArgs e) { barvaPozadi = Color.MistyRose; pictureBox1.Invalidate(); }

        // nastaveni pravidel 
        private void star·VerzeToolStripMenuItem_Click(object sender, EventArgs e) { hra.ProchazetZdi = false; pictureBox1.Invalidate(); }
        private void nov·VerzeToolStripMenuItem_Click(object sender, EventArgs e) { hra.ProchazetZdi = true; pictureBox1.Invalidate(); }

        private void NastavVzhled(Brush h, Brush t, Brush o, Color c, string n)
        {
            brushHlava = h;
            brushTelo = t;
            brushOcas = o;
            barvaHadaCista = c;
            nazevBarvyHada = n;

            Image hlava = null, telo = null, ocas = null;

            switch (n)
            {
                case "Zelen·":
                    hlava = Resource1.hlava_zelena;
                    telo = Resource1.telo_zelena;
                    ocas = Resource1.ocas_zelena;
                    break;

                case "»erven·":
                    hlava = Resource1.hlava_cervena;
                    telo = Resource1.telo_cervena;
                    ocas = Resource1.ocas_cervena;
                    break;

                case "Modr·":
                    hlava = Resource1.hlava_modra;
                    telo = Resource1.telo_modra;
                    ocas = Resource1.ocas_modra;
                    break;

                case "élut·":
                    hlava = Resource1.hlava_zluta;
                    telo = Resource1.telo_zluta;
                    ocas = Resource1.ocas_zluta;
                    break;

                case "Fialov·":
                    hlava = Resource1.hlava_fialova;
                    telo = Resource1.telo_fialova;
                    ocas = Resource1.ocas_fialova;
                    break;

                case "»ern·":
                    hlava = Resource1.hlava_cerna;
                    telo = Resource1.telo_cerna;
                    ocas = Resource1.ocas_cerna;
                    break;

                default:
                    break;
            }

            // tady se provede rotace jen jednou pri zmene barvy
            PripravOtoceneObrazky(hlava, telo, ocas);
            pictureBox1.Invalidate();
        }

        private void StartHry()
        {
            skore = 0;
            hra.ResetHada();
            hra.Jidla.Clear();
            hra.VytvorJidlo(pictureBox1.Width / velikostCtverce, pictureBox1.Height / velikostCtverce);
            aktualniStav = StavHry.Hra;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (aktualniStav != StavHry.Hra)
            {
                return;
            }

            int maxS = pictureBox1.Width / velikostCtverce;
            int maxV = pictureBox1.Height / velikostCtverce;

            hra.Pohyb(maxS, maxV);

            for (int i = 0; i < hra.Jidla.Count; i++)
            {
                if (hra.Tela[0] == hra.Jidla[i])
                {
                    hra.ProdluzSe();
                    hra.Jidla.RemoveAt(i);
                    hra.VytvorJidlo(maxS, maxV);
                    skore += 10; break;
                }
            }
            if ((!hra.ProchazetZdi && (hra.Tela[0].X < 0 || hra.Tela[0].X >= maxS || hra.Tela[0].Y < 0 || hra.Tela[0].Y >= maxV)) || hra.NarazilDoSebe())
            {
                timer1.Stop(); aktualniStav = StavHry.Konec;
            }
            pictureBox1.Invalidate();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(barvaPozadi);

            if (aktualniStav == StavHry.Menu)
            {
                VykresliMenu(g, "NASTAVENÕ HADA", $"Rychlost: {nazevRychlosti}\nReûim: {(hra.ProchazetZdi ? "Pr˘chozÌ" : "Klasik")}\n[ ENTER ] Hr·t");
            }
            else
            {
                // mrizka
                if (mrizkaPozadi != null)
                {
                    g.DrawImage(mrizkaPozadi, 0, 0);
                }

                // jablicko
                foreach (var j in hra.Jidla)
                {
                    if (obrazekJablka != null)
                    {
                        g.DrawImage(obrazekJablka, j.X * velikostCtverce, j.Y * velikostCtverce, velikostCtverce, velikostCtverce);
                    }
                }

                
                for (int i = 0; i < hra.Tela.Count; i++)
                {
                    Image img = null;
                    Point pos = new Point(hra.Tela[i].X * velikostCtverce, hra.Tela[i].Y * velikostCtverce);

                    if (i == 0) // hlava
                    {
                        hlavySmer.TryGetValue(hra.Smer, out img);
                    }
                    else if (i == hra.Tela.Count - 1) // Ocas
                    {
                        Point smerOcasu = new Point(hra.Tela[i - 1].X - hra.Tela[i].X, hra.Tela[i - 1].Y - hra.Tela[i].Y);
                        ocasySmer.TryGetValue(smerOcasu, out img);
                    }
                    else // telo
                    {
                        Point smerTela = new Point(hra.Tela[i - 1].X - hra.Tela[i].X, hra.Tela[i - 1].Y - hra.Tela[i].Y);
                        telaSmer.TryGetValue(smerTela, out img);
                    }

                    if (img != null)
                    {
                        g.DrawImage(img, pos.X, pos.Y, velikostCtverce, velikostCtverce);
                    }
                }

                Brush skoreBrush = (barvaPozadi == Color.Black) ? Brushes.White : Brushes.DimGray;
                g.DrawString($"SkÛre: {skore}", fontSkore, skoreBrush, 10, 40);

                if (aktualniStav == StavHry.Konec)
                {
                    VykresliMenu(g, "KONEC HRY", $"Vaöe skÛre: {skore}\n\n[ ENTER ] Hr·t znovu | [ R ] Menu");
                }
            }
        }

        private void VykresliMenu(Graphics g, string nadpis, string info)
        {
            int sirka = pictureBox1.Width;
            int vyska = pictureBox1.Height;


            StringFormat formatovani = new StringFormat();
            formatovani.Alignment = StringAlignment.Center;
            formatovani.LineAlignment = StringAlignment.Center;


            Color barvaNadpisu;
            if (barvaPozadi == Color.Black && barvaHadaCista == Color.Black)
            {
                barvaNadpisu = Color.White;
            }
            else
            {
                barvaNadpisu = barvaHadaCista;
            }


            g.DrawString(nadpis, fontNadpis, Brushes.Black, new Rectangle(3, vyska / 5 + 3, sirka, vyska / 4), formatovani);


            using (Brush stetecNadpis = new SolidBrush(barvaNadpisu))
            {
                g.DrawString(nadpis, fontNadpis, stetecNadpis, new Rectangle(0, vyska / 5, sirka, vyska / 4), formatovani);
            }


            string textBarvaHada = "Barva hada: " + nazevBarvyHada;

            //ramecek
            SizeF rozmerTextu = g.MeasureString(textBarvaHada, fontMaly);
            int sirkaRamene = (int)rozmerTextu.Width + 40;
            int vyskaRamene = (int)rozmerTextu.Height + 10;

            int stredX = (sirka - sirkaRamene) / 2;
            int stredY = vyska / 2;

            // Barevn˝ obdelnicek pod textem
            using (Brush stetecHada = new SolidBrush(barvaHadaCista))
            {
                g.FillRectangle(stetecHada, stredX, stredY, sirkaRamene, vyskaRamene);
            }


            //text uvnitr obdelnicku
            Brush barvaPismaVObdelniku;
            if (barvaHadaCista == Color.Yellow || barvaHadaCista == Color.White)
            {
                barvaPismaVObdelniku = Brushes.Black;
            }
            else
            {
                barvaPismaVObdelniku = Brushes.White;
            }

            g.DrawString(textBarvaHada, fontMaly, barvaPismaVObdelniku, new Rectangle(0, stredY, sirka, vyskaRamene), formatovani);

            
            Brush stetecInfo;
            if (barvaPozadi == Color.Black)
            {
                stetecInfo = Brushes.White;
            }
            else
            {
                stetecInfo = Brushes.Black;
            }

            g.DrawString(info, fontMaly, stetecInfo, new Rectangle(0, vyska / 2 + 100, sirka, vyska / 4), formatovani);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && (aktualniStav == StavHry.Menu || aktualniStav == StavHry.Konec))
            {
                StartHry();
            }

            if (e.KeyCode == Keys.R && aktualniStav == StavHry.Konec)
            {
                aktualniStav = StavHry.Menu;
                pictureBox1.Invalidate();
            }

            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }

            if (aktualniStav == StavHry.Hra)
            {
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        // Pokud had nejde dol˘ m˘ûe jÌt nahoru
                        if (hra.Smer.Y != 1)
                        {
                            hra.Smer = new Point(0, -1);
                        }
                        break;

                    case Keys.Down:
                        // Pokud nejde nahoru m˘ûe jÌt dol˘
                        if (hra.Smer.Y != -1)
                        {
                            hra.Smer = new Point(0, 1);
                        }
                        break;

                    case Keys.Left:
                        // Pokud nejde doprava m˘ûe doleva
                        if (hra.Smer.X != 1)
                        {
                            hra.Smer = new Point(-1, 0);
                        }
                        break;

                    case Keys.Right:
                        // Pokud nejde doleva m˘ûe doprava
                        if (hra.Smer.X != -1)
                        {
                            hra.Smer = new Point(1, 0);
                        }
                        break;
                }
            }
        }
    }
}