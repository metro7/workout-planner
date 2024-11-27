namespace WorkoutPlanner
{
    partial class SessionDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvSessionDetails;

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
        /*private void InitializeComponent()
        {
            
        }*/
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvSessionDetails = new DataGridView();
            Exercise = new DataGridViewTextBoxColumn();
            SetNumber = new DataGridViewTextBoxColumn();
            Reps = new DataGridViewTextBoxColumn();
            Weight = new DataGridViewTextBoxColumn();
            backButton = new Button();
            History = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSessionDetails).BeginInit();
            SuspendLayout();
            // 
            // dgvSessionDetails
            // 
            dgvSessionDetails.AllowUserToAddRows = false;
            dgvSessionDetails.AllowUserToDeleteRows = false;
            dgvSessionDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSessionDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSessionDetails.Columns.AddRange(new DataGridViewColumn[] { Exercise, SetNumber, Reps, Weight });
            dgvSessionDetails.Location = new Point(12, 135);
            dgvSessionDetails.Name = "dgvSessionDetails";
            dgvSessionDetails.ReadOnly = true;
            dgvSessionDetails.RowHeadersVisible = false;
            dgvSessionDetails.Size = new Size(824, 359);
            dgvSessionDetails.TabIndex = 0;
            // 
            // Exercise
            // 
            Exercise.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Exercise.HeaderText = "Exercise";
            Exercise.Name = "Exercise";
            Exercise.ReadOnly = true;
            // 
            // SetNumber
            // 
            SetNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SetNumber.HeaderText = "Set#";
            SetNumber.Name = "SetNumber";
            SetNumber.ReadOnly = true;
            // 
            // Reps
            // 
            Reps.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Reps.HeaderText = "Reps";
            Reps.Name = "Reps";
            Reps.ReadOnly = true;
            // 
            // Weight
            // 
            Weight.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Weight.HeaderText = "Weight";
            Weight.Name = "Weight";
            Weight.ReadOnly = true;
            // 
            // backButton
            // 
            backButton.Anchor = AnchorStyles.Bottom;
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            backButton.ForeColor = Color.White;
            backButton.Location = new Point(371, 578);
            backButton.Name = "backButton";
            backButton.Size = new Size(108, 59);
            backButton.TabIndex = 8;
            backButton.Text = "Close";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // History
            // 
            History.Anchor = AnchorStyles.Top;
            History.AutoSize = true;
            History.FlatStyle = FlatStyle.Flat;
            History.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            History.ForeColor = Color.White;
            History.Location = new Point(270, 44);
            History.Name = "History";
            History.Size = new Size(295, 44);
            History.TabIndex = 9;
            History.Text = "Session Details";
            // 
            // SessionDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(846, 647);
            Controls.Add(History);
            Controls.Add(backButton);
            Controls.Add(dgvSessionDetails);
            MaximizeBox = false;
            Name = "SessionDetails";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Session Details";
            Load += SessionDetailsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSessionDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button backButton;
        private Label History;
        private DataGridViewTextBoxColumn Exercise;
        private DataGridViewTextBoxColumn SetNumber;
        private DataGridViewTextBoxColumn Reps;
        private DataGridViewTextBoxColumn Weight;
    }
}