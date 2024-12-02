using ex01_Garage.Models.Vehicules;

namespace ex01_Garage.Models
{
    internal class Garage
    {
        public List<Vehicule> voitures = new List<Vehicule>();

        public void Add(Vehicule voiture)
        {
            voitures.Add(voiture);
        }

        public override string ToString()
        {
            if (voitures.Count == 0)
            {
                return "Aucune voiture sauvegardée !\n**************************\n* Garage .NET *\n**************************";
            }

            return string.Format(string.Join("\n", voitures));
        }
    }
}
