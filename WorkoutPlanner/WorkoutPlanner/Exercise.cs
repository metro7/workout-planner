using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutPlanner
{
    public class Exercise
    {
        public string Name { get; set; }
        public int Sets { get; set; }
        public string RepRange { get; set; }

        public Exercise(string name, int sets, string repRange)
        {
            Name = name;
            Sets = sets;
            RepRange = repRange;
        }
    }
}
