namespace WorkoutPlanner
{
    partial class AddEditExercise
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Workouts = new Label();
            SuspendLayout();
            // 
            // Workouts
            // 
            Workouts.Anchor = AnchorStyles.Top;
            Workouts.AutoSize = true;
            Workouts.FlatStyle = FlatStyle.Flat;
            Workouts.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            Workouts.ForeColor = Color.White;
            Workouts.Location = new Point(303, 23);
            Workouts.Name = "Workouts";
            Workouts.Size = new Size(336, 44);
            Workouts.TabIndex = 14;
            Workouts.Text = "Add/Edit Exercise";
            // 
            // AddEditExercise
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(937, 598);
            Controls.Add(Workouts);
            Name = "AddEditExercise";
            Text = "AddEditExercise";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Workouts;
    }
}