using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities
{
    public class Diet : IEntity
    {
        public Diet()
        {
            Days = new List<Day>();
        }
        public int Id { get; set; }
        public int DietMethodId { get; set; }
        public int PatientId { get; set; }
        public string Name { get; set; }
        public List<Day> Days { get; set; }
        public Patient Patient { get; set; }
    }
}
