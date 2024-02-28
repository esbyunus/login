namespace login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.WriteLine("Kullanci adiniz ?: ");
                string kullanciadi = Console.ReadLine();

                Console.WriteLine("Sifreniz ?: ");
                string sifre = Console.ReadLine();

                if (kullanciadi != "user")
                {
                    Console.WriteLine("Kullanici adiniz hatali!");
                }
                else if (sifre != "asd123")
                {
                    Console.WriteLine("Sifreniz hatali!");
                }
                else
                {
                    Console.WriteLine("Basarili giris yaptiniz");
                    break;
                }

            }

        }
    }
}