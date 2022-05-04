using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using System.Threading;

namespace JakmRunCounter
{
    public partial class MainForm : Form
    {

        public int changeProfileCounter = 0;
        public Boolean itemsActivated = false;
        public Boolean pauseClock = false;
        public Boolean midRun = false;

        public Form OverlayMFForm = new Form();
        public Button newRunButton2 = new Button();
        public Button StopButton2 = new Button();
        public Button FoundItemButton2 = new Button();
        public Button GrailCheckButton2 = new Button();
        public Form ConfirmImportForm = new Form();
        public Button btn_confirm = new Button();
        public Button btn_deny = new Button();
        public Label discardLabel = new Label();

        public List<d2ItemModel> grailSearchList;


        public void DiscardPrompt()
        {
            

            ConfirmImportForm.Visible = true;

        }
        public static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }

        public void MFOverlay_on()
        {
          
            OverlayMFForm.TopMost = true;
            OverlayMFForm.Activate();
            OverlayMFForm.Visible = true;
            OverlayMFForm.SetDesktopLocation(0, 0);
            OverlayMFForm.Height = 40;

        }

        public void MFOverlay_off()
        {
            OverlayMFForm.TopMost = false;
            OverlayMFForm.Visible = false;
            OverlayMFForm.Height = 40;
            OverlayMFForm.Width = 400;
            newRunButton2.SetBounds(0, 0, 100, 40);
            StopButton2.SetBounds(100, 0, 100, 40);
            FoundItemButton2.SetBounds(200, 0, 100, 40);
            GrailCheckButton2.SetBounds(300, 0, 100, 40);
        }

        public void NewRun()
        {
            if (Stopwatch.Enabled == true)
            {
                runNumber++;
                Stopwatch.Enabled = false;
                int bestTimeCalc = (minutes * 60) + seconds;
                if (BestTime == 0)
                {
                    lbl_BestTime.Text = lbl_RunTime.Text;
                    BestTime = (minutes * 60) + seconds;
                }
                else if (bestTimeCalc < BestTime)
                {
                    lbl_BestTime.Text = lbl_RunTime.Text;
                    BestTime = (minutes * 60) + seconds;
                }
                minutes = 0;
                seconds = 0;
                Stopwatch.Enabled = true;
            }
            else
            {
                minutes = 0;
                seconds = 0;
                Stopwatch.Enabled = true;
            }
            btn_Found_Item.Enabled = true;
            btn_Stop.Enabled = true;
            StopButton2.Enabled = true;
            FoundItemButton2.Enabled = true;
            newRunButton2.Text = "New Run: " + (runNumber + 1).ToString();
            lbl_RunNumber.Text = (runNumber + 1).ToString();
        }

        public void FoundItem()
        {
            //if (Stopwatch.Enabled == true)
            //{

                runNumber++;
                lbl_RunNumber.Text = runNumber.ToString();
                Stopwatch.Enabled = false;
                String newRunNumber = "Run " + runNumber;
                lst_RunNumber.Items.Add(newRunNumber);

                int bestTimeCalc = (minutes * 60) + seconds;
                if (BestTime == 0)
                {
                    lbl_BestTime.Text = lbl_RunTime.Text;
                }
                else if (bestTimeCalc < BestTime)
                {
                    lbl_BestTime.Text = lbl_RunTime.Text;
                }

                //string itemName = "Item";
                //DialogResult inputItemName = InputBox("Item Name", "Item Name:", ref itemName);
                //String itemNameString = itemName;
                //lst_ItemFound.Items.Add(itemNameString);
                btn_Found_Item.Enabled = false;
                btn_Stop.Enabled = false;
                StopButton2.Enabled = false;
                FoundItemButton2.Enabled = false;
            //}
        }

        public void recordFoundItem(String ItemCaption)
        {
            if (ItemCaption == "")
            {
                lst_ItemFound.Items.Add(GlobalFoundItem.foundItem);
            }
            else
            {
                lst_ItemFound.Items.Add(GlobalFoundItem.foundItem + " (" + ItemCaption + ')');
            }
        }

        public void StopRun()
        {
            if (Stopwatch.Enabled == true)
            {
                midRun = false;
                runNumber++;
                lbl_RunNumber.Text = runNumber.ToString();
                Stopwatch.Enabled = false;

                int bestTimeCalc = (minutes * 60) + seconds;
                if (BestTime == 0)
                {
                    lbl_BestTime.Text = lbl_RunTime.Text;
                    BestTime = (minutes * 60) + seconds;
                }
                else if (bestTimeCalc < BestTime)
                {
                    lbl_BestTime.Text = lbl_RunTime.Text;
                    BestTime = (minutes * 60) + seconds;
                }
                btn_Found_Item.Enabled = false;
                btn_Stop.Enabled = false;
                StopButton2.Enabled = false;
                FoundItemButton2.Enabled = false;
            }
        }

        public Array RunTimes;
        public int seconds;
        public int minutes;
        public int runNumber;
        public int BestTime;
        public int overlayOn;
        public int DiscardConfirmInt = 0;
        public MainForm()
        {
            InitializeComponent();
            overlayOn = 0;
         }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 279;
            runNumber = 0;
            OverlayMFForm.Width = 400;
            OverlayMFForm.FormBorderStyle = FormBorderStyle.None;
            newRunButton2.Text = "New Run";
            StopButton2.Text = "Stop";
            FoundItemButton2.Text = "Found Item";
            GrailCheckButton2.Text = "Add To Grail";
            newRunButton2.SetBounds(0, 0, 100, 40);
            StopButton2.SetBounds(100, 0, 100, 40);
            FoundItemButton2.SetBounds(200, 0, 100, 40);
            GrailCheckButton2.SetBounds(300, 0, 100, 40);
            OverlayMFForm.Controls.AddRange(new Control[] { newRunButton2, StopButton2, FoundItemButton2, GrailCheckButton2 });
            newRunButton2.Click += new EventHandler(this.newRunButton2_Click);
            newRunButton2.MouseDown += new MouseEventHandler(this.newRunButton2_MouseDown);
            FoundItemButton2.Click += new EventHandler(this.FoundItemButton2_Click);
            FoundItemButton2.MouseDown += new MouseEventHandler(this.FoundItemButton2_MouseDown);
            StopButton2.Click += new EventHandler(this.StopButton2_Click);
            StopButton2.MouseDown += new MouseEventHandler(this.StopButton2_MouseDown);
            GrailCheckButton2.Click += new EventHandler(this.GrailCheckButton2_Click);
            GrailCheckButton2.MouseDown += new MouseEventHandler(this.GrailCheckButton2_MouseDown);
            newRunButton2.ForeColor = Color.Yellow;
            newRunButton2.BackColor = Color.Black;
            newRunButton2.Font = new Font(newRunButton2.Font, FontStyle.Bold);
            StopButton2.ForeColor = Color.Yellow;
            StopButton2.BackColor = Color.Black;
            StopButton2.Font = new Font(StopButton2.Font, FontStyle.Bold);
            StopButton2.Enabled = false;
            FoundItemButton2.ForeColor = Color.Yellow;
            FoundItemButton2.BackColor = Color.Black;
            FoundItemButton2.Font = new Font(FoundItemButton2.Font, FontStyle.Bold);
            FoundItemButton2.Enabled = false;
            GrailCheckButton2.ForeColor = Color.Yellow;
            GrailCheckButton2.BackColor = Color.Black;
            GrailCheckButton2.Font = new Font(FoundItemButton2.Font, FontStyle.Bold);


            ConfirmImportForm.Width = 340;
            ConfirmImportForm.Height = 200;
            ConfirmImportForm.Text = "Confirm";
            discardLabel.SetBounds(50, 20, 60, 60);
            ConfirmImportForm.Activate();
            discardLabel.Text = "Discard current runs?";
            discardLabel.Visible = true;
            discardLabel.AutoSize = true;
            discardLabel.Font = new Font(this.Font.FontFamily, 16);
            btn_confirm.Text = "Yes";
            btn_deny.Text = "Cancel";
            btn_confirm.SetBounds(40, 90, 70, 30);
            btn_deny.SetBounds(210, 90, 70, 30);
            ConfirmImportForm.Controls.AddRange(new Control[] { discardLabel, btn_confirm, btn_deny });
            btn_confirm.Click += new EventHandler(this.btn_confirm_Click);
            btn_deny.Click += new EventHandler(this.btn_deny_Click);
            ConfirmImportForm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            ConfirmImportForm.MaximizeBox = false;
            ConfirmImportForm.MinimizeBox = false;

            cbxItemCatagory.Items.Add("Unique");
            cbxItemCatagory.Items.Add("Set Items");
            cbxItemCatagory.Items.Add("Runewords");
            cbxItemCatagory.Items.Add("Runes");
            cbxItemCatagory.Items.Add("ALL");

            if (System.IO.File.Exists(@".\lastUsedProfile.txt"))
            {
                string profileName = File.ReadAllText(@".\lastUsedProfile.txt", Encoding.UTF8);
                UsedProfile.usedProfile = profileName;
            }
            else
            {
                createNewProfile();
            }

            updateProfileName();
            SQLiteDataAccess.createInitialSettings();

        }

        private void OverlayMFForm_Load(object sender, EventArgs e)
        {

        }

        public void updateProfileName()
        {
            cbxProfile.DataSource = SQLiteDataAccess.getProfiles();
            cbxProfile.DisplayMember = "profileName";
            cbxProfile.SelectedIndex = cbxProfile.FindStringExact(UsedProfile.usedProfile);
        }

        public void createNewProfile()
        {
            string newProfileName = "";
            do
            {
                newProfileName = Interaction.InputBox("Enter a Profile Name to save your Holy Grail", "New Profile", "Profile Name", 60, 60);
                UsedProfile.usedProfile = newProfileName;
            } while (newProfileName == "");
            SQLiteDataAccess.createInitialSettings();
            SQLiteDataAccess.CreateNewProfile($"{UsedProfile.usedProfile}");
            File.WriteAllText(@".\lastUsedProfile.txt", UsedProfile.usedProfile);
            //Thread.Sleep(2000);
            SQLiteDataAccess.saveProfile(UsedProfile.usedProfile);
            updateProfileName();
        }

        private void Stopwatch_Tick(object sender, EventArgs e)
        {
            seconds++;
            if (seconds == 60)
            {
                minutes++;
                seconds = 0;
            }
            if (seconds < 10)
            {
                lbl_RunTime.Text = minutes + ":0" + seconds;
            }
            else
            {
                lbl_RunTime.Text = minutes + ":" + seconds;
            }
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            StopRun();
        }

        private void btn_NewRun_Click(object sender, EventArgs e)
        {
            NewRun();
        }

        private void btn_Found_Item_Click(object sender, EventArgs e)
        {
            foundItemForm();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            try
            {

                lst_RunNumber.Items.Clear();
                lst_ItemFound.Items.Clear();
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "CSV File|*.csv";
                openFileDialog1.ShowDialog();
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);
                String[] lineFields;
                String fileLine;
                String comma = ",";
                String newRunNumber;
                String newRunItem;
                String colon = ":";
                String[] runNumberSplit;
                String[] bestTimeSplit;
                Char commaChar = char.Parse(comma);
                Char colonChar = char.Parse(colon);
                while (!sr.EndOfStream)
                {
                    fileLine = sr.ReadLine();
                    lineFields = fileLine.Split(commaChar);
                    newRunNumber = lineFields[0];
                    newRunItem = lineFields[1];
                    if (newRunNumber.StartsWith("RunNumber"))
                    {
                        runNumberSplit = newRunNumber.Split(colonChar);
                        bestTimeSplit = newRunItem.Split(colonChar);
                        runNumber = Int32.Parse(runNumberSplit[1]);
                        BestTime = Int32.Parse(bestTimeSplit[1]);
                        lbl_BestTime.Text = BestTime.ToString() + " Seconds";
                        lbl_RunNumber.Text = runNumber.ToString();
                    }
                    else
                    {
                        lst_RunNumber.Items.Add(newRunNumber);
                        lst_ItemFound.Items.Add(newRunItem);
                    }
                }
                sr.Close();
            }
            catch
            {

            }
            ConfirmImportForm.Visible = false;
        }

        private void btn_deny_Click(object sender, EventArgs e)
        {
            ConfirmImportForm.Visible = false;
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "CSV File|*.csv";
            saveFileDialog1.ShowDialog();
            StringBuilder sbOutput = new StringBuilder();
            sbOutput.AppendLine("RunNumber:" + runNumber.ToString() + ",BestTime:" + BestTime.ToString());
            for(int i = 0; i < lst_RunNumber.Items.Count; i++)
            {
                sbOutput.AppendLine(lst_RunNumber.Items[i] + "," + lst_ItemFound.Items[i]);
            }
            try
            {
                File.WriteAllText(saveFileDialog1.FileName, sbOutput.ToString());
            }
            catch
            {

            }
        }

        private void btn_Import_Click(object sender, EventArgs e)
        {
            if(lst_RunNumber.Items.Count >= 0)
            {
                DiscardPrompt();
            }

        }

        private void chk_Overlay_CheckedChanged(object sender, EventArgs e)
        {
            if(chk_Overlay.Checked == true)
            {
                MFOverlay_on();
                overlayOn = 1;
                chk_MoveOverlay.Visible = true;
                lblHeight.Visible = true;
                lblWidth.Visible = true;
                btn_HeightDown.Visible = true;
                btn_HeightUp.Visible = true;
                btn_WidthDown.Visible = true;
                btn_WidthUp.Visible = true;
            }else if(chk_Overlay.Checked == false){
                MFOverlay_off();
                overlayOn = 0;
                chk_MoveOverlay.Visible = false;
                lblHeight.Visible = false;
                lblWidth.Visible = false;
                btn_HeightDown.Visible = false;
                btn_HeightUp.Visible = false;
                btn_WidthDown.Visible = false;
                btn_WidthUp.Visible = false;

            }
        }

        public void GrailCheckButton2_Click(object sender, EventArgs e)
        {
            GlobalFoundItem.isGrailOnly = true;
            FoundIItemForm newFoundItemForm = new FoundIItemForm(this);
            newFoundItemForm.Show();
        }

        public void GrailCheckButton2_MouseDown(object sender, MouseEventArgs e)
        {
            if (chk_MoveOverlay.Checked == true)
            {
                GrailCheckButton2.Capture = false;

                const int WM_NCLBUTTONDOWN = 0x00A1;
                const int HTCAPTION = 2;
                Message msg =
                    Message.Create(OverlayMFForm.Handle, WM_NCLBUTTONDOWN,
                        new IntPtr(HTCAPTION), IntPtr.Zero);
                this.DefWndProc(ref msg);
            }
        }

        public void newRunButton2_Click(object sender, EventArgs e)
        {
            NewRun();
        }

        public void newRunButton2_MouseDown(object sender, MouseEventArgs e)
        {
            if(chk_MoveOverlay.Checked == true)
            {
                newRunButton2.Capture = false;

                const int WM_NCLBUTTONDOWN = 0x00A1;
                const int HTCAPTION = 2;
                Message msg =
                    Message.Create(OverlayMFForm.Handle, WM_NCLBUTTONDOWN,
                        new IntPtr(HTCAPTION), IntPtr.Zero);
                this.DefWndProc(ref msg);
            }
        }

        public void StopButton2_MouseDown(object sender, MouseEventArgs e)
        {
            if (chk_MoveOverlay.Checked == true)
            {
                StopButton2.Capture = false;

                const int WM_NCLBUTTONDOWN = 0x00A1;
                const int HTCAPTION = 2;
                Message msg =
                    Message.Create(OverlayMFForm.Handle, WM_NCLBUTTONDOWN,
                        new IntPtr(HTCAPTION), IntPtr.Zero);
                this.DefWndProc(ref msg);
            }
        }

        public void FoundItemButton2_MouseDown(object sender, MouseEventArgs e)
        {
            if (chk_MoveOverlay.Checked == true)
            {
                FoundItemButton2.Capture = false;

                const int WM_NCLBUTTONDOWN = 0x00A1;
                const int HTCAPTION = 2;
                Message msg =
                    Message.Create(OverlayMFForm.Handle, WM_NCLBUTTONDOWN,
                        new IntPtr(HTCAPTION), IntPtr.Zero);
                this.DefWndProc(ref msg);
            }
        }

        public void StopButton2_Click(object sender, EventArgs e)
        {
            StopRun();
        }

        public void FoundItemButton2_Click(object sender, EventArgs e)
        {
            foundItemForm();
        }

        private void lst_RunNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lst_ItemFound.TopIndex != lst_RunNumber.TopIndex)
            {
                lst_ItemFound.TopIndex = lst_RunNumber.TopIndex;
            }

            if(lst_ItemFound.SelectedIndex != lst_RunNumber.SelectedIndex)
            {
                lst_ItemFound.SelectedIndex = lst_RunNumber.SelectedIndex;
            }
        }

        private void lst_ItemFound_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lst_RunNumber.TopIndex != lst_ItemFound.TopIndex)
            {
                lst_RunNumber.TopIndex = lst_ItemFound.TopIndex;
            }

            if(lst_RunNumber.SelectedIndex != lst_ItemFound.SelectedIndex)
            {
                lst_RunNumber.SelectedIndex = lst_ItemFound.SelectedIndex;
            }
        }

        private void btn_WidthDown_Click(object sender, EventArgs e)
        {
            if (OverlayMFForm.Width >= 330)
            {
                OverlayMFForm.Width -= 20;
                newRunButton2.Width -= 5;
                StopButton2.Left -= 5;
                StopButton2.Width -= 5;
                FoundItemButton2.Left -= 10;
                FoundItemButton2.Width -= 5;
                GrailCheckButton2.Left -= 15;
                GrailCheckButton2.Width -= 5;

            }
        }

        private void btn_WidthUp_Click(object sender, EventArgs e)
        {
            OverlayMFForm.Width += 20;
            newRunButton2.Width += 5;
            StopButton2.Left += 5;
            StopButton2.Width += 5;
            FoundItemButton2.Left += 10;
            FoundItemButton2.Width += 5;
            GrailCheckButton2.Left += 15;
            GrailCheckButton2.Width += 5;


        }

        private void btn_HeightDown_Click(object sender, EventArgs e)
        {
            if (OverlayMFForm.Height >= 40)
            {
                OverlayMFForm.Height -= 20;
                newRunButton2.Height -= 20;
                StopButton2.Height -= 20;
                FoundItemButton2.Height -= 20;
                GrailCheckButton2.Height -= 20;
            }
        }

        private void btn_HeightUp_Click(object sender, EventArgs e)
        {
            OverlayMFForm.Height += 20;
            newRunButton2.Height += 20;
            StopButton2.Height += 20;
            FoundItemButton2.Height += 20;
            GrailCheckButton2.Height += 20;
        }

        private void chk_MoveOverlay_CheckedChanged(object sender, EventArgs e)
        {
            if(chk_MoveOverlay.Checked == true)
            {
                newRunButton2.Text = "Move Me";
            }
            else
            {
                newRunButton2.Text = "New Run: " + (runNumber).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            createNewProfile();
        }

        private void cbxProfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            UsedProfile.usedProfile = cbxProfile.Text;
            File.WriteAllText(@".\lastUsedProfile.txt", UsedProfile.usedProfile);
            try
            {
                lstGrail.DataSource = SQLiteDataAccess.LoadItems(UsedProfile.usedProfile);
                lstGrail.DisplayMember = "name";
            }
            catch
            {

            }


        }


        private void btnItems_Click(object sender, EventArgs e)
        {
            if(itemsActivated == false)
            {
                this.Width = 609;
                itemsActivated = true;
                btnItems.Text = "Items <-";
            }
            else
            {
                this.Width = 279;
                itemsActivated = false;
                btnItems.Text = "Items ->";
            }
        }


        public void foundItemForm()
        {
            if (Stopwatch.Enabled == true)
            {
                Stopwatch.Enabled = false;
                midRun = true;
            }
            FoundIItemForm newFoundItemForm = new FoundIItemForm(this);
            newFoundItemForm.Show();
        }

        public void cancelFromFoundItemForm()
        {
            if (Stopwatch.Enabled == false && midRun == true)
            {
                Stopwatch.Enabled = true;
            }
        }

        private void txtGrailSearch_TextChanged(object sender, EventArgs e)
        {
            updateSearch();
        }

        private void chkFound_CheckedChanged(object sender, EventArgs e)
        {
            updateSearch();
        }
        
        public void updateSearch()
        {
            var sqlCommand = $"select * from d2Items where name like '%{txtGrailSearch.Text}%'";

            if (chkFound.Checked == true)
            {
                sqlCommand += " and found='1'";
            }

            if (chkNotFound.Checked == true)
            {
                sqlCommand += " and found='0'";
            }

            if (cbxItemCatagory.Text == "Unique")
            {
                    sqlCommand += " and rarity='uniqueItems'";
            }
            else if(cbxItemCatagory.Text == "Set Items"){
                    sqlCommand += " and rarity='setItems'";
            }
            else if (cbxItemCatagory.Text == "Runewords")
            {
                    sqlCommand += " and rarity='runewords'";
            }
            else if (cbxItemCatagory.Text == "Runes")
            {
                    sqlCommand += " and rarity='runes'";
            }

            //grailSearchList = SQLiteDataAccess.searchItemNames(UsedProfile.usedProfile, txtGrailSearch.Text);
            lstGrail.DataSource = SQLiteDataAccess.searchItemNames(UsedProfile.usedProfile, sqlCommand);
            lstGrail.DisplayMember = "name";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cbxItemCatagory_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateSearch();
        }

        private void btnGrailOnly_Click(object sender, EventArgs e)
        {
            GlobalFoundItem.isGrailOnly = true;
            FoundIItemForm newFoundItemForm = new FoundIItemForm(this);
            newFoundItemForm.Show();
        }

        private void chkNotFound_CheckedChanged(object sender, EventArgs e)
        {
            updateSearch();
        }

        private static string getDate()
        {
            return DateTime.Today.ToString("MM/dd");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RemoveProfile removeProfileForm = new RemoveProfile(this);
            removeProfileForm.Show();
        }
    }
}
