using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
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
            return $"Client: \t{Name}\nClient ID:\t{ID}";
        }

        public Client DeepCopy()
        {
            Client newClient = new(ID, Name);
            return newClient;
        }
    }
}
