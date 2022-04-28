
namespace JakmRunCounter
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btn_NewRun = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.btn_Found_Item = new System.Windows.Forms.Button();
            this.lbl_RunTimeText = new System.Windows.Forms.Label();
            this.lbl_RunTime = new System.Windows.Forms.Label();
            this.lbl_BestTimeText = new System.Windows.Forms.Label();
            this.lbl_BestTime = new System.Windows.Forms.Label();
            this.lst_RunNumber = new System.Windows.Forms.ListBox();
            this.lst_ItemFound = new System.Windows.Forms.ListBox();
            this.Stopwatch = new System.Windows.Forms.Timer(this.components);
            this.btn_Import = new System.Windows.Forms.Button();
            this.btn_Export = new System.Windows.Forms.Button();
            this.lblRunNumberText = new System.Windows.Forms.Label();
            this.lbl_RunNumber = new System.Windows.Forms.Label();
            this.chk_Overlay = new System.Windows.Forms.CheckBox();
            this.chk_MoveOverlay = new System.Windows.Forms.CheckBox();
            this.btn_HeightDown = new System.Windows.Forms.Button();
            this.btn_WidthDown = new System.Windows.Forms.Button();
            this.lblWidth = new System.Windows.Forms.Label();
            this.btn_WidthUp = new System.Windows.Forms.Button();
            this.btn_HeightUp = new System.Windows.Forms.Button();
            this.lblHeight = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxProfile = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnItems = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lstGrail = new System.Windows.Forms.ListBox();
            this.txtGrailSearch = new System.Windows.Forms.TextBox();
            this.chkFound = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkNotFound = new System.Windows.Forms.CheckBox();
            this.cbxItemCatagory = new System.Windows.Forms.ComboBox();
            this.btnGrailOnly = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_NewRun
            // 
            this.btn_NewRun.BackColor = System.Drawing.Color.Black;
            this.btn_NewRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NewRun.ForeColor = System.Drawing.Color.Yellow;
            this.btn_NewRun.Location = new System.Drawing.Point(12, 59);
            this.btn_NewRun.Name = "btn_NewRun";
            this.btn_NewRun.Size = new System.Drawing.Size(75, 23);
            this.btn_NewRun.TabIndex = 0;
            this.btn_NewRun.Text = "New Run";
            this.btn_NewRun.UseVisualStyleBackColor = false;
            this.btn_NewRun.Click += new System.EventHandler(this.btn_NewRun_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.BackColor = System.Drawing.Color.Black;
            this.btn_Stop.Enabled = false;
            this.btn_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Stop.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Stop.Location = new System.Drawing.Point(93, 59);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(75, 23);
            this.btn_Stop.TabIndex = 1;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.UseVisualStyleBackColor = false;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // btn_Found_Item
            // 
            this.btn_Found_Item.BackColor = System.Drawing.Color.Black;
            this.btn_Found_Item.Enabled = false;
            this.btn_Found_Item.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Found_Item.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Found_Item.Location = new System.Drawing.Point(174, 59);
            this.btn_Found_Item.Name = "btn_Found_Item";
            this.btn_Found_Item.Size = new System.Drawing.Size(75, 23);
            this.btn_Found_Item.TabIndex = 2;
            this.btn_Found_Item.Text = "Found Item";
            this.btn_Found_Item.UseVisualStyleBackColor = false;
            this.btn_Found_Item.Click += new System.EventHandler(this.btn_Found_Item_Click);
            // 
            // lbl_RunTimeText
            // 
            this.lbl_RunTimeText.AutoSize = true;
            this.lbl_RunTimeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RunTimeText.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_RunTimeText.Location = new System.Drawing.Point(9, 85);
            this.lbl_RunTimeText.Name = "lbl_RunTimeText";
            this.lbl_RunTimeText.Size = new System.Drawing.Size(65, 13);
            this.lbl_RunTimeText.TabIndex = 3;
            this.lbl_RunTimeText.Text = "Run Time:";
            // 
            // lbl_RunTime
            // 
            this.lbl_RunTime.AutoSize = true;
            this.lbl_RunTime.ForeColor = System.Drawing.Color.White;
            this.lbl_RunTime.Location = new System.Drawing.Point(80, 85);
            this.lbl_RunTime.Name = "lbl_RunTime";
            this.lbl_RunTime.Size = new System.Drawing.Size(28, 13);
            this.lbl_RunTime.TabIndex = 4;
            this.lbl_RunTime.Text = "0:00";
            // 
            // lbl_BestTimeText
            // 
            this.lbl_BestTimeText.AutoSize = true;
            this.lbl_BestTimeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BestTimeText.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_BestTimeText.Location = new System.Drawing.Point(129, 85);
            this.lbl_BestTimeText.Name = "lbl_BestTimeText";
            this.lbl_BestTimeText.Size = new System.Drawing.Size(67, 13);
            this.lbl_BestTimeText.TabIndex = 5;
            this.lbl_BestTimeText.Text = "Best Time:";
            // 
            // lbl_BestTime
            // 
            this.lbl_BestTime.AutoSize = true;
            this.lbl_BestTime.ForeColor = System.Drawing.Color.White;
            this.lbl_BestTime.Location = new System.Drawing.Point(202, 85);
            this.lbl_BestTime.Name = "lbl_BestTime";
            this.lbl_BestTime.Size = new System.Drawing.Size(28, 13);
            this.lbl_BestTime.TabIndex = 6;
            this.lbl_BestTime.Text = "0:00";
            // 
            // lst_RunNumber
            // 
            this.lst_RunNumber.FormattingEnabled = true;
            this.lst_RunNumber.Location = new System.Drawing.Point(12, 117);
            this.lst_RunNumber.Name = "lst_RunNumber";
            this.lst_RunNumber.Size = new System.Drawing.Size(75, 277);
            this.lst_RunNumber.TabIndex = 7;
            this.lst_RunNumber.SelectedIndexChanged += new System.EventHandler(this.lst_RunNumber_SelectedIndexChanged);
            // 
            // lst_ItemFound
            // 
            this.lst_ItemFound.FormattingEnabled = true;
            this.lst_ItemFound.Location = new System.Drawing.Point(93, 117);
            this.lst_ItemFound.Name = "lst_ItemFound";
            this.lst_ItemFound.Size = new System.Drawing.Size(156, 277);
            this.lst_ItemFound.TabIndex = 9;
            this.lst_ItemFound.SelectedIndexChanged += new System.EventHandler(this.lst_ItemFound_SelectedIndexChanged);
            // 
            // Stopwatch
            // 
            this.Stopwatch.Interval = 1000;
            this.Stopwatch.Tick += new System.EventHandler(this.Stopwatch_Tick);
            // 
            // btn_Import
            // 
            this.btn_Import.BackColor = System.Drawing.Color.Black;
            this.btn_Import.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Import.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Import.Location = new System.Drawing.Point(33, 437);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Size = new System.Drawing.Size(75, 23);
            this.btn_Import.TabIndex = 10;
            this.btn_Import.Text = "Import";
            this.btn_Import.UseVisualStyleBackColor = false;
            this.btn_Import.Click += new System.EventHandler(this.btn_Import_Click);
            // 
            // btn_Export
            // 
            this.btn_Export.BackColor = System.Drawing.Color.Black;
            this.btn_Export.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Export.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Export.Location = new System.Drawing.Point(149, 437);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(75, 23);
            this.btn_Export.TabIndex = 11;
            this.btn_Export.Text = "Save";
            this.btn_Export.UseVisualStyleBackColor = false;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // lblRunNumberText
            // 
            this.lblRunNumberText.AutoSize = true;
            this.lblRunNumberText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRunNumberText.ForeColor = System.Drawing.Color.Yellow;
            this.lblRunNumberText.Location = new System.Drawing.Point(9, 15);
            this.lblRunNumberText.Name = "lblRunNumberText";
            this.lblRunNumberText.Size = new System.Drawing.Size(46, 13);
            this.lblRunNumberText.TabIndex = 12;
            this.lblRunNumberText.Text = "Run #:";
            // 
            // lbl_RunNumber
            // 
            this.lbl_RunNumber.AutoSize = true;
            this.lbl_RunNumber.ForeColor = System.Drawing.Color.White;
            this.lbl_RunNumber.Location = new System.Drawing.Point(61, 15);
            this.lbl_RunNumber.Name = "lbl_RunNumber";
            this.lbl_RunNumber.Size = new System.Drawing.Size(13, 13);
            this.lbl_RunNumber.TabIndex = 13;
            this.lbl_RunNumber.Text = "0";
            // 
            // chk_Overlay
            // 
            this.chk_Overlay.AutoSize = true;
            this.chk_Overlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Overlay.ForeColor = System.Drawing.Color.Yellow;
            this.chk_Overlay.Location = new System.Drawing.Point(33, 473);
            this.chk_Overlay.Name = "chk_Overlay";
            this.chk_Overlay.Size = new System.Drawing.Size(69, 17);
            this.chk_Overlay.TabIndex = 14;
            this.chk_Overlay.Text = "Overlay";
            this.chk_Overlay.UseVisualStyleBackColor = true;
            this.chk_Overlay.CheckedChanged += new System.EventHandler(this.chk_Overlay_CheckedChanged);
            // 
            // chk_MoveOverlay
            // 
            this.chk_MoveOverlay.AutoSize = true;
            this.chk_MoveOverlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_MoveOverlay.ForeColor = System.Drawing.Color.Yellow;
            this.chk_MoveOverlay.Location = new System.Drawing.Point(132, 473);
            this.chk_MoveOverlay.Name = "chk_MoveOverlay";
            this.chk_MoveOverlay.Size = new System.Drawing.Size(100, 17);
            this.chk_MoveOverlay.TabIndex = 15;
            this.chk_MoveOverlay.Text = "Drag Overlay";
            this.chk_MoveOverlay.UseVisualStyleBackColor = true;
            this.chk_MoveOverlay.Visible = false;
            this.chk_MoveOverlay.CheckedChanged += new System.EventHandler(this.chk_MoveOverlay_CheckedChanged);
            // 
            // btn_HeightDown
            // 
            this.btn_HeightDown.BackColor = System.Drawing.Color.Black;
            this.btn_HeightDown.ForeColor = System.Drawing.Color.Yellow;
            this.btn_HeightDown.Location = new System.Drawing.Point(45, 522);
            this.btn_HeightDown.Name = "btn_HeightDown";
            this.btn_HeightDown.Size = new System.Drawing.Size(29, 23);
            this.btn_HeightDown.TabIndex = 16;
            this.btn_HeightDown.Text = "<-";
            this.btn_HeightDown.UseVisualStyleBackColor = false;
            this.btn_HeightDown.Visible = false;
            this.btn_HeightDown.Click += new System.EventHandler(this.btn_HeightDown_Click);
            // 
            // btn_WidthDown
            // 
            this.btn_WidthDown.BackColor = System.Drawing.Color.Black;
            this.btn_WidthDown.ForeColor = System.Drawing.Color.Yellow;
            this.btn_WidthDown.Location = new System.Drawing.Point(45, 496);
            this.btn_WidthDown.Name = "btn_WidthDown";
            this.btn_WidthDown.Size = new System.Drawing.Size(29, 23);
            this.btn_WidthDown.TabIndex = 17;
            this.btn_WidthDown.Text = "<-";
            this.btn_WidthDown.UseVisualStyleBackColor = false;
            this.btn_WidthDown.Visible = false;
            this.btn_WidthDown.Click += new System.EventHandler(this.btn_WidthDown_Click);
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.ForeColor = System.Drawing.Color.Yellow;
            this.lblWidth.Location = new System.Drawing.Point(103, 501);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(35, 13);
            this.lblWidth.TabIndex = 18;
            this.lblWidth.Text = "Width";
            this.lblWidth.Visible = false;
            // 
            // btn_WidthUp
            // 
            this.btn_WidthUp.BackColor = System.Drawing.Color.Black;
            this.btn_WidthUp.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_WidthUp.ForeColor = System.Drawing.Color.Yellow;
            this.btn_WidthUp.Location = new System.Drawing.Point(174, 496);
            this.btn_WidthUp.Name = "btn_WidthUp";
            this.btn_WidthUp.Size = new System.Drawing.Size(29, 23);
            this.btn_WidthUp.TabIndex = 20;
            this.btn_WidthUp.Text = "->";
            this.btn_WidthUp.UseVisualStyleBackColor = false;
            this.btn_WidthUp.Visible = false;
            this.btn_WidthUp.Click += new System.EventHandler(this.btn_WidthUp_Click);
            // 
            // btn_HeightUp
            // 
            this.btn_HeightUp.BackColor = System.Drawing.Color.Black;
            this.btn_HeightUp.ForeColor = System.Drawing.Color.Yellow;
            this.btn_HeightUp.Location = new System.Drawing.Point(174, 522);
            this.btn_HeightUp.Name = "btn_HeightUp";
            this.btn_HeightUp.Size = new System.Drawing.Size(29, 23);
            this.btn_HeightUp.TabIndex = 19;
            this.btn_HeightUp.Text = "->";
            this.btn_HeightUp.UseVisualStyleBackColor = false;
            this.btn_HeightUp.Visible = false;
            this.btn_HeightUp.Click += new System.EventHandler(this.btn_HeightUp_Click);
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.ForeColor = System.Drawing.Color.Yellow;
            this.lblHeight.Location = new System.Drawing.Point(103, 527);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(38, 13);
            this.lblHeight.TabIndex = 21;
            this.lblHeight.Text = "Height";
            this.lblHeight.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(30, 561);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Current Profile:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(94, 582);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 23;
            // 
            // cbxProfile
            // 
            this.cbxProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProfile.FormattingEnabled = true;
            this.cbxProfile.Location = new System.Drawing.Point(12, 579);
            this.cbxProfile.Name = "cbxProfile";
            this.cbxProfile.Size = new System.Drawing.Size(143, 21);
            this.cbxProfile.TabIndex = 25;
            this.cbxProfile.SelectedIndexChanged += new System.EventHandler(this.cbxProfile_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(161, 577);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "New Profile";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnItems
            // 
            this.btnItems.BackColor = System.Drawing.Color.Black;
            this.btnItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItems.ForeColor = System.Drawing.Color.Yellow;
            this.btnItems.Location = new System.Drawing.Point(174, 12);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(77, 40);
            this.btnItems.TabIndex = 28;
            this.btnItems.Text = "Items ->";
            this.btnItems.UseVisualStyleBackColor = false;
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "border";
            this.label3.Visible = false;
            // 
            // lstGrail
            // 
            this.lstGrail.FormattingEnabled = true;
            this.lstGrail.Location = new System.Drawing.Point(281, 163);
            this.lstGrail.Name = "lstGrail";
            this.lstGrail.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstGrail.Size = new System.Drawing.Size(288, 420);
            this.lstGrail.TabIndex = 30;
            // 
            // txtGrailSearch
            // 
            this.txtGrailSearch.Location = new System.Drawing.Point(343, 62);
            this.txtGrailSearch.Name = "txtGrailSearch";
            this.txtGrailSearch.Size = new System.Drawing.Size(167, 20);
            this.txtGrailSearch.TabIndex = 32;
            this.txtGrailSearch.TextChanged += new System.EventHandler(this.txtGrailSearch_TextChanged);
            // 
            // chkFound
            // 
            this.chkFound.AutoSize = true;
            this.chkFound.ForeColor = System.Drawing.Color.Yellow;
            this.chkFound.Location = new System.Drawing.Point(281, 127);
            this.chkFound.Name = "chkFound";
            this.chkFound.Size = new System.Drawing.Size(56, 17);
            this.chkFound.TabIndex = 33;
            this.chkFound.Text = "Found";
            this.chkFound.UseVisualStyleBackColor = true;
            this.chkFound.CheckedChanged += new System.EventHandler(this.chkFound_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(405, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Search:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // chkNotFound
            // 
            this.chkNotFound.AutoSize = true;
            this.chkNotFound.ForeColor = System.Drawing.Color.Yellow;
            this.chkNotFound.Location = new System.Drawing.Point(380, 127);
            this.chkNotFound.Name = "chkNotFound";
            this.chkNotFound.Size = new System.Drawing.Size(76, 17);
            this.chkNotFound.TabIndex = 35;
            this.chkNotFound.Text = "Not Found";
            this.chkNotFound.UseVisualStyleBackColor = true;
            this.chkNotFound.CheckedChanged += new System.EventHandler(this.chkNotFound_CheckedChanged);
            // 
            // cbxItemCatagory
            // 
            this.cbxItemCatagory.FormattingEnabled = true;
            this.cbxItemCatagory.Location = new System.Drawing.Point(490, 125);
            this.cbxItemCatagory.Name = "cbxItemCatagory";
            this.cbxItemCatagory.Size = new System.Drawing.Size(79, 21);
            this.cbxItemCatagory.TabIndex = 36;
            this.cbxItemCatagory.Text = "Catagory";
            this.cbxItemCatagory.SelectedIndexChanged += new System.EventHandler(this.cbxItemCatagory_SelectedIndexChanged);
            // 
            // btnGrailOnly
            // 
            this.btnGrailOnly.BackColor = System.Drawing.Color.Black;
            this.btnGrailOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrailOnly.ForeColor = System.Drawing.Color.Yellow;
            this.btnGrailOnly.Location = new System.Drawing.Point(93, 12);
            this.btnGrailOnly.Name = "btnGrailOnly";
            this.btnGrailOnly.Size = new System.Drawing.Size(75, 40);
            this.btnGrailOnly.TabIndex = 37;
            this.btnGrailOnly.Text = "Add to Grail";
            this.btnGrailOnly.UseVisualStyleBackColor = false;
            this.btnGrailOnly.Click += new System.EventHandler(this.btnGrailOnly_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Yellow;
            this.button2.Location = new System.Drawing.Point(161, 606);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 23);
            this.button2.TabIndex = 38;
            this.button2.Text = "Delete Profile";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(592, 631);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnGrailOnly);
            this.Controls.Add(this.cbxItemCatagory);
            this.Controls.Add(this.chkNotFound);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkFound);
            this.Controls.Add(this.txtGrailSearch);
            this.Controls.Add(this.lstGrail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnItems);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbxProfile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.btn_WidthUp);
            this.Controls.Add(this.btn_HeightUp);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.btn_WidthDown);
            this.Controls.Add(this.btn_HeightDown);
            this.Controls.Add(this.chk_MoveOverlay);
            this.Controls.Add(this.chk_Overlay);
            this.Controls.Add(this.lbl_RunNumber);
            this.Controls.Add(this.lblRunNumberText);
            this.Controls.Add(this.btn_Export);
            this.Controls.Add(this.btn_Import);
            this.Controls.Add(this.lst_ItemFound);
            this.Controls.Add(this.lst_RunNumber);
            this.Controls.Add(this.lbl_BestTime);
            this.Controls.Add(this.lbl_BestTimeText);
            this.Controls.Add(this.lbl_RunTime);
            this.Controls.Add(this.lbl_RunTimeText);
            this.Controls.Add(this.btn_Found_Item);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btn_NewRun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Jakm D2 Run Counter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_NewRun;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Button btn_Found_Item;
        private System.Windows.Forms.Label lbl_RunTimeText;
        private System.Windows.Forms.Label lbl_RunTime;
        private System.Windows.Forms.Label lbl_BestTimeText;
        private System.Windows.Forms.Label lbl_BestTime;
        private System.Windows.Forms.ListBox lst_RunNumber;
        private System.Windows.Forms.ListBox lst_ItemFound;
        private System.Windows.Forms.Timer Stopwatch;
        private System.Windows.Forms.Button btn_Import;
        private System.Windows.Forms.Button btn_Export;
        private System.Windows.Forms.Label lblRunNumberText;
        private System.Windows.Forms.Label lbl_RunNumber;
        private System.Windows.Forms.CheckBox chk_Overlay;
        private System.Windows.Forms.CheckBox chk_MoveOverlay;
        private System.Windows.Forms.Button btn_HeightDown;
        private System.Windows.Forms.Button btn_WidthDown;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Button btn_WidthUp;
        private System.Windows.Forms.Button btn_HeightUp;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxProfile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnItems;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstGrail;
        private System.Windows.Forms.TextBox txtGrailSearch;
        private System.Windows.Forms.CheckBox chkFound;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkNotFound;
        private System.Windows.Forms.ComboBox cbxItemCatagory;
        private System.Windows.Forms.Button btnGrailOnly;
        private System.Windows.Forms.Button button2;
    }
}

