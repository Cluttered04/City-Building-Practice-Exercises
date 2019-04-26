using System;
using System.Collections.Generic;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building fifty = new Building();
            fifty.width = 30;
            fifty.depth= 80;
            fifty.stories = 4;
            fifty.createAddress("1000 4th Avenue");
            fifty.publicAddress("1000 4th Avenue");
            fifty.purchase("Bob Ross");
            fifty.construct();
            fifty.designer = "Sable";


            Building twenty = new Building();
            twenty.width = 20;
            twenty.depth = 40;
            twenty.stories = 5;
            twenty.createAddress("1000 8th Avenue");
            twenty.publicAddress("1000 8th Avenue");
            twenty.purchase("Dwayne Johnson");
            twenty.construct();
            twenty.designer = "Sable";

            Building thirty = new Building();
            thirty.width = 30;
            thirty.depth = 30;
            thirty.stories = 30;
            thirty.createAddress("30 30th Avenue");
            thirty.publicAddress("30 30th Avenue");
            thirty.purchase("30 Man");
            thirty.construct();
            thirty.designer = "Sable";


            List<Building> buildingList = new List<Building>();
            buildingList.Add(twenty);
            buildingList.Add(fifty);
            buildingList.Add(thirty);


            City greatPlace = new City();
            greatPlace.name = "Great Place";
            greatPlace.mayor = "Sable";
            greatPlace.yearEstablished = 2019;

            greatPlace.addBuilding(twenty);
            greatPlace.addBuilding(thirty);
            greatPlace.addBuilding(fifty);


            foreach(Building singleBuilding in greatPlace.buildingsInCity){
                Console.WriteLine($"{singleBuilding.address}");
                Console.WriteLine("-------------");
                Console.WriteLine($"Designed by {singleBuilding.designer}");
                Console.WriteLine($"Constructed on {singleBuilding.constructionDate}");
                Console.WriteLine($"Owned by {singleBuilding.private_owner}");
                Console.WriteLine($"{singleBuilding.volume} cubic meters of space.");
            }












        }
    }
}
