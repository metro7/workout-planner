namespace WorkoutPlanner
{
    partial class ViewWorkouts
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
            main_menu = new Button();
            Workouts = new Label();
            createWorkout = new Button();
            startSession = new Button();
            workoutsList = new ListBox();
            editWorkout = new Button();
            deleteWorkout = new Button();
            SuspendLayout();
            // 
            // main_menu
            // 
            main_menu.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            main_menu.FlatStyle = FlatStyle.Flat;
            main_menu.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            main_menu.ForeColor = Color.White;
            main_menu.Location = new Point(833, 560);
            main_menu.Name = "main_menu";
            main_menu.Size = new Size(108, 59);
            main_menu.TabIndex = 1;
            main_menu.Text = "Main Menu";
            main_menu.UseVisualStyleBackColor = true;
            main_menu.Click += main_menu_Click;
            // 
            // Workouts
            // 
            Workouts.Anchor = AnchorStyles.Top;
            Workouts.AutoSize = true;
            Workouts.FlatStyle = FlatStyle.Flat;
            Workouts.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            Workouts.ForeColor = Color.White;
            Workouts.Location = new Point(379, 44);
            Workouts.Name = "Workouts";
            Workouts.Size = new Size(190, 44);
            Workouts.TabIndex = 4;
            Workouts.Text = "Workouts";
            // 
            // createWorkout
            // 
            createWorkout.Anchor = AnchorStyles.Top;
            createWorkout.FlatStyle = FlatStyle.Flat;
            createWorkout.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            createWorkout.ForeColor = Color.White;
            createWorkout.Location = new Point(347, 105);
            createWorkout.Name = "createWorkout";
            createWorkout.Size = new Size(250, 59);
            createWorkout.TabIndex = 5;
            createWorkout.Text = "Create New Workout";
            createWorkout.UseVisualStyleBackColor = true;
            createWorkout.Click += createWorkout_Click;
            // 
            // startSession
            // 
            startSession.Anchor = AnchorStyles.Top;
            startSession.FlatStyle = FlatStyle.Flat;
            startSession.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            startSession.ForeColor = Color.White;
            startSession.Location = new Point(473, 426);
            startSession.Name = "startSession";
            startSession.Size = new Size(187, 59);
            startSession.TabIndex = 6;
            startSession.Text = "Start Workout Session";
            startSession.UseVisualStyleBackColor = true;
            // 
            // workoutsList
            // 
            workoutsList.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            workoutsList.FormattingEnabled = true;
            workoutsList.ItemHeight = 15;
            workoutsList.Location = new Point(235, 191);
            workoutsList.Name = "workoutsList";
            workoutsList.Size = new Size(471, 229);
            workoutsList.TabIndex = 7;
            // 
            // editWorkout
            // 
            editWorkout.Anchor = AnchorStyles.Top;
            editWorkout.FlatStyle = FlatStyle.Flat;
            editWorkout.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            editWorkout.ForeColor = Color.White;
            editWorkout.Location = new Point(281, 426);
            editWorkout.Name = "editWorkout";
            editWorkout.Size = new Size(187, 59);
            editWorkout.TabIndex = 8;
            editWorkout.Text = "Edit Workout";
            editWorkout.UseVisualStyleBackColor = true;
            editWorkout.Click += editWorkout_Click;
            // 
            // deleteWorkout
            // 
            deleteWorkout.Anchor = AnchorStyles.Top;
            deleteWorkout.FlatStyle = FlatStyle.Flat;
            deleteWorkout.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            deleteWorkout.ForeColor = Color.White;
            deleteWorkout.Location = new Point(382, 491);
            deleteWorkout.Name = "deleteWorkout";
            deleteWorkout.Size = new Size(187, 59);
            deleteWorkout.TabIndex = 9;
            deleteWorkout.Text = "Delete Workout";
            deleteWorkout.UseVisualStyleBackColor = true;
            deleteWorkout.Click += deleteWorkout_Click;
            // 
            // ViewWorkouts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(953, 631);
            Controls.Add(deleteWorkout);
            Controls.Add(editWorkout);
            Controls.Add(workoutsList);
            Controls.Add(startSession);
            Controls.Add(createWorkout);
            Controls.Add(Workouts);
            Controls.Add(main_menu);
            Name = "ViewWorkouts";
            Text = "ViewWorkouts";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button main_menu;
        private Label Workouts;
        private Button createWorkout;
        private Button startSession;
        private ListBox workoutsList;
        private Button editWorkout;
        private Button deleteWorkout;
    }
}