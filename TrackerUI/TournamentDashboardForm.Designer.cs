namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            this.TournamentDashboardLable = new System.Windows.Forms.Label();
            this.LoadExistingTournamentDropDown = new System.Windows.Forms.ComboBox();
            this.LoadExistingTournamentLable = new System.Windows.Forms.Label();
            this.loadTournamentButton = new System.Windows.Forms.Button();
            this.createTournamentBotton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TournamentDashboardLable
            // 
            this.TournamentDashboardLable.AutoSize = true;
            this.TournamentDashboardLable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TournamentDashboardLable.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TournamentDashboardLable.Location = new System.Drawing.Point(69, 19);
            this.TournamentDashboardLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TournamentDashboardLable.Name = "TournamentDashboardLable";
            this.TournamentDashboardLable.Size = new System.Drawing.Size(177, 21);
            this.TournamentDashboardLable.TabIndex = 14;
            this.TournamentDashboardLable.Text = "Tournament Dashboard";
            // 
            // LoadExistingTournamentDropDown
            // 
            this.LoadExistingTournamentDropDown.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LoadExistingTournamentDropDown.FormattingEnabled = true;
            this.LoadExistingTournamentDropDown.Location = new System.Drawing.Point(18, 95);
            this.LoadExistingTournamentDropDown.Name = "LoadExistingTournamentDropDown";
            this.LoadExistingTournamentDropDown.Size = new System.Drawing.Size(304, 28);
            this.LoadExistingTournamentDropDown.TabIndex = 20;
            // 
            // LoadExistingTournamentLable
            // 
            this.LoadExistingTournamentLable.AutoSize = true;
            this.LoadExistingTournamentLable.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LoadExistingTournamentLable.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LoadExistingTournamentLable.Location = new System.Drawing.Point(69, 58);
            this.LoadExistingTournamentLable.Name = "LoadExistingTournamentLable";
            this.LoadExistingTournamentLable.Size = new System.Drawing.Size(181, 20);
            this.LoadExistingTournamentLable.TabIndex = 21;
            this.LoadExistingTournamentLable.Text = "Load Existing Tournament";
            // 
            // loadTournamentButton
            // 
            this.loadTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.loadTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.loadTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.loadTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loadTournamentButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.loadTournamentButton.Location = new System.Drawing.Point(76, 129);
            this.loadTournamentButton.Name = "loadTournamentButton";
            this.loadTournamentButton.Size = new System.Drawing.Size(170, 30);
            this.loadTournamentButton.TabIndex = 34;
            this.loadTournamentButton.Text = "Load Tournament";
            this.loadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // createTournamentBotton
            // 
            this.createTournamentBotton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.createTournamentBotton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.createTournamentBotton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.createTournamentBotton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentBotton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createTournamentBotton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.createTournamentBotton.Location = new System.Drawing.Point(76, 177);
            this.createTournamentBotton.Name = "createTournamentBotton";
            this.createTournamentBotton.Size = new System.Drawing.Size(170, 37);
            this.createTournamentBotton.TabIndex = 35;
            this.createTournamentBotton.Text = "Create Tournament";
            this.createTournamentBotton.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(336, 243);
            this.Controls.Add(this.createTournamentBotton);
            this.Controls.Add(this.loadTournamentButton);
            this.Controls.Add(this.LoadExistingTournamentLable);
            this.Controls.Add(this.LoadExistingTournamentDropDown);
            this.Controls.Add(this.TournamentDashboardLable);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TournamentDashboardForm";
            this.Text = "Tournament Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TournamentDashboardLable;
        private System.Windows.Forms.ComboBox LoadExistingTournamentDropDown;
        private System.Windows.Forms.Label LoadExistingTournamentLable;
        private System.Windows.Forms.Button loadTournamentButton;
        private System.Windows.Forms.Button createTournamentBotton;
    }
}