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
            SuspendLayout();
            // 
            // main_menu
            // 
            main_menu.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            main_menu.FlatStyle = FlatStyle.Flat;
            main_menu.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            main_menu.ForeColor = Color.White;
            main_menu.Location = new Point(771, 453);
            main_menu.Name = "main_menu";
            main_menu.Size = new Size(108, 59);
            main_menu.TabIndex = 1;
            main_menu.Text = "Main Menu";
            main_menu.UseVisualStyleBackColor = true;
            main_menu.Click += main_menu_Click;
            // 
            // ViewWorkouts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(891, 524);
            Controls.Add(main_menu);
            Name = "ViewWorkouts";
            Text = "ViewWorkouts";
            ResumeLayout(false);
        }

        #endregion

        private Button main_menu;
    }
}