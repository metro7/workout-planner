using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutPlanner
{
    public class Workout
    {
        public string Name { get; set; }
        public List<Exercise> Exercises { get; set; }

        public Workout(string name)
        {
            Name = name;
            Exercises = new List<Exercise>();
        }

        public void AddExercise(Exercise exercise)
        {
            Exercises.Add(exercise);
        }

        public void RemoveExercise(Exercise exercise)
        {
            Exercises.Remove(exercise);
        }

        public void EditExercise(int index, Exercise newExercise)
        {
            if (index >= 0 && index < Exercises.Count)
            {
                Exercises[index] = newExercise;
            }
        }
    }
}
