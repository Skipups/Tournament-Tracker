
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
            this.tournamentNameValue = new System.Windows.Forms.TextBox();
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.addTeamMemberSubmitButton = new System.Windows.Forms.Button();
            this.selectTeamMemberDropdown = new System.Windows.Forms.ComboBox();
            this.selectATeamMemberLabel = new System.Windows.Forms.Label();
            this.addNewTeamMemberGroupBox = new System.Windows.Forms.GroupBox();
            this.teamOneScoreLabel = new System.Windows.Forms.Label();
            this.firstNameValue = new System.Windows.Forms.TextBox();
            this.lastNameValue = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.emailValue = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.cellphoneValue = new System.Windows.Forms.TextBox();
            this.cellPhoneLabel = new System.Windows.Forms.Label();
            this.createMemberButton = new System.Windows.Forms.Button();
            this.createTeamButton = new System.Windows.Forms.Button();
            this.teamMembersListBox = new System.Windows.Forms.ListBox();
            this.deletedSelectedTeamMemberButton = new System.Windows.Forms.Button();
            this.addNewTeamMemberGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tournamentNameValue
            // 
            this.tournamentNameValue.Location = new System.Drawing.Point(33, 120);
            this.tournamentNameValue.Name = "tournamentNameValue";
            this.tournamentNameValue.Size = new System.Drawing.Size(213, 20);
            this.tournamentNameValue.TabIndex = 13;
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamNameLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.teamNameLabel.Location = new System.Drawing.Point(31, 80);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(157, 37);
            this.teamNameLabel.TabIndex = 12;
            this.teamNameLabel.Text = "Team Name";
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.HeaderLabel.Location = new System.Drawing.Point(24, 18);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(213, 50);
            this.HeaderLabel.TabIndex = 11;
            this.HeaderLabel.Text = "Create Team";
            // 
            // addTeamMemberSubmitButton
            // 
            this.addTeamMemberSubmitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addTeamMemberSubmitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addTeamMemberSubmitButton.Location = new System.Drawing.Point(103, 228);
            this.addTeamMemberSubmitButton.Name = "addTeamMemberSubmitButton";
            this.addTeamMemberSubmitButton.Size = new System.Drawing.Size(95, 26);
            this.addTeamMemberSubmitButton.TabIndex = 22;
            this.addTeamMemberSubmitButton.Text = "Add Member";
            this.addTeamMemberSubmitButton.UseVisualStyleBackColor = true;
            // 
            // selectTeamMemberDropdown
            // 
            this.selectTeamMemberDropdown.FormattingEnabled = true;
            this.selectTeamMemberDropdown.Location = new System.Drawing.Point(33, 201);
            this.selectTeamMemberDropdown.Name = "selectTeamMemberDropdown";
            this.selectTeamMemberDropdown.Size = new System.Drawing.Size(213, 21);
            this.selectTeamMemberDropdown.TabIndex = 21;
            // 
            // selectATeamMemberLabel
            // 
            this.selectATeamMemberLabel.AutoSize = true;
            this.selectATeamMemberLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectATeamMemberLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.selectATeamMemberLabel.Location = new System.Drawing.Point(31, 161);
            this.selectATeamMemberLabel.Name = "selectATeamMemberLabel";
            this.selectATeamMemberLabel.Size = new System.Drawing.Size(263, 37);
            this.selectATeamMemberLabel.TabIndex = 20;
            this.selectATeamMemberLabel.Text = "Select Team Member";
            // 
            // addNewTeamMemberGroupBox
            // 
            this.addNewTeamMemberGroupBox.Controls.Add(this.createMemberButton);
            this.addNewTeamMemberGroupBox.Controls.Add(this.cellphoneValue);
            this.addNewTeamMemberGroupBox.Controls.Add(this.cellPhoneLabel);
            this.addNewTeamMemberGroupBox.Controls.Add(this.emailValue);
            this.addNewTeamMemberGroupBox.Controls.Add(this.emailLabel);
            this.addNewTeamMemberGroupBox.Controls.Add(this.lastNameValue);
            this.addNewTeamMemberGroupBox.Controls.Add(this.lastNameLabel);
            this.addNewTeamMemberGroupBox.Controls.Add(this.firstNameValue);
            this.addNewTeamMemberGroupBox.Controls.Add(this.teamOneScoreLabel);
            this.addNewTeamMemberGroupBox.Location = new System.Drawing.Point(33, 283);
            this.addNewTeamMemberGroupBox.Name = "addNewTeamMemberGroupBox";
            this.addNewTeamMemberGroupBox.Size = new System.Drawing.Size(243, 200);
            this.addNewTeamMemberGroupBox.TabIndex = 24;
            this.addNewTeamMemberGroupBox.TabStop = false;
            this.addNewTeamMemberGroupBox.Text = "Add New Member";
            // 
            // teamOneScoreLabel
            // 
            this.teamOneScoreLabel.AutoSize = true;
            this.teamOneScoreLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamOneScoreLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.teamOneScoreLabel.Location = new System.Drawing.Point(6, 22);
            this.teamOneScoreLabel.Name = "teamOneScoreLabel";
            this.teamOneScoreLabel.Size = new System.Drawing.Size(113, 30);
            this.teamOneScoreLabel.TabIndex = 9;
            this.teamOneScoreLabel.Text = "First Name";
            // 
            // firstNameValue
            // 
            this.firstNameValue.Location = new System.Drawing.Point(125, 29);
            this.firstNameValue.Name = "firstNameValue";
            this.firstNameValue.Size = new System.Drawing.Size(103, 20);
            this.firstNameValue.TabIndex = 25;
            // 
            // lastNameValue
            // 
            this.lastNameValue.Location = new System.Drawing.Point(125, 62);
            this.lastNameValue.Name = "lastNameValue";
            this.lastNameValue.Size = new System.Drawing.Size(103, 20);
            this.lastNameValue.TabIndex = 27;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lastNameLabel.Location = new System.Drawing.Point(7, 52);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(112, 30);
            this.lastNameLabel.TabIndex = 26;
            this.lastNameLabel.Text = "Last Name";
            // 
            // emailValue
            // 
            this.emailValue.Location = new System.Drawing.Point(125, 92);
            this.emailValue.Name = "emailValue";
            this.emailValue.Size = new System.Drawing.Size(103, 20);
            this.emailValue.TabIndex = 29;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.emailLabel.Location = new System.Drawing.Point(7, 82);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(63, 30);
            this.emailLabel.TabIndex = 28;
            this.emailLabel.Text = "Email";
            // 
            // cellphoneValue
            // 
            this.cellphoneValue.Location = new System.Drawing.Point(125, 122);
            this.cellphoneValue.Name = "cellphoneValue";
            this.cellphoneValue.Size = new System.Drawing.Size(103, 20);
            this.cellphoneValue.TabIndex = 31;
            // 
            // cellPhoneLabel
            // 
            this.cellPhoneLabel.AutoSize = true;
            this.cellPhoneLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellPhoneLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.cellPhoneLabel.Location = new System.Drawing.Point(7, 112);
            this.cellPhoneLabel.Name = "cellPhoneLabel";
            this.cellPhoneLabel.Size = new System.Drawing.Size(106, 30);
            this.cellPhoneLabel.TabIndex = 30;
            this.cellPhoneLabel.Text = "Cellphone";
            // 
            // createMemberButton
            // 
            this.createMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createMemberButton.Location = new System.Drawing.Point(70, 159);
            this.createMemberButton.Name = "createMemberButton";
            this.createMemberButton.Size = new System.Drawing.Size(95, 26);
            this.createMemberButton.TabIndex = 32;
            this.createMemberButton.Text = "Create Member";
            this.createMemberButton.UseVisualStyleBackColor = true;
            // 
            // createTeamButton
            // 
            this.createTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTeamButton.Location = new System.Drawing.Point(295, 470);
            this.createTeamButton.Name = "createTeamButton";
            this.createTeamButton.Size = new System.Drawing.Size(136, 26);
            this.createTeamButton.TabIndex = 25;
            this.createTeamButton.Text = "Create Team";
            this.createTeamButton.UseVisualStyleBackColor = true;
            // 
            // teamMembersListBox
            // 
            this.teamMembersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamMembersListBox.FormattingEnabled = true;
            this.teamMembersListBox.Location = new System.Drawing.Point(376, 80);
            this.teamMembersListBox.Name = "teamMembersListBox";
            this.teamMembersListBox.Size = new System.Drawing.Size(258, 379);
            this.teamMembersListBox.TabIndex = 26;
            // 
            // deletedSelectedTeamMemberButton
            // 
            this.deletedSelectedTeamMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deletedSelectedTeamMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deletedSelectedTeamMemberButton.Location = new System.Drawing.Point(650, 201);
            this.deletedSelectedTeamMemberButton.Name = "deletedSelectedTeamMemberButton";
            this.deletedSelectedTeamMemberButton.Size = new System.Drawing.Size(89, 26);
            this.deletedSelectedTeamMemberButton.TabIndex = 27;
            this.deletedSelectedTeamMemberButton.Text = "Delete Selected";
            this.deletedSelectedTeamMemberButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.deletedSelectedTeamMemberButton);
            this.Controls.Add(this.teamMembersListBox);
            this.Controls.Add(this.createTeamButton);
            this.Controls.Add(this.addNewTeamMemberGroupBox);
            this.Controls.Add(this.addTeamMemberSubmitButton);
            this.Controls.Add(this.selectTeamMemberDropdown);
            this.Controls.Add(this.selectATeamMemberLabel);
            this.Controls.Add(this.tournamentNameValue);
            this.Controls.Add(this.teamNameLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.Load += new System.EventHandler(this.CreateTeamForm_Load);
            this.addNewTeamMemberGroupBox.ResumeLayout(false);
            this.addNewTeamMemberGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tournamentNameValue;
        private System.Windows.Forms.Label teamNameLabel;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Button addTeamMemberSubmitButton;
        private System.Windows.Forms.ComboBox selectTeamMemberDropdown;
        private System.Windows.Forms.Label selectATeamMemberLabel;
        private System.Windows.Forms.GroupBox addNewTeamMemberGroupBox;
        private System.Windows.Forms.Label teamOneScoreLabel;
        private System.Windows.Forms.TextBox firstNameValue;
        private System.Windows.Forms.Button createMemberButton;
        private System.Windows.Forms.TextBox cellphoneValue;
        private System.Windows.Forms.Label cellPhoneLabel;
        private System.Windows.Forms.TextBox emailValue;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox lastNameValue;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Button createTeamButton;
        private System.Windows.Forms.ListBox teamMembersListBox;
        private System.Windows.Forms.Button deletedSelectedTeamMemberButton;
    }
}