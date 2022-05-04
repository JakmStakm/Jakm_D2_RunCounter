using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JakmRunCounter
{
    public partial class FoundIItemForm : Form
    {
        private MainForm _mainform;
        public FoundIItemForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainform = mainForm;
        }

        private void FoundIItem_Load(object sender, EventArgs e)
        {
            cbxItem.DataSource = SQLiteDataAccess.LoadItems(UsedProfile.usedProfile);
            cbxItem.DisplayMember = "name";
            if (GlobalFoundItem.isGrailOnly == true)
            {
                chbGrailOnly.Visible = false;
                txtComments.Visible = false;
                label1.Visible = false;
                chbGrailOnly.Checked = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SQLiteDataAccess.checkItemExists(UsedProfile.usedProfile, cbxItem.Text) == true)
            {

                GlobalFoundItem.foundItem = cbxItem.Text;

                if (SQLiteDataAccess.checkIFNewHolyGrail(UsedProfile.usedProfile, cbxItem.Text) == true)
                {
                    System.Windows.Forms.MessageBox.Show(cbxItem.Text + " added to your Holy Grail!");
                    SQLiteDataAccess.addNewItem(UsedProfile.usedProfile, cbxItem.Text, getDate());
                }
                else
                {
                    if(GlobalFoundItem.isGrailOnly == true)
                    {
                        string dateFound = SQLiteDataAccess.CheckDateOfHolyGrail(UsedProfile.usedProfile, cbxItem.Text);
                        System.Windows.Forms.MessageBox.Show(cbxItem.Text + " has already been found on " + dateFound);
                    }
                }
                if (chbGrailOnly.Checked == false && GlobalFoundItem.isGrailOnly == false)
                {
                    _mainform.recordFoundItem(txtComments.Text);
                    _mainform.FoundItem();
                    GlobalFoundItem.foundItem = cbxItem.Text + " " + txtComments.Text;
                }
                else if(chbGrailOnly.Checked == true || GlobalFoundItem.isGrailOnly == true)
                {
                    //_mainform.cancelFromFoundItemForm();
                    //System.Windows.Forms.MessageBox.Show(cbxItem.Text + " NOT A RUN");
                }
                GlobalFoundItem.isGrailOnly = false;
                this.Close();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Invalid item name, try again");
            }
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            GlobalFoundItem.isGrailOnly = false;
            _mainform.cancelFromFoundItemForm();
            this.Close();
            
        }

        private static string getDate()
        {
            return DateTime.Today.ToString("MM/dd");
        }
    }
}
