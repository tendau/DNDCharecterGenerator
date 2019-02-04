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
using System.Xml;

namespace DND_Charecter_Generator
{
    public partial class Form1 : Form
    {
        static string currentDir = System.AppContext.BaseDirectory;
        static string xmlPath = Path.Combine(currentDir, "Characters.xml");
    
        public Form1()
        {
            InitializeComponent();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlTextReader xtr = new XmlTextReader(xmlPath);
            
        }
    }
}
