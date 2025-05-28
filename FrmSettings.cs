using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keypord_typing_project
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
            Form1.ChangeTimerCount((int)numericUpDown1.Value);
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            numericUpDown1.ReadOnly = true;
        }
    }
}
