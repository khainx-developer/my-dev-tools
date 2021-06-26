using my_tools.components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace my_tools
{
    public partial class MainForm : Form
    {
        public Base64Component base64Component { get; set; }
        public MainForm()
        {
            InitializeComponent();
        }


        private void base64ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            if (base64Component == null)
            {
                base64Component = new Base64Component();
                base64Component.Dock = DockStyle.Fill;
                base64Component.Location = new System.Drawing.Point(0, 0);
            }
            mainPanel.Controls.Add(base64Component);
            mainPanel.Update();
        }
    }
}