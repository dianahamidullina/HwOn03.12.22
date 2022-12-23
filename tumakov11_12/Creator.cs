using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tumakov11_12
{
    public static class Creator
    {
        private static Hashtable hashtable = new Hashtable();
        public static void CreateBuild(float height, byte numberStoreys, byte numberEntrance, ushort numberFlats)
        {
            Building building = new Building(height, numberStoreys, numberEntrance, numberFlats);
            hashtable[building.GetID()] = building;
        }
        public static void DeleteBuilding(uint id)
        {
            hashtable.Remove(id);
        }
        public static List<Building> GetCreatedBuildingsList()
        {
            List<Building> buildings = new List<Building>();
            foreach (var item in hashtable.Values)
            {
                if (item is Building)
                {
                    buildings.Add((Building)item);
                }
            }
            return buildings;
        }

    }
}
