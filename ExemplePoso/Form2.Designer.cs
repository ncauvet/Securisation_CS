namespace ExemplePoso
{
    partial class FormEPPWS
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEPPWS));
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.unitComboBox = new System.Windows.Forms.ComboBox();
            this.freqComboBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.exportButton = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.enPaButton = new System.Windows.Forms.RadioButton();
            this.activeDosecomboBox = new System.Windows.Forms.ComboBox();
            this.enDoseButton = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IAM = new System.Windows.Forms.DataGridViewImageColumn();
            this.CI = new System.Windows.Forms.DataGridViewImageColumn();
            this.PE = new System.Windows.Forms.DataGridViewImageColumn();
            this.Subs = new System.Windows.Forms.DataGridViewImageColumn();
            this.POSO = new System.Windows.Forms.DataGridViewImageColumn();
            this.PCI = new System.Windows.Forms.DataGridViewImageColumn();
            this.RED = new System.Windows.Forms.DataGridViewImageColumn();
            this.SURV = new System.Windows.Forms.DataGridViewImageColumn();
            this.MEG = new System.Windows.Forms.DataGridViewImageColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.dureeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.dureeComboBox = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.flashTreeView = new System.Windows.Forms.TreeView();
            this.productButton = new System.Windows.Forms.RadioButton();
            this.vmpButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.prescRadioButton = new System.Windows.Forms.RadioButton();
            this.ucdRadioButton = new System.Windows.Forms.RadioButton();
            this.packRadioButton = new System.Windows.Forms.RadioButton();
            this.smrButton = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn6 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn7 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn8 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn9 = new System.Windows.Forms.DataGridViewImageColumn();
            this.prescriptionPictureBox = new System.Windows.Forms.PictureBox();
            this.genericPictureBox = new System.Windows.Forms.PictureBox();
            this.vigilanePictureBox = new System.Windows.Forms.PictureBox();
            this.dopantPictureBox = new System.Windows.Forms.PictureBox();
            this.withOutPictureBox = new System.Windows.Forms.PictureBox();
            this.indicListBox = new System.Windows.Forms.ListBox();
            this.patientControl2 = new ExemplePoso.PatientControl(helper);
            this.listBoxCI = new System.Windows.Forms.ListBox();
            this.listBoxPE = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.recosbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dureeNumericUpDown)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genericPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vigilanePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dopantPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.withOutPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(260, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.DisplayMember = "name";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 68);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(305, 95);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(242, 20);
            this.textBox1.TabIndex = 2;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(6, 19);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(306, 186);
            this.treeView1.TabIndex = 3;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(11, 300);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(120, 26);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            this.linkLabel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.linkLabel1_MouseClick);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 1;
            this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown1.Location = new System.Drawing.Point(314, 19);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(87, 20);
            this.numericUpDown1.TabIndex = 5;
            // 
            // unitComboBox
            // 
            this.unitComboBox.DisplayMember = "name";
            this.unitComboBox.FormattingEnabled = true;
            this.unitComboBox.Location = new System.Drawing.Point(27, 13);
            this.unitComboBox.Name = "unitComboBox";
            this.unitComboBox.Size = new System.Drawing.Size(161, 21);
            this.unitComboBox.TabIndex = 6;
            // 
            // freqComboBox
            // 
            this.freqComboBox.FormattingEnabled = true;
            this.freqComboBox.Location = new System.Drawing.Point(608, 19);
            this.freqComboBox.Name = "freqComboBox";
            this.freqComboBox.Size = new System.Drawing.Size(273, 21);
            this.freqComboBox.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(432, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(335, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Add Prescription Line";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 173);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(305, 23);
            this.button3.TabIndex = 28;
            this.button3.Text = "Choose";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.recosbutton);
            this.groupBox2.Controls.Add(this.exportButton);
            this.groupBox2.Controls.Add(this.listBox2);
            this.groupBox2.Controls.Add(this.groupBox7);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dureeNumericUpDown);
            this.groupBox2.Controls.Add(this.dureeComboBox);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.freqComboBox);
            this.groupBox2.Controls.Add(this.treeView1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Location = new System.Drawing.Point(12, 327);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1208, 485);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Prescription en Doses";
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(1089, 125);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(105, 23);
            this.exportButton.TabIndex = 33;
            this.exportButton.Text = "Exporter JSON";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(1082, 52);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 56);
            this.listBox2.TabIndex = 32;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.enPaButton);
            this.groupBox7.Controls.Add(this.activeDosecomboBox);
            this.groupBox7.Controls.Add(this.enDoseButton);
            this.groupBox7.Controls.Add(this.unitComboBox);
            this.groupBox7.Location = new System.Drawing.Point(408, 7);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(194, 68);
            this.groupBox7.TabIndex = 31;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Unité";
            // 
            // enPaButton
            // 
            this.enPaButton.AutoSize = true;
            this.enPaButton.Location = new System.Drawing.Point(6, 43);
            this.enPaButton.Name = "enPaButton";
            this.enPaButton.Size = new System.Drawing.Size(14, 13);
            this.enPaButton.TabIndex = 9;
            this.enPaButton.UseVisualStyleBackColor = true;
            // 
            // activeDosecomboBox
            // 
            this.activeDosecomboBox.DisplayMember = "name";
            this.activeDosecomboBox.FormattingEnabled = true;
            this.activeDosecomboBox.Location = new System.Drawing.Point(27, 40);
            this.activeDosecomboBox.Name = "activeDosecomboBox";
            this.activeDosecomboBox.Size = new System.Drawing.Size(161, 21);
            this.activeDosecomboBox.TabIndex = 8;
            // 
            // enDoseButton
            // 
            this.enDoseButton.AutoSize = true;
            this.enDoseButton.Checked = true;
            this.enDoseButton.Location = new System.Drawing.Point(6, 16);
            this.enDoseButton.Name = "enDoseButton";
            this.enDoseButton.Size = new System.Drawing.Size(14, 13);
            this.enDoseButton.TabIndex = 7;
            this.enDoseButton.TabStop = true;
            this.enDoseButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Prix,
            this.IAM,
            this.CI,
            this.PE,
            this.Subs,
            this.POSO,
            this.PCI,
            this.RED,
            this.SURV,
            this.MEG,
            this.Name});
            this.dataGridView1.Location = new System.Drawing.Point(314, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(762, 363);
            this.dataGridView1.TabIndex = 9;
            // 
            // Prix
            // 
            this.Prix.HeaderText = "Prix";
            this.Prix.Name = "Prix";
            this.Prix.Width = 50;
            // 
            // IAM
            // 
            this.IAM.HeaderText = "IAM";
            this.IAM.Image = ((System.Drawing.Image)(resources.GetObject("IAM.Image")));
            this.IAM.Name = "IAM";
            this.IAM.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IAM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IAM.Width = 40;
            // 
            // CI
            // 
            this.CI.HeaderText = "CI";
            this.CI.Image = ((System.Drawing.Image)(resources.GetObject("CI.Image")));
            this.CI.Name = "CI";
            this.CI.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CI.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CI.Width = 40;
            // 
            // PE
            // 
            this.PE.HeaderText = "Pe";
            this.PE.Image = ((System.Drawing.Image)(resources.GetObject("PE.Image")));
            this.PE.Name = "PE";
            this.PE.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.PE.Width = 40;
            // 
            // Subs
            // 
            this.Subs.HeaderText = "Subs";
            this.Subs.Image = ((System.Drawing.Image)(resources.GetObject("Subs.Image")));
            this.Subs.Name = "Subs";
            this.Subs.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Subs.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Subs.Width = 40;
            // 
            // POSO
            // 
            this.POSO.HeaderText = "POSO";
            this.POSO.Image = ((System.Drawing.Image)(resources.GetObject("POSO.Image")));
            this.POSO.Name = "POSO";
            this.POSO.Width = 40;
            // 
            // PCI
            // 
            this.PCI.HeaderText = "PCI";
            this.PCI.Image = ((System.Drawing.Image)(resources.GetObject("PCI.Image")));
            this.PCI.Name = "PCI";
            this.PCI.Width = 40;
            // 
            // RED
            // 
            this.RED.HeaderText = "RED";
            this.RED.Image = ((System.Drawing.Image)(resources.GetObject("RED.Image")));
            this.RED.Name = "RED";
            this.RED.Width = 40;
            // 
            // SURV
            // 
            this.SURV.HeaderText = "SURV";
            this.SURV.Image = ((System.Drawing.Image)(resources.GetObject("SURV.Image")));
            this.SURV.Name = "SURV";
            this.SURV.Width = 40;
            // 
            // MEG
            // 
            this.MEG.HeaderText = "MEG";
            this.MEG.Image = ((System.Drawing.Image)(resources.GetObject("MEG.Image")));
            this.MEG.Name = "MEG";
            this.MEG.Width = 40;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.Width = 300;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(897, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Pendant :";
            // 
            // dureeNumericUpDown
            // 
            this.dureeNumericUpDown.Location = new System.Drawing.Point(956, 20);
            this.dureeNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.dureeNumericUpDown.Name = "dureeNumericUpDown";
            this.dureeNumericUpDown.Size = new System.Drawing.Size(83, 20);
            this.dureeNumericUpDown.TabIndex = 3;
            // 
            // dureeComboBox
            // 
            this.dureeComboBox.FormattingEnabled = true;
            this.dureeComboBox.Location = new System.Drawing.Point(1067, 20);
            this.dureeComboBox.Name = "dureeComboBox";
            this.dureeComboBox.Size = new System.Drawing.Size(135, 21);
            this.dureeComboBox.TabIndex = 2;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(10, 211);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(148, 56);
            this.button6.TabIndex = 30;
            this.button6.Text = "Analyse";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(790, 83);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // flashTreeView
            // 
            this.flashTreeView.Location = new System.Drawing.Point(13, 596);
            this.flashTreeView.Name = "flashTreeView";
            this.flashTreeView.Size = new System.Drawing.Size(305, 206);
            this.flashTreeView.TabIndex = 31;
            // 
            // productButton
            // 
            this.productButton.AutoSize = true;
            this.productButton.Checked = true;
            this.productButton.Location = new System.Drawing.Point(7, 13);
            this.productButton.Name = "productButton";
            this.productButton.Size = new System.Drawing.Size(61, 17);
            this.productButton.TabIndex = 32;
            this.productButton.TabStop = true;
            this.productButton.Text = "product";
            this.productButton.UseVisualStyleBackColor = true;
            // 
            // vmpButton2
            // 
            this.vmpButton2.AutoSize = true;
            this.vmpButton2.Location = new System.Drawing.Point(74, 13);
            this.vmpButton2.Name = "vmpButton2";
            this.vmpButton2.Size = new System.Drawing.Size(45, 17);
            this.vmpButton2.TabIndex = 33;
            this.vmpButton2.Text = "vmp";
            this.vmpButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.prescRadioButton);
            this.groupBox6.Controls.Add(this.ucdRadioButton);
            this.groupBox6.Controls.Add(this.packRadioButton);
            this.groupBox6.Controls.Add(this.vmpButton2);
            this.groupBox6.Controls.Add(this.productButton);
            this.groupBox6.Location = new System.Drawing.Point(13, 26);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(302, 36);
            this.groupBox6.TabIndex = 34;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Drug type";
            // 
            // prescRadioButton
            // 
            this.prescRadioButton.AutoSize = true;
            this.prescRadioButton.Location = new System.Drawing.Point(213, 13);
            this.prescRadioButton.Name = "prescRadioButton";
            this.prescRadioButton.Size = new System.Drawing.Size(82, 17);
            this.prescRadioButton.TabIndex = 36;
            this.prescRadioButton.Text = "prescribable";
            this.prescRadioButton.UseVisualStyleBackColor = true;
            // 
            // ucdRadioButton
            // 
            this.ucdRadioButton.AutoSize = true;
            this.ucdRadioButton.Location = new System.Drawing.Point(169, 13);
            this.ucdRadioButton.Name = "ucdRadioButton";
            this.ucdRadioButton.Size = new System.Drawing.Size(43, 17);
            this.ucdRadioButton.TabIndex = 35;
            this.ucdRadioButton.Text = "ucd";
            this.ucdRadioButton.UseVisualStyleBackColor = true;
            // 
            // packRadioButton
            // 
            this.packRadioButton.AutoSize = true;
            this.packRadioButton.Location = new System.Drawing.Point(122, 13);
            this.packRadioButton.Name = "packRadioButton";
            this.packRadioButton.Size = new System.Drawing.Size(49, 17);
            this.packRadioButton.TabIndex = 34;
            this.packRadioButton.Text = "pack";
            this.packRadioButton.UseVisualStyleBackColor = true;
            // 
            // smrButton
            // 
            this.smrButton.Location = new System.Drawing.Point(13, 202);
            this.smrButton.Name = "smrButton";
            this.smrButton.Size = new System.Drawing.Size(75, 23);
            this.smrButton.TabIndex = 55;
            this.smrButton.Text = "smr/asmr";
            this.smrButton.UseVisualStyleBackColor = true;
            this.smrButton.Click += new System.EventHandler(this.smrButton_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "IAM";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 40;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "CI";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn2.Width = 40;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "Pe";
            this.dataGridViewImageColumn3.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn3.Image")));
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn3.Width = 40;
            // 
            // dataGridViewImageColumn4
            // 
            this.dataGridViewImageColumn4.HeaderText = "Subs";
            this.dataGridViewImageColumn4.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn4.Image")));
            this.dataGridViewImageColumn4.Name = "dataGridViewImageColumn4";
            this.dataGridViewImageColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn4.Width = 40;
            // 
            // dataGridViewImageColumn5
            // 
            this.dataGridViewImageColumn5.HeaderText = "POSO";
            this.dataGridViewImageColumn5.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn5.Image")));
            this.dataGridViewImageColumn5.Name = "dataGridViewImageColumn5";
            this.dataGridViewImageColumn5.Width = 40;
            // 
            // dataGridViewImageColumn6
            // 
            this.dataGridViewImageColumn6.HeaderText = "PCI";
            this.dataGridViewImageColumn6.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn6.Image")));
            this.dataGridViewImageColumn6.Name = "dataGridViewImageColumn6";
            this.dataGridViewImageColumn6.Width = 40;
            // 
            // dataGridViewImageColumn7
            // 
            this.dataGridViewImageColumn7.HeaderText = "RED";
            this.dataGridViewImageColumn7.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn7.Image")));
            this.dataGridViewImageColumn7.Name = "dataGridViewImageColumn7";
            this.dataGridViewImageColumn7.Width = 40;
            // 
            // dataGridViewImageColumn8
            // 
            this.dataGridViewImageColumn8.HeaderText = "SURV";
            this.dataGridViewImageColumn8.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn8.Image")));
            this.dataGridViewImageColumn8.Name = "dataGridViewImageColumn8";
            this.dataGridViewImageColumn8.Width = 40;
            // 
            // dataGridViewImageColumn9
            // 
            this.dataGridViewImageColumn9.HeaderText = "MEG";
            this.dataGridViewImageColumn9.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn9.Image")));
            this.dataGridViewImageColumn9.Name = "dataGridViewImageColumn9";
            this.dataGridViewImageColumn9.Width = 40;
            // 
            // prescriptionPictureBox
            // 
            this.prescriptionPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("prescriptionPictureBox.Image")));
            this.prescriptionPictureBox.Location = new System.Drawing.Point(97, 198);
            this.prescriptionPictureBox.Name = "prescriptionPictureBox";
            this.prescriptionPictureBox.Size = new System.Drawing.Size(29, 28);
            this.prescriptionPictureBox.TabIndex = 63;
            this.prescriptionPictureBox.TabStop = false;
            // 
            // genericPictureBox
            // 
            this.genericPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("genericPictureBox.Image")));
            this.genericPictureBox.Location = new System.Drawing.Point(132, 199);
            this.genericPictureBox.Name = "genericPictureBox";
            this.genericPictureBox.Size = new System.Drawing.Size(27, 28);
            this.genericPictureBox.TabIndex = 62;
            this.genericPictureBox.TabStop = false;
            // 
            // vigilanePictureBox
            // 
            this.vigilanePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("vigilanePictureBox.Image")));
            this.vigilanePictureBox.Location = new System.Drawing.Point(198, 198);
            this.vigilanePictureBox.Name = "vigilanePictureBox";
            this.vigilanePictureBox.Size = new System.Drawing.Size(23, 28);
            this.vigilanePictureBox.TabIndex = 59;
            this.vigilanePictureBox.TabStop = false;
            // 
            // dopantPictureBox
            // 
            this.dopantPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("dopantPictureBox.Image")));
            this.dopantPictureBox.Location = new System.Drawing.Point(165, 198);
            this.dopantPictureBox.Name = "dopantPictureBox";
            this.dopantPictureBox.Size = new System.Drawing.Size(27, 28);
            this.dopantPictureBox.TabIndex = 56;
            this.dopantPictureBox.TabStop = false;
            // 
            // withOutPictureBox
            // 
            this.withOutPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("withOutPictureBox.Image")));
            this.withOutPictureBox.Location = new System.Drawing.Point(226, 196);
            this.withOutPictureBox.Name = "withOutPictureBox";
            this.withOutPictureBox.Size = new System.Drawing.Size(28, 32);
            this.withOutPictureBox.TabIndex = 64;
            this.withOutPictureBox.TabStop = false;
            // 
            // indicListBox
            // 
            this.indicListBox.FormattingEnabled = true;
            this.indicListBox.Location = new System.Drawing.Point(13, 255);
            this.indicListBox.Name = "indicListBox";
            this.indicListBox.Size = new System.Drawing.Size(311, 43);
            this.indicListBox.TabIndex = 65;
            // 
            // patientControl2
            // 
            this.patientControl2.Location = new System.Drawing.Point(331, 5);
            this.patientControl2.Name = "patientControl2";
            this.patientControl2.Size = new System.Drawing.Size(901, 250);
            this.patientControl2.TabIndex = 66;
            // 
            // listBoxCI
            // 
            this.listBoxCI.FormattingEnabled = true;
            this.listBoxCI.Location = new System.Drawing.Point(342, 231);
            this.listBoxCI.Name = "listBoxCI";
            this.listBoxCI.Size = new System.Drawing.Size(331, 69);
            this.listBoxCI.TabIndex = 67;
            // 
            // listBoxPE
            // 
            this.listBoxPE.FormattingEnabled = true;
            this.listBoxPE.Location = new System.Drawing.Point(696, 231);
            this.listBoxPE.Name = "listBoxPE";
            this.listBoxPE.Size = new System.Drawing.Size(331, 69);
            this.listBoxPE.TabIndex = 68;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(258, 202);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(57, 23);
            this.button4.TabIndex = 69;
            this.button4.Text = "Détail";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // recosbutton
            // 
            this.recosbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recosbutton.Location = new System.Drawing.Point(160, 211);
            this.recosbutton.Name = "recosbutton";
            this.recosbutton.Size = new System.Drawing.Size(148, 56);
            this.recosbutton.TabIndex = 34;
            this.recosbutton.Text = "Recos";
            this.recosbutton.UseVisualStyleBackColor = true;
            this.recosbutton.Click += new System.EventHandler(this.recosbutton_Click);
            // 
            // FormEPPWS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1430, 826);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.listBoxPE);
            this.Controls.Add(this.listBoxCI);
            this.Controls.Add(this.patientControl2);
            this.Controls.Add(this.indicListBox);
            this.Controls.Add(this.withOutPictureBox);
            this.Controls.Add(this.prescriptionPictureBox);
            this.Controls.Add(this.genericPictureBox);
            this.Controls.Add(this.vigilanePictureBox);
            this.Controls.Add(this.dopantPictureBox);
            this.Controls.Add(this.smrButton);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.flashTreeView);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
           // this.Name = "FormEPPWS";
            this.Text = "DrugPrescriptionAnalysis v1.0";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dureeNumericUpDown)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genericPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vigilanePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dopantPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.withOutPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox unitComboBox;
        private System.Windows.Forms.ComboBox freqComboBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TreeView flashTreeView;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown dureeNumericUpDown;
        private System.Windows.Forms.ComboBox dureeComboBox;
        private System.Windows.Forms.RadioButton productButton;
        private System.Windows.Forms.RadioButton vmpButton2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton enPaButton;
        private System.Windows.Forms.ComboBox activeDosecomboBox;
        private System.Windows.Forms.RadioButton enDoseButton;
        private System.Windows.Forms.Button smrButton;
        private System.Windows.Forms.RadioButton ucdRadioButton;
        private System.Windows.Forms.RadioButton packRadioButton;
        private System.Windows.Forms.RadioButton prescRadioButton;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix;
        private System.Windows.Forms.DataGridViewImageColumn IAM;
        private System.Windows.Forms.DataGridViewImageColumn CI;
        private System.Windows.Forms.DataGridViewImageColumn PE;
        private System.Windows.Forms.DataGridViewImageColumn Subs;
        private System.Windows.Forms.DataGridViewImageColumn POSO;
        private System.Windows.Forms.DataGridViewImageColumn PCI;
        private System.Windows.Forms.DataGridViewImageColumn RED;
        private System.Windows.Forms.DataGridViewImageColumn SURV;
        private System.Windows.Forms.DataGridViewImageColumn MEG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn4;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn5;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn6;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn7;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn8;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn9;
        private System.Windows.Forms.PictureBox dopantPictureBox;
        private System.Windows.Forms.PictureBox vigilanePictureBox;
        private System.Windows.Forms.PictureBox genericPictureBox;
        private System.Windows.Forms.PictureBox prescriptionPictureBox;
        private System.Windows.Forms.PictureBox withOutPictureBox;
        
        private System.Windows.Forms.ListBox indicListBox;
        private PatientControl patientControl2;
        private System.Windows.Forms.ListBox listBoxCI;
        private System.Windows.Forms.ListBox listBoxPE;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button recosbutton;
    }
}

