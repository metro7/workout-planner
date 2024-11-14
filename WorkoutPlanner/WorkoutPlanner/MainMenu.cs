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
    }
}