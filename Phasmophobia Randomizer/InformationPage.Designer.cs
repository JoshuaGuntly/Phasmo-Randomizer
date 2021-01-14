namespace Phasmophobia_Randomizer
{
    partial class Information
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Information));
            this.InfoTitleLabel = new System.Windows.Forms.Label();
            this.MainMenuButton = new System.Windows.Forms.Button();
            this.HowToLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InfoTitleLabel
            // 
            this.InfoTitleLabel.AutoSize = true;
            this.InfoTitleLabel.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoTitleLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.InfoTitleLabel.Location = new System.Drawing.Point(47, 9);
            this.InfoTitleLabel.Name = "InfoTitleLabel";
            this.InfoTitleLabel.Size = new System.Drawing.Size(348, 23);
            this.InfoTitleLabel.TabIndex = 1;
            this.InfoTitleLabel.Text = "How To Use This Randomizer";
            // 
            // MainMenuButton
            // 
            this.MainMenuButton.Location = new System.Drawing.Point(298, 275);
            this.MainMenuButton.Name = "MainMenuButton";
            this.MainMenuButton.Size = new System.Drawing.Size(139, 23);
            this.MainMenuButton.TabIndex = 2;
            this.MainMenuButton.Text = "Return to Main Menu";
            this.MainMenuButton.UseVisualStyleBackColor = true;
            this.MainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click);
            // 
            // HowToLabel
            // 
            this.HowToLabel.AutoSize = true;
            this.HowToLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HowToLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.HowToLabel.Location = new System.Drawing.Point(12, 56);
            this.HowToLabel.Name = "HowToLabel";
            this.HowToLabel.Size = new System.Drawing.Size(412, 160);
            this.HowToLabel.TabIndex = 3;
            this.HowToLabel.Text = resources.GetString("HowToLabel.Text");
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(448, 310);
            this.Controls.Add(this.HowToLabel);
            this.Controls.Add(this.MainMenuButton);
            this.Controls.Add(this.InfoTitleLabel);
            this.Name = "Information";
            this.Text = "Phasmophobia Randomizer v1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InfoTitleLabel;
        private System.Windows.Forms.Button MainMenuButton;
        private System.Windows.Forms.Label HowToLabel;
    }
}