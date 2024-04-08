﻿namespace Po1450_Klikacka.Models
{
    public class Grafika
    {
        public Grafika()
        {
            NahodneMatici(6, 9, 0, 1);
        }
        public Grafika(int pocetRadku, int pocetSloupcu, int pocetBarev)
        {
            NahodneMatici(pocetRadku, pocetSloupcu, minCislo: 0, pocetBarev);
            PripravitBarvy(pocetBarev);
            ZvolenaBarva = 0;
            BarvySeznam[0].Selected = true;
        }

        public Bunka[,] Matice { get; private set; }
        public List<BunkaBarva> BarvySeznam { get; set; } = new List<BunkaBarva>();
        private int ZvolenaBarva { get; set; } = 2;

        private Random rnd = new Random();
        private void NahodneMatici(int radku, int sloupcu, int minCislo, int maxCislo)
        {
            Matice = new Bunka[radku, sloupcu];

            for (int i = 0; i < radku; i++)
            {
                for (int j = 0; j < sloupcu; j++)
                {
                    Matice[i, j] = new Bunka(i, j, rnd.Next(minCislo, maxCislo + 1));
                }
            }
        }

        private void PripravitBarvy(int pocetBarev)
        {
            for (int i = 0; i <= pocetBarev; i++)
            {
                BarvySeznam.Add(new BunkaBarva(i));
            }
        }
        public void OnCellClick(Models.Bunka bunka)
        {
            if (bunka.Hodnota == 0 && bunka.StyleIndexBarvy != ZvolenaBarva || BarvySeznam.Any())
            {
                bunka.StyleIndexBarvy = ZvolenaBarva;
            }
            else
            {
                bunka.StyleIndexBarvy = 0;
            }
        }
        public void OnCellClick(Models.BunkaBarva bunka)
        {
            for (int i = 0; i < BarvySeznam.Count; i++)
            {
                BarvySeznam[i].Selected = false;
            }
            bunka.Selected = true;
            ZvolenaBarva = bunka.Hodnota;
        }
    }
}
