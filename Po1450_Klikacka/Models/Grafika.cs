namespace Po1450_Klikacka.Models
{
    public class Grafika
    {
        public Grafika() 
        {
            NahodneMatici(6, 9, 0, 1);
        }
        public Bunka[,] Matice { get; private set; }
        private int ZvolenaBarva { get; set; } = 2;

        private Random rnd = new Random();
        private void NahodneMatici(int radku, int sloupcu, int minCislo, int maxCislo )
        {
            Matice = new Bunka[radku, sloupcu];

            for ( int i = 0; i < radku; i++ )
            {
                for (int j = 0; j < sloupcu; j++)
                {
                    Matice[i, j] = new Bunka(i, j, rnd.Next(minCislo, maxCislo + 1));
                }
            }
        }

        public void OnCellClick(Models.Bunka bunka)
        {
            if (bunka.Hodnota == 0)
            {
                bunka.StyleIndexBarvy = ZvolenaBarva;
            }
        }
    }
}
