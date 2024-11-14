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
            textBox1 = new TextBox();
            label1 = new Label();
            addExercise = new Button();
            SuspendLayout();
            // 
            // main_menu
            // 
            main_menu.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            main_menu.FlatStyle = FlatStyle.Flat;
            main_menu.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            main_menu.ForeColor = Color.White;
            main_menu.Location = new Point(834, 513);
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
            exercisesList.Size = new Size(525, 274);
            exercisesList.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(230, 417);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(345, 23);
            textBox1.TabIndex = 2;
            textBox1.Text = "Exercise Name:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(386, 33);
            label1.Name = "label1";
            label1.Size = new Size(194, 44);
            label1.TabIndex = 3;
            label1.Text = "Exercises";
            // 
            // addExercise
            // 
            addExercise.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            addExercise.FlatStyle = FlatStyle.Flat;
            addExercise.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            addExercise.ForeColor = Color.White;
            addExercise.Location = new Point(581, 402);
            addExercise.Name = "addExercise";
            addExercise.Size = new Size(174, 50);
            addExercise.TabIndex = 4;
            addExercise.Text = "Add Exercise";
            addExercise.UseVisualStyleBackColor = true;
            // 
            // ViewExercises
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(954, 584);
            Controls.Add(addExercise);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(exercisesList);
            Controls.Add(main_menu);
            Name = "ViewExercises";
            Text = "ViewExercises";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button main_menu;
        private ListBox exercisesList;
        private TextBox textBox1;
        private Label label1;
        private Button addExercise;
    }
}