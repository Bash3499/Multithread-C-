using System.Threading;

namespace Multithreads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread mainthread = Thread.CurrentThread;

            Thread thread1 = new Thread(Contagem);
            Thread thread2 = new Thread(Cronometro);
            thread1.Start();
            thread2.Start();



            Contagem();
            Cronometro();




            static void Contagem()
            {
                Console.WriteLine("Contador de 10 a 0 ");

                for (int c = 10; c >= 0; c--)
                {
                    Console.WriteLine("O contador esta em: " + c + " segundos");
                    Thread.Sleep(1000);

                }
                Console.WriteLine("Sua contagem esta completa");
            }


            static void Cronometro()
            {
                Console.WriteLine("Contagem de 0 a 10");

                for (int r = 0; r <= 10; r++)
                {
                    Console.WriteLine("Sua contagem está em: " + r + " segundos");
                    Thread.Sleep(1000);
                }

                Console.WriteLine("Sua contagem esta completa");

            }




























        }
    }
}








    





