namespace student_registreation_form
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.regist_btn = new System.Windows.Forms.Button();
            this.AdditionalNotes_groupBox4 = new System.Windows.Forms.GroupBox();
            this.additionalnote_richTextBox = new System.Windows.Forms.RichTextBox();
            this.PaymentDetails_groupbox = new System.Windows.Forms.GroupBox();
            this.BankTransfer_radiobtn = new System.Windows.Forms.RadioButton();
            this.cash_radiobtn = new System.Windows.Forms.RadioButton();
            this.Card_radiobtn = new System.Windows.Forms.RadioButton();
            this.PaymentMethod_lbl = new System.Windows.Forms.Label();
            this.CourseDetails_groupbox = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.selectedcourse_lbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PersonalDetails_groupbox = new System.Windows.Forms.GroupBox();
            this.browse_btn = new System.Windows.Forms.Button();
            this.studentphoto = new System.Windows.Forms.PictureBox();
            this.gender_combobox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.address_txt = new System.Windows.Forms.TextBox();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.gender_lbl = new System.Windows.Forms.Label();
            this.dateofbirth_lbl = new System.Windows.Forms.Label();
            this.address_lbl = new System.Windows.Forms.Label();
            this.name_lbl = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.AdditionalNotes_groupBox4.SuspendLayout();
            this.PaymentDetails_groupbox.SuspendLayout();
            this.CourseDetails_groupbox.SuspendLayout();
            this.PersonalDetails_groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentphoto)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.errorProvider1.SetError(this.splitContainer1, resources.GetString("splitContainer1.Error"));
            this.errorProvider1.SetIconAlignment(this.splitContainer1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("splitContainer1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.splitContainer1, ((int)(resources.GetObject("splitContainer1.IconPadding"))));
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            resources.ApplyResources(this.splitContainer1.Panel1, "splitContainer1.Panel1");
            this.splitContainer1.Panel1.Controls.Add(this.Cancel_btn);
            this.splitContainer1.Panel1.Controls.Add(this.clear_btn);
            this.splitContainer1.Panel1.Controls.Add(this.regist_btn);
            this.splitContainer1.Panel1.Controls.Add(this.AdditionalNotes_groupBox4);
            this.splitContainer1.Panel1.Controls.Add(this.PaymentDetails_groupbox);
            this.splitContainer1.Panel1.Controls.Add(this.CourseDetails_groupbox);
            this.splitContainer1.Panel1.Controls.Add(this.PersonalDetails_groupbox);
            this.errorProvider1.SetError(this.splitContainer1.Panel1, resources.GetString("splitContainer1.Panel1.Error"));
            this.errorProvider1.SetIconAlignment(this.splitContainer1.Panel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("splitContainer1.Panel1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.splitContainer1.Panel1, ((int)(resources.GetObject("splitContainer1.Panel1.IconPadding"))));
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            resources.ApplyResources(this.splitContainer1.Panel2, "splitContainer1.Panel2");
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.errorProvider1.SetError(this.splitContainer1.Panel2, resources.GetString("splitContainer1.Panel2.Error"));
            this.errorProvider1.SetIconAlignment(this.splitContainer1.Panel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("splitContainer1.Panel2.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.splitContainer1.Panel2, ((int)(resources.GetObject("splitContainer1.Panel2.IconPadding"))));
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            // 
            // Cancel_btn
            // 
            resources.ApplyResources(this.Cancel_btn, "Cancel_btn");
            this.errorProvider1.SetError(this.Cancel_btn, resources.GetString("Cancel_btn.Error"));
            this.errorProvider1.SetIconAlignment(this.Cancel_btn, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Cancel_btn.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.Cancel_btn, ((int)(resources.GetObject("Cancel_btn.IconPadding"))));
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            this.Cancel_btn.Click += new System.EventHandler(this.button4_Click);
            // 
            // clear_btn
            // 
            resources.ApplyResources(this.clear_btn, "clear_btn");
            this.errorProvider1.SetError(this.clear_btn, resources.GetString("clear_btn.Error"));
            this.errorProvider1.SetIconAlignment(this.clear_btn, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("clear_btn.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.clear_btn, ((int)(resources.GetObject("clear_btn.IconPadding"))));
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // regist_btn
            // 
            resources.ApplyResources(this.regist_btn, "regist_btn");
            this.errorProvider1.SetError(this.regist_btn, resources.GetString("regist_btn.Error"));
            this.errorProvider1.SetIconAlignment(this.regist_btn, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("regist_btn.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.regist_btn, ((int)(resources.GetObject("regist_btn.IconPadding"))));
            this.regist_btn.Name = "regist_btn";
            this.regist_btn.UseVisualStyleBackColor = true;
            this.regist_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // AdditionalNotes_groupBox4
            // 
            resources.ApplyResources(this.AdditionalNotes_groupBox4, "AdditionalNotes_groupBox4");
            this.AdditionalNotes_groupBox4.Controls.Add(this.additionalnote_richTextBox);
            this.errorProvider1.SetError(this.AdditionalNotes_groupBox4, resources.GetString("AdditionalNotes_groupBox4.Error"));
            this.errorProvider1.SetIconAlignment(this.AdditionalNotes_groupBox4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("AdditionalNotes_groupBox4.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.AdditionalNotes_groupBox4, ((int)(resources.GetObject("AdditionalNotes_groupBox4.IconPadding"))));
            this.AdditionalNotes_groupBox4.Name = "AdditionalNotes_groupBox4";
            this.AdditionalNotes_groupBox4.TabStop = false;
            // 
            // additionalnote_richTextBox
            // 
            resources.ApplyResources(this.additionalnote_richTextBox, "additionalnote_richTextBox");
            this.errorProvider1.SetError(this.additionalnote_richTextBox, resources.GetString("additionalnote_richTextBox.Error"));
            this.errorProvider1.SetIconAlignment(this.additionalnote_richTextBox, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("additionalnote_richTextBox.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.additionalnote_richTextBox, ((int)(resources.GetObject("additionalnote_richTextBox.IconPadding"))));
            this.additionalnote_richTextBox.Name = "additionalnote_richTextBox";
            // 
            // PaymentDetails_groupbox
            // 
            resources.ApplyResources(this.PaymentDetails_groupbox, "PaymentDetails_groupbox");
            this.PaymentDetails_groupbox.Controls.Add(this.BankTransfer_radiobtn);
            this.PaymentDetails_groupbox.Controls.Add(this.cash_radiobtn);
            this.PaymentDetails_groupbox.Controls.Add(this.Card_radiobtn);
            this.PaymentDetails_groupbox.Controls.Add(this.PaymentMethod_lbl);
            this.errorProvider1.SetError(this.PaymentDetails_groupbox, resources.GetString("PaymentDetails_groupbox.Error"));
            this.errorProvider1.SetIconAlignment(this.PaymentDetails_groupbox, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("PaymentDetails_groupbox.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.PaymentDetails_groupbox, ((int)(resources.GetObject("PaymentDetails_groupbox.IconPadding"))));
            this.PaymentDetails_groupbox.Name = "PaymentDetails_groupbox";
            this.PaymentDetails_groupbox.TabStop = false;
            // 
            // BankTransfer_radiobtn
            // 
            resources.ApplyResources(this.BankTransfer_radiobtn, "BankTransfer_radiobtn");
            this.errorProvider1.SetError(this.BankTransfer_radiobtn, resources.GetString("BankTransfer_radiobtn.Error"));
            this.errorProvider1.SetIconAlignment(this.BankTransfer_radiobtn, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("BankTransfer_radiobtn.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.BankTransfer_radiobtn, ((int)(resources.GetObject("BankTransfer_radiobtn.IconPadding"))));
            this.BankTransfer_radiobtn.Name = "BankTransfer_radiobtn";
            this.BankTransfer_radiobtn.TabStop = true;
            this.BankTransfer_radiobtn.UseVisualStyleBackColor = true;
            // 
            // cash_radiobtn
            // 
            resources.ApplyResources(this.cash_radiobtn, "cash_radiobtn");
            this.errorProvider1.SetError(this.cash_radiobtn, resources.GetString("cash_radiobtn.Error"));
            this.errorProvider1.SetIconAlignment(this.cash_radiobtn, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cash_radiobtn.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.cash_radiobtn, ((int)(resources.GetObject("cash_radiobtn.IconPadding"))));
            this.cash_radiobtn.Name = "cash_radiobtn";
            this.cash_radiobtn.TabStop = true;
            this.cash_radiobtn.UseVisualStyleBackColor = true;
            this.cash_radiobtn.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Card_radiobtn
            // 
            resources.ApplyResources(this.Card_radiobtn, "Card_radiobtn");
            this.errorProvider1.SetError(this.Card_radiobtn, resources.GetString("Card_radiobtn.Error"));
            this.errorProvider1.SetIconAlignment(this.Card_radiobtn, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Card_radiobtn.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.Card_radiobtn, ((int)(resources.GetObject("Card_radiobtn.IconPadding"))));
            this.Card_radiobtn.Name = "Card_radiobtn";
            this.Card_radiobtn.TabStop = true;
            this.Card_radiobtn.UseVisualStyleBackColor = true;
            // 
            // PaymentMethod_lbl
            // 
            resources.ApplyResources(this.PaymentMethod_lbl, "PaymentMethod_lbl");
            this.errorProvider1.SetError(this.PaymentMethod_lbl, resources.GetString("PaymentMethod_lbl.Error"));
            this.errorProvider1.SetIconAlignment(this.PaymentMethod_lbl, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("PaymentMethod_lbl.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.PaymentMethod_lbl, ((int)(resources.GetObject("PaymentMethod_lbl.IconPadding"))));
            this.PaymentMethod_lbl.Name = "PaymentMethod_lbl";
            // 
            // CourseDetails_groupbox
            // 
            resources.ApplyResources(this.CourseDetails_groupbox, "CourseDetails_groupbox");
            this.CourseDetails_groupbox.Controls.Add(this.checkBox1);
            this.CourseDetails_groupbox.Controls.Add(this.checkedListBox1);
            this.CourseDetails_groupbox.Controls.Add(this.comboBox2);
            this.CourseDetails_groupbox.Controls.Add(this.selectedcourse_lbl);
            this.CourseDetails_groupbox.Controls.Add(this.label4);
            this.errorProvider1.SetError(this.CourseDetails_groupbox, resources.GetString("CourseDetails_groupbox.Error"));
            this.errorProvider1.SetIconAlignment(this.CourseDetails_groupbox, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("CourseDetails_groupbox.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.CourseDetails_groupbox, ((int)(resources.GetObject("CourseDetails_groupbox.IconPadding"))));
            this.CourseDetails_groupbox.Name = "CourseDetails_groupbox";
            this.CourseDetails_groupbox.TabStop = false;
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.errorProvider1.SetError(this.checkBox1, resources.GetString("checkBox1.Error"));
            this.errorProvider1.SetIconAlignment(this.checkBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("checkBox1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.checkBox1, ((int)(resources.GetObject("checkBox1.IconPadding"))));
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkedListBox1
            // 
            resources.ApplyResources(this.checkedListBox1, "checkedListBox1");
            this.errorProvider1.SetError(this.checkedListBox1, resources.GetString("checkedListBox1.Error"));
            this.checkedListBox1.FormattingEnabled = true;
            this.errorProvider1.SetIconAlignment(this.checkedListBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("checkedListBox1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.checkedListBox1, ((int)(resources.GetObject("checkedListBox1.IconPadding"))));
            this.checkedListBox1.Items.AddRange(new object[] {
            resources.GetString("checkedListBox1.Items"),
            resources.GetString("checkedListBox1.Items1"),
            resources.GetString("checkedListBox1.Items2")});
            this.checkedListBox1.Name = "checkedListBox1";
            // 
            // comboBox2
            // 
            resources.ApplyResources(this.comboBox2, "comboBox2");
            this.errorProvider1.SetError(this.comboBox2, resources.GetString("comboBox2.Error"));
            this.comboBox2.FormattingEnabled = true;
            this.errorProvider1.SetIconAlignment(this.comboBox2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox2.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.comboBox2, ((int)(resources.GetObject("comboBox2.IconPadding"))));
            this.comboBox2.Items.AddRange(new object[] {
            resources.GetString("comboBox2.Items"),
            resources.GetString("comboBox2.Items1"),
            resources.GetString("comboBox2.Items2")});
            this.comboBox2.Name = "comboBox2";
            // 
            // selectedcourse_lbl
            // 
            resources.ApplyResources(this.selectedcourse_lbl, "selectedcourse_lbl");
            this.errorProvider1.SetError(this.selectedcourse_lbl, resources.GetString("selectedcourse_lbl.Error"));
            this.errorProvider1.SetIconAlignment(this.selectedcourse_lbl, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("selectedcourse_lbl.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.selectedcourse_lbl, ((int)(resources.GetObject("selectedcourse_lbl.IconPadding"))));
            this.selectedcourse_lbl.Name = "selectedcourse_lbl";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.errorProvider1.SetError(this.label4, resources.GetString("label4.Error"));
            this.errorProvider1.SetIconAlignment(this.label4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label4.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label4, ((int)(resources.GetObject("label4.IconPadding"))));
            this.label4.Name = "label4";
            // 
            // PersonalDetails_groupbox
            // 
            resources.ApplyResources(this.PersonalDetails_groupbox, "PersonalDetails_groupbox");
            this.PersonalDetails_groupbox.Controls.Add(this.browse_btn);
            this.PersonalDetails_groupbox.Controls.Add(this.studentphoto);
            this.PersonalDetails_groupbox.Controls.Add(this.gender_combobox);
            this.PersonalDetails_groupbox.Controls.Add(this.dateTimePicker1);
            this.PersonalDetails_groupbox.Controls.Add(this.address_txt);
            this.PersonalDetails_groupbox.Controls.Add(this.name_txt);
            this.PersonalDetails_groupbox.Controls.Add(this.gender_lbl);
            this.PersonalDetails_groupbox.Controls.Add(this.dateofbirth_lbl);
            this.PersonalDetails_groupbox.Controls.Add(this.address_lbl);
            this.PersonalDetails_groupbox.Controls.Add(this.name_lbl);
            this.errorProvider1.SetError(this.PersonalDetails_groupbox, resources.GetString("PersonalDetails_groupbox.Error"));
            this.errorProvider1.SetIconAlignment(this.PersonalDetails_groupbox, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("PersonalDetails_groupbox.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.PersonalDetails_groupbox, ((int)(resources.GetObject("PersonalDetails_groupbox.IconPadding"))));
            this.PersonalDetails_groupbox.Name = "PersonalDetails_groupbox";
            this.PersonalDetails_groupbox.TabStop = false;
            // 
            // browse_btn
            // 
            resources.ApplyResources(this.browse_btn, "browse_btn");
            this.errorProvider1.SetError(this.browse_btn, resources.GetString("browse_btn.Error"));
            this.errorProvider1.SetIconAlignment(this.browse_btn, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("browse_btn.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.browse_btn, ((int)(resources.GetObject("browse_btn.IconPadding"))));
            this.browse_btn.Name = "browse_btn";
            this.browse_btn.UseVisualStyleBackColor = true;
            // 
            // studentphoto
            // 
            resources.ApplyResources(this.studentphoto, "studentphoto");
            this.errorProvider1.SetError(this.studentphoto, resources.GetString("studentphoto.Error"));
            this.errorProvider1.SetIconAlignment(this.studentphoto, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("studentphoto.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.studentphoto, ((int)(resources.GetObject("studentphoto.IconPadding"))));
            this.studentphoto.Name = "studentphoto";
            this.studentphoto.TabStop = false;
            // 
            // gender_combobox
            // 
            resources.ApplyResources(this.gender_combobox, "gender_combobox");
            this.errorProvider1.SetError(this.gender_combobox, resources.GetString("gender_combobox.Error"));
            this.gender_combobox.FormattingEnabled = true;
            this.errorProvider1.SetIconAlignment(this.gender_combobox, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("gender_combobox.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.gender_combobox, ((int)(resources.GetObject("gender_combobox.IconPadding"))));
            this.gender_combobox.Items.AddRange(new object[] {
            resources.GetString("gender_combobox.Items"),
            resources.GetString("gender_combobox.Items1")});
            this.gender_combobox.Name = "gender_combobox";
            // 
            // dateTimePicker1
            // 
            resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
            this.errorProvider1.SetError(this.dateTimePicker1, resources.GetString("dateTimePicker1.Error"));
            this.errorProvider1.SetIconAlignment(this.dateTimePicker1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("dateTimePicker1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.dateTimePicker1, ((int)(resources.GetObject("dateTimePicker1.IconPadding"))));
            this.dateTimePicker1.Name = "dateTimePicker1";
            // 
            // address_txt
            // 
            resources.ApplyResources(this.address_txt, "address_txt");
            this.errorProvider1.SetError(this.address_txt, resources.GetString("address_txt.Error"));
            this.errorProvider1.SetIconAlignment(this.address_txt, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("address_txt.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.address_txt, ((int)(resources.GetObject("address_txt.IconPadding"))));
            this.address_txt.Name = "address_txt";
            // 
            // name_txt
            // 
            resources.ApplyResources(this.name_txt, "name_txt");
            this.errorProvider1.SetError(this.name_txt, resources.GetString("name_txt.Error"));
            this.errorProvider1.SetIconAlignment(this.name_txt, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("name_txt.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.name_txt, ((int)(resources.GetObject("name_txt.IconPadding"))));
            this.name_txt.Name = "name_txt";
            // 
            // gender_lbl
            // 
            resources.ApplyResources(this.gender_lbl, "gender_lbl");
            this.errorProvider1.SetError(this.gender_lbl, resources.GetString("gender_lbl.Error"));
            this.errorProvider1.SetIconAlignment(this.gender_lbl, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("gender_lbl.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.gender_lbl, ((int)(resources.GetObject("gender_lbl.IconPadding"))));
            this.gender_lbl.Name = "gender_lbl";
            // 
            // dateofbirth_lbl
            // 
            resources.ApplyResources(this.dateofbirth_lbl, "dateofbirth_lbl");
            this.errorProvider1.SetError(this.dateofbirth_lbl, resources.GetString("dateofbirth_lbl.Error"));
            this.errorProvider1.SetIconAlignment(this.dateofbirth_lbl, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("dateofbirth_lbl.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.dateofbirth_lbl, ((int)(resources.GetObject("dateofbirth_lbl.IconPadding"))));
            this.dateofbirth_lbl.Name = "dateofbirth_lbl";
            // 
            // address_lbl
            // 
            resources.ApplyResources(this.address_lbl, "address_lbl");
            this.errorProvider1.SetError(this.address_lbl, resources.GetString("address_lbl.Error"));
            this.errorProvider1.SetIconAlignment(this.address_lbl, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("address_lbl.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.address_lbl, ((int)(resources.GetObject("address_lbl.IconPadding"))));
            this.address_lbl.Name = "address_lbl";
            // 
            // name_lbl
            // 
            resources.ApplyResources(this.name_lbl, "name_lbl");
            this.errorProvider1.SetError(this.name_lbl, resources.GetString("name_lbl.Error"));
            this.errorProvider1.SetIconAlignment(this.name_lbl, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("name_lbl.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.name_lbl, ((int)(resources.GetObject("name_lbl.IconPadding"))));
            this.name_lbl.Name = "name_lbl";
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.errorProvider1.SetError(this.statusStrip1, resources.GetString("statusStrip1.Error"));
            this.errorProvider1.SetIconAlignment(this.statusStrip1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("statusStrip1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.statusStrip1, ((int)(resources.GetObject("statusStrip1.IconPadding"))));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Name = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            // 
            // dataGridView1
            // 
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.errorProvider1.SetError(this.dataGridView1, resources.GetString("dataGridView1.Error"));
            this.errorProvider1.SetIconAlignment(this.dataGridView1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("dataGridView1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.dataGridView1, ((int)(resources.GetObject("dataGridView1.IconPadding"))));
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 24;
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.errorProvider1.SetError(this.menuStrip1, resources.GetString("menuStrip1.Error"));
            this.errorProvider1.SetIconAlignment(this.menuStrip1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("menuStrip1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.menuStrip1, ((int)(resources.GetObject("menuStrip1.IconPadding"))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Name = "menuStrip1";
            // 
            // toolStrip1
            // 
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.errorProvider1.SetError(this.toolStrip1, resources.GetString("toolStrip1.Error"));
            this.errorProvider1.SetIconAlignment(this.toolStrip1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("toolStrip1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.toolStrip1, ((int)(resources.GetObject("toolStrip1.IconPadding"))));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Name = "toolStrip1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            resources.ApplyResources(this.errorProvider1, "errorProvider1");
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            resources.ApplyResources(this.openFileDialog1, "openFileDialog1");
            // 
            // saveFileDialog1
            // 
            resources.ApplyResources(this.saveFileDialog1, "saveFileDialog1");
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.AdditionalNotes_groupBox4.ResumeLayout(false);
            this.PaymentDetails_groupbox.ResumeLayout(false);
            this.PaymentDetails_groupbox.PerformLayout();
            this.CourseDetails_groupbox.ResumeLayout(false);
            this.CourseDetails_groupbox.PerformLayout();
            this.PersonalDetails_groupbox.ResumeLayout(false);
            this.PersonalDetails_groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentphoto)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox CourseDetails_groupbox;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox PersonalDetails_groupbox;
        private System.Windows.Forms.Button browse_btn;
        private System.Windows.Forms.PictureBox studentphoto;
        private System.Windows.Forms.ComboBox gender_combobox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox address_txt;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.Label dateofbirth_lbl;
        private System.Windows.Forms.Label address_lbl;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label PaymentMethod_lbl;
        private System.Windows.Forms.GroupBox PaymentDetails_groupbox;
        private System.Windows.Forms.RadioButton BankTransfer_radiobtn;
        private System.Windows.Forms.RadioButton cash_radiobtn;
        private System.Windows.Forms.RadioButton Card_radiobtn;
        private System.Windows.Forms.GroupBox AdditionalNotes_groupBox4;
        private System.Windows.Forms.RichTextBox additionalnote_richTextBox;
        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.Button regist_btn;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label gender_lbl;
        private System.Windows.Forms.Label selectedcourse_lbl;
        private System.Windows.Forms.Button clear_btn;
    }
}

