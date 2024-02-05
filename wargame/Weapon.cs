using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wargame
{
    internal class Weapon : GameObject
    {
        string _caliber;
        float _range;
        int _maxshots;
        int _rpm;

        GameObject _sight;
        GameObject _barrel;
        GameObject _grip;
        GameObject _stock;
        GameObject _underbarrel;

        public Weapon(string name, string description, string type, string skeleton, string caliber) : base(name, description, type, skeleton)
        {
            _caliber = caliber;
            _range = 0f;
        }

        public override void print()
        {
            throw new NotImplementedException();
        }
    }
}
