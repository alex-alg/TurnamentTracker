
namespace TrackerUI
{
    partial class TurnamentViewerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.headerLabel = new System.Windows.Forms.Label();
            this.turnamentName = new System.Windows.Forms.Label();
            this.roundLabel = new System.Windows.Forms.Label();
            this.roundDropDown = new System.Windows.Forms.ComboBox();
            this.unplaiedOnlyCheckbox = new System.Windows.Forms.CheckBox();
            this.matchupListBox = new System.Windows.Forms.ListBox();
            this.teamOneName = new System.Windows.Forms.Label();
            this.teamOneScoreLabel = new System.Windows.Forms.Label();
            this.teamOneScoreValue = new System.Windows.Forms.TextBox();
            this.teamTwoScoreValue = new System.Windows.Forms.TextBox();
            this.teamTwoScoreLabel = new System.Windows.Forms.Label();
            this.teamTwoName = new System.Windows.Forms.Label();
            this.versusLabel = new System.Windows.Forms.Label();
            this.scoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.headerLabel.Location = new System.Drawing.Point(21, 71);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(119, 30);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Turnament:";
            // 
            // turnamentName
            // 
            this.turnamentName.AutoSize = true;
            this.turnamentName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.turnamentName.Location = new System.Drawing.Point(227, 71);
            this.turnamentName.Name = "turnamentName";
            this.turnamentName.Size = new System.Drawing.Size(88, 30);
            this.turnamentName.TabIndex = 1;
            this.turnamentName.Text = "<none>";
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roundLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.roundLabel.Location = new System.Drawing.Point(21, 142);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(95, 37);
            this.roundLabel.TabIndex = 2;
            this.roundLabel.Text = "Round";
            // 
            // roundDropDown
            // 
            this.roundDropDown.FormattingEnabled = true;
            this.roundDropDown.Location = new System.Drawing.Point(162, 144);
            this.roundDropDown.Name = "roundDropDown";
            this.roundDropDown.Size = new System.Drawing.Size(238, 38);
            this.roundDropDown.TabIndex = 3;
            // 
            // unplaiedOnlyCheckbox
            // 
            this.unplaiedOnlyCheckbox.AutoSize = true;
            this.unplaiedOnlyCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unplaiedOnlyCheckbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.unplaiedOnlyCheckbox.Location = new System.Drawing.Point(162, 203);
            this.unplaiedOnlyCheckbox.Name = "unplaiedOnlyCheckbox";
            this.unplaiedOnlyCheckbox.Size = new System.Drawing.Size(165, 34);
            this.unplaiedOnlyCheckbox.TabIndex = 4;
            this.unplaiedOnlyCheckbox.Text = "Unplayed Only";
            this.unplaiedOnlyCheckbox.UseVisualStyleBackColor = true;
            // 
            // matchupListBox
            // 
            this.matchupListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchupListBox.FormattingEnabled = true;
            this.matchupListBox.ItemHeight = 30;
            this.matchupListBox.Location = new System.Drawing.Point(21, 253);
            this.matchupListBox.Name = "matchupListBox";
            this.matchupListBox.Size = new System.Drawing.Size(379, 242);
            this.matchupListBox.TabIndex = 5;
            // 
            // teamOneName
            // 
            this.teamOneName.AutoSize = true;
            this.teamOneName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamOneName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.teamOneName.Location = new System.Drawing.Point(455, 247);
            this.teamOneName.Name = "teamOneName";
            this.teamOneName.Size = new System.Drawing.Size(162, 37);
            this.teamOneName.TabIndex = 6;
            this.teamOneName.Text = "<teamOne>";
            // 
            // teamOneScoreLabel
            // 
            this.teamOneScoreLabel.AutoSize = true;
            this.teamOneScoreLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamOneScoreLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.teamOneScoreLabel.Location = new System.Drawing.Point(455, 296);
            this.teamOneScoreLabel.Name = "teamOneScoreLabel";
            this.teamOneScoreLabel.Size = new System.Drawing.Size(82, 37);
            this.teamOneScoreLabel.TabIndex = 7;
            this.teamOneScoreLabel.Text = "Score";
            // 
            // teamOneScoreValue
            // 
            this.teamOneScoreValue.Location = new System.Drawing.Point(571, 298);
            this.teamOneScoreValue.Name = "teamOneScoreValue";
            this.teamOneScoreValue.Size = new System.Drawing.Size(147, 35);
            this.teamOneScoreValue.TabIndex = 8;
            // 
            // teamTwoScoreValue
            // 
            this.teamTwoScoreValue.Location = new System.Drawing.Point(571, 449);
            this.teamTwoScoreValue.Name = "teamTwoScoreValue";
            this.teamTwoScoreValue.Size = new System.Drawing.Size(147, 35);
            this.teamTwoScoreValue.TabIndex = 11;
            // 
            // teamTwoScoreLabel
            // 
            this.teamTwoScoreLabel.AutoSize = true;
            this.teamTwoScoreLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamTwoScoreLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.teamTwoScoreLabel.Location = new System.Drawing.Point(456, 447);
            this.teamTwoScoreLabel.Name = "teamTwoScoreLabel";
            this.teamTwoScoreLabel.Size = new System.Drawing.Size(82, 37);
            this.teamTwoScoreLabel.TabIndex = 10;
            this.teamTwoScoreLabel.Text = "Score";
            // 
            // teamTwoName
            // 
            this.teamTwoName.AutoSize = true;
            this.teamTwoName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamTwoName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.teamTwoName.Location = new System.Drawing.Point(456, 398);
            this.teamTwoName.Name = "teamTwoName";
            this.teamTwoName.Size = new System.Drawing.Size(163, 37);
            this.teamTwoName.TabIndex = 9;
            this.teamTwoName.Text = "<teamTwo>";
            // 
            // versusLabel
            // 
            this.versusLabel.AutoSize = true;
            this.versusLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.versusLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.versusLabel.Location = new System.Drawing.Point(618, 361);
            this.versusLabel.Name = "versusLabel";
            this.versusLabel.Size = new System.Drawing.Size(48, 37);
            this.versusLabel.TabIndex = 12;
            this.versusLabel.Text = "VS";
            // 
            // scoreButton
            // 
            this.scoreButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.scoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.scoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.scoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scoreButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.scoreButton.Location = new System.Drawing.Point(741, 365);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(114, 44);
            this.scoreButton.TabIndex = 13;
            this.scoreButton.Text = "Score";
            this.scoreButton.UseVisualStyleBackColor = true;
            // 
            // TurnamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(895, 550);
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.versusLabel);
            this.Controls.Add(this.teamTwoScoreValue);
            this.Controls.Add(this.teamTwoScoreLabel);
            this.Controls.Add(this.teamTwoName);
            this.Controls.Add(this.teamOneScoreValue);
            this.Controls.Add(this.teamOneScoreLabel);
            this.Controls.Add(this.teamOneName);
            this.Controls.Add(this.matchupListBox);
            this.Controls.Add(this.unplaiedOnlyCheckbox);
            this.Controls.Add(this.roundDropDown);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.turnamentName);
            this.Controls.Add(this.headerLabel);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "TurnamentViewerForm";
            this.Text = "Turnament Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label turnamentName;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.ComboBox roundDropDown;
        private System.Windows.Forms.CheckBox unplaiedOnlyCheckbox;
        private System.Windows.Forms.ListBox matchupListBox;
        private System.Windows.Forms.Label teamOneName;
        private System.Windows.Forms.Label teamOneScoreLabel;
        private System.Windows.Forms.TextBox teamOneScoreValue;
        private System.Windows.Forms.TextBox teamTwoScoreValue;
        private System.Windows.Forms.Label teamTwoScoreLabel;
        private System.Windows.Forms.Label teamTwoName;
        private System.Windows.Forms.Label versusLabel;
        private System.Windows.Forms.Button scoreButton;
    }
}

