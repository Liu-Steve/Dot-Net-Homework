using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    [Serializable]
    public class Client
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public Client() { }

        public Client(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public override bool Equals(object obj)
        {
            return obj is Client p && p.Name == Name && p.ID == ID;
        }

        public override int GetHashCode()
        {
            return ID;
        }

        public override string ToString()
        {
            return $"{Name}({ID})";
        }

        public Client DeepCopy()
        {
            Client newClient = new Client(ID, Name);
            return newClient;
        }
    }
}
