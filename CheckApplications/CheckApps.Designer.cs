namespace CheckApplications
{
    partial class CheckApps
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
            this.StatusLabel = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.ReRunButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(320, 9);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(34, 13);
            this.StatusLabel.TabIndex = 0;
            this.StatusLabel.Text = "Satus";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 25);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(701, 23);
            this.progressBar.TabIndex = 1;
            // 
            // ReRunButton
            // 
            this.ReRunButton.Location = new System.Drawing.Point(638, 2);
            this.ReRunButton.Name = "ReRunButton";
            this.ReRunButton.Size = new System.Drawing.Size(75, 20);
            this.ReRunButton.TabIndex = 2;
            this.ReRunButton.Text = "Run Again";
            this.ReRunButton.UseVisualStyleBackColor = true;
            this.ReRunButton.Click += new System.EventHandler(this.ReRunButton_Click);
            // 
            // CheckApps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 491);
            this.Controls.Add(this.ReRunButton);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.StatusLabel);
            this.Name = "CheckApps";
            this.Text = "CheckApps";
            this.Load += new System.EventHandler(this.CheckApps_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button ReRunButton;
    }
}

