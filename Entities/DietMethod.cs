using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities
{
    public class DietMethod : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
