namespace WorkoutPlanner
{
    partial class WorkoutSession
    {
        private System.ComponentModel.IContainer components = null;

        private ListBox exerciseListBox;
        private DataGridView sessionDataGridView;
        private Label lblRepRange;
        private Button btnSaveSession;
        private Button btnCancelSession;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.exerciseListBox = new System.Windows.Forms.ListBox();
            this.sessionDataGridView = new System.Windows.Forms.DataGridView();
            this.lblRepRange = new System.Windows.Forms.Label();
            this.btnSaveSession = new System.Windows.Forms.Button();
            this.btnCancelSession = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sessionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // exerciseListBox
            // 
            this.exerciseListBox.FormattingEnabled = true;
            this.exerciseListBox.Location = new System.Drawing.Point(12, 12);
            this.exerciseListBox.Name = "exerciseListBox";
            this.exerciseListBox.Size = new System.Drawing.Size(200, 290);
            this.exerciseListBox.TabIndex = 0;
            this.exerciseListBox.SelectedIndexChanged += new System.EventHandler(this.exerciseListBox_SelectedIndexChanged);
            // 
            // sessionDataGridView
            // 
            this.sessionDataGridView.AllowUserToAddRows = false;
            this.sessionDataGridView.AllowUserToDeleteRows = false;
            this.sessionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sessionDataGridView.Location = new System.Drawing.Point(230, 50);
            this.sessionDataGridView.Name = "sessionDataGridView";
            this.sessionDataGridView.Size = new System.Drawing.Size(400, 250);
            this.sessionDataGridView.TabIndex = 1;
            // 
            // lblRepRange
            // 
            this.lblRepRange.AutoSize = true;
            this.lblRepRange.Location = new System.Drawing.Point(230, 20);
            this.lblRepRange.Name = "lblRepRange";
            this.lblRepRange.Size = new System.Drawing.Size(63, 13);
            this.lblRepRange.TabIndex = 2;
            this.lblRepRange.Text = "Rep Range:";
            // 
            // btnSaveSession
            // 
            this.btnSaveSession.Location = new System.Drawing.Point(230, 320);
            this.btnSaveSession.Name = "btnSaveSession";
            this.btnSaveSession.Size = new System.Drawing.Size(200, 30);
            this.btnSaveSession.TabIndex = 3;
            this.btnSaveSession.Text = "Save Session";
            this.btnSaveSession.UseVisualStyleBackColor = true;
            this.btnSaveSession.Click += new System.EventHandler(this.btnSaveSession_Click);
            // 
            // btnCancelSession
            // 
            this.btnCancelSession.Location = new System.Drawing.Point(430, 320);
            this.btnCancelSession.Name = "btnCancelSession";
            this.btnCancelSession.Size = new System.Drawing.Size(200, 30);
            this.btnCancelSession.TabIndex = 4;
            this.btnCancelSession.Text = "Cancel";
            this.btnCancelSession.UseVisualStyleBackColor = true;
            this.btnCancelSession.Click += new System.EventHandler(this.btnCancelSession_Click);
            // 
            // WorkoutSession
            // 
            this.ClientSize = new System.Drawing.Size(644, 361);
            this.Controls.Add(this.btnCancelSession);
            this.Controls.Add(this.btnSaveSession);
            this.Controls.Add(this.lblRepRange);
            this.Controls.Add(this.sessionDataGridView);
            this.Controls.Add(this.exerciseListBox);
            this.Name = "WorkoutSession";
            this.Text = "Workout Session";
            ((System.ComponentModel.ISupportInitialize)(this.sessionDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
