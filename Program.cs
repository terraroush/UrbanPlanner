using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building Home = new Building("Gates Road")
            {
                Stories = 1,
                Width = 60,
                Depth = 40
            };
            Home.Construct();
            Home.Purchase("Terra Roush");
            Home.Designer("Anne Hathaway");
            Home.BuildBuilding();

            Building Emerson = new Building("Emerson Street")
            {
                Stories = 2,
                Width = 50,
                Depth = 60

            };
            Emerson.Construct();
            Emerson.Purchase("Rick Prokaski");
            Emerson.Designer("Bob and Tom");
            Emerson.BuildBuilding();

            Building Shangrila = new Building("Shangri La Road")
            {
                Stories = 3,
                Width = 40,
                Depth = 30
            };
            Shangrila.Construct();
            Shangrila.Purchase("Julie Dietrich");
            Shangrila.Designer("some prefab person");
            Shangrila.BuildBuilding();

            Building OG = new Building("Church Street")
            {
                Stories = 3,
                Width = 45,
                Depth = 40

            };
            OG.Construct();
            OG.Purchase("Denny Anderson");
            OG.Designer("someone long since gone");
            OG.BuildBuilding();



        }
    }
}
