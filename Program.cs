using System;

namespace Urban_Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building tallTower = new Building("513 9th Avenue")
            {
                Width = 124,
                Stories = 42,
                Depth = 225
            };
            tallTower.Construct();
            tallTower.Purchase("Deep Patel");

            Building shortTower = new Building("514 11th Avenue")
            {
                Width = 114,
                Stories = 2,
                Depth = 125
            };
            shortTower.Construct();
            shortTower.Purchase("Deep Patel");

            Building batmanBuilding = new Building("515 12th Avenue")
            {
                Width = 153,
                Stories = 14,
                Depth = 225
            };
            batmanBuilding.Construct();
            batmanBuilding.Purchase("Deep Patel");

            Building robinBuilding = new Building("516 14th Avenue")
            {
                Width = 153,
                Stories = 14,
                Depth = 225
            };
            robinBuilding.Construct();
            robinBuilding.Purchase("Deep Patel");

            // Create new instance of the City class
            City DeepTopia = new City();

            // Establish when the city was founded
            DeepTopia.Founded();

            // Add mayor
            DeepTopia.Election("Batman");

            // Add buildings to city list
            DeepTopia.AddBuilding(tallTower);
            DeepTopia.AddBuilding(shortTower);
            DeepTopia.AddBuilding(batmanBuilding);
            DeepTopia.AddBuilding(robinBuilding);

            foreach (Building building in DeepTopia.CityBuildings)
            {
                building.BuildingDeets();
            }
        }
    }
}
