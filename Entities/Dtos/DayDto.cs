using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Dtos
{
    public class DayDto : IDto
    {

        public string WeekDay { get; set; }


        public string Breakfast { get; set; }


        public string FirstSnack { get; set; }


        public string Launch { get; set; }


        public string SecondSnack { get; set; }


        public string Dinner { get; set; }


        public string LastSnack { get; set; }


        public string DailyTotal { get; set; }


        public string Recommended { get; set; }
    }
}
