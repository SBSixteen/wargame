using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wargame
{
    internal abstract class GameObject
    {
        protected string _name;
        protected string _description;
        protected string _type;
        protected string _skeleton;
        protected int _GID;
        protected bool _assigned;

        protected GameObject? _parent;
        protected List<GameObject>? _children;

        protected GameObject(string name, string description, string type, string skeleton)
        {
            _GID = Constants.assignGID();
            _name = name;
            _description = description;
            _type = type;
            _skeleton = skeleton;
            _assigned = false;
            Constants.birthGameObject(this);
        }

        public void assignChildren(params GameObject[] children)
        {
            if (_children == null || _children.Count == 0)
            {
                _children = new List<GameObject>();
            }

            foreach (var child in children)
            {
                _children.Add(child);
                child.assignParent(this);
            }
        }

        public void assignChildren(IEnumerable<GameObject> children)
        {
            if (_children == null || _children.Count == 0)
            {
                _children = new List<GameObject>();
            }

            foreach (var child in children)
            {
                _children.Add(child);
                child.assignParent(this);
            }
        }

        internal void assignParent(GameObject parent)
        {
            _parent = parent;
        }

        void clearChildren()
        {
            _children?.Clear();
        }

        void clearParent()
        {
            _parent = null;
        }

        public abstract void print();

        public int getGID()
        {
            return _GID;
        }

        public string getName()
        {
            return _name;
        }

        public GameObject getParent()
        {
            return _parent;
        }

    }
}
