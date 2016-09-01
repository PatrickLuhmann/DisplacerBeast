using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisplacerBeast
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // PJL code
            this.MainOutputTextBox.Text += "This is a test.";
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.AppendLine("This is line number 1.");
            sb.AppendLine("This is line number 2.");
            this.MainOutputTextBox.Text += sb.ToString();
            int val = 123;
            sb.Clear();
            sb.AppendFormat("{0:X4} == {0}", val, val);
            sb.AppendLine();
            this.MainOutputTextBox.Text += sb.ToString();

            for (int x = 0; x < 32; x++)
            {
                this.MainOutputTextBox.Text += string.Format("{0,2}", x);
                this.MainOutputTextBox.Text += System.Environment.NewLine;
            }

            System.Diagnostics.Debug.WriteLine("This is a debug test.");

        }
    }
}
