using ex01_Garage.Models.Moteurs;
using ex01_Garage.Models.Options;
using static ex01_Garage.Enums.Enumerations;

namespace ex01_Garage.Models.Vehicules
{
    internal class Vehicule
    {
        private double prix;
        private List<IOption> options = new List<IOption>();
        private Moteur moteur;
        protected Marque nomMarque;

        public void AddOption(IOption option)
        {
            options.Add(option);
        }

        public double GetPrix()
        {
            return prix + options.Select(x => x.GetPrix()).Sum() + moteur.GetPrix();
        }

        public void SetMoteur(Moteur moteur)
        {
            this.moteur = moteur;
        }

        public override string ToString()
        {
            return string.Format("+ Voiture {0} : {1} {2}[{3}] d'une valeur totale de {4}", nomMarque, GetType().Name, moteur, options.CustomToString(), GetPrix().ToString("c"));
        }
    }
}
