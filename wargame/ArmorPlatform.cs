using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wargame
{
    internal class ArmorPlatform : GameObject
    {
        string _bodyTag = "TORSO";
        int _cap = 0;

        public ArmorPlatform(string name, string description, string type, string skeleton, int cap) : base(name, description, type, skeleton) 
        {
            _children = new List<GameObject>();
            _cap = cap;
        }

        public void addPlate(ArmorPlate plate)
        {
            if (plate.getParent() != null)
            {
                Console.WriteLine("Cannot add a plate as it belongs to a different plate carrier");
                return;
            }

            if (_children.Count < _cap)
            {
                this._children.Add(plate);
                plate.assignParent(this);
                return;
            }
        }

        public override void print()
        {
            float sum = 0;


            foreach (ArmorPlate plate in _children)
            {
                sum+=plate.getap();
            }

            Console.WriteLine("Name => {0} | AP => {1} | Purpose Part => {2}", _name, sum, _bodyTag);
        }

        public void definition()
        {
            int i = 0;

            Console.WriteLine("Occupying {0} out of {1} plate slots", _children.Count(), _cap);

            foreach (ArmorPlate plate in _children)
            {
                Console.WriteLine("Plate {0} | {1} | AP : {2}", i, plate.getName(), plate.getap());
                i++;
            }
        }

    }
}
