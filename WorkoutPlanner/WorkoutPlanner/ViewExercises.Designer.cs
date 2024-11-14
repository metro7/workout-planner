namespace WorkoutPlanner
{
    partial class ViewExercises
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
            exercisesList = new ListBox();
            exerciseName = new TextBox();
            label1 = new Label();
            addExercise = new Button();
            removeExercise = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // main_menu
            // 
            main_menu.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            main_menu.FlatStyle = FlatStyle.Flat;
            main_menu.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            main_menu.ForeColor = Color.White;
            main_menu.Location = new Point(809, 537);
            main_menu.Name = "main_menu";
            main_menu.Size = new Size(108, 59);
            main_menu.TabIndex = 0;
            main_menu.Text = "Main Menu";
            main_menu.UseVisualStyleBackColor = true;
            main_menu.Click += main_menu_Click;
            // 
            // exercisesList
            // 
            exercisesList.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            exercisesList.FormattingEnabled = true;
            exercisesList.ItemHeight = 15;
            exercisesList.Location = new Point(230, 119);
            exercisesList.Name = "exercisesList";
            exercisesList.Size = new Size(500, 274);
            exercisesList.TabIndex = 1;
            exercisesList.SelectedIndexChanged += exercisesList_SelectedIndexChanged;
            // 
            // exerciseName
            // 
            exerciseName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            exerciseName.Location = new Point(230, 90);
            exerciseName.Name = "exerciseName";
            exerciseName.Size = new Size(392, 23);
            exerciseName.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(373, 33);
            label1.Name = "label1";
            label1.Size = new Size(194, 44);
            label1.TabIndex = 3;
            label1.Text = "Exercises";
            // 
            // addExercise
            // 
            addExercise.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addExercise.FlatStyle = FlatStyle.Flat;
            addExercise.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            addExercise.ForeColor = Color.White;
            addExercise.Location = new Point(628, 90);
            addExercise.Name = "addExercise";
            addExercise.Size = new Size(102, 23);
            addExercise.TabIndex = 4;
            addExercise.Text = "Add";
            addExercise.UseVisualStyleBackColor = true;
            addExercise.Click += addExercise_Click;
            // 
            // removeExercise
            // 
            removeExercise.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            removeExercise.FlatStyle = FlatStyle.Flat;
            removeExercise.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            removeExercise.ForeColor = Color.White;
            removeExercise.Location = new Point(628, 399);
            removeExercise.Name = "removeExercise";
            removeExercise.Size = new Size(102, 23);
            removeExercise.TabIndex = 5;
            removeExercise.Text = "Remove";
            removeExercise.UseVisualStyleBackColor = true;
            removeExercise.Click += removeExercise_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(92, 91);
            label2.Name = "label2";
            label2.Size = new Size(132, 18);
            label2.TabIndex = 6;
            label2.Text = "Exercise Name:";
            // 
            // ViewExercises
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(929, 608);
            Controls.Add(label2);
            Controls.Add(removeExercise);
            Controls.Add(addExercise);
            Controls.Add(label1);
            Controls.Add(exerciseName);
            Controls.Add(exercisesList);
            Controls.Add(main_menu);
            Name = "ViewExercises";
            Text = "ViewExercises";
            Load += ViewExercises_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button main_menu;
        private ListBox exercisesList;
        private TextBox exerciseName;
        private Label label1;
        private Button addExercise;
        private Button removeExercise;
        private Label label2;
    }
}