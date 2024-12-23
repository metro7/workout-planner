﻿using System;
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
    public partial class WorkoutHistory : Form
    {
        public WorkoutHistory()
        {
            InitializeComponent();
            string[] sessionFiles = Directory.GetFiles("WorkoutSessions", "*.txt");
            sessions.Items.AddRange(sessionFiles.Select(Path.GetFileName).ToArray());
        }

        private void main_menu_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu menu = new MainMenu();
            menu.Show();
        }

        private void sessionDetails_Click(object sender, EventArgs e)
        {
            if (sessions.SelectedItem != null)
            {
                string sessionFiles = Path.Combine("WorkoutSessions", sessions.SelectedItem.ToString());
                SessionDetails detailsForm = new SessionDetails(sessionFiles);
                detailsForm.ShowDialog();
            }
        }
    }
}
