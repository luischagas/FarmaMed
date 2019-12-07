using System;
using System.Collections.Generic;
using System.Text;

namespace FarmaMed.DomainModel
{
    public abstract class EntityBase
    {
        public Guid Id { get; set; }
    }
}
