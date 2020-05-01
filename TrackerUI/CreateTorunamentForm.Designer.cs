namespace TrackerUI
{
    partial class CreateTorunamentForm
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
            this.CreateTournamentLable = new System.Windows.Forms.Label();
            this.TournamentNameValue = new System.Windows.Forms.TextBox();
            this.TournamentNameLable = new System.Windows.Forms.Label();
            this.EntryFeeValue = new System.Windows.Forms.TextBox();
            this.EntryFeeLable = new System.Windows.Forms.Label();
            this.SelectTeamDropDown = new System.Windows.Forms.ComboBox();
            this.SelectTeamLable = new System.Windows.Forms.Label();
            this.CreateNewTeamLink = new System.Windows.Forms.LinkLabel();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.tournamentPlayersListBox = new System.Windows.Forms.ListBox();
            this.tournamentPlayersLable = new System.Windows.Forms.Label();
            this.deleteSelectedPlayersButton = new System.Windows.Forms.Button();
            this.deleteSelectPrizeButton = new System.Windows.Forms.Button();
            this.prizesLable = new System.Windows.Forms.Label();
            this.prizesListBox = new System.Windows.Forms.ListBox();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateTournamentLable
            // 
            this.CreateTournamentLable.AutoSize = true;
            this.CreateTournamentLable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CreateTournamentLable.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.CreateTournamentLable.Location = new System.Drawing.Point(29, 20);
            this.CreateTournamentLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CreateTournamentLable.Name = "CreateTournamentLable";
            this.CreateTournamentLable.Size = new System.Drawing.Size(146, 21);
            this.CreateTournamentLable.TabIndex = 1;
            this.CreateTournamentLable.Text = "Create Tournament";
            // 
            // TournamentNameValue
            // 
            this.TournamentNameValue.Location = new System.Drawing.Point(33, 85);
            this.TournamentNameValue.Name = "TournamentNameValue";
            this.TournamentNameValue.Size = new System.Drawing.Size(172, 29);
            this.TournamentNameValue.TabIndex = 11;
            // 
            // TournamentNameLable
            // 
            this.TournamentNameLable.AutoSize = true;
            this.TournamentNameLable.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TournamentNameLable.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TournamentNameLable.Location = new System.Drawing.Point(29, 52);
            this.TournamentNameLable.Name = "TournamentNameLable";
            this.TournamentNameLable.Size = new System.Drawing.Size(133, 20);
            this.TournamentNameLable.TabIndex = 10;
            this.TournamentNameLable.Text = "Tournament Name";
            // 
            // EntryFeeValue
            // 
            this.EntryFeeValue.Location = new System.Drawing.Point(117, 123);
            this.EntryFeeValue.Name = "EntryFeeValue";
            this.EntryFeeValue.Size = new System.Drawing.Size(72, 29);
            this.EntryFeeValue.TabIndex = 13;
            this.EntryFeeValue.Text = "0";
            // 
            // EntryFeeLable
            // 
            this.EntryFeeLable.AutoSize = true;
            this.EntryFeeLable.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EntryFeeLable.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.EntryFeeLable.Location = new System.Drawing.Point(29, 132);
            this.EntryFeeLable.Name = "EntryFeeLable";
            this.EntryFeeLable.Size = new System.Drawing.Size(69, 20);
            this.EntryFeeLable.TabIndex = 12;
            this.EntryFeeLable.Text = "Entry Fee";
            // 
            // SelectTeamDropDown
            // 
            this.SelectTeamDropDown.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SelectTeamDropDown.FormattingEnabled = true;
            this.SelectTeamDropDown.Location = new System.Drawing.Point(29, 196);
            this.SelectTeamDropDown.Name = "SelectTeamDropDown";
            this.SelectTeamDropDown.Size = new System.Drawing.Size(176, 28);
            this.SelectTeamDropDown.TabIndex = 15;
            // 
            // SelectTeamLable
            // 
            this.SelectTeamLable.AutoSize = true;
            this.SelectTeamLable.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SelectTeamLable.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.SelectTeamLable.Location = new System.Drawing.Point(25, 172);
            this.SelectTeamLable.Name = "SelectTeamLable";
            this.SelectTeamLable.Size = new System.Drawing.Size(90, 20);
            this.SelectTeamLable.TabIndex = 14;
            this.SelectTeamLable.Text = "Select Team";
            // 
            // CreateNewTeamLink
            // 
            this.CreateNewTeamLink.AutoSize = true;
            this.CreateNewTeamLink.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CreateNewTeamLink.Location = new System.Drawing.Point(134, 167);
            this.CreateNewTeamLink.Name = "CreateNewTeamLink";
            this.CreateNewTeamLink.Size = new System.Drawing.Size(71, 17);
            this.CreateNewTeamLink.TabIndex = 16;
            this.CreateNewTeamLink.TabStop = true;
            this.CreateNewTeamLink.Text = "create new";
            this.CreateNewTeamLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CreateNewTeamLink_LinkClicked);
            // 
            // addTeamButton
            // 
            this.addTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.addTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.addTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.addTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addTeamButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.addTeamButton.Location = new System.Drawing.Point(50, 239);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(125, 30);
            this.addTeamButton.TabIndex = 17;
            this.addTeamButton.Text = "Add Team";
            this.addTeamButton.UseVisualStyleBackColor = true;
            this.addTeamButton.Click += new System.EventHandler(this.addTeamButton_Click);
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createPrizeButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.createPrizeButton.Location = new System.Drawing.Point(50, 293);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(125, 30);
            this.createPrizeButton.TabIndex = 18;
            this.createPrizeButton.Text = "Create Prize";
            this.createPrizeButton.UseVisualStyleBackColor = true;
            this.createPrizeButton.Click += new System.EventHandler(this.createPrizeButton_Click);
            // 
            // tournamentPlayersListBox
            // 
            this.tournamentPlayersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tournamentPlayersListBox.FormattingEnabled = true;
            this.tournamentPlayersListBox.ItemHeight = 21;
            this.tournamentPlayersListBox.Location = new System.Drawing.Point(264, 85);
            this.tournamentPlayersListBox.Name = "tournamentPlayersListBox";
            this.tournamentPlayersListBox.Size = new System.Drawing.Size(217, 107);
            this.tournamentPlayersListBox.TabIndex = 19;
            // 
            // tournamentPlayersLable
            // 
            this.tournamentPlayersLable.AutoSize = true;
            this.tournamentPlayersLable.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tournamentPlayersLable.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tournamentPlayersLable.Location = new System.Drawing.Point(260, 62);
            this.tournamentPlayersLable.Name = "tournamentPlayersLable";
            this.tournamentPlayersLable.Size = new System.Drawing.Size(112, 20);
            this.tournamentPlayersLable.TabIndex = 20;
            this.tournamentPlayersLable.Text = "Teams / Players";
            // 
            // deleteSelectedPlayersButton
            // 
            this.deleteSelectedPlayersButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.deleteSelectedPlayersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.deleteSelectedPlayersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.deleteSelectedPlayersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedPlayersButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteSelectedPlayersButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.deleteSelectedPlayersButton.Location = new System.Drawing.Point(503, 105);
            this.deleteSelectedPlayersButton.Name = "deleteSelectedPlayersButton";
            this.deleteSelectedPlayersButton.Size = new System.Drawing.Size(125, 61);
            this.deleteSelectedPlayersButton.TabIndex = 21;
            this.deleteSelectedPlayersButton.Text = "Delate Selected";
            this.deleteSelectedPlayersButton.UseVisualStyleBackColor = true;
            this.deleteSelectedPlayersButton.Click += new System.EventHandler(this.deleteSelectedPlayersButton_Click);
            // 
            // deleteSelectPrizeButton
            // 
            this.deleteSelectPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.deleteSelectPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.deleteSelectPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.deleteSelectPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectPrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteSelectPrizeButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.deleteSelectPrizeButton.Location = new System.Drawing.Point(503, 250);
            this.deleteSelectPrizeButton.Name = "deleteSelectPrizeButton";
            this.deleteSelectPrizeButton.Size = new System.Drawing.Size(125, 61);
            this.deleteSelectPrizeButton.TabIndex = 24;
            this.deleteSelectPrizeButton.Text = "Delete Selected";
            this.deleteSelectPrizeButton.UseVisualStyleBackColor = true;
            this.deleteSelectPrizeButton.Click += new System.EventHandler(this.deleteSelectPrizeButton_Click);
            // 
            // prizesLable
            // 
            this.prizesLable.AutoSize = true;
            this.prizesLable.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prizesLable.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.prizesLable.Location = new System.Drawing.Point(260, 204);
            this.prizesLable.Name = "prizesLable";
            this.prizesLable.Size = new System.Drawing.Size(47, 20);
            this.prizesLable.TabIndex = 23;
            this.prizesLable.Text = "Prizes";
            // 
            // prizesListBox
            // 
            this.prizesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prizesListBox.FormattingEnabled = true;
            this.prizesListBox.ItemHeight = 21;
            this.prizesListBox.Location = new System.Drawing.Point(264, 230);
            this.prizesListBox.Name = "prizesListBox";
            this.prizesListBox.Size = new System.Drawing.Size(217, 107);
            this.prizesListBox.TabIndex = 22;
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createTournamentButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.createTournamentButton.Location = new System.Drawing.Point(202, 353);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(170, 30);
            this.createTournamentButton.TabIndex = 25;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = true;
            this.createTournamentButton.Click += new System.EventHandler(this.createTournamentButton_Click);
            // 
            // CreateTorunamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 422);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.deleteSelectPrizeButton);
            this.Controls.Add(this.prizesLable);
            this.Controls.Add(this.prizesListBox);
            this.Controls.Add(this.deleteSelectedPlayersButton);
            this.Controls.Add(this.tournamentPlayersLable);
            this.Controls.Add(this.tournamentPlayersListBox);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.addTeamButton);
            this.Controls.Add(this.CreateNewTeamLink);
            this.Controls.Add(this.SelectTeamDropDown);
            this.Controls.Add(this.SelectTeamLable);
            this.Controls.Add(this.EntryFeeValue);
            this.Controls.Add(this.EntryFeeLable);
            this.Controls.Add(this.TournamentNameValue);
            this.Controls.Add(this.TournamentNameLable);
            this.Controls.Add(this.CreateTournamentLable);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreateTorunamentForm";
            this.Text = "Create Torunament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CreateTournamentLable;
        private System.Windows.Forms.TextBox TournamentNameValue;
        private System.Windows.Forms.Label TournamentNameLable;
        private System.Windows.Forms.TextBox EntryFeeValue;
        private System.Windows.Forms.Label EntryFeeLable;
        private System.Windows.Forms.ComboBox SelectTeamDropDown;
        private System.Windows.Forms.Label SelectTeamLable;
        private System.Windows.Forms.LinkLabel CreateNewTeamLink;
        private System.Windows.Forms.Button addTeamButton;
        private System.Windows.Forms.Button createPrizeButton;
        private System.Windows.Forms.ListBox tournamentPlayersListBox;
        private System.Windows.Forms.Label tournamentPlayersLable;
        private System.Windows.Forms.Button deleteSelectedPlayersButton;
        private System.Windows.Forms.Button deleteSelectPrizeButton;
        private System.Windows.Forms.Label prizesLable;
        private System.Windows.Forms.ListBox prizesListBox;
        private System.Windows.Forms.Button createTournamentButton;
    }
}