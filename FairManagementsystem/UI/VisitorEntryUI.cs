using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FairManagementsystem.BLL;
using FairManagementsystem.DAL.DAO;

namespace FairManagementsystem.UI
{
    public partial class VisitorEntryUI : Form
    {
        public VisitorEntryUI()
        {
            InitializeComponent();
            CheckBoxFalse();
            zoneList = aZoneManager.ZoneList();
            CheckZoneType(zoneList);
        }
        VisitorManager aVisitorManager=new VisitorManager();
        List<ZoneType> zoneList =new List<ZoneType>();
        ZoneTypeManager aZoneManager=new ZoneTypeManager();
        private string message;
        int count = 0;
        public void CheckBoxFalse()
        {
            checkBox1.Hide();
            checkBox2.Hide();
            checkBox3.Hide();
            checkBox4.Hide();
            checkBox5.Hide();
            checkBox6.Hide();
        }

        
        public void CheckZoneType(List<ZoneType> zoneList)
        {
            count = 0;
            foreach (ZoneType zone in zoneList)
            {
                count ++;
                if (count == 1)
                {
                    checkBox1.Show();
                    checkBox1.Text = zone.Zonetype;
                    checkBox1.Checked=true;
                }
                else if (count == 2)
                {
                    checkBox2.Show();
                    checkBox2.Text = zone.Zonetype;
                    checkBox2.Checked = true;
                }

                else if (count == 3)
                {
                    checkBox3.Show();
                    checkBox3.Text = zone.Zonetype;
                    checkBox3.Checked = true;
                }
                else if (count == 4)
                {
                    checkBox4.Show();
                    checkBox4.Text = zone.Zonetype;
                    checkBox4.Checked = true;
                }

                else if (count == 5)
                {
                    checkBox5.Show();
                    checkBox5.Text = zone.Zonetype;
                    checkBox5.Checked = true;
                }
                else
                {
                    
                    checkBox6.Show();
                    checkBox6.Text = zone.Zonetype;
                    checkBox6.Checked = true;
                

                }


            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Visitor aVisitor=new Visitor();
            aVisitor.Name = nameTextBox.Text;
            aVisitor.Email = emailTextBox.Text;
            aVisitor.ContactNo = contactTextBox.Text;
            List<string> visitorZoneTypeList= new List<string>();
            
            if (!aVisitorManager.CheckVisitorInfo(aVisitor, out message))
            {
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                for (int i = 1; i <= count; i++)
                {
                    if (i == 1 && checkBox1.Checked == true)
                    {
                        visitorZoneTypeList.Add(checkBox1.Text);
                    }
                    else if (i == 2 && checkBox2.Checked == true)
                    {
                        visitorZoneTypeList.Add(checkBox2.Text);
                    }
                    else if (i == 3 && checkBox3.Checked == true)
                    {
                        visitorZoneTypeList.Add(checkBox3.Text);
                    }
                    else if (i == 4 && checkBox4.Checked == true)
                    {
                        visitorZoneTypeList.Add(checkBox4.Text);
                    }

                    else if (i == 5 && checkBox5.Checked == true)
                    {
                        visitorZoneTypeList.Add(checkBox5.Text);
                    }
                    else if (i == 6 && checkBox6.Checked == true)
                    {
                        visitorZoneTypeList.Add(checkBox6.Text);
                    }
                }

                aVisitorManager.Save(aVisitor, visitorZoneTypeList);
                MessageBox.Show(message, "Successfully Saved", MessageBoxButtons.OK);
                

            }
            nameTextBox.Text = emailTextBox.Text = contactTextBox.Text = null;
            zoneList = aZoneManager.ZoneList();
            CheckZoneType(zoneList);
           
          
        }

      
    }
}
