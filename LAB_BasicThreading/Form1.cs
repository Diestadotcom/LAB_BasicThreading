using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_BasicThreading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Console.WriteLine("-Before starting thread-");
            Thread ThreadA = new Thread(new ThreadStart(MyThreadClass.Thread1));
            Thread ThreadB = new Thread(new ThreadStart(MyThreadClass.Thread1));
            ThreadA.Name = "Thread A";
            ThreadB.Name = "Thread B";

            ThreadA.Start();
            ThreadB.Start();

            ThreadA.Join();
            ThreadB.Join();
            Console.WriteLine("-End of Thread-");

            lblStatus.Text = "-End of Thread-";
        }
    }
}