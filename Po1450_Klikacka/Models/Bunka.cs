﻿namespace Po1450_Klikacka.Models
{
    public class Bunka
    {
        public Bunka(int radka, int sloupec, int hod) 
        { 
            Radka = radka;
            Sloupec = sloupec;
            Hodnota = hod;
        }
        public int Radka { get; private set; }
        public int Sloupec { get; private set; }
        public int Hodnota { get; private set; }
        public int StyleIndexBarvy { get; set; } = 0;
        public virtual string StyleClassName => $"barva-{StyleIndexBarvy}";
    }
}
