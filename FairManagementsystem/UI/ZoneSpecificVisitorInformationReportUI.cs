using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using FairManagementsystem.BLL;
using FairManagementsystem.DAL.DAO;

namespace FairManagementsystem.UI
{
    public partial class ZoneSpecificVisitorInformationReportUI : Form
    {
        public ZoneSpecificVisitorInformationReportUI()
        {
            InitializeComponent();
            LoadAllZone();
             zoneName = (ZoneType)zoneTypeComboBox.SelectedItem;
            LoadZoneTypeVisitor(zoneName);
            totalTextBox.Text = Convert.ToString(visitorDetails.Count);

        }

        private ZoneType zoneName;
        private int totalVisitorNumber;
        ZoneTypeManager zoneManager=new ZoneTypeManager();
        VisitorManager visitorManager =new VisitorManager();
        private List<int> visitorIdList; 
        private List<Visitor> visitorDetails;
      
        public void LoadAllZone()
        {
            zoneTypeComboBox.DataSource = zoneManager.ZoneList();
            zoneTypeComboBox.DisplayMember = "ZoneType";
            zoneTypeComboBox.ValueMember = "ID";

        }

        public void LoadZoneTypeVisitor(ZoneType zoneName)
        {
          visitorDetails= new List<Visitor>();

          visitorIdList = zoneManager.ZoneTypeVisitor(zoneName);
            foreach (int id in visitorIdList)
            {
                Visitor aVisitor=new Visitor();
                aVisitor = visitorManager.GetVisitorInfo(id);
                visitorDetails.Add(aVisitor);
            }
           
            LoadDataGridView(visitorDetails);

        }
        
        public void LoadDataGridView(List<Visitor> visitorList)
        {
            zoneTypeVisitorsDataGridView.Rows.Clear();

            foreach (Visitor visitor in visitorList)
            {
                zoneTypeVisitorsDataGridView.Rows.Add(visitor.Name, visitor.Email, visitor.ContactNo);
            }
           
        }

        private void showButton_Click(object sender, EventArgs e)
        {
             zoneName = (ZoneType)zoneTypeComboBox.SelectedItem;
            LoadZoneTypeVisitor(zoneName);
            totalTextBox.Text = Convert.ToString(visitorDetails.Count);
        }


        private void saveToExcelButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = @"ExportToExcel.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                
                ToExcel(zoneTypeVisitorsDataGridView, sfd.FileName); 
            }
        }

        private void ToExcel(DataGridView dGV, string fileName)
        {
            string stOutput = "";
            
            string sHeaders = "";

            sHeaders += "\t" + zoneName.Zonetype + "\t\t\n";

            for (int j = 0; j < dGV.Columns.Count; j++)
            
                
                sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
                stOutput += sHeaders + "\r\n";
            

            for (int i = 0; i < dGV.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                {
                    if (j == 2)
                    {
                        stLine += "\t";
                    }
                       
                    stLine = stLine.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value) + "\t";
                   

                }

                stOutput += stLine + "\r\n";
            }
            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(fileName, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length); 
            bw.Flush();
            bw.Close();
            fs.Close();
        }
    }
}
