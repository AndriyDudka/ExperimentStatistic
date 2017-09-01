using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperimentStatistic.Models
{
    public class ExperimentModel
    {
        public DateTime Date {get; set;}
        public double TumorSize { get; set; }
        public bool Show { get; set; }
    }
}
