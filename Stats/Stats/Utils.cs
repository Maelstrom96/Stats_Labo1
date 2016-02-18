using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stats
{
    static class Utils
    {
        public static List<List<string>> GetEchantillonAleatoire(List<List<string>> population, int tailleEchantillon)
        {
            List<List<string>> Echantillon = new List<List<string>>();
            List<List<string>> pop = new List<List<string>>(population);
            Random rnd = new Random();

            // Erreurs
            if (pop.Count == 0) throw new Exception("La population est vide.");
            if (pop.Count < tailleEchantillon) throw new Exception("La taille d'échantillon demandé est plus grand que la population.");

            for (int i = 0; i < tailleEchantillon; i++)
            {
                int tmpIndex = rnd.Next(pop.Count - 1);
                Echantillon.Add(pop[tmpIndex]);
                pop.RemoveAt(tmpIndex);
            }

            return Echantillon;
        }

        public static List<List<string>> GetEchantillonSystematique(List<List<string>> population, int tailleEchantillon)
        {
            int pas = (int)Math.Round((double)population.Count/tailleEchantillon);
            List<List<string>> Echantillon = new List<List<string>>();
            List<List<string>> pop = new List<List<string>>(population);
            Random rnd = new Random();
            int origin = rnd.Next(pop.Count - 1);
            int start;

            // Erreurs
            if (pop.Count == 0) throw new Exception("La population est vide.");
            if (pop.Count < tailleEchantillon) throw new Exception("La taille d'échantillon demandé est plus grand que la population.");

            // Go to first data
            for (start = origin; start >= 0; start = start - pas) ;

            for (int i = start ; i < pop.Count; i = i + pas )
            {
                Echantillon.Add(pop.ElementAt(i));
            }

            return Echantillon;
        }
    }
}
