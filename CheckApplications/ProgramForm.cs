using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace CheckApplications
{
    public partial class ProgramForm : Form
    {

        public string location;


        public ProgramForm()
        {
            InitializeComponent();
        }

        private void ProgramForm_Load(object sender, EventArgs e)
        {
            //Get the last index of a \ so we can show just the .exe filename
            int idx = location.LastIndexOf('\\');
            LocationLabel.Text = location.Substring(idx + 1);

            
            CheckIfFileExists();

        }

        private void CheckIfFileExists()
        {
            //Check if location exists
            bool exists = File.Exists(@location);

            if (exists)
            {
                //If it does exist, set the color to green
                ProgressBox.BackColor = Color.Green;
            }
            else
            {
                //If it doesn't exist set it to red
                ProgressBox.BackColor = Color.Red;
            }
        }

    }
}
