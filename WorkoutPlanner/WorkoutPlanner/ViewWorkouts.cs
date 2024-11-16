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
    public partial class ViewWorkouts : Form
    {

        private List<Workout> workouts = new List<Workout>();

        public ViewWorkouts()
        {
            InitializeComponent();
        }

        private void ViewWorkouts_Load(object sender, EventArgs e)
        {
            string workoutFolderLocation = Application.StartupPath.ToString();
            string workoutFolderPath = System.IO.Path.Combine(workoutFolderLocation, "workouts");

            System.IO.Directory.CreateDirectory(workoutFolderPath);

            string pathToWorkouts = Application.StartupPath.ToString() + @"\workouts\";
            string[] workoutFiles = Directory.GetFiles(pathToWorkouts, "*.txt");

            foreach (string file in workoutFiles)
            {
                var workoutData = File.ReadAllLines(file);
                var workoutName = workoutData[0].Replace("Workout: ", "");
                var workout = new Workout(workoutName);

                for (int i = 1; i < workoutData.Length; i++)
                {
                    var line = workoutData[i];
                    var parts = line.Split(new[] { " - ", " sets, " }, StringSplitOptions.None);
                    if (parts.Length == 3)
                    {
                        workout.AddExercise(new Exercise(parts[0], int.Parse(parts[1]), parts[2]));
                    }
                }

                workouts.Add(workout);
                workoutsList.Items.Add(workoutName);
            }
        }

        private void main_menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu menu = new MainMenu();
            menu.Show();
        }

        private void createWorkout_Click(object sender, EventArgs e)
        {
            var createWorkoutForm = new CreateWorkout();
            createWorkoutForm.ShowDialog();
        }

        private void editWorkout_Click(object sender, EventArgs e)
        {
            if (workoutsList.SelectedItem == null)
            {
                return;
            }

            string selectedWorkoutName = workoutsList.SelectedItem.ToString();
            var selectedWorkout = workouts.FirstOrDefault(w => w.Name == selectedWorkoutName);

            if (selectedWorkout != null)
            {
                var createWorkoutForm = new CreateWorkout(selectedWorkout);
                createWorkoutForm.ShowDialog();
            }


        }
    }   
}
