using Enumerate.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Enumerate.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Momento { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return Id + ", " + Momento + ", " + Status;
        }
    }
}
