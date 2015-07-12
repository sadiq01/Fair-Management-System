using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FairManagementsystem.UI;

namespace FairManagementsystem
{
    public partial class MainAreaUI : Form
    {
        public MainAreaUI()
        {
            InitializeComponent();
        }

        private void MainAreaUI_Load(object sender, EventArgs e)
        {

        }

        private void visitorEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisitorEntryUI visitorEntryUi=new VisitorEntryUI();
            visitorEntryUi.Show();
        }

        private void zoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZoneTypeEntryUI zoneTypeEntryUi= new ZoneTypeEntryUI();
            zoneTypeEntryUi.Show();
        }

        private void zoneSpecificVisitorDetailisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZoneSpecificVisitorInformationReportUI zoneSpecificVisitorInformationReportUi= new ZoneSpecificVisitorInformationReportUI();
            zoneSpecificVisitorInformationReportUi.Show();
        }

        private void zoneWiseVisitorNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZoneTypeWiseUI zoneTypeWiseUi=new ZoneTypeWiseUI();
            zoneTypeWiseUi.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
    }
}
