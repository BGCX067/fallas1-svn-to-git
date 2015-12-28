using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FallasI
{
    public partial class SimulationDebug : Form
    {
        public SimulationDebug()
        {
            InitializeComponent();
        }

        public static void debugResult(String str)
        {
            FallasI.Simulator._formDebug.debugTxtBox.Text += "\nFrom Rule: " + str;
            FallasI.Simulator._formDebug.Refresh();
        }
    }
}
