using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5eCharGen
{
    public partial class MainWindow : Form
    {
        Data data = new Data();

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            // Initialize Datasets
            string dataPath = "./Data";
            if (Directory.Exists(dataPath))
            {
                //MessageBox.Show("Directory Exists");

                foreach (string file in Directory.EnumerateFiles(Directory.GetCurrentDirectory()
                    + dataPath, "*.json", SearchOption.TopDirectoryOnly))
                {
                    FileInfo fileinfo = new FileInfo(file);
                   
                    data.Add(JsonConvert.DeserializeObject(File.ReadAllText(file), 
                        Type.GetType("_5eCharGen." + 
                        fileinfo.Name.Substring(0, fileinfo.Name.IndexOf('.')))));

                    
                }
                //Sample call to GetRaces to return the Queue
                Queue<Race> races = data.GetRaces();

            }
        }
        private void btnMainLoad_Click(object sender, EventArgs e)
        {
            loadCharDialog.ShowDialog();
        }
    }
}
