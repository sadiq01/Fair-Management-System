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
    public partial class ZoneTypeWiseUI : Form
    {
        public ZoneTypeWiseUI()
        {
            InitializeComponent();
            LoadZoneInfo();

        }

        ZoneTypeManager zoneManager=new ZoneTypeManager();
        List<ZoneType> allZoneTypeList=new List<ZoneType>();
        Queue<int> visitorsID=new Queue<int>();
        private int total;
        public void LoadZoneInfo()
        {
            allZoneTypeList = zoneManager.GetZone(out visitorsID);
            LoadDataGridView();

        }

        public void LoadDataGridView()
        {
            int visitorNumber = 0;
            foreach (ZoneType zone in allZoneTypeList)
            {
                visitorNumber = visitorsID.Dequeue();
                total += visitorNumber;
                zoneWiseDataGridView.Rows.Add(zone.Zonetype, visitorNumber.ToString());

            }
            totalTextBox.Text = total.ToString();
        }
    }
}
