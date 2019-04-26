using System.Collections.Generic;

namespace Planner {

    class City {
    public string name {get; set;}
    public string mayor {get; set;}
    public int yearEstablished {get; set;}
    public List<Building> buildingsInCity {get; set;} = new List<Building>();

    public void addBuilding(Building building){
        buildingsInCity.Add(building);
    }

    }






}