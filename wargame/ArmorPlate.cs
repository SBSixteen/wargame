using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wargame
{
    internal class ArmorPlate : GameObject
    {
        float _ap;
        public ArmorPlate(string name, string description, string type, string skeleton, float ap) : base(name, description, type, skeleton)
        {
            _ap = ap;
        }

        public float getap()
        {
            return _ap;
        }

        public override void print()
        {
            throw new NotImplementedException();
        }
    }
}
