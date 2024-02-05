using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wargame
{
    internal class Constants
    {
        public static int _GameObjectID = 0;

        public static int assignGID()
        {
            _GameObjectID++;
            return _GameObjectID;
        }

        public static Dictionary<int,GameObject> GameObjectHistory = new Dictionary<int, GameObject>();

        public static void birthGameObject(GameObject obj)
        {
            if (!GameObjectHistory.ContainsKey(obj.getGID()))
            {
                GameObjectHistory.Add(obj.getGID(), obj);
            }
            else
            {
                Console.WriteLine("Fatal Bookeeping Error!");
            }

        }

        public static void revealHistory()
        {
            foreach (KeyValuePair<int, GameObject> kvp in GameObjectHistory)
            {
                Console.WriteLine(kvp.Key + " | " + kvp.Value.ToString());
            }
        }

        public static String[] skeleton = new String[] 
        { "FLESH",
          "METAL",
          "CERAMIC",
          "FABRIC",
          "POLYMER"
        };
    }
}
