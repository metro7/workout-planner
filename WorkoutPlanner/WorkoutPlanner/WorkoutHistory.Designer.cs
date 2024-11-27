namespace WorkoutPlanner
{
    partial class WorkoutHistory
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
            History = new Label();
            sessions = new ListBox();
            main_menu = new Button();
            sessionDetails = new Button();
            SuspendLayout();
            // 
            // History
            // 
            History.Anchor = AnchorStyles.Top;
            History.AutoSize = true;
            History.FlatStyle = FlatStyle.Flat;
            History.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            History.ForeColor = Color.White;
            History.Location = new Point(352, 58);
            History.Name = "History";
            History.Size = new Size(146, 44);
            History.TabIndex = 5;
            History.Text = "History";
            // 
            // sessions
            // 
            sessions.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            sessions.FormattingEnabled = true;
            sessions.ItemHeight = 15;
            sessions.Location = new Point(94, 168);
            sessions.Name = "sessions";
            sessions.Size = new Size(662, 184);
            sessions.TabIndex = 6;
            // 
            // main_menu
            // 
            main_menu.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            main_menu.FlatStyle = FlatStyle.Flat;
            main_menu.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            main_menu.ForeColor = Color.White;
            main_menu.Location = new Point(733, 575);
            main_menu.Name = "main_menu";
            main_menu.Size = new Size(108, 59);
            main_menu.TabIndex = 7;
            main_menu.Text = "Main Menu";
            main_menu.UseVisualStyleBackColor = true;
            main_menu.Click += main_menu_Click;
            // 
            // sessionDetails
            // 
            sessionDetails.Anchor = AnchorStyles.Top;
            sessionDetails.FlatStyle = FlatStyle.Flat;
            sessionDetails.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            sessionDetails.ForeColor = Color.White;
            sessionDetails.Location = new Point(302, 358);
            sessionDetails.Name = "sessionDetails";
            sessionDetails.Size = new Size(246, 59);
            sessionDetails.TabIndex = 8;
            sessionDetails.Text = "View Session Details";
            sessionDetails.UseVisualStyleBackColor = true;
            sessionDetails.Click += sessionDetails_Click;
            // 
            // WorkoutHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(853, 646);
            Controls.Add(sessionDetails);
            Controls.Add(main_menu);
            Controls.Add(sessions);
            Controls.Add(History);
            Name = "WorkoutHistory";
            Text = "WorkoutHistory";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label History;
        private ListBox sessions;
        private Button main_menu;
        private Button sessionDetails;
    }
}