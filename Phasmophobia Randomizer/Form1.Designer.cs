namespace Phasmophobia_Randomizer
{
    partial class Form1
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
            this.RandomizeButton = new System.Windows.Forms.Button();
            this.InformationButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RandomizeButton
            // 
            this.RandomizeButton.Location = new System.Drawing.Point(12, 67);
            this.RandomizeButton.Name = "RandomizeButton";
            this.RandomizeButton.Size = new System.Drawing.Size(131, 29);
            this.RandomizeButton.TabIndex = 1;
            this.RandomizeButton.Text = "Randomize";
            this.RandomizeButton.UseVisualStyleBackColor = true;
            this.RandomizeButton.Click += new System.EventHandler(this.RandomizeButton_Click);
            // 
            // InformationButton
            // 
            this.InformationButton.Location = new System.Drawing.Point(232, 67);
            this.InformationButton.Name = "InformationButton";
            this.InformationButton.Size = new System.Drawing.Size(131, 29);
            this.InformationButton.TabIndex = 2;
            this.InformationButton.Text = "Information";
            this.InformationButton.UseVisualStyleBackColor = true;
            this.InformationButton.Click += new System.EventHandler(this.InformationButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.TitleLabel.Location = new System.Drawing.Point(37, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(309, 23);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Phasmophobia Randomizer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(375, 126);
            this.Controls.Add(this.InformationButton);
            this.Controls.Add(this.RandomizeButton);
            this.Controls.Add(this.TitleLabel);
            this.Name = "Form1";
            this.Text = "Phasmophobia Randomizer v1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button RandomizeButton;
        private System.Windows.Forms.Button InformationButton;
        private System.Windows.Forms.Label TitleLabel;
    }
}

