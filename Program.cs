namespace GLS_CLI
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<AutoAdatok>autok=new List<AutoAdatok>();
            StreamReader sr = new StreamReader("GLS.txt");
            while (!sr.EndOfStream)
            {
                autok.Add(new AutoAdatok(sr.ReadLine()));
            }
            sr.Close();
            int db = 0;
            for (int i = 0; i < autok.Count; i++)
            {
                db++;
            }
            Console.WriteLine("2. feladat:");
            Console.WriteLine($"Az autó használatban töltött napjainak száma: {db}");
            
            Console.WriteLine("3. feladat:");
            List<string>nev_list = new List<string>();
            for (int i = 0; i < autok.Count; i++)
            {
                if (nev_list.Contains(autok[i].nev))
                {
                    
                }
                else
                {
                    nev_list.Add(autok[i].nev);
                }
                
            }
            Console.WriteLine($"Különböző sofőrök száma: {nev_list.Count}");
            //---------nem jók----------//
            Console.WriteLine("4. feladat:");
            int ossz_kilometer = 0;
            for (int i = 0; i < autok.Count; i++)
            {
                ossz_kilometer += autok[i].napi_km;
            }
            Console.WriteLine($"Az összes megtett kilométer: {ossz_kilometer} km");
            Console.WriteLine("6.feladat:");
          
            Console.WriteLine("7.feladat:");
            for (int i = 0; i < autok.Count; i++)
            {
                
            }
            Console.WriteLine("A legtöbbet vezető sofőr: X, napok száma: Y");
        }

        public static int atlag_fogy(int liter,int km)
        {
            int fogy = liter / (km / 100);
            if (0<fogy)
            {
                return fogy;
            }
            
            return 0;
        }
    }
}
