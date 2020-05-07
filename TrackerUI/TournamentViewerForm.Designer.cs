namespace TrackerUI
{
    partial class TournamentViewerForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.headerLable = new System.Windows.Forms.Label();
            this.tournamentName = new System.Windows.Forms.Label();
            this.roundLable = new System.Windows.Forms.Label();
            this.roundDropDown = new System.Windows.Forms.ComboBox();
            this.UnplayedOnlycheckBox = new System.Windows.Forms.CheckBox();
            this.matchuplistBox = new System.Windows.Forms.ListBox();
            this.teamOneName = new System.Windows.Forms.Label();
            this.TeamOneScorelabel = new System.Windows.Forms.Label();
            this.teamOneScoreValue = new System.Windows.Forms.TextBox();
            this.teamTwoScoreValue = new System.Windows.Forms.TextBox();
            this.TeamTwoScorelabel = new System.Windows.Forms.Label();
            this.teamTwoName = new System.Windows.Forms.Label();
            this.versusLabel = new System.Windows.Forms.Label();
            this.scoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLable
            // 
            this.headerLable.AutoSize = true;
            this.headerLable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.headerLable.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.headerLable.Location = new System.Drawing.Point(11, 9);
            this.headerLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.headerLable.Name = "headerLable";
            this.headerLable.Size = new System.Drawing.Size(99, 21);
            this.headerLable.TabIndex = 0;
            this.headerLable.Text = "Tournament:";
            // 
            // tournamentName
            // 
            this.tournamentName.AutoSize = true;
            this.tournamentName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tournamentName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tournamentName.Location = new System.Drawing.Point(130, 9);
            this.tournamentName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tournamentName.Name = "tournamentName";
            this.tournamentName.Size = new System.Drawing.Size(67, 21);
            this.tournamentName.TabIndex = 1;
            this.tournamentName.Text = "<none>";
            // 
            // roundLable
            // 
            this.roundLable.AutoSize = true;
            this.roundLable.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.roundLable.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.roundLable.Location = new System.Drawing.Point(12, 44);
            this.roundLable.Name = "roundLable";
            this.roundLable.Size = new System.Drawing.Size(52, 20);
            this.roundLable.TabIndex = 2;
            this.roundLable.Text = "Round";
            // 
            // roundDropDown
            // 
            this.roundDropDown.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.roundDropDown.FormattingEnabled = true;
            this.roundDropDown.Location = new System.Drawing.Point(87, 36);
            this.roundDropDown.Name = "roundDropDown";
            this.roundDropDown.Size = new System.Drawing.Size(146, 28);
            this.roundDropDown.TabIndex = 3;
            this.roundDropDown.SelectedIndexChanged += new System.EventHandler(this.roundDropDown_SelectedIndexChanged);
            // 
            // UnplayedOnlycheckBox
            // 
            this.UnplayedOnlycheckBox.AutoSize = true;
            this.UnplayedOnlycheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnplayedOnlycheckBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UnplayedOnlycheckBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.UnplayedOnlycheckBox.Location = new System.Drawing.Point(87, 80);
            this.UnplayedOnlycheckBox.Name = "UnplayedOnlycheckBox";
            this.UnplayedOnlycheckBox.Size = new System.Drawing.Size(122, 24);
            this.UnplayedOnlycheckBox.TabIndex = 4;
            this.UnplayedOnlycheckBox.Text = "Unplayed Only";
            this.UnplayedOnlycheckBox.UseVisualStyleBackColor = true;
            // 
            // matchuplistBox
            // 
            this.matchuplistBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchuplistBox.FormattingEnabled = true;
            this.matchuplistBox.ItemHeight = 21;
            this.matchuplistBox.Location = new System.Drawing.Point(16, 124);
            this.matchuplistBox.Name = "matchuplistBox";
            this.matchuplistBox.Size = new System.Drawing.Size(217, 212);
            this.matchuplistBox.TabIndex = 5;
            // 
            // teamOneName
            // 
            this.teamOneName.AutoSize = true;
            this.teamOneName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teamOneName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.teamOneName.Location = new System.Drawing.Point(256, 124);
            this.teamOneName.Name = "teamOneName";
            this.teamOneName.Size = new System.Drawing.Size(92, 20);
            this.teamOneName.TabIndex = 6;
            this.teamOneName.Text = "<team one>";
            // 
            // TeamOneScorelabel
            // 
            this.TeamOneScorelabel.AutoSize = true;
            this.TeamOneScorelabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TeamOneScorelabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TeamOneScorelabel.Location = new System.Drawing.Point(256, 158);
            this.TeamOneScorelabel.Name = "TeamOneScorelabel";
            this.TeamOneScorelabel.Size = new System.Drawing.Size(46, 20);
            this.TeamOneScorelabel.TabIndex = 7;
            this.TeamOneScorelabel.Text = "Score";
            // 
            // teamOneScoreValue
            // 
            this.teamOneScoreValue.Location = new System.Drawing.Point(322, 149);
            this.teamOneScoreValue.Name = "teamOneScoreValue";
            this.teamOneScoreValue.Size = new System.Drawing.Size(100, 29);
            this.teamOneScoreValue.TabIndex = 9;
            // 
            // teamTwoScoreValue
            // 
            this.teamTwoScoreValue.Location = new System.Drawing.Point(322, 249);
            this.teamTwoScoreValue.Name = "teamTwoScoreValue";
            this.teamTwoScoreValue.Size = new System.Drawing.Size(100, 29);
            this.teamTwoScoreValue.TabIndex = 12;
            // 
            // TeamTwoScorelabel
            // 
            this.TeamTwoScorelabel.AutoSize = true;
            this.TeamTwoScorelabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TeamTwoScorelabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TeamTwoScorelabel.Location = new System.Drawing.Point(256, 258);
            this.TeamTwoScorelabel.Name = "TeamTwoScorelabel";
            this.TeamTwoScorelabel.Size = new System.Drawing.Size(46, 20);
            this.TeamTwoScorelabel.TabIndex = 11;
            this.TeamTwoScorelabel.Text = "Score";
            // 
            // teamTwoName
            // 
            this.teamTwoName.AutoSize = true;
            this.teamTwoName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teamTwoName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.teamTwoName.Location = new System.Drawing.Point(256, 224);
            this.teamTwoName.Name = "teamTwoName";
            this.teamTwoName.Size = new System.Drawing.Size(92, 20);
            this.teamTwoName.TabIndex = 10;
            this.teamTwoName.Text = "<team two>";
            // 
            // versusLabel
            // 
            this.versusLabel.AutoSize = true;
            this.versusLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.versusLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.versusLabel.Location = new System.Drawing.Point(292, 195);
            this.versusLabel.Name = "versusLabel";
            this.versusLabel.Size = new System.Drawing.Size(26, 20);
            this.versusLabel.TabIndex = 13;
            this.versusLabel.Text = "VS";
            // 
            // scoreButton
            // 
            this.scoreButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.scoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.scoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.scoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scoreButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.scoreButton.Location = new System.Drawing.Point(467, 195);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(88, 49);
            this.scoreButton.TabIndex = 14;
            this.scoreButton.Text = "Score";
            this.scoreButton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(594, 353);
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.versusLabel);
            this.Controls.Add(this.teamTwoScoreValue);
            this.Controls.Add(this.TeamTwoScorelabel);
            this.Controls.Add(this.teamTwoName);
            this.Controls.Add(this.teamOneScoreValue);
            this.Controls.Add(this.TeamOneScorelabel);
            this.Controls.Add(this.teamOneName);
            this.Controls.Add(this.matchuplistBox);
            this.Controls.Add(this.UnplayedOnlycheckBox);
            this.Controls.Add(this.roundDropDown);
            this.Controls.Add(this.roundLable);
            this.Controls.Add(this.tournamentName);
            this.Controls.Add(this.headerLable);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TournamentViewerForm";
            this.Text = "Tournament Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLable;
        private System.Windows.Forms.Label tournamentName;
        private System.Windows.Forms.Label roundLable;
        private System.Windows.Forms.ComboBox roundDropDown;
        private System.Windows.Forms.CheckBox UnplayedOnlycheckBox;
        private System.Windows.Forms.ListBox matchuplistBox;
        private System.Windows.Forms.Label teamOneName;
        private System.Windows.Forms.Label TeamOneScorelabel;
        private System.Windows.Forms.TextBox teamOneScoreValue;
        private System.Windows.Forms.TextBox teamTwoScoreValue;
        private System.Windows.Forms.Label TeamTwoScorelabel;
        private System.Windows.Forms.Label teamTwoName;
        private System.Windows.Forms.Label versusLabel;
        private System.Windows.Forms.Button scoreButton;
    }
}

