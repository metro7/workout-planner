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
            selectExercise = new ListBox();
            numberOfSetsBox = new TextBox();
            minRepsBox = new TextBox();
            maxRepsBox = new TextBox();
            cancelExercise = new Button();
            saveExercise = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // Workouts
            // 
            Workouts.Anchor = AnchorStyles.Top;
            Workouts.AutoSize = true;
            Workouts.FlatStyle = FlatStyle.Flat;
            Workouts.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            Workouts.ForeColor = Color.White;
            Workouts.Location = new Point(376, 23);
            Workouts.Name = "Workouts";
            Workouts.Size = new Size(336, 44);
            Workouts.TabIndex = 14;
            Workouts.Text = "Add/Edit Exercise";
            // 
            // selectExercise
            // 
            selectExercise.Anchor = AnchorStyles.Top;
            selectExercise.FormattingEnabled = true;
            selectExercise.ItemHeight = 15;
            selectExercise.Location = new Point(376, 103);
            selectExercise.Name = "selectExercise";
            selectExercise.Size = new Size(336, 184);
            selectExercise.TabIndex = 15;
            // 
            // numberOfSetsBox
            // 
            numberOfSetsBox.Anchor = AnchorStyles.Top;
            numberOfSetsBox.Location = new Point(376, 344);
            numberOfSetsBox.Name = "numberOfSetsBox";
            numberOfSetsBox.Size = new Size(336, 23);
            numberOfSetsBox.TabIndex = 16;
            // 
            // minRepsBox
            // 
            minRepsBox.Anchor = AnchorStyles.Top;
            minRepsBox.Location = new Point(376, 426);
            minRepsBox.Name = "minRepsBox";
            minRepsBox.Size = new Size(129, 23);
            minRepsBox.TabIndex = 17;
            // 
            // maxRepsBox
            // 
            maxRepsBox.Anchor = AnchorStyles.Top;
            maxRepsBox.Location = new Point(583, 426);
            maxRepsBox.Name = "maxRepsBox";
            maxRepsBox.Size = new Size(129, 23);
            maxRepsBox.TabIndex = 18;
            // 
            // cancelExercise
            // 
            cancelExercise.Anchor = AnchorStyles.Top;
            cancelExercise.FlatStyle = FlatStyle.Flat;
            cancelExercise.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            cancelExercise.ForeColor = Color.White;
            cancelExercise.Location = new Point(338, 503);
            cancelExercise.Name = "cancelExercise";
            cancelExercise.Size = new Size(167, 59);
            cancelExercise.TabIndex = 19;
            cancelExercise.Text = "Cancel";
            cancelExercise.UseVisualStyleBackColor = true;
            cancelExercise.Click += cancelExercise_Click;
            // 
            // saveExercise
            // 
            saveExercise.Anchor = AnchorStyles.Top;
            saveExercise.FlatStyle = FlatStyle.Flat;
            saveExercise.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            saveExercise.ForeColor = Color.White;
            saveExercise.Location = new Point(583, 503);
            saveExercise.Name = "saveExercise";
            saveExercise.Size = new Size(167, 59);
            saveExercise.TabIndex = 20;
            saveExercise.Text = "Save Exercise";
            saveExercise.UseVisualStyleBackColor = true;
            saveExercise.Click += saveExercise_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(376, 323);
            label1.Name = "label1";
            label1.Size = new Size(135, 18);
            label1.TabIndex = 21;
            label1.Text = "Number of Sets:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(376, 405);
            label2.Name = "label2";
            label2.Size = new Size(101, 18);
            label2.TabIndex = 22;
            label2.Text = "Rep Range:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(531, 426);
            label3.Name = "label3";
            label3.Size = new Size(24, 18);
            label3.TabIndex = 23;
            label3.Text = "to";
            // 
            // AddEditExercise
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1083, 629);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(saveExercise);
            Controls.Add(cancelExercise);
            Controls.Add(maxRepsBox);
            Controls.Add(minRepsBox);
            Controls.Add(numberOfSetsBox);
            Controls.Add(selectExercise);
            Controls.Add(Workouts);
            Name = "AddEditExercise";
            Text = "AddEditExercise";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Workouts;
        private ListBox selectExercise;
        private TextBox numberOfSetsBox;
        private TextBox minRepsBox;
        private TextBox maxRepsBox;
        private Button cancelExercise;
        private Button saveExercise;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}