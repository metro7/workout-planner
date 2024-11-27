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
    public partial class SessionDetails : Form
    {

        private string sessionFile;

        public SessionDetails(string sessionFile)
        {
            this.sessionFile = sessionFile;
            InitializeComponent();
        }

        private void SessionDetailsForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(sessionFile))
            {
                string[] sessionData = File.ReadAllLines(sessionFile);
                foreach (var line in sessionData)
                {
                    var parts = line.Split('|');
                    if (parts.Length == 4)
                    {
                        dgvSessionDetails.Rows.Add(parts[0], parts[1], parts[2], parts[3]);
                    }
                }
            }
            else
            {
                MessageBox.Show("Session file not found.");
                this.Close();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
