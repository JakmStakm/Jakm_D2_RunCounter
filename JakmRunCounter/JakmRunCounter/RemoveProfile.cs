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
    public partial class RemoveProfile : Form
    {
        private MainForm _mainform;
        public RemoveProfile(MainForm mainForm)
        {
            InitializeComponent();
            _mainform = mainForm;
        }

        private void RemoveProfile_Load(object sender, EventArgs e)
        {
            cbxProfile.DataSource = SQLiteDataAccess.getProfiles();
            cbxProfile.DisplayMember = "profileName";
            cbxProfile.SelectedIndex = cbxProfile.FindStringExact(UsedProfile.usedProfile);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to delete this Profile? You will lose all Holy Grail progress for this account";
            string title = "Confirm DELETE";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                SQLiteDataAccess.deleteProfile(cbxProfile.Text);

                _mainform.updateProfileName();
            }
            else
            {
                // Do something  
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
