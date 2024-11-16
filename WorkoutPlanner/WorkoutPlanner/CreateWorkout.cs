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

        private string workoutName;
        private List<string> exercises = new List<string>();


        public CreateWorkout()
        {
            InitializeComponent();
        }


        public CreateWorkout(string workoutName) : this()
        {
            this.workoutName = workoutName;
            txtWorkoutName.Text = workoutName;
            LoadExercises();
        }

        private void LoadExercises()
        {
            exercises.Clear();
            string workoutFile = Path.Combine("workouts", workoutName + ".txt");
            if (File.Exists(workoutFile))
            {
                string[] lines = File.ReadAllLines(workoutFile);
                exercises.AddRange(lines);
            }
            exercisesList.DataSource = exercises;
        }


        private void addExercise_Click(object sender, EventArgs e)
        {
            // Add new exercise to the workout

        }

        private void editExercise_Click(object sender, EventArgs e)
        {
            // Edit the selected exercise 

        }

        private void removeExercise_Click(object sender, EventArgs e)
        {
            string selectedExercise = exercisesList.SelectedItem.ToString();
            exercises.Remove(selectedExercise);
            exercisesList.DataSource = null;
            exercisesList.DataSource = exercises;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            // Cancel Workout Creation

            this.Close();
            ViewWorkouts viewWorkouts = new ViewWorkouts();
            viewWorkouts.Show();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // If changed name, create new file with new name and delete old file
            if(workoutName != txtWorkoutName.Text)
            {
                string workoutToDelete = Path.Combine("workouts", workoutName + ".txt");
                workoutName = txtWorkoutName.Text;
                string workoutFile = Path.Combine("workouts", workoutName + ".txt");
                File.WriteAllLines(workoutFile, exercises);
                this.DialogResult = DialogResult.OK;
                File.Delete(workoutToDelete);
                
            } else
            {
                string workoutFile = Path.Combine("workouts", workoutName + ".txt");
                File.WriteAllLines(workoutFile, exercises);
                this.DialogResult = DialogResult.OK;
            }
            
            this.Close();
            ViewWorkouts viewWorkouts = new ViewWorkouts();
            viewWorkouts.Show();
        }

        
    }
}
