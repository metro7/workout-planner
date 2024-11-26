using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WorkoutPlanner
{
    public partial class ViewWorkouts : Form
    {

        private List<string> workouts = new List<string>();

        public ViewWorkouts()
        {
            InitializeComponent();
            LoadWorkouts();
        }


        private void LoadWorkouts()
        {
            workouts.Clear();
            string[] workoutFiles = Directory.GetFiles("workouts", "*.txt");
            foreach (var file in workoutFiles)
            {
                workouts.Add(Path.GetFileNameWithoutExtension(file));
            }
            workoutsList.DataSource = workouts;
        }


        private void main_menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu menu = new MainMenu();
            menu.Show();
        }

        private void createWorkout_Click(object sender, EventArgs e)
        {
            string workoutName = workoutNameBox.Text;
            if (!string.IsNullOrEmpty(workoutName))
            {
                if (File.Exists(Path.Combine("workouts", workoutNameBox.Text + ".txt")))
                {
                    MessageBox.Show("A workout with this name already exists.");
                    return;
                }
                this.Close();
                CreateWorkout createWorkoutForm = new CreateWorkout(workoutName);
                string workoutFilePath = Path.Combine("workouts", workoutName + ".txt");
                var workoutFile = File.Create(workoutFilePath);
                workoutFile.Close();
                createWorkoutForm.ShowDialog();
                LoadWorkouts();
            }
            else
            {
                MessageBox.Show("Enter a workout name.");
                return;
            }
        }

        private void editWorkout_Click(object sender, EventArgs e)
        {
            string selectedWorkout = workoutsList.SelectedItem.ToString();
            if (selectedWorkout != null)
            {
                this.Close();
                CreateWorkout editWorkoutForm = new CreateWorkout(selectedWorkout);
                editWorkoutForm.ShowDialog();
                LoadWorkouts();
            }
        }

        private void deleteWorkout_Click(object sender, EventArgs e)
        {

            if (workoutsList.SelectedItem != null)
            {
                var confirmResult = MessageBox.Show("Are you sure you want to delete this workout?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    // If 'Yes', do something here.

                    string selectedWorkout = workoutsList.SelectedItem.ToString();
                    workouts.Remove(selectedWorkout);
                    workoutsList.DataSource = null;
                    workoutsList.DataSource = workouts;
                    string workoutToDelete = Path.Combine("workouts", selectedWorkout + ".txt");
                    File.Delete(workoutToDelete);
                }

            }
        }

        private void startSession_Click(object sender, EventArgs e)
        {
            if (workoutsList.SelectedItem == null)
            {
                MessageBox.Show("Please select a workout to start a session.", "No Workout Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedWorkout = workoutsList.SelectedItem.ToString();

            // Open the WorkoutSession form
            WorkoutSession sessionForm = new WorkoutSession(selectedWorkout);
            sessionForm.ShowDialog();
        }
    }
}
