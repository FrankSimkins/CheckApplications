namespace CheckApplications
{
    partial class ProgramForm
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
            this.LocationLabel = new System.Windows.Forms.Label();
            this.ProgressBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Location = new System.Drawing.Point(159, 5);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(48, 13);
            this.LocationLabel.TabIndex = 0;
            this.LocationLabel.Text = "Location";
            // 
            // ProgressBox
            // 
            this.ProgressBox.FormattingEnabled = true;
            this.ProgressBox.Location = new System.Drawing.Point(12, 21);
            this.ProgressBox.Name = "ProgressBox";
            this.ProgressBox.Size = new System.Drawing.Size(336, 17);
            this.ProgressBox.TabIndex = 1;
            // 
            // ProgramForm
            // 
            this.ClientSize = new System.Drawing.Size(360, 50);
            this.Controls.Add(this.ProgressBox);
            this.Controls.Add(this.LocationLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProgramForm";
            this.Load += new System.EventHandler(this.ProgramForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.ListBox ProgressBox;
    }
}