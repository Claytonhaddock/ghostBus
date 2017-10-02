using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GhostBus
{
    public partial class Form1 : Form
    {
        bool winning = true;
        manager GameMan = new manager();
        public Form1()
        {
            InitializeComponent();
        }


        

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] times= GameMan.RequestArrivals();
            bus1time.Text = times[0].ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GameMan.init();
        }
    }
}
