using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio1
{
    class Quartos
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Rooms { get; set; }

        public Quartos(string name, string email, int rooms)
        {
            Name = name;
            Email = email;
            Rooms = rooms;
        }

        public override string ToString()
        {
            return Name + ", " + Email;
        }
    }
}
