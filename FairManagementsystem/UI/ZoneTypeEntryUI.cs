using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FairManagementsystem.BLL;
using FairManagementsystem.DAL.DAO;

namespace FairManagementsystem.UI
{
    public partial class ZoneTypeEntryUI : Form
    {
        public ZoneTypeEntryUI()
        {
            InitializeComponent();
        }
        ZoneTypeManager aZoneManager=new ZoneTypeManager();
        ZoneType aZoneType=new ZoneType();
        private void saveButton_Click(object sender, EventArgs e)
        {
            aZoneType.Zonetype = typeNameTextBox.Text;
            typeNameTextBox.Text = "";
            MessageBox.Show(aZoneManager.Save(aZoneType));
            LoadDataGridView(aZoneManager.ZoneList());
            
        }

        public void LoadDataGridView(List<ZoneType> zoneList )
        {
            zoneTypeDataGridView.Rows.Clear();
            foreach (ZoneType zone in zoneList)
            {
                zoneTypeDataGridView.Rows.Add(zone.Zonetype);
            }
            
        }

        private void ZoneTypeEntryUI_Load(object sender, EventArgs e)
        {
            LoadDataGridView(aZoneManager.ZoneList());
        }
        
    }
}
