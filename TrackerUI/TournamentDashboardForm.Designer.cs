
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
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.loadTournamentButton = new System.Windows.Forms.Button();
            this.selectTounamentDropdown = new System.Windows.Forms.ComboBox();
            this.loadExisitngTournamentLabel = new System.Windows.Forms.Label();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.HeaderLabel.Location = new System.Drawing.Point(139, 37);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(385, 50);
            this.HeaderLabel.TabIndex = 13;
            this.HeaderLabel.Text = "Tournament Dashboard";
            // 
            // loadTournamentButton
            // 
            this.loadTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.loadTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.loadTournamentButton.Location = new System.Drawing.Point(250, 192);
            this.loadTournamentButton.Name = "loadTournamentButton";
            this.loadTournamentButton.Size = new System.Drawing.Size(162, 26);
            this.loadTournamentButton.TabIndex = 25;
            this.loadTournamentButton.Text = "Load Tournament";
            this.loadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // selectTounamentDropdown
            // 
            this.selectTounamentDropdown.FormattingEnabled = true;
            this.selectTounamentDropdown.Location = new System.Drawing.Point(225, 165);
            this.selectTounamentDropdown.Name = "selectTounamentDropdown";
            this.selectTounamentDropdown.Size = new System.Drawing.Size(213, 21);
            this.selectTounamentDropdown.TabIndex = 24;
            // 
            // loadExisitngTournamentLabel
            // 
            this.loadExisitngTournamentLabel.AutoSize = true;
            this.loadExisitngTournamentLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadExisitngTournamentLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.loadExisitngTournamentLabel.Location = new System.Drawing.Point(170, 125);
            this.loadExisitngTournamentLabel.Name = "loadExisitngTournamentLabel";
            this.loadExisitngTournamentLabel.Size = new System.Drawing.Size(322, 37);
            this.loadExisitngTournamentLabel.TabIndex = 23;
            this.loadExisitngTournamentLabel.Text = "Load Existing Tournament";
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTournamentButton.Location = new System.Drawing.Point(261, 245);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(136, 43);
            this.createTournamentButton.TabIndex = 36;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // TournamentDashBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(681, 388);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.loadTournamentButton);
            this.Controls.Add(this.selectTounamentDropdown);
            this.Controls.Add(this.loadExisitngTournamentLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Name = "TournamentDashBoardForm";
            this.Text = "Tournament Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Button loadTournamentButton;
        private System.Windows.Forms.ComboBox selectTounamentDropdown;
        private System.Windows.Forms.Label loadExisitngTournamentLabel;
        private System.Windows.Forms.Button createTournamentButton;
    }
}