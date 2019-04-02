using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            Process[] procList = Process.GetProcesses();
            foreach (var proc in procList) {
                listView1.Items.Add(proc.Id.ToString() + ")  " + proc.ProcessName.ToString() +"(имя машины: "+ proc.MachineName+")"+" Памяти занято: "+proc.WorkingSet.ToString()+"байт");
            }
        }
    }
}
