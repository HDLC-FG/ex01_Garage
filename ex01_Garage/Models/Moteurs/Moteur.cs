using static ex01_Garage.Enums.Enumerations;

namespace ex01_Garage.Models.Moteurs
{
    internal class Moteur
    {
        private TypeMoteur type;
        private string cylindre;
        private double prix;

        public Moteur(string cylindre, double prix)
        {
            this.cylindre = cylindre;
            this.prix = prix;
        }

        public double GetPrix()
        {
            return prix;
        }

        public override string ToString()
        {
            return string.Format("Moteur {0} {1} ({2})", type, cylindre, prix.ToString("c"));
        }
    }
}
