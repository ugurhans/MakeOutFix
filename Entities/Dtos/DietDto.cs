using System;
using System.Collections.Generic;

using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Core.Entities;
using Entities.Concrate;

namespace Entities.Dtos
{
    public class DietDto : IDto
    {
        public DietDto()
        {
            Days = new List<Day>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int MethodId { get; set; }
        public string DietMethodName { get; set; }
        public List<Day> Days { get; set; }
    }
}
