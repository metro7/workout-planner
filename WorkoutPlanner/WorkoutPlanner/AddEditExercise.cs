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
    public partial class AddEditExercise : Form
    {
        private string workoutName;
        private string currentExercise;

        public AddEditExercise(string workoutName, string exercise = null)
        {
            InitializeComponent();
            LoadExerciseList();
            this.workoutName = workoutName;
            currentExercise = exercise;


            if (exercise != null)
            {
                string[] parts = exercise.Split('|');
                selectExercise.Text = parts[0];
                numberOfSetsBox.Text = parts[1];
                minRepsBox.Text = parts[2];
                maxRepsBox.Text = parts[3];
            }

        }

        private void LoadExerciseList()
        {
            string path = "exercises.txt";
            if (File.Exists(path))
            {
                var exercises = File.ReadAllLines(path);
                selectExercise.Items.AddRange(exercises);
            }
        }

        private void saveExercise_Click(object sender, EventArgs e)
        {
            string name = selectExercise.Text.Trim();
            string sets = numberOfSetsBox.Text.Trim();
            string minReps = minRepsBox.Text.Trim();
            string maxReps = maxRepsBox.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(sets) ||
                string.IsNullOrEmpty(minReps) || string.IsNullOrEmpty(maxReps))
            {
                MessageBox.Show("Missing Field.");
                return;
            }

            string exercise = $"{name}|{sets}|{minReps}|{maxReps}";
            string workoutFile = Path.Combine("workouts", workoutName + ".txt");
            if (currentExercise != exercise)
            {
                string workoutToDelete = Path.Combine("workouts", "workoutToDelete" + ".txt");
                File.Copy(workoutFile, workoutToDelete);
                string line = null;
                string line_to_delete = currentExercise;

                using (StreamReader reader = new StreamReader(workoutToDelete))
                {
                    using (StreamWriter writer = new StreamWriter(workoutFile))
                    {
                        while ((line = reader.ReadLine()) != null)
                        {
                            if (String.Compare(line, line_to_delete) == 0)
                                continue;

                            writer.WriteLine(line);
                        }
                    }
                }
                
                File.Delete(workoutToDelete);
            }

            
            File.AppendAllText(workoutFile, exercise + Environment.NewLine);

            this.Close();
            CreateWorkout editWorkoutForm = new CreateWorkout(this.workoutName);
            editWorkoutForm.Show();
        }

        private void cancelExercise_Click(object sender, EventArgs e)
        {
            this.Close();
            CreateWorkout editWorkoutForm = new CreateWorkout(this.workoutName);
            editWorkoutForm.Show();
        }
    }
}
