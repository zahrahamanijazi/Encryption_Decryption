
namespace Security_P1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CipherTextBox = new System.Windows.Forms.TextBox();
            this.LogTextBox = new System.Windows.Forms.TextBox();
            this.KeyTextBox = new System.Windows.Forms.TextBox();
            this.FinalResultTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PercentLabel = new System.Windows.Forms.Label();
            this.Countlabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.KeyTimelabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LastTimelabel = new System.Windows.Forms.Label();
            this.AverageTimelabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TotalTimelabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPause = new System.Windows.Forms.Button();
            this.KeyListBox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.FromKeyLenUpDown = new System.Windows.Forms.NumericUpDown();
            this.btnICDecrypt = new System.Windows.Forms.Button();
            this.cmbMode = new System.Windows.Forms.ComboBox();
            this.rbWithKey = new System.Windows.Forms.RadioButton();
            this.rbNoKey = new System.Windows.Forms.RadioButton();
            this.WithKeyPanel = new System.Windows.Forms.Panel();
            this.NoKeyPanel = new System.Windows.Forms.Panel();
            this.chkDictionary = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.WordLenLenUpDown = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.ToKeyLenUpDown = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.FinalTextICMaskEdit = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ICMaskEdit = new System.Windows.Forms.MaskedTextBox();
            this.ICLevellabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.FromKeyLenUpDown)).BeginInit();
            this.WithKeyPanel.SuspendLayout();
            this.NoKeyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WordLenLenUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToKeyLenUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // CipherTextBox
            // 
            this.CipherTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CipherTextBox.Location = new System.Drawing.Point(93, 5);
            this.CipherTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CipherTextBox.Multiline = true;
            this.CipherTextBox.Name = "CipherTextBox";
            this.CipherTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.CipherTextBox.Size = new System.Drawing.Size(1371, 112);
            this.CipherTextBox.TabIndex = 1;
            this.CipherTextBox.Text = resources.GetString("CipherTextBox.Text");
            // 
            // LogTextBox
            // 
            this.LogTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.LogTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LogTextBox.Location = new System.Drawing.Point(97, 5);
            this.LogTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.LogTextBox.Multiline = true;
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.ReadOnly = true;
            this.LogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.LogTextBox.Size = new System.Drawing.Size(1145, 158);
            this.LogTextBox.TabIndex = 2;
            // 
            // KeyTextBox
            // 
            this.KeyTextBox.Location = new System.Drawing.Point(59, 6);
            this.KeyTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.Size = new System.Drawing.Size(740, 22);
            this.KeyTextBox.TabIndex = 3;
            // 
            // FinalResultTextBox
            // 
            this.FinalResultTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.FinalResultTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FinalResultTextBox.Location = new System.Drawing.Point(99, 5);
            this.FinalResultTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.FinalResultTextBox.Multiline = true;
            this.FinalResultTextBox.Name = "FinalResultTextBox";
            this.FinalResultTextBox.ReadOnly = true;
            this.FinalResultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.FinalResultTextBox.Size = new System.Drawing.Size(1143, 155);
            this.FinalResultTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = " Final Result :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(5, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cipher Text :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Location = new System.Drawing.Point(5, 5);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "              Log:";
            // 
            // PercentLabel
            // 
            this.PercentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PercentLabel.Location = new System.Drawing.Point(807, 81);
            this.PercentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PercentLabel.Name = "PercentLabel";
            this.PercentLabel.Size = new System.Drawing.Size(76, 20);
            this.PercentLabel.TabIndex = 6;
            this.PercentLabel.Text = "0%";
            // 
            // Countlabel
            // 
            this.Countlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Countlabel.Location = new System.Drawing.Point(774, 52);
            this.Countlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Countlabel.Name = "Countlabel";
            this.Countlabel.Size = new System.Drawing.Size(288, 23);
            this.Countlabel.TabIndex = 7;
            this.Countlabel.Text = "0 of 0";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Key Generate Time : ";
            // 
            // KeyTimelabel
            // 
            this.KeyTimelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.KeyTimelabel.Location = new System.Drawing.Point(185, 24);
            this.KeyTimelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.KeyTimelabel.Name = "KeyTimelabel";
            this.KeyTimelabel.Size = new System.Drawing.Size(230, 17);
            this.KeyTimelabel.TabIndex = 9;
            this.KeyTimelabel.Text = "0 Second";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 60);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Last Decrypt Time :";
            // 
            // LastTimelabel
            // 
            this.LastTimelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LastTimelabel.Location = new System.Drawing.Point(185, 60);
            this.LastTimelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LastTimelabel.Name = "LastTimelabel";
            this.LastTimelabel.Size = new System.Drawing.Size(230, 17);
            this.LastTimelabel.TabIndex = 11;
            this.LastTimelabel.Text = "0 Second";
            // 
            // AverageTimelabel
            // 
            this.AverageTimelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AverageTimelabel.Location = new System.Drawing.Point(182, 101);
            this.AverageTimelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AverageTimelabel.Name = "AverageTimelabel";
            this.AverageTimelabel.Size = new System.Drawing.Size(230, 17);
            this.AverageTimelabel.TabIndex = 13;
            this.AverageTimelabel.Text = "0 Second";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 101);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "Average Decrypt Time :";
            // 
            // TotalTimelabel
            // 
            this.TotalTimelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalTimelabel.Location = new System.Drawing.Point(185, 150);
            this.TotalTimelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalTimelabel.Name = "TotalTimelabel";
            this.TotalTimelabel.Size = new System.Drawing.Size(230, 17);
            this.TotalTimelabel.TabIndex = 15;
            this.TotalTimelabel.Text = "0 Second";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 150);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Total Decrypt Time :";
            // 
            // btnPause
            // 
            this.btnPause.Enabled = false;
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnPause.Location = new System.Drawing.Point(799, 118);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(102, 49);
            this.btnPause.TabIndex = 16;
            this.btnPause.Tag = "0";
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // KeyListBox
            // 
            this.KeyListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KeyListBox.FormattingEnabled = true;
            this.KeyListBox.ItemHeight = 16;
            this.KeyListBox.Location = new System.Drawing.Point(0, 17);
            this.KeyListBox.Name = "KeyListBox";
            this.KeyListBox.Size = new System.Drawing.Size(222, 316);
            this.KeyListBox.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Keys:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Key :";
            // 
            // FromKeyLenUpDown
            // 
            this.FromKeyLenUpDown.Location = new System.Drawing.Point(109, 14);
            this.FromKeyLenUpDown.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.FromKeyLenUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FromKeyLenUpDown.Name = "FromKeyLenUpDown";
            this.FromKeyLenUpDown.Size = new System.Drawing.Size(70, 22);
            this.FromKeyLenUpDown.TabIndex = 22;
            this.FromKeyLenUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FromKeyLenUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btnICDecrypt
            // 
            this.btnICDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnICDecrypt.ForeColor = System.Drawing.Color.Green;
            this.btnICDecrypt.Location = new System.Drawing.Point(605, 48);
            this.btnICDecrypt.Margin = new System.Windows.Forms.Padding(4);
            this.btnICDecrypt.Name = "btnICDecrypt";
            this.btnICDecrypt.Size = new System.Drawing.Size(161, 136);
            this.btnICDecrypt.TabIndex = 27;
            this.btnICDecrypt.Text = "Decrypt";
            this.btnICDecrypt.UseVisualStyleBackColor = true;
            this.btnICDecrypt.Click += new System.EventHandler(this.btnICDecrypt_Click);
            // 
            // cmbMode
            // 
            this.cmbMode.FormattingEnabled = true;
            this.cmbMode.Items.AddRange(new object[] {
            "AutoKey(frequency analysis)",
            "Vigenere(frequency analysis)",
            "Vigenere(brute force)"});
            this.cmbMode.Location = new System.Drawing.Point(29, 42);
            this.cmbMode.Name = "cmbMode";
            this.cmbMode.Size = new System.Drawing.Size(270, 24);
            this.cmbMode.TabIndex = 28;
            this.cmbMode.SelectedIndexChanged += new System.EventHandler(this.cmbMode_SelectedIndexChanged);
            // 
            // rbWithKey
            // 
            this.rbWithKey.AutoSize = true;
            this.rbWithKey.Location = new System.Drawing.Point(94, 14);
            this.rbWithKey.Name = "rbWithKey";
            this.rbWithKey.Size = new System.Drawing.Size(119, 21);
            this.rbWithKey.TabIndex = 29;
            this.rbWithKey.Text = "I have the Key";
            this.rbWithKey.UseVisualStyleBackColor = true;
            this.rbWithKey.CheckedChanged += new System.EventHandler(this.rbWithKey_CheckedChanged);
            // 
            // rbNoKey
            // 
            this.rbNoKey.AutoSize = true;
            this.rbNoKey.Checked = true;
            this.rbNoKey.Location = new System.Drawing.Point(85, 94);
            this.rbNoKey.Name = "rbNoKey";
            this.rbNoKey.Size = new System.Drawing.Size(128, 21);
            this.rbNoKey.TabIndex = 30;
            this.rbNoKey.TabStop = true;
            this.rbNoKey.Text = "I don\'t have key";
            this.rbNoKey.UseVisualStyleBackColor = true;
            this.rbNoKey.CheckedChanged += new System.EventHandler(this.rbNoKey_CheckedChanged);
            // 
            // WithKeyPanel
            // 
            this.WithKeyPanel.Controls.Add(this.KeyTextBox);
            this.WithKeyPanel.Controls.Add(this.label9);
            this.WithKeyPanel.Enabled = false;
            this.WithKeyPanel.Location = new System.Drawing.Point(228, 8);
            this.WithKeyPanel.Name = "WithKeyPanel";
            this.WithKeyPanel.Size = new System.Drawing.Size(803, 33);
            this.WithKeyPanel.TabIndex = 31;
            // 
            // NoKeyPanel
            // 
            this.NoKeyPanel.Controls.Add(this.chkDictionary);
            this.NoKeyPanel.Controls.Add(this.label13);
            this.NoKeyPanel.Controls.Add(this.WordLenLenUpDown);
            this.NoKeyPanel.Controls.Add(this.label12);
            this.NoKeyPanel.Controls.Add(this.ToKeyLenUpDown);
            this.NoKeyPanel.Controls.Add(this.label11);
            this.NoKeyPanel.Controls.Add(this.FinalTextICMaskEdit);
            this.NoKeyPanel.Controls.Add(this.label2);
            this.NoKeyPanel.Controls.Add(this.ICMaskEdit);
            this.NoKeyPanel.Controls.Add(this.ICLevellabel);
            this.NoKeyPanel.Controls.Add(this.FromKeyLenUpDown);
            this.NoKeyPanel.Controls.Add(this.cmbMode);
            this.NoKeyPanel.Location = new System.Drawing.Point(228, 52);
            this.NoKeyPanel.Name = "NoKeyPanel";
            this.NoKeyPanel.Size = new System.Drawing.Size(371, 132);
            this.NoKeyPanel.TabIndex = 32;
            // 
            // chkDictionary
            // 
            this.chkDictionary.AutoSize = true;
            this.chkDictionary.Checked = true;
            this.chkDictionary.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDictionary.Location = new System.Drawing.Point(227, 75);
            this.chkDictionary.Name = "chkDictionary";
            this.chkDictionary.Size = new System.Drawing.Size(136, 21);
            this.chkDictionary.TabIndex = 39;
            this.chkDictionary.Text = "Check Dictionary";
            this.chkDictionary.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 135);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(155, 17);
            this.label13.TabIndex = 38;
            this.label13.Text = "Average Word Length :";
            this.label13.Visible = false;
            // 
            // WordLenLenUpDown
            // 
            this.WordLenLenUpDown.Location = new System.Drawing.Point(170, 133);
            this.WordLenLenUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.WordLenLenUpDown.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.WordLenLenUpDown.Name = "WordLenLenUpDown";
            this.WordLenLenUpDown.Size = new System.Drawing.Size(53, 22);
            this.WordLenLenUpDown.TabIndex = 37;
            this.WordLenLenUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WordLenLenUpDown.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.WordLenLenUpDown.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(182, 16);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 17);
            this.label12.TabIndex = 36;
            this.label12.Text = "To";
            // 
            // ToKeyLenUpDown
            // 
            this.ToKeyLenUpDown.Location = new System.Drawing.Point(214, 14);
            this.ToKeyLenUpDown.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.ToKeyLenUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ToKeyLenUpDown.Name = "ToKeyLenUpDown";
            this.ToKeyLenUpDown.Size = new System.Drawing.Size(70, 22);
            this.ToKeyLenUpDown.TabIndex = 35;
            this.ToKeyLenUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ToKeyLenUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 16);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 17);
            this.label11.TabIndex = 34;
            this.label11.Text = "Key From :";
            // 
            // FinalTextICMaskEdit
            // 
            this.FinalTextICMaskEdit.Location = new System.Drawing.Point(170, 105);
            this.FinalTextICMaskEdit.Mask = "0.0000";
            this.FinalTextICMaskEdit.Name = "FinalTextICMaskEdit";
            this.FinalTextICMaskEdit.Size = new System.Drawing.Size(113, 22);
            this.FinalTextICMaskEdit.TabIndex = 33;
            this.FinalTextICMaskEdit.Text = "00600";
            this.FinalTextICMaskEdit.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Final Text IC Accuracy:";
            // 
            // ICMaskEdit
            // 
            this.ICMaskEdit.Location = new System.Drawing.Point(103, 74);
            this.ICMaskEdit.Mask = "0.0000";
            this.ICMaskEdit.Name = "ICMaskEdit";
            this.ICMaskEdit.Size = new System.Drawing.Size(113, 22);
            this.ICMaskEdit.TabIndex = 31;
            this.ICMaskEdit.Text = "00535";
            this.ICMaskEdit.ValidatingType = typeof(int);
            // 
            // ICLevellabel
            // 
            this.ICLevellabel.AutoSize = true;
            this.ICLevellabel.Location = new System.Drawing.Point(8, 76);
            this.ICLevellabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ICLevellabel.Name = "ICLevellabel";
            this.ICLevellabel.Size = new System.Drawing.Size(86, 17);
            this.ICLevellabel.TabIndex = 30;
            this.ICLevellabel.Text = "IC Accuracy:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CipherTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(1469, 122);
            this.panel1.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TotalTimelabel);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.AverageTimelabel);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.LastTimelabel);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.KeyTimelabel);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1062, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(407, 191);
            this.panel2.TabIndex = 34;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.PercentLabel);
            this.panel3.Controls.Add(this.NoKeyPanel);
            this.panel3.Controls.Add(this.WithKeyPanel);
            this.panel3.Controls.Add(this.rbNoKey);
            this.panel3.Controls.Add(this.rbWithKey);
            this.panel3.Controls.Add(this.btnICDecrypt);
            this.panel3.Controls.Add(this.btnPause);
            this.panel3.Controls.Add(this.Countlabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1062, 191);
            this.panel3.TabIndex = 35;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 122);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1469, 191);
            this.panel4.TabIndex = 36;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 313);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1469, 333);
            this.panel5.TabIndex = 37;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.FinalResultTextBox);
            this.panel8.Controls.Add(this.label1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 168);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(5);
            this.panel8.Size = new System.Drawing.Size(1247, 165);
            this.panel8.TabIndex = 21;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.LogTextBox);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(5);
            this.panel7.Size = new System.Drawing.Size(1247, 168);
            this.panel7.TabIndex = 20;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.KeyListBox);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(1247, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(222, 333);
            this.panel6.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1469, 646);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FromKeyLenUpDown)).EndInit();
            this.WithKeyPanel.ResumeLayout(false);
            this.WithKeyPanel.PerformLayout();
            this.NoKeyPanel.ResumeLayout(false);
            this.NoKeyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WordLenLenUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToKeyLenUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox CipherTextBox;
        private System.Windows.Forms.TextBox LogTextBox;
        private System.Windows.Forms.TextBox KeyTextBox;
        private System.Windows.Forms.TextBox FinalResultTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label PercentLabel;
        private System.Windows.Forms.Label Countlabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label KeyTimelabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LastTimelabel;
        private System.Windows.Forms.Label AverageTimelabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label TotalTimelabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.ListBox KeyListBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown FromKeyLenUpDown;
        private System.Windows.Forms.Button btnICDecrypt;
        private System.Windows.Forms.ComboBox cmbMode;
        private System.Windows.Forms.RadioButton rbWithKey;
        private System.Windows.Forms.RadioButton rbNoKey;
        private System.Windows.Forms.Panel WithKeyPanel;
        private System.Windows.Forms.Panel NoKeyPanel;
        private System.Windows.Forms.MaskedTextBox ICMaskEdit;
        private System.Windows.Forms.Label ICLevellabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.MaskedTextBox FinalTextICMaskEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown ToKeyLenUpDown;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown WordLenLenUpDown;
        private System.Windows.Forms.CheckBox chkDictionary;
    }
}

