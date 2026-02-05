using System.Drawing;
using System.Collections.Generic;
using System;

namespace snake_game
{
    internal class game
    {
        public List<Point> Tela { get; set; }
        public Point Smer { get; set; }
        public List<Point> Jidla { get; set; } 
        public bool ProchazetZdi { get; set; } = false;
        private Random rnd = new Random();

        public game()
        {
            Jidla = new List<Point>();
            ResetHada();
        }

        public void ResetHada()
        {
            Tela = new List<Point>
            {
                new Point(10, 10),
                new Point(9, 10),
                new Point(8, 10)
            };
            Smer = new Point(1, 0);
        }

        public void Pohyb(int sirka, int vyska)
        {
            if (sirka <= 0 || vyska <= 0) return;


            for (int i = Tela.Count - 1; i > 0; i--)
            {
                Tela[i] = Tela[i - 1];
            }

            int novaX = Tela[0].X + Smer.X;
            int novaY = Tela[0].Y + Smer.Y;

            // Režim průchozích zdí
            if (ProchazetZdi)
            {
                if (novaX < 0)
                {
                    novaX = sirka - 1;
                }
                else if (novaX >= sirka)
                {
                    novaX = 0;
                }

                if (novaY < 0)
                {
                    novaY = vyska - 1;
                }
                else if (novaY >= vyska)
                {
                    novaY = 0;
                }
            }

            Tela[0] = new Point(novaX, novaY);
        }

        public void ProdluzSe()
        {
            // Přidá nový článek na pozici posledního
            Tela.Add(new Point(Tela[Tela.Count - 1].X, Tela[Tela.Count - 1].Y));
        }

        public bool NarazilDoSebe()
        {
            for (int i = 1; i < Tela.Count; i++)
            {
                if (Tela[0] == Tela[i])
                {
                    return true;
                }
            }
            return false;
        }

        public void VytvorJidlo(int sirkaPole, int vyskaPole)
        {
            if (sirkaPole <= 0 || vyskaPole <= 0) return;

            // Doplňování jídel do počtu 2
            while (Jidla.Count < 2)
            {
                bool naObsahu;
                int x, y;
                do
                {
                    naObsahu = false;
                    x = rnd.Next(0, sirkaPole);
                    y = rnd.Next(0, vyskaPole);

                    // Kontrola, aby jídlo nebylo na hadovi
                    foreach (var clanek in Tela)
                    {
                        if (clanek.X == x && clanek.Y == y)
                        {
                            naObsahu = true;
                            break;
                        }
                    }
                    // Kontrola, aby jídlo nebylo na jiném jídle
                    foreach (var j in Jidla)
                    {
                        if (j.X == x && j.Y == y)
                        {
                            naObsahu = true;
                            break;
                        }
                    }

                } while (naObsahu);

                Jidla.Add(new Point(x, y));
            }
        }
    }
}