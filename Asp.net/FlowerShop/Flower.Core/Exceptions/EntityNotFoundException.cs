using System;
using System.Collections.Generic;
using System.Text;

namespace Flower.Core.Exceptions
{
    public class EntityNotFoundException : Exception
    {
        public object[] KeyValues { get; set; }

        public EntityNotFoundException(string message = "") : base(message) { }

        public EntityNotFoundException(object[] keyValues, string message = "") : base(message)
        {
            KeyValues = keyValues;
        }
    }
}
