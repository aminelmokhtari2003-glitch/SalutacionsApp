namespace SalutacionsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BonDia bonDia = new BonDia();
            BonaNit bonaNit = new BonaNit();

            bonDia.Saludar();
            bonaNit.Saludar();
        }
    }
}