using System.Collections.Generic;

namespace MockAssessment3
{
    public class Town
    {
        public List<Villager> Villagers { get; set; }

        public Town()
        {
            Villagers = new List<Villager>();
            Villagers.Add(new Farmer());
            Villagers.Add(new Slacker());
            Villagers.Add(new Slacker());
            Villagers.Add(new Slacker());
        }

        public int Harvest()
        {
            int total = 0;
            foreach (var villager in Villagers)
            {
                total += villager.Farm();
            }

            return total;
        }

        public int CalcFoodConsumption()
        {
            int total = 0;
            foreach (var villager in Villagers)
            {
                total += villager.Hunger;
            }

            return total;
        }

        public bool SurviveTheWinter()
        {
            var harvestTotal = Harvest();
            var calcFoodConsumptionInCamelCase = CalcFoodConsumption();

            return calcFoodConsumptionInCamelCase <= harvestTotal;
            // ...or...
            //if (calcFoodConsumptionInCamelCase <= harvestTotal)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }
    }
}
