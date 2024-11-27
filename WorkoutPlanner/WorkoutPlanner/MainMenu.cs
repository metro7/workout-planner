namespace WorkoutPlanner
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewExercises exercises = new ViewExercises();
            exercises.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewWorkouts workouts = new ViewWorkouts();
            workouts.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            WorkoutHistory history = new WorkoutHistory();
            history.Show();
        }
    }
}