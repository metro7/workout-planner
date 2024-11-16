using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkoutPlanner
{
    public partial class CreateWorkout : Form
    {

        private Workout currentWorkout;
        private List<Exercise> availableExercises;


        public CreateWorkout()
        {
            InitializeComponent();
            //LoadAvailableExercises();
            currentWorkout = new Workout(string.Empty);
        }


        public CreateWorkout(Workout workout) : this()
        {
            // When a workout is passed in, edit instead of creating a new exercise
            currentWorkout = workout;
            //txtWorkoutName.Text = workout.Name;


            InitializeComponent();
        }


        private void addExercise_Click(object sender, EventArgs e)
        {
            // Add new exercise to the workout

        }

        private void editExercise_Click(object sender, EventArgs e)
        {
            // Edit the selected exercise 

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            // Cancel Workout Creation

            this.Hide();
            ViewWorkouts workouts = new ViewWorkouts();
            workouts.Show();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // Save Workout Creation

            this.Hide();
            ViewWorkouts workouts = new ViewWorkouts();
            workouts.Show();
        }


    }
}
