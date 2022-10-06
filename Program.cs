namespace VectorT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] v1 = new int[100];

            Thread t1 = new Thread(() => MyThread.CargarVector(ref v1, 0, 25));
            Thread t2 = new Thread(() => MyThread.CargarVector(ref v1, 25, 50));
            Thread t3 = new Thread(() => MyThread.CargarVector(ref v1, 50, 75));
            Thread t4 = new Thread(() => MyThread.CargarVector(ref v1, 75, 100));
            
            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();


            //Console.ReadKey();

            MyThread.MostrarVector(v1);
            //Console.ReadKey();
        }

    }

    public class MyThread
    {
        public static void CargarVector(ref int[] a, int posInicial, int posFinal)
        {
            Random r = new Random();
            for (int i = posInicial; i < posFinal; i++)
            {
                a[i] = r.Next(0, 100);
            }
        }
        public static void MostrarVector(int[] a)
        {
            Thread t1 = new Thread(() => MyThread.mostrarVector(a, 0, 50));
            Thread t2 = new Thread(() => MyThread.mostrarVector(a, 50, 100));
            t1.Start();
            t2.Start();

        }

        private static void mostrarVector(int[] a, int posInicial, int posFinal)
        {
            for (int i = posInicial; i < posFinal; i++)
            {

                Console.WriteLine(a[i]);
            }
        }
    }
}