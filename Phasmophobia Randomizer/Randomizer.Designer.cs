namespace Phasmophobia_Randomizer
{
    partial class Randomizer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Randomizer));
            this.ItemTitleLabel = new System.Windows.Forms.Label();
            this.ChallengeTitleLabel = new System.Windows.Forms.Label();
            this.RerollButton = new System.Windows.Forms.Button();
            this.RerollLabel = new System.Windows.Forms.Label();
            this.ExtraItemsLabel = new System.Windows.Forms.Label();
            this.ChallengesLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemTitleLabel
            // 
            this.ItemTitleLabel.AutoSize = true;
            this.ItemTitleLabel.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemTitleLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.ItemTitleLabel.Location = new System.Drawing.Point(12, 9);
            this.ItemTitleLabel.Name = "ItemTitleLabel";
            this.ItemTitleLabel.Size = new System.Drawing.Size(131, 21);
            this.ItemTitleLabel.TabIndex = 1;
            this.ItemTitleLabel.Text = "Extra Items";
            // 
            // ChallengeTitleLabel
            // 
            this.ChallengeTitleLabel.AutoSize = true;
            this.ChallengeTitleLabel.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChallengeTitleLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.ChallengeTitleLabel.Location = new System.Drawing.Point(11, 197);
            this.ChallengeTitleLabel.Name = "ChallengeTitleLabel";
            this.ChallengeTitleLabel.Size = new System.Drawing.Size(120, 21);
            this.ChallengeTitleLabel.TabIndex = 2;
            this.ChallengeTitleLabel.Text = "Challenges";
            // 
            // RerollButton
            // 
            this.RerollButton.Location = new System.Drawing.Point(1010, 43);
            this.RerollButton.Name = "RerollButton";
            this.RerollButton.Size = new System.Drawing.Size(135, 25);
            this.RerollButton.TabIndex = 3;
            this.RerollButton.Text = "Randomize";
            this.RerollButton.UseVisualStyleBackColor = true;
            this.RerollButton.Click += new System.EventHandler(this.RerollButton_Click);
            // 
            // RerollLabel
            // 
            this.RerollLabel.AutoSize = true;
            this.RerollLabel.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RerollLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.RerollLabel.Location = new System.Drawing.Point(750, 13);
            this.RerollLabel.Name = "RerollLabel";
            this.RerollLabel.Size = new System.Drawing.Size(395, 17);
            this.RerollLabel.TabIndex = 4;
            this.RerollLabel.Text = "Want to reroll? Click the randomize button.";
            // 
            // ExtraItemsLabel
            // 
            this.ExtraItemsLabel.AutoSize = true;
            this.ExtraItemsLabel.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtraItemsLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ExtraItemsLabel.Location = new System.Drawing.Point(16, 43);
            this.ExtraItemsLabel.Name = "ExtraItemsLabel";
            this.ExtraItemsLabel.Size = new System.Drawing.Size(269, 17);
            this.ExtraItemsLabel.TabIndex = 5;
            this.ExtraItemsLabel.Text = "Click Randomize to get items!";
            // 
            // ChallengesLabel
            // 
            this.ChallengesLabel.AutoSize = true;
            this.ChallengesLabel.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChallengesLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ChallengesLabel.Location = new System.Drawing.Point(12, 233);
            this.ChallengesLabel.Name = "ChallengesLabel";
            this.ChallengesLabel.Size = new System.Drawing.Size(314, 17);
            this.ChallengesLabel.TabIndex = 6;
            this.ChallengesLabel.Text = "Click Randomize to get challenges!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(461, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Randomizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1158, 332);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ChallengesLabel);
            this.Controls.Add(this.ExtraItemsLabel);
            this.Controls.Add(this.RerollLabel);
            this.Controls.Add(this.RerollButton);
            this.Controls.Add(this.ChallengeTitleLabel);
            this.Controls.Add(this.ItemTitleLabel);
            this.Name = "Randomizer";
            this.Text = "Phasmophobia Randomizer v1.0";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ItemTitleLabel;
        private System.Windows.Forms.Label ChallengeTitleLabel;
        private System.Windows.Forms.Button RerollButton;
        private System.Windows.Forms.Label RerollLabel;
        public System.Windows.Forms.Label ExtraItemsLabel;
        public System.Windows.Forms.Label ChallengesLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}