using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    [Serializable]
    public class Client
    {
        public int ClientID { get; set; }

        public string Name { get; set; }

        public Client() { }

        public Client(int id, string name)
        {
            ClientID = id;
            Name = name;
        }

        public override bool Equals(object obj)
        {
            return obj is Client p && p.Name == Name && p.ClientID == ClientID;
        }

        public override int GetHashCode()
        {
            return ClientID;
        }

        public override string ToString()
        {
            return $"{Name}({ClientID})";
        }
    }
}
