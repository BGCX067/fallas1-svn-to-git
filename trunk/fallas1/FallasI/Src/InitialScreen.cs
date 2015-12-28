using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FallasI.Src;


namespace FallasI
{
    public partial class InitialScreen : Form
    {
        public InitialScreen()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void IntroduceData_Click(object sender, EventArgs e)
        {
            IntroduceData iDForm = new IntroduceData();
            iDForm.Show();
        }

        private void Simulate_Click(object sender, EventArgs e)
        {
            Simulation sForm = new Simulation();
            sForm.Show();
            
        }
    }
}
