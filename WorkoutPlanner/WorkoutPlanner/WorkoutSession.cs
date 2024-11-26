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
    public partial class WorkoutSession : Form
    {
        private string workoutFile;

        public WorkoutSession(string workoutName)
        {
            InitializeComponent();
            this.workoutFile = $"Workouts/{workoutName}.txt";
            LoadExercises();
            SetupDataGridView();
        }

        // Load exercises into the ListBox
        private void LoadExercises()
        {
            if (File.Exists(workoutFile))
            {
                var exercises = File.ReadAllLines(workoutFile);
                foreach (var exercise in exercises)
                {
                    var exerciseName = exercise.Split('|')[0];
                    exerciseListBox.Items.Add(exerciseName);
                }
            }
        }

        // Setup DataGridView for entering sets, reps, and weight
        private void SetupDataGridView()
        {
            sessionDataGridView.Columns.Add("Set", "Set");
            sessionDataGridView.Columns.Add("Reps", "Reps");
            sessionDataGridView.Columns.Add("Weight", "Weight");
        }

        // Populate DataGridView and display rep range when an exercise is selected
        private void exerciseListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (exerciseListBox.SelectedItem == null)
                return;

            sessionDataGridView.Rows.Clear();
            string selectedExercise = exerciseListBox.SelectedItem.ToString();
            var exerciseDetails = File.ReadAllLines(workoutFile)
                                      .FirstOrDefault(line => line.StartsWith(selectedExercise));
            if (exerciseDetails != null)
            {
                var parts = exerciseDetails.Split('|');
                string repRange = parts[2] + " - " + parts[3]; // Format: Min-Max
                lblRepRange.Text = $"Rep Range: {repRange}";
                int sets = Int32.Parse(parts[1]);
                for (int i = 1; i <= sets; i++) 
                {
                    sessionDataGridView.Rows.Add(i.ToString(), "", "");
                }
            }
        }

        // Save session data to a log file
        private void btnSaveSession_Click(object sender, EventArgs e)
        {
            if (exerciseListBox.SelectedItem == null)
            {
                MessageBox.Show("Please select an exercise before saving.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedExercise = exerciseListBox.SelectedItem.ToString();
            string sessionFile = $"Sessions/{Path.GetFileNameWithoutExtension(workoutFile)}_Session.txt";

            if (!Directory.Exists("Sessions"))
                Directory.CreateDirectory("Sessions");

            using (StreamWriter writer = new StreamWriter(sessionFile, true))
            {
                writer.WriteLine($"Exercise: {selectedExercise}");
                foreach (DataGridViewRow row in sessionDataGridView.Rows)
                {
                    if (row.Cells["Reps"].Value != null && row.Cells["Weight"].Value != null)
                    {
                        writer.WriteLine($"Set {row.Cells["Set"].Value}: {row.Cells["Reps"].Value} reps, {row.Cells["Weight"].Value} kg");
                    }
                }
                writer.WriteLine();
            }

            MessageBox.Show("Session saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Cancel session
        private void btnCancelSession_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
