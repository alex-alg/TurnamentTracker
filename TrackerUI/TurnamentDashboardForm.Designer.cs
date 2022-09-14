
namespace TrackerUI
{
    partial class TurnamentDashboardForm
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
            this.turnamentDashboardLabel = new System.Windows.Forms.Label();
            this.loadExistingTurnamentDropDown = new System.Windows.Forms.ComboBox();
            this.loadExistingTurnamentLabel = new System.Windows.Forms.Label();
            this.loadTurnamentButton = new System.Windows.Forms.Button();
            this.createTurnamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // turnamentDashboardLabel
            // 
            this.turnamentDashboardLabel.AutoSize = true;
            this.turnamentDashboardLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.turnamentDashboardLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.turnamentDashboardLabel.Location = new System.Drawing.Point(109, 37);
            this.turnamentDashboardLabel.Name = "turnamentDashboardLabel";
            this.turnamentDashboardLabel.Size = new System.Drawing.Size(380, 50);
            this.turnamentDashboardLabel.TabIndex = 13;
            this.turnamentDashboardLabel.Text = "TurnamentDashboard";
            // 
            // loadExistingTurnamentDropDown
            // 
            this.loadExistingTurnamentDropDown.FormattingEnabled = true;
            this.loadExistingTurnamentDropDown.Location = new System.Drawing.Point(145, 175);
            this.loadExistingTurnamentDropDown.Name = "loadExistingTurnamentDropDown";
            this.loadExistingTurnamentDropDown.Size = new System.Drawing.Size(309, 38);
            this.loadExistingTurnamentDropDown.TabIndex = 16;
            // 
            // loadExistingTurnamentLabel
            // 
            this.loadExistingTurnamentLabel.AutoSize = true;
            this.loadExistingTurnamentLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loadExistingTurnamentLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.loadExistingTurnamentLabel.Location = new System.Drawing.Point(145, 125);
            this.loadExistingTurnamentLabel.Name = "loadExistingTurnamentLabel";
            this.loadExistingTurnamentLabel.Size = new System.Drawing.Size(309, 37);
            this.loadExistingTurnamentLabel.TabIndex = 15;
            this.loadExistingTurnamentLabel.Text = "Load Existing Turnament";
            // 
            // loadTurnamentButton
            // 
            this.loadTurnamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.loadTurnamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.loadTurnamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.loadTurnamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadTurnamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loadTurnamentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.loadTurnamentButton.Location = new System.Drawing.Point(189, 262);
            this.loadTurnamentButton.Name = "loadTurnamentButton";
            this.loadTurnamentButton.Size = new System.Drawing.Size(221, 44);
            this.loadTurnamentButton.TabIndex = 26;
            this.loadTurnamentButton.Text = "Load Turnament";
            this.loadTurnamentButton.UseVisualStyleBackColor = true;
            // 
            // createTurnamentButton
            // 
            this.createTurnamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTurnamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTurnamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTurnamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTurnamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createTurnamentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.createTurnamentButton.Location = new System.Drawing.Point(189, 312);
            this.createTurnamentButton.Name = "createTurnamentButton";
            this.createTurnamentButton.Size = new System.Drawing.Size(221, 44);
            this.createTurnamentButton.TabIndex = 27;
            this.createTurnamentButton.Text = "Create Turnament";
            this.createTurnamentButton.UseVisualStyleBackColor = true;
            // 
            // TurnamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(594, 413);
            this.Controls.Add(this.createTurnamentButton);
            this.Controls.Add(this.loadTurnamentButton);
            this.Controls.Add(this.loadExistingTurnamentDropDown);
            this.Controls.Add(this.loadExistingTurnamentLabel);
            this.Controls.Add(this.turnamentDashboardLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "TurnamentDashboardForm";
            this.Text = "Turnament Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label turnamentDashboardLabel;
        private System.Windows.Forms.ComboBox loadExistingTurnamentDropDown;
        private System.Windows.Forms.Label loadExistingTurnamentLabel;
        private System.Windows.Forms.Button loadTurnamentButton;
        private System.Windows.Forms.Button createTurnamentButton;
    }
}