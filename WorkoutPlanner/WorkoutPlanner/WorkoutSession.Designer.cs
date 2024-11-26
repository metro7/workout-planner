namespace WorkoutPlanner
{
    partial class WorkoutSession
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblWorkoutName;
        private ListBox lbExercises;
        private DataGridView dgvSetData;
        private Button btnSaveProgress;
        private Button btnFinishSession;

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblWorkoutName = new Label();
            lbExercises = new ListBox();
            dgvSetData = new DataGridView();
            btnSaveProgress = new Button();
            btnFinishSession = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSetData).BeginInit();
            SuspendLayout();
            // 
            // lblWorkoutName
            // 
            lblWorkoutName.AutoSize = true;
            lblWorkoutName.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblWorkoutName.ForeColor = Color.White;
            lblWorkoutName.Location = new Point(20, 10);
            lblWorkoutName.Name = "lblWorkoutName";
            lblWorkoutName.Size = new Size(205, 29);
            lblWorkoutName.TabIndex = 0;
            lblWorkoutName.Text = "Workout: [Name]";
            // 
            // lbExercises
            // 
            lbExercises.FormattingEnabled = true;
            lbExercises.ItemHeight = 15;
            lbExercises.Location = new Point(20, 40);
            lbExercises.Name = "lbExercises";
            lbExercises.Size = new Size(407, 199);
            lbExercises.TabIndex = 1;
            // 
            // dgvSetData
            // 
            dgvSetData.AllowUserToAddRows = false;
            dgvSetData.AllowUserToDeleteRows = false;
            dgvSetData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSetData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSetData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            
            dgvSetData.Location = new Point(20, 260);
            dgvSetData.Name = "dgvSetData";
            dgvSetData.RowHeadersVisible = false;
            dgvSetData.RowTemplate.Height = 25;
            dgvSetData.Size = new Size(607, 287);
            dgvSetData.TabIndex = 2;
            DataGridViewTextBoxColumn setColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Set #",
                Name = "SetNumber",
                ReadOnly = true,
                Width = 50
            };
            dgvSetData.Columns.Add(setColumn);
            DataGridViewTextBoxColumn repsColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Reps",
                Name = "Reps",
                Width = 100
            };
            dgvSetData.Columns.Add(repsColumn);
            DataGridViewTextBoxColumn weightColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Weight",
                Name = "Weight",
                Width = 100
            };
            dgvSetData.Columns.Add(weightColumn);

            // 
            // btnSaveProgress
            // 
            btnSaveProgress.Anchor = AnchorStyles.None;
            btnSaveProgress.FlatStyle = FlatStyle.Popup;
            btnSaveProgress.Location = new Point(2, 604);
            btnSaveProgress.Name = "btnSaveProgress";
            btnSaveProgress.Size = new Size(12, 10);
            btnSaveProgress.TabIndex = 3;
            btnSaveProgress.UseVisualStyleBackColor = false;
            // 
            // btnFinishSession
            // 
            btnFinishSession.Anchor = AnchorStyles.Bottom;
            btnFinishSession.FlatStyle = FlatStyle.Flat;
            btnFinishSession.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnFinishSession.ForeColor = Color.White;
            btnFinishSession.Location = new Point(253, 567);
            btnFinishSession.Name = "btnFinishSession";
            btnFinishSession.Size = new Size(150, 38);
            btnFinishSession.TabIndex = 4;
            btnFinishSession.Text = "Finish Workout";
            btnFinishSession.UseVisualStyleBackColor = false;
            // 
            // WorkoutSession
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(651, 617);
            Controls.Add(btnFinishSession);
            Controls.Add(btnSaveProgress);
            Controls.Add(dgvSetData);
            Controls.Add(lbExercises);
            Controls.Add(lblWorkoutName);
            Name = "WorkoutSession";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Workout Session";
            ((System.ComponentModel.ISupportInitialize)dgvSetData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
