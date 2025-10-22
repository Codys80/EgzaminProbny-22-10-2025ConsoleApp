namespace EgzaminProbny_22_10_2025ConsoleApp
{
    internal class Program
    {
        static bool[] tablica = new bool[10000];
         static void zapelnijTablice()
        {
            for (int i = 1; i < tablica.Length; i++)
            {
                tablica[i] = false;
            }
        }
        static bool czyWystepujeCztery(int index)
        {
            return index.ToString().Contains('4');
        }
        static bool czyLiczbaCzworkowa(int index)
        {
            string indexString = index.ToString();
            int suma = 0;
            int czworkowosc = 0;
            for (int i = 0; i<indexString.Length; i++)
            {
                suma += int.Parse(indexString[i].ToString());
            }
            string indexSuma = suma.ToString();
            //Console.WriteLine(suma);
            if (indexSuma[indexSuma.Length-1] == '4')
                return true;
            return false;
        }

        static void Main(string[] args)
        {
            //czyLiczbaCzworkowa(13);
            for (int i = 1; i < tablica.Length; i++)
            {
                tablica[i] = false;
                if (czyWystepujeCztery(i))
                {
                    tablica[i] = true;
                }
                if (czyLiczbaCzworkowa(i))
                {
                    tablica[i] = true;
                }
                
            }

            for (int i = 1; i < tablica.Length; i++)
            {

                Console.WriteLine("i: "+i +" T: " + tablica[i]);
            }
            Console.WriteLine(czyLiczbaCzworkowa(68));

        }
    }
}
