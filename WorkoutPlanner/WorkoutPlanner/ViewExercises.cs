using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkoutPlanner.Properties;

namespace WorkoutPlanner
{
    public partial class ViewExercises : Form
    {


        public ViewExercises()
        {
            InitializeComponent();
        }

        private void ViewExercises_Load(object sender, EventArgs e)
        {
            
            string pathToExercises = Application.StartupPath.ToString() + "Exercises.txt";
            
            if (File.Exists(pathToExercises))
            {
                // Read all lines from the file and add them to the ListBox
                string[] lines = File.ReadAllLines(pathToExercises);
                exercisesList.Items.Clear();
                exercisesList.Items.AddRange(lines);
            }

        }


        private void main_menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu menu = new MainMenu();
            menu.Show();
        }

        private void exercisesList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addExercise_Click(object sender, EventArgs e)
        {
            string newLine = exerciseName.Text;

            if (string.IsNullOrEmpty(exerciseName.Text))
            {
                return;
            }
            exercisesList.Items.Add(newLine);

            string pathToExercises = Application.StartupPath.ToString() + "Exercises.txt";
            File.AppendAllText(pathToExercises, newLine + Environment.NewLine);

            

            exerciseName.Clear();
            exerciseName.Focus();
        }

        private void removeExercise_Click(object sender, EventArgs e)
        {
            if(exercisesList != null)
            {
                string exerciseToRemove = exercisesList.SelectedItem.ToString();

                exercisesList.Items.Remove(exerciseToRemove);

                string pathToExercises = Application.StartupPath.ToString() + "Exercises.txt";

                string[] lines = File.ReadAllLines(pathToExercises);

                var updatedLines = lines.Where(line => line != exerciseToRemove).ToArray();

                File.WriteAllLines(pathToExercises, updatedLines);
            }
            
        }

    }
}
