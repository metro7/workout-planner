namespace WorkoutPlanner
{
    partial class CreateWorkout
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
            removeExercise = new Button();
            cancelButton = new Button();
            editExercise = new Button();
            addExercise = new Button();
            label2 = new Label();
            txtWorkoutName = new TextBox();
            Workouts = new Label();
            exercisesList = new ListBox();
            saveButton = new Button();
            SuspendLayout();
            // 
            // removeExercise
            // 
            removeExercise.Anchor = AnchorStyles.Top;
            removeExercise.FlatStyle = FlatStyle.Flat;
            removeExercise.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            removeExercise.ForeColor = Color.White;
            removeExercise.Location = new Point(455, 444);
            removeExercise.Name = "removeExercise";
            removeExercise.Size = new Size(231, 59);
            removeExercise.TabIndex = 6;
            removeExercise.Text = "Remove Exercise";
            removeExercise.UseVisualStyleBackColor = true;
            removeExercise.Click += removeExercise_Click;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Top;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cancelButton.ForeColor = Color.White;
            cancelButton.Location = new Point(218, 538);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(231, 59);
            cancelButton.TabIndex = 7;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // editExercise
            // 
            editExercise.Anchor = AnchorStyles.Top;
            editExercise.FlatStyle = FlatStyle.Flat;
            editExercise.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            editExercise.ForeColor = Color.White;
            editExercise.Location = new Point(218, 444);
            editExercise.Name = "editExercise";
            editExercise.Size = new Size(231, 59);
            editExercise.TabIndex = 8;
            editExercise.Text = "Edit Exercise";
            editExercise.UseVisualStyleBackColor = true;
            editExercise.Click += editExercise_Click;
            // 
            // addExercise
            // 
            addExercise.Anchor = AnchorStyles.Top;
            addExercise.FlatStyle = FlatStyle.Flat;
            addExercise.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            addExercise.ForeColor = Color.White;
            addExercise.Location = new Point(308, 144);
            addExercise.Name = "addExercise";
            addExercise.Size = new Size(295, 59);
            addExercise.TabIndex = 9;
            addExercise.Text = "Add Exercise";
            addExercise.UseVisualStyleBackColor = true;
            addExercise.Click += addExercise_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(185, 89);
            label2.Name = "label2";
            label2.Size = new Size(130, 18);
            label2.TabIndex = 11;
            label2.Text = "Workout Name:";
            // 
            // txtWorkoutName
            // 
            txtWorkoutName.Anchor = AnchorStyles.Top;
            txtWorkoutName.Location = new Point(321, 89);
            txtWorkoutName.Name = "txtWorkoutName";
            txtWorkoutName.Size = new Size(392, 23);
            txtWorkoutName.TabIndex = 12;
            // 
            // Workouts
            // 
            Workouts.Anchor = AnchorStyles.Top;
            Workouts.AutoSize = true;
            Workouts.FlatStyle = FlatStyle.Flat;
            Workouts.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            Workouts.ForeColor = Color.White;
            Workouts.Location = new Point(308, 23);
            Workouts.Name = "Workouts";
            Workouts.Size = new Size(375, 44);
            Workouts.TabIndex = 13;
            Workouts.Text = "Create/Edit Workout";
            // 
            // exercisesList
            // 
            exercisesList.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            exercisesList.FormattingEnabled = true;
            exercisesList.ItemHeight = 15;
            exercisesList.Location = new Point(197, 209);
            exercisesList.Name = "exercisesList";
            exercisesList.Size = new Size(517, 229);
            exercisesList.TabIndex = 14;
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.Top;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            saveButton.ForeColor = Color.White;
            saveButton.Location = new Point(455, 538);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(231, 59);
            saveButton.TabIndex = 15;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // CreateWorkout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(895, 648);
            Controls.Add(saveButton);
            Controls.Add(exercisesList);
            Controls.Add(Workouts);
            Controls.Add(txtWorkoutName);
            Controls.Add(label2);
            Controls.Add(addExercise);
            Controls.Add(editExercise);
            Controls.Add(cancelButton);
            Controls.Add(removeExercise);
            Name = "CreateWorkout";
            Text = "CreateWorkout";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button removeExercise;
        private Button cancelButton;
        private Button editExercise;
        private Button addExercise;
        private Label label2;
        private TextBox txtWorkoutName;
        private Label Workouts;
        private ListBox exercisesList;
        private Button saveButton;
    }
}