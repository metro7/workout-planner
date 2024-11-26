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
        private string workoutName;
        private string workoutFilePath;
        private string sessionFilePath;

        public WorkoutSession(string workoutName)
        {
            InitializeComponent();
            InitializeSetDataGridView();
            this.workoutName = workoutName;

            workoutFilePath = Path.Combine("Workouts", workoutName + ".txt");
            sessionFilePath = Path.Combine("WorkoutSessions", workoutName + $"_Session_{DateTime.Now:yyyyMMdd_HHmmss}.txt");

            lblWorkoutName.Text = $"Workout: {workoutName}";
            LoadExercises();

            lbExercises.SelectedIndexChanged += (s, e) => LoadExerciseSets();
            dgvSetData.CellValueChanged += (s, e) => SaveSetData(e.RowIndex, e.ColumnIndex);
            btnFinishSession.Click += (s, e) => FinishSession();
        }

        private void LoadExercises()
        {
            if (!File.Exists(workoutFilePath))
            {
                MessageBox.Show($"Workout file '{workoutFilePath}' not found.");
                Close();
                return;
            }

            lbExercises.Items.Clear();

            // loads exercises from workout file
            foreach (var line in File.ReadAllLines(workoutFilePath))
            {
                var exerciseName = line.Split('|')[0];
                lbExercises.Items.Add(exerciseName);
            }
        }

        private void LoadExerciseSets()
        {
            if (lbExercises.SelectedItem == null) return;

            string selectedExercise = lbExercises.SelectedItem.ToString();
            dgvSetData.Rows.Clear();

            var exerciseDetails = File.ReadAllLines(workoutFilePath)
                .FirstOrDefault(line => line.StartsWith(selectedExercise));

            if (exerciseDetails == null)
            {
                MessageBox.Show($"Details for exercise '{selectedExercise}' not found in workout file.");
                return;
            }

            // Format data
            var parts = exerciseDetails.Split('|');
            if (parts.Length < 4) return;

            int sets = int.Parse(parts[1]);
            int minReps = int.Parse(parts[2]);
            int maxReps = int.Parse(parts[3]);

            for (int i = 1; i <= sets; i++)
            {
                dgvSetData.Rows.Add(i, $"{minReps}-{maxReps}", "");
            }

            dgvSetData.AllowUserToAddRows = false;

            // Load session data if exists
            if (File.Exists(sessionFilePath))
            {
                var sessionData = File.ReadAllLines(sessionFilePath)
                    .Where(line => line.StartsWith(selectedExercise))
                    .ToList();

                foreach (var line in sessionData)
                {
                    var sessionParts = line.Split('|');
                    if (sessionParts.Length == 4)
                    {
                        int setNumber = int.Parse(sessionParts[1]);
                        if (setNumber <= dgvSetData.Rows.Count)
                        {
                            dgvSetData.Rows[setNumber - 1].Cells[1].Value = sessionParts[2];
                            dgvSetData.Rows[setNumber - 1].Cells[2].Value = sessionParts[3];
                        }
                    }
                }
            }
        }

        private void SaveSetData(int rowIndex, int columnIndex)
        {
            if (rowIndex < 0 || lbExercises.SelectedItem == null) return;

            string selectedExercise = lbExercises.SelectedItem.ToString();
            var row = dgvSetData.Rows[rowIndex];
            if (row.Cells[0].Value == null || row.Cells[1].Value == null || row.Cells[2].Value == null) return;

            int setNumber = int.Parse(row.Cells[0].Value.ToString());
            string reps = row.Cells[1].Value.ToString();
            string weight = row.Cells[2].Value.ToString();

            // Remove existing data for this set
            var allLines = File.Exists(sessionFilePath) ? File.ReadAllLines(sessionFilePath).ToList() : new List<string>();
            allLines.RemoveAll(line => line.StartsWith($"{selectedExercise}|{setNumber}|"));

            // Add updated data
            allLines.Add($"{selectedExercise}|{setNumber}|{reps}|{weight}");
            File.WriteAllLines(sessionFilePath, allLines);
        }

        private void InitializeSetDataGridView()
        {
            dgvSetData.AllowUserToAddRows = false;
            dgvSetData.RowHeadersVisible = false;
            dgvSetData.Columns["SetNumber"].ReadOnly = true;
        }

        private void FinishSession()
        {
            MessageBox.Show("Workout session finished!");
            Close();
        }
    }
}
