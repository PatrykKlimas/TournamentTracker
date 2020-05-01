namespace TrackerUI
{
    partial class CreateTeamForm
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
            this.TeamNameValue = new System.Windows.Forms.TextBox();
            this.TeamNameLable = new System.Windows.Forms.Label();
            this.CreateTournamentLable = new System.Windows.Forms.Label();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.SelectTeamMemberDropDown = new System.Windows.Forms.ComboBox();
            this.SelectTeamMemberLable = new System.Windows.Forms.Label();
            this.addMemberGroupBox = new System.Windows.Forms.GroupBox();
            this.createMemberButton = new System.Windows.Forms.Button();
            this.cellphoneValue = new System.Windows.Forms.TextBox();
            this.cellphoneLable = new System.Windows.Forms.Label();
            this.emailValue = new System.Windows.Forms.TextBox();
            this.EmailLable = new System.Windows.Forms.Label();
            this.lastNameValue = new System.Windows.Forms.TextBox();
            this.lastNameLable = new System.Windows.Forms.Label();
            this.firstNameValue = new System.Windows.Forms.TextBox();
            this.firstNameLable = new System.Windows.Forms.Label();
            this.TeamMembersListBox = new System.Windows.Forms.ListBox();
            this.removeSelectedMemberButton = new System.Windows.Forms.Button();
            this.createTeamButton = new System.Windows.Forms.Button();
            this.addMemberGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TeamNameValue
            // 
            this.TeamNameValue.Location = new System.Drawing.Point(31, 73);
            this.TeamNameValue.Name = "TeamNameValue";
            this.TeamNameValue.Size = new System.Drawing.Size(281, 29);
            this.TeamNameValue.TabIndex = 14;
            // 
            // TeamNameLable
            // 
            this.TeamNameLable.AutoSize = true;
            this.TeamNameLable.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TeamNameLable.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TeamNameLable.Location = new System.Drawing.Point(27, 50);
            this.TeamNameLable.Name = "TeamNameLable";
            this.TeamNameLable.Size = new System.Drawing.Size(90, 20);
            this.TeamNameLable.TabIndex = 13;
            this.TeamNameLable.Text = "Team Name";
            // 
            // CreateTournamentLable
            // 
            this.CreateTournamentLable.AutoSize = true;
            this.CreateTournamentLable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CreateTournamentLable.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.CreateTournamentLable.Location = new System.Drawing.Point(27, 18);
            this.CreateTournamentLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CreateTournamentLable.Name = "CreateTournamentLable";
            this.CreateTournamentLable.Size = new System.Drawing.Size(99, 21);
            this.CreateTournamentLable.TabIndex = 12;
            this.CreateTournamentLable.Text = "Create Team";
            // 
            // addMemberButton
            // 
            this.addMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.addMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.addMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.addMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addMemberButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.addMemberButton.Location = new System.Drawing.Point(52, 199);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(125, 30);
            this.addMemberButton.TabIndex = 20;
            this.addMemberButton.Text = "Add Member";
            this.addMemberButton.UseVisualStyleBackColor = true;
            this.addMemberButton.Click += new System.EventHandler(this.addMemberButton_Click);
            // 
            // SelectTeamMemberDropDown
            // 
            this.SelectTeamMemberDropDown.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SelectTeamMemberDropDown.FormattingEnabled = true;
            this.SelectTeamMemberDropDown.Location = new System.Drawing.Point(31, 156);
            this.SelectTeamMemberDropDown.Name = "SelectTeamMemberDropDown";
            this.SelectTeamMemberDropDown.Size = new System.Drawing.Size(281, 28);
            this.SelectTeamMemberDropDown.TabIndex = 19;
            // 
            // SelectTeamMemberLable
            // 
            this.SelectTeamMemberLable.AutoSize = true;
            this.SelectTeamMemberLable.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SelectTeamMemberLable.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.SelectTeamMemberLable.Location = new System.Drawing.Point(31, 124);
            this.SelectTeamMemberLable.Name = "SelectTeamMemberLable";
            this.SelectTeamMemberLable.Size = new System.Drawing.Size(150, 20);
            this.SelectTeamMemberLable.TabIndex = 18;
            this.SelectTeamMemberLable.Text = "Select Team Member";
            // 
            // addMemberGroupBox
            // 
            this.addMemberGroupBox.BackColor = System.Drawing.Color.White;
            this.addMemberGroupBox.Controls.Add(this.createMemberButton);
            this.addMemberGroupBox.Controls.Add(this.cellphoneValue);
            this.addMemberGroupBox.Controls.Add(this.cellphoneLable);
            this.addMemberGroupBox.Controls.Add(this.emailValue);
            this.addMemberGroupBox.Controls.Add(this.EmailLable);
            this.addMemberGroupBox.Controls.Add(this.lastNameValue);
            this.addMemberGroupBox.Controls.Add(this.lastNameLable);
            this.addMemberGroupBox.Controls.Add(this.firstNameValue);
            this.addMemberGroupBox.Controls.Add(this.firstNameLable);
            this.addMemberGroupBox.Location = new System.Drawing.Point(31, 235);
            this.addMemberGroupBox.Name = "addMemberGroupBox";
            this.addMemberGroupBox.Size = new System.Drawing.Size(300, 214);
            this.addMemberGroupBox.TabIndex = 21;
            this.addMemberGroupBox.TabStop = false;
            this.addMemberGroupBox.Text = "Add Member";
            // 
            // createMemberButton
            // 
            this.createMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.createMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.createMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.createMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createMemberButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.createMemberButton.Location = new System.Drawing.Point(70, 178);
            this.createMemberButton.Name = "createMemberButton";
            this.createMemberButton.Size = new System.Drawing.Size(158, 30);
            this.createMemberButton.TabIndex = 22;
            this.createMemberButton.Text = "Create Member";
            this.createMemberButton.UseVisualStyleBackColor = true;
            this.createMemberButton.Click += new System.EventHandler(this.createMemberButton_Click);
            // 
            // cellphoneValue
            // 
            this.cellphoneValue.Location = new System.Drawing.Point(135, 140);
            this.cellphoneValue.Name = "cellphoneValue";
            this.cellphoneValue.Size = new System.Drawing.Size(146, 29);
            this.cellphoneValue.TabIndex = 29;
            // 
            // cellphoneLable
            // 
            this.cellphoneLable.AutoSize = true;
            this.cellphoneLable.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cellphoneLable.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cellphoneLable.Location = new System.Drawing.Point(23, 144);
            this.cellphoneLable.Name = "cellphoneLable";
            this.cellphoneLable.Size = new System.Drawing.Size(76, 20);
            this.cellphoneLable.TabIndex = 28;
            this.cellphoneLable.Text = "Cellphone";
            // 
            // emailValue
            // 
            this.emailValue.Location = new System.Drawing.Point(135, 105);
            this.emailValue.Name = "emailValue";
            this.emailValue.Size = new System.Drawing.Size(146, 29);
            this.emailValue.TabIndex = 27;
            // 
            // EmailLable
            // 
            this.EmailLable.AutoSize = true;
            this.EmailLable.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EmailLable.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.EmailLable.Location = new System.Drawing.Point(23, 109);
            this.EmailLable.Name = "EmailLable";
            this.EmailLable.Size = new System.Drawing.Size(103, 20);
            this.EmailLable.TabIndex = 26;
            this.EmailLable.Text = "Email Address";
            // 
            // lastNameValue
            // 
            this.lastNameValue.Location = new System.Drawing.Point(135, 68);
            this.lastNameValue.Name = "lastNameValue";
            this.lastNameValue.Size = new System.Drawing.Size(146, 29);
            this.lastNameValue.TabIndex = 25;
            // 
            // lastNameLable
            // 
            this.lastNameLable.AutoSize = true;
            this.lastNameLable.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lastNameLable.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lastNameLable.Location = new System.Drawing.Point(23, 72);
            this.lastNameLable.Name = "lastNameLable";
            this.lastNameLable.Size = new System.Drawing.Size(79, 20);
            this.lastNameLable.TabIndex = 24;
            this.lastNameLable.Text = "Last Name";
            // 
            // firstNameValue
            // 
            this.firstNameValue.Location = new System.Drawing.Point(135, 33);
            this.firstNameValue.Name = "firstNameValue";
            this.firstNameValue.Size = new System.Drawing.Size(146, 29);
            this.firstNameValue.TabIndex = 23;
            // 
            // firstNameLable
            // 
            this.firstNameLable.AutoSize = true;
            this.firstNameLable.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.firstNameLable.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.firstNameLable.Location = new System.Drawing.Point(23, 37);
            this.firstNameLable.Name = "firstNameLable";
            this.firstNameLable.Size = new System.Drawing.Size(80, 20);
            this.firstNameLable.TabIndex = 22;
            this.firstNameLable.Text = "First Name";
            // 
            // TeamMembersListBox
            // 
            this.TeamMembersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TeamMembersListBox.FormattingEnabled = true;
            this.TeamMembersListBox.ItemHeight = 21;
            this.TeamMembersListBox.Location = new System.Drawing.Point(381, 73);
            this.TeamMembersListBox.Name = "TeamMembersListBox";
            this.TeamMembersListBox.Size = new System.Drawing.Size(217, 380);
            this.TeamMembersListBox.TabIndex = 22;
            // 
            // removeSelectedMemberButton
            // 
            this.removeSelectedMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.removeSelectedMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.removeSelectedMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.removeSelectedMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeSelectedMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.removeSelectedMemberButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.removeSelectedMemberButton.Location = new System.Drawing.Point(606, 231);
            this.removeSelectedMemberButton.Name = "removeSelectedMemberButton";
            this.removeSelectedMemberButton.Size = new System.Drawing.Size(125, 61);
            this.removeSelectedMemberButton.TabIndex = 23;
            this.removeSelectedMemberButton.Text = "Remove Selected";
            this.removeSelectedMemberButton.UseVisualStyleBackColor = true;
            this.removeSelectedMemberButton.Click += new System.EventHandler(this.removeSelectedMemberButton_Click);
            // 
            // createTeamButton
            // 
            this.createTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.createTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.createTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.createTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createTeamButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.createTeamButton.Location = new System.Drawing.Point(269, 459);
            this.createTeamButton.Name = "createTeamButton";
            this.createTeamButton.Size = new System.Drawing.Size(170, 30);
            this.createTeamButton.TabIndex = 26;
            this.createTeamButton.Text = "Create Team";
            this.createTeamButton.UseVisualStyleBackColor = true;
            this.createTeamButton.Click += new System.EventHandler(this.createTeamButton_Click);
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(743, 517);
            this.Controls.Add(this.createTeamButton);
            this.Controls.Add(this.removeSelectedMemberButton);
            this.Controls.Add(this.TeamMembersListBox);
            this.Controls.Add(this.addMemberGroupBox);
            this.Controls.Add(this.addMemberButton);
            this.Controls.Add(this.SelectTeamMemberDropDown);
            this.Controls.Add(this.SelectTeamMemberLable);
            this.Controls.Add(this.TeamNameValue);
            this.Controls.Add(this.TeamNameLable);
            this.Controls.Add(this.CreateTournamentLable);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.addMemberGroupBox.ResumeLayout(false);
            this.addMemberGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TeamNameValue;
        private System.Windows.Forms.Label TeamNameLable;
        private System.Windows.Forms.Label CreateTournamentLable;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.ComboBox SelectTeamMemberDropDown;
        private System.Windows.Forms.Label SelectTeamMemberLable;
        private System.Windows.Forms.GroupBox addMemberGroupBox;
        private System.Windows.Forms.Button createMemberButton;
        private System.Windows.Forms.TextBox cellphoneValue;
        private System.Windows.Forms.Label cellphoneLable;
        private System.Windows.Forms.TextBox emailValue;
        private System.Windows.Forms.Label EmailLable;
        private System.Windows.Forms.TextBox lastNameValue;
        private System.Windows.Forms.Label lastNameLable;
        private System.Windows.Forms.TextBox firstNameValue;
        private System.Windows.Forms.Label firstNameLable;
        private System.Windows.Forms.ListBox TeamMembersListBox;
        private System.Windows.Forms.Button removeSelectedMemberButton;
        private System.Windows.Forms.Button createTeamButton;
    }
}