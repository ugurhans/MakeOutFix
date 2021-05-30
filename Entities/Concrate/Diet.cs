using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Entities;
using Entities.Concrate;
using Entities.Dtos;

namespace Entities.Concrate
{
    public class Diet : IEntity
    {
        public Diet()
        {
            Days = new List<Day>();
        }
        [Key]
        public int Id { get; set; }
        public int DietMethodId { get; set; }
        public int PatientId { get; set; }
        public string Name { get; set; }
        public List<Day> Days { get; set; }
        //public Patient Patient { get; set; }
    }
}
