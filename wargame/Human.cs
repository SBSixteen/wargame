using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wargame
{
    internal class Human : GameObject
    {
        float _hp;
        float _mass; //KG

        string _faction = "NEUTRAL";

        public Human(string name, string description, string type, string skeleton): base(name, description, type, skeleton)
        {
            _hp = 100;
            _mass = 70;
            
        }
        
        public override void print()
        {
            Console.WriteLine("GID => {0}", _GID);
            Console.Write("Name => {0} \nDescription => {1} \nType => {2} \nMass => {3} | HP => {4}\n",
                _name, _description, _type, _skeleton, _hp);

            if (_children != null) {
                foreach (var child in _children)
                {
                    Console.Write("Equipment | ");
                    child.print();
                }
            }
            else
            {
                Console.WriteLine("[GID : {0}] has no Equipment Assigned", _GID);
            }
        }
        
        public void setFaction(string fname)
        {
            _faction = fname;
        }

    }
}
