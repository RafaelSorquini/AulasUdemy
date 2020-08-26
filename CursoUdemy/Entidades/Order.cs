using System;
using CursoUdemy.Entidades.Enuns;

namespace CursoUdemy.Entidades
{
    class Order
    {
        public int Id { get; set; }

        public DateTime Moment { get; set; }
        public int MyProperty { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return Id
                + ", "
                + Moment
                + ", "
                + Status;
        }
    }
}
