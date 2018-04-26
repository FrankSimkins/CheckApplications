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
    public partial class CheckApps : Form
    {
        public CheckApps()
        {
            InitializeComponent();
        }

        private void CheckApps_Load(object sender, EventArgs e)
        {
            //Set this to an Mdi Container so it can have child objects
            this.IsMdiContainer = true;

            //Start loading in child objects, one for each location
            LoadAppLocations();

            //Set status to show complete
            StatusLabel.Text = "Status: Complete";
        }

        private void LoadAppLocations()
        {
            //Get directory location and set to string var
            string programLocation = $"{System.IO.Path.GetDirectoryName(Application.ExecutablePath)}\\Programs.txt";
            //create an array of all the file locations, each line in the txt file is a new string
            string[] locations = System.IO.File.ReadAllLines(@programLocation);
            //Create dictionary of child forms
            Dictionary<int, ProgramForm> forms = new Dictionary<int, ProgramForm>();

            //Start location at 0
            int xLocation = 0;
            int yLocation = 0;

            //For each location we create a form, add it to our dictionary, pass on its location, and set its location.
            for (int i = 0; i < locations.Length; i++)
            {
                //Set status to show which app it is checking
                StatusLabel.Text = $"Checking App: {i}";


                string formName = $"form{i}";
                //Add new form to our dictionary
                forms.Add(i, new ProgramForm());

                //Set location, parent object, and make it show
                forms[i].location = locations[i];
                forms[i].MdiParent = this;
                forms[i].Show();

                //Check to see if we hit the bottom of the screen, if we did then go back to the top and to the right
                if (yLocation > 357)
                {
                    yLocation = 0;
                    xLocation += 361;
                    yLocation += 51;
                }
                else
                    yLocation += 51;

                //Set location
                forms[i].Location = new Point(xLocation, yLocation);


                //Update progress bar
                int progress = ((i+1) / locations.Length) * 100;
                progressBar.Value = progress;

                



            }
        }

        private void ReRunButton_Click(object sender, EventArgs e)
        {
            //Run program again if clicked
            LoadAppLocations();
            //Set status to show complete
            StatusLabel.Text = "Status: Complete";
        }
    }
}
