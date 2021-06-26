using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace my_tools.components
{
    public class Base64Component : UserControl
    {
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox inputTextBox;
        private Panel panel1;
        private Button DecodeButton;
        private Button EncodeButton;
        private TextBox outputTextBox;
        public Base64Component()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EncodeButton = new System.Windows.Forms.Button();
            this.DecodeButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.inputTextBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.outputTextBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(859, 539);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // inputTextBox
            // 
            this.inputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputTextBox.Location = new System.Drawing.Point(3, 3);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(853, 238);
            this.inputTextBox.TabIndex = 1;
            // 
            // outputTextBox
            // 
            this.outputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputTextBox.Location = new System.Drawing.Point(3, 297);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(853, 239);
            this.outputTextBox.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DecodeButton);
            this.panel1.Controls.Add(this.EncodeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 247);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 44);
            this.panel1.TabIndex = 3;
            // 
            // EncodeButton
            // 
            this.EncodeButton.Location = new System.Drawing.Point(14, 11);
            this.EncodeButton.Name = "EncodeButton";
            this.EncodeButton.Size = new System.Drawing.Size(75, 23);
            this.EncodeButton.TabIndex = 0;
            this.EncodeButton.Text = "Encode";
            this.EncodeButton.UseVisualStyleBackColor = true;
            this.EncodeButton.Click += new System.EventHandler(this.EncodeButton_Click);
            // 
            // DecodeButton
            // 
            this.DecodeButton.Location = new System.Drawing.Point(106, 11);
            this.DecodeButton.Name = "DecodeButton";
            this.DecodeButton.Size = new System.Drawing.Size(75, 23);
            this.DecodeButton.TabIndex = 1;
            this.DecodeButton.Text = "Decode";
            this.DecodeButton.UseVisualStyleBackColor = true;
            this.DecodeButton.Click += new System.EventHandler(this.DecodeButton_Click);
            // 
            // Base64Component
            // 
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Base64Component";
            this.Size = new System.Drawing.Size(859, 539);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void EncodeButton_Click(object sender, EventArgs e)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(inputTextBox.Text);
            outputTextBox.Text = System.Convert.ToBase64String(plainTextBytes);
        }

        private void DecodeButton_Click(object sender, EventArgs e)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(inputTextBox.Text);
            outputTextBox.Text = System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
    }
}
