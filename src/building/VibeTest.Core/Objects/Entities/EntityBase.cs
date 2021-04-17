using System;
using System.Collections.Generic;
using System.Text;

namespace VibeTest.Core.Objects.Entities
{
    public abstract class EntityBase
    {
        public int Id { get; set; }
        public override string ToString()
        {
            return $"{GetType().Name } [Id = {Id}]";
        }
    }
}
