namespace kök_bulma_programı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kökünü bulmak istediğiniz sayıyı giriniz = ");
            double kok =double.Parse(Console.ReadLine());
            double g = 1;
            int i = 0;
        a:
            if ((g * g) != kok && i != 100)
            {
                g = (g + kok / g) / 2;
                Console.WriteLine(g);
                i++;
                goto a;

            }
            Console.WriteLine("kök değeri = " + g);
        }
    }
}
