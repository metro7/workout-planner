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
        public ViewWorkouts()
        {
            InitializeComponent();
        }

        private void main_menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu menu = new MainMenu();
            menu.Show();
        }
    }
}
