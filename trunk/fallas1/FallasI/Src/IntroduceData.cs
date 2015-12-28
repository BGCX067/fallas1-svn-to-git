using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace FallasI.Src
{
    public partial class IntroduceData : Form
    {

        private Simulator sim = Simulator.Instance;
        
        public IntroduceData()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            LoadDataToSimulator();
            this.Close();
        }

        private void LoadDataToSimulator()
        {
            sim.GameSurfaceType = cmbSurfaceType.SelectedIndex;
            sim.GameSurface = cmbGameSurface.SelectedIndex;
            sim.ServerType = cmbServerType.SelectedIndex;
            sim.ServerHeight = cmbServerHeight.SelectedIndex;
            sim.ReceptorHeight = cmbReceptorHeight.SelectedIndex;
            sim.ReceptorType = cmbReceptorType.SelectedIndex;
            sim.ReceptorPositionX = cmbReceptorPositionX.SelectedIndex;
            sim.ReceptorPositionY = cmbReceptorPositionY.SelectedIndex;
        }

        private void cmbReceptorPositionY_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
   }
}
