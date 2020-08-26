using System;
using System.Collections.Generic;
using System.Text;

namespace CursoUdemy.Entidades
{
    class DomainException : ApplicationException
    {

        public DomainException(string message) : base(message)
        {
        }
    }
}
