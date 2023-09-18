using System.Diagnostics;

namespace Clone_Utility_
{
    public partial class Clone : Form
    {
        public Clone()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
             
        }
        public void StartCloning(string pathToClone, string webURL, string branchName)
        {
            string command = $"git clone -b {branchName} {webURL}";
            Process prc;
            string dateTime = (Convert.ToString(DateTime.Now)).Replace("/", "-").Replace(":", "-").Replace(" ", "_");
            string folderCreated = $"{branchName}-{dateTime}";
            var p = new ProcessStartInfo
            {
                WorkingDirectory = pathToClone,
                UseShellExecute = false,
                FileName = @"C:\Windows\System32\cmd.exe"
            };

            prc = new Process
            {
                StartInfo = p
            };

            prc.StartInfo.ArgumentList.Add($"/c cd {pathToClone} && mkdir {folderCreated} && cd {folderCreated} && {command}");
            prc.Start();
            prc.WaitForExit();
            Console.WriteLine();
            MessageBox.Show($"Project Cloned Successfully!", "Completed");
        }

        private void txtLocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClone_Click(object sender, EventArgs e)
        {
            string pathToClone = txtLocation.Text;
            string WebURL = txtWebURL.Text;
            string branchName = txtBranch.Text;

            if (string.IsNullOrEmpty(pathToClone))
            {
                pathToClone = txtLocation.PlaceholderText;
            }
            if(!Directory.Exists(pathToClone))
            {
                Directory.CreateDirectory(pathToClone);
            }
            if (string.IsNullOrEmpty(WebURL))
            {           
                MessageBox.Show("Enter the Web URL for project to clone", "Empty Web URL" ,MessageBoxButtons.OK);
            }
            if(string.IsNullOrEmpty(branchName))
            {
                MessageBox.Show("Enter the Branch Name", "Empty Branch Name", MessageBoxButtons.OK);
            }

            StartCloning(pathToClone, WebURL, branchName);
        }

        private void txtLocation_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void Clone_Load(object sender, EventArgs e)
        {
            txtWebURL.Select();
        }
    }
}