using ex01_Garage.Models;
using ex01_Garage.Models.Moteurs;
using ex01_Garage.Models.Options;
using ex01_Garage.Models.Vehicules;

namespace ex01_Garage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            Garage garage = new Garage();
            Console.WriteLine(garage);

            Vehicule lag1 = new Lagouna();
            lag1.SetMoteur(new MoteurEssence("150 Chevaux", 10256d));
            lag1.AddOption(new GPS());
            lag1.AddOption(new SiegeChauffant());
            lag1.AddOption(new VitreElectrique());

            garage.Add(lag1);

            Vehicule A300B_2 = new A300B();
            A300B_2.SetMoteur(new MoteurElectrique("1500 W", 1234d));
            A300B_2.AddOption(new Climatisation());
            A300B_2.AddOption(new BarreDeToit());
            A300B_2.AddOption(new SiegeChauffant());
            garage.Add(A300B_2);

            Vehicule d4_1 = new D4();
            d4_1.SetMoteur(new MoteurDiesel("200 Hdi", 25684.80d));
            d4_1.AddOption(new BarreDeToit());
            d4_1.AddOption(new Climatisation());
            d4_1.AddOption(new GPS());

            garage.Add(d4_1);

            Vehicule lag2 = new Lagouna();
            lag2.SetMoteur(new MoteurDiesel("500 Hdi", 456987d));

            garage.Add(lag2);

            Vehicule A300B_1 = new A300B();
            A300B_1.SetMoteur(new MoteurHybride("ESSENCE/Electrique", 12345.95d));
            A300B_1.AddOption(new VitreElectrique());
            A300B_1.AddOption(new BarreDeToit());

            garage.Add(A300B_1);

            Vehicule d4_2 = new D4();
            d4_2.SetMoteur(new MoteurElectrique("100 KW", 1224d));
            d4_2.AddOption(new SiegeChauffant());
            d4_2.AddOption(new BarreDeToit());
            d4_2.AddOption(new Climatisation());
            d4_2.AddOption(new GPS());
            d4_2.AddOption(new VitreElectrique());

            garage.Add(d4_2);

            Console.WriteLine(garage);
        }
    }
}
