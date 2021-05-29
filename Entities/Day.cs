using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Core.Entities;

namespace Entities
{
    public class Day : IEntity
    {
        public int Id { get; set; }

        public string WeekDay { get; set; }


        public string Breakfast { get; set; }


        public string FirstSnack { get; set; }


        public string Launch { get; set; }


        public string SecondSnack { get; set; }


        public string Dinner { get; set; }


        public string LastSnack { get; set; }


        public string DailyTotal { get; set; }


        public string Recommended { get; set; }

        public int DietId { get; set; }

    }
}
