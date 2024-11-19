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

        public CreateWorkout(string workoutName)
        {
            InitializeComponent();
            this.workoutName = workoutName;
            txtWorkoutName.Text = workoutName;
            if (!string.IsNullOrEmpty(workoutName))
            { 
                LoadExercises(workoutName);
            }
        }



        private void LoadExercises(string workoutName)
        {
            exercises.Clear();
            var workoutFile = Path.Combine("workouts", workoutName + ".txt");
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
            var addExerciseForm = new AddEditExercise(workoutName);
            addExerciseForm.Show();
            this.Close();
        }

        private void editExercise_Click(object sender, EventArgs e)
        {
            // Edit the selected exercise 
            if (exercisesList.SelectedItem == null)
            {
                MessageBox.Show("Select an exercise to edit.");
                return;
            }

            var exercise = exercisesList.SelectedItem.ToString();
            var addExerciseForm = new AddEditExercise(workoutName, exercise);
            addExerciseForm.Show();
            this.Close();
        }

        private void removeExercise_Click(object sender, EventArgs e)
        {

            if (exercisesList.SelectedItem != null)
            {
                var confirmResult = MessageBox.Show("Are you sure you want to delete this Exercise?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {

                    string selectedExercise = exercisesList.SelectedItem.ToString();
                    exercises.Remove(selectedExercise);
                    exercisesList.DataSource = null;
                    exercisesList.DataSource = exercises;
                    string workoutFile = Path.Combine("workouts", workoutName + ".txt");
                File.WriteAllLines(workoutFile, exercises);
                }

            }
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
                if(File.Exists(Path.Combine("workouts", txtWorkoutName.Text + ".txt")))
                {
                    MessageBox.Show("A workout with this name already exists.");
                    return;
                }
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
