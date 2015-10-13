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

                List<Object> data = new List<Object>();
                foreach (string file in Directory.EnumerateFiles(Directory.GetCurrentDirectory() + "/Data", "*.json", SearchOption.TopDirectoryOnly))
                {
                    FileInfo fileinfo = new FileInfo(file);
                    Type currType = Type.GetType("_5eCharGen." + fileinfo.Name.Substring(0, fileinfo.Name.IndexOf('.')));

                    data.Add(JsonConvert.DeserializeObject(File.ReadAllText(file), currType));

                }


            }
        }
        private void btnMainLoad_Click(object sender, EventArgs e)
        {
            loadCharDialog.ShowDialog();
        }
    }
}
