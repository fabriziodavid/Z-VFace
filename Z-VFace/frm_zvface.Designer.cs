namespace Z_VFace
{
    partial class frm_zvface
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpGeneral = new System.Windows.Forms.TabPage();
            this.chkAutoFanFixedEnabled = new System.Windows.Forms.CheckBox();
            this.chkEnableBridge = new System.Windows.Forms.CheckBox();
            this.chkVisibleBottomFirst = new System.Windows.Forms.CheckBox();
            this.chkEnableFirstLayer = new System.Windows.Forms.CheckBox();
            this.lbl_autofanfixedSpeed = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.trkb_autofanFixedSpeed = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAutofanMaxTime = new System.Windows.Forms.MaskedTextBox();
            this.txtAutofanMinTime = new System.Windows.Forms.MaskedTextBox();
            this.chkAutofanEnable = new System.Windows.Forms.CheckBox();
            this.chkEnableSupport = new System.Windows.Forms.CheckBox();
            this.chkEnableRaft = new System.Windows.Forms.CheckBox();
            this.lbl_tempbed = new System.Windows.Forms.Label();
            this.trkb_tempbed = new System.Windows.Forms.TrackBar();
            this.lbl_tempextruder = new System.Windows.Forms.Label();
            this.trkb_tempextruder = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpOther = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tpScripts = new System.Windows.Forms.TabPage();
            this.txtEndGCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStartGCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tpUtility = new System.Windows.Forms.TabPage();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lbl_file = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCodice = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tpGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkb_autofanFixedSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkb_tempbed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkb_tempextruder)).BeginInit();
            this.tpOther.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tpScripts.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpGeneral);
            this.tabControl1.Controls.Add(this.tpOther);
            this.tabControl1.Controls.Add(this.tpUtility);
            this.tabControl1.Location = new System.Drawing.Point(12, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(555, 383);
            this.tabControl1.TabIndex = 3;
            // 
            // tpGeneral
            // 
            this.tpGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tpGeneral.Controls.Add(this.chkAutoFanFixedEnabled);
            this.tpGeneral.Controls.Add(this.chkEnableBridge);
            this.tpGeneral.Controls.Add(this.chkVisibleBottomFirst);
            this.tpGeneral.Controls.Add(this.chkEnableFirstLayer);
            this.tpGeneral.Controls.Add(this.lbl_autofanfixedSpeed);
            this.tpGeneral.Controls.Add(this.label5);
            this.tpGeneral.Controls.Add(this.trkb_autofanFixedSpeed);
            this.tpGeneral.Controls.Add(this.label4);
            this.tpGeneral.Controls.Add(this.txtAutofanMaxTime);
            this.tpGeneral.Controls.Add(this.txtAutofanMinTime);
            this.tpGeneral.Controls.Add(this.chkAutofanEnable);
            this.tpGeneral.Controls.Add(this.chkEnableSupport);
            this.tpGeneral.Controls.Add(this.chkEnableRaft);
            this.tpGeneral.Controls.Add(this.lbl_tempbed);
            this.tpGeneral.Controls.Add(this.trkb_tempbed);
            this.tpGeneral.Controls.Add(this.lbl_tempextruder);
            this.tpGeneral.Controls.Add(this.trkb_tempextruder);
            this.tpGeneral.Controls.Add(this.label3);
            this.tpGeneral.Controls.Add(this.label2);
            this.tpGeneral.Controls.Add(this.label1);
            this.tpGeneral.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tpGeneral.Location = new System.Drawing.Point(4, 22);
            this.tpGeneral.Name = "tpGeneral";
            this.tpGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeneral.Size = new System.Drawing.Size(547, 357);
            this.tpGeneral.TabIndex = 0;
            this.tpGeneral.Text = "General";
            // 
            // chkAutoFanFixedEnabled
            // 
            this.chkAutoFanFixedEnabled.AutoSize = true;
            this.chkAutoFanFixedEnabled.Location = new System.Drawing.Point(10, 105);
            this.chkAutoFanFixedEnabled.Name = "chkAutoFanFixedEnabled";
            this.chkAutoFanFixedEnabled.Size = new System.Drawing.Size(124, 17);
            this.chkAutoFanFixedEnabled.TabIndex = 20;
            this.chkAutoFanFixedEnabled.Text = "AutoFanFixedEnable";
            this.chkAutoFanFixedEnabled.UseVisualStyleBackColor = true;
            this.chkAutoFanFixedEnabled.CheckedChanged += new System.EventHandler(this.chkAutoFanFixedEnabled_CheckedChanged);
            // 
            // chkEnableBridge
            // 
            this.chkEnableBridge.AutoSize = true;
            this.chkEnableBridge.Location = new System.Drawing.Point(10, 316);
            this.chkEnableBridge.Name = "chkEnableBridge";
            this.chkEnableBridge.Size = new System.Drawing.Size(89, 17);
            this.chkEnableBridge.TabIndex = 19;
            this.chkEnableBridge.Text = "EnableBridge";
            this.chkEnableBridge.UseVisualStyleBackColor = true;
            // 
            // chkVisibleBottomFirst
            // 
            this.chkVisibleBottomFirst.AutoSize = true;
            this.chkVisibleBottomFirst.Location = new System.Drawing.Point(10, 293);
            this.chkVisibleBottomFirst.Name = "chkVisibleBottomFirst";
            this.chkVisibleBottomFirst.Size = new System.Drawing.Size(108, 17);
            this.chkVisibleBottomFirst.TabIndex = 18;
            this.chkVisibleBottomFirst.Text = "VisibleBottomFirst";
            this.chkVisibleBottomFirst.UseVisualStyleBackColor = true;
            // 
            // chkEnableFirstLayer
            // 
            this.chkEnableFirstLayer.AutoSize = true;
            this.chkEnableFirstLayer.Location = new System.Drawing.Point(140, 293);
            this.chkEnableFirstLayer.Name = "chkEnableFirstLayer";
            this.chkEnableFirstLayer.Size = new System.Drawing.Size(104, 17);
            this.chkEnableFirstLayer.TabIndex = 17;
            this.chkEnableFirstLayer.Text = "EnableFirstLayer";
            this.chkEnableFirstLayer.UseVisualStyleBackColor = true;
            // 
            // lbl_autofanfixedSpeed
            // 
            this.lbl_autofanfixedSpeed.AutoSize = true;
            this.lbl_autofanfixedSpeed.Location = new System.Drawing.Point(278, 165);
            this.lbl_autofanfixedSpeed.Name = "lbl_autofanfixedSpeed";
            this.lbl_autofanfixedSpeed.Size = new System.Drawing.Size(35, 13);
            this.lbl_autofanfixedSpeed.TabIndex = 16;
            this.lbl_autofanfixedSpeed.Text = "label3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "AutofanFixedSpeed";
            // 
            // trkb_autofanFixedSpeed
            // 
            this.trkb_autofanFixedSpeed.Enabled = false;
            this.trkb_autofanFixedSpeed.Location = new System.Drawing.Point(154, 133);
            this.trkb_autofanFixedSpeed.Maximum = 100;
            this.trkb_autofanFixedSpeed.Name = "trkb_autofanFixedSpeed";
            this.trkb_autofanFixedSpeed.Size = new System.Drawing.Size(313, 45);
            this.trkb_autofanFixedSpeed.TabIndex = 14;
            this.trkb_autofanFixedSpeed.Scroll += new System.EventHandler(this.trkb_autofanFixedSpeed_Scroll);
            this.trkb_autofanFixedSpeed.ValueChanged += new System.EventHandler(this.trkb_autofanFixedSpeed_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "TempBed";
            // 
            // txtAutofanMaxTime
            // 
            this.txtAutofanMaxTime.Enabled = false;
            this.txtAutofanMaxTime.Location = new System.Drawing.Point(140, 239);
            this.txtAutofanMaxTime.Mask = "00";
            this.txtAutofanMaxTime.Name = "txtAutofanMaxTime";
            this.txtAutofanMaxTime.Size = new System.Drawing.Size(18, 20);
            this.txtAutofanMaxTime.TabIndex = 12;
            // 
            // txtAutofanMinTime
            // 
            this.txtAutofanMinTime.Enabled = false;
            this.txtAutofanMinTime.Location = new System.Drawing.Point(140, 208);
            this.txtAutofanMinTime.Mask = "00";
            this.txtAutofanMinTime.Name = "txtAutofanMinTime";
            this.txtAutofanMinTime.Size = new System.Drawing.Size(18, 20);
            this.txtAutofanMinTime.TabIndex = 12;
            // 
            // chkAutofanEnable
            // 
            this.chkAutofanEnable.AutoSize = true;
            this.chkAutofanEnable.Location = new System.Drawing.Point(10, 180);
            this.chkAutofanEnable.Name = "chkAutofanEnable";
            this.chkAutofanEnable.Size = new System.Drawing.Size(96, 17);
            this.chkAutofanEnable.TabIndex = 11;
            this.chkAutofanEnable.Text = "AutofanEnable";
            this.chkAutofanEnable.UseVisualStyleBackColor = true;
            this.chkAutofanEnable.CheckedChanged += new System.EventHandler(this.chkAutofanEnable_CheckedChanged);
            // 
            // chkEnableSupport
            // 
            this.chkEnableSupport.AutoSize = true;
            this.chkEnableSupport.Location = new System.Drawing.Point(10, 270);
            this.chkEnableSupport.Name = "chkEnableSupport";
            this.chkEnableSupport.Size = new System.Drawing.Size(96, 17);
            this.chkEnableSupport.TabIndex = 10;
            this.chkEnableSupport.Text = "EnableSupport";
            this.chkEnableSupport.UseVisualStyleBackColor = true;
            // 
            // chkEnableRaft
            // 
            this.chkEnableRaft.AutoSize = true;
            this.chkEnableRaft.Location = new System.Drawing.Point(140, 270);
            this.chkEnableRaft.Name = "chkEnableRaft";
            this.chkEnableRaft.Size = new System.Drawing.Size(79, 17);
            this.chkEnableRaft.TabIndex = 9;
            this.chkEnableRaft.Text = "EnableRaft";
            this.chkEnableRaft.UseVisualStyleBackColor = true;
            // 
            // lbl_tempbed
            // 
            this.lbl_tempbed.AutoSize = true;
            this.lbl_tempbed.Location = new System.Drawing.Point(237, 86);
            this.lbl_tempbed.Name = "lbl_tempbed";
            this.lbl_tempbed.Size = new System.Drawing.Size(35, 13);
            this.lbl_tempbed.TabIndex = 6;
            this.lbl_tempbed.Text = "label3";
            // 
            // trkb_tempbed
            // 
            this.trkb_tempbed.Location = new System.Drawing.Point(113, 54);
            this.trkb_tempbed.Maximum = 105;
            this.trkb_tempbed.Minimum = 30;
            this.trkb_tempbed.Name = "trkb_tempbed";
            this.trkb_tempbed.Size = new System.Drawing.Size(313, 45);
            this.trkb_tempbed.TabIndex = 5;
            this.trkb_tempbed.Value = 30;
            this.trkb_tempbed.Scroll += new System.EventHandler(this.trkb_tempbed_Scroll);
            this.trkb_tempbed.ValueChanged += new System.EventHandler(this.trkb_tempbed_ValueChanged);
            // 
            // lbl_tempextruder
            // 
            this.lbl_tempextruder.AutoSize = true;
            this.lbl_tempextruder.Location = new System.Drawing.Point(237, 38);
            this.lbl_tempextruder.Name = "lbl_tempextruder";
            this.lbl_tempextruder.Size = new System.Drawing.Size(35, 13);
            this.lbl_tempextruder.TabIndex = 4;
            this.lbl_tempextruder.Text = "label3";
            // 
            // trkb_tempextruder
            // 
            this.trkb_tempextruder.Location = new System.Drawing.Point(113, 6);
            this.trkb_tempextruder.Maximum = 295;
            this.trkb_tempextruder.Minimum = 190;
            this.trkb_tempextruder.Name = "trkb_tempextruder";
            this.trkb_tempextruder.Size = new System.Drawing.Size(313, 45);
            this.trkb_tempextruder.TabIndex = 3;
            this.trkb_tempextruder.Value = 190;
            this.trkb_tempextruder.Scroll += new System.EventHandler(this.trkb_tempextruder_Scroll);
            this.trkb_tempextruder.ValueChanged += new System.EventHandler(this.trkb_tempextruder_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "AutofanMaxTime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "AutofanMinTime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TempExtruder";
            // 
            // tpOther
            // 
            this.tpOther.BackColor = System.Drawing.Color.Gainsboro;
            this.tpOther.Controls.Add(this.tabControl2);
            this.tpOther.Location = new System.Drawing.Point(4, 22);
            this.tpOther.Name = "tpOther";
            this.tpOther.Size = new System.Drawing.Size(547, 357);
            this.tpOther.TabIndex = 2;
            this.tpOther.Text = "Other";
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tpScripts);
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(490, 341);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(482, 315);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tpScripts
            // 
            this.tpScripts.Controls.Add(this.txtEndGCode);
            this.tpScripts.Controls.Add(this.label7);
            this.tpScripts.Controls.Add(this.txtStartGCode);
            this.tpScripts.Controls.Add(this.label6);
            this.tpScripts.Location = new System.Drawing.Point(4, 22);
            this.tpScripts.Name = "tpScripts";
            this.tpScripts.Padding = new System.Windows.Forms.Padding(3);
            this.tpScripts.Size = new System.Drawing.Size(482, 315);
            this.tpScripts.TabIndex = 1;
            this.tpScripts.Text = "Scripts";
            this.tpScripts.UseVisualStyleBackColor = true;
            // 
            // txtEndGCode
            // 
            this.txtEndGCode.Location = new System.Drawing.Point(46, 170);
            this.txtEndGCode.Multiline = true;
            this.txtEndGCode.Name = "txtEndGCode";
            this.txtEndGCode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtEndGCode.Size = new System.Drawing.Size(402, 117);
            this.txtEndGCode.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "End G-Code";
            // 
            // txtStartGCode
            // 
            this.txtStartGCode.Location = new System.Drawing.Point(46, 33);
            this.txtStartGCode.Multiline = true;
            this.txtStartGCode.Name = "txtStartGCode";
            this.txtStartGCode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtStartGCode.Size = new System.Drawing.Size(402, 117);
            this.txtStartGCode.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Start G-Code";
            // 
            // tpUtility
            // 
            this.tpUtility.Location = new System.Drawing.Point(4, 22);
            this.tpUtility.Name = "tpUtility";
            this.tpUtility.Padding = new System.Windows.Forms.Padding(3);
            this.tpUtility.Size = new System.Drawing.Size(547, 357);
            this.tpUtility.TabIndex = 1;
            this.tpUtility.Text = "Utility";
            this.tpUtility.UseVisualStyleBackColor = true;
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(27, 12);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 23);
            this.btn_load.TabIndex = 4;
            this.btn_load.Text = "Carica";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.Enabled = false;
            this.btn_save.Location = new System.Drawing.Point(254, 464);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "Salva file";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lbl_file
            // 
            this.lbl_file.AutoSize = true;
            this.lbl_file.Location = new System.Drawing.Point(113, 17);
            this.lbl_file.Name = "lbl_file";
            this.lbl_file.Size = new System.Drawing.Size(0, 13);
            this.lbl_file.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(448, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Genera Codice";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCodice
            // 
            this.txtCodice.Location = new System.Drawing.Point(221, 20);
            this.txtCodice.Name = "txtCodice";
            this.txtCodice.Size = new System.Drawing.Size(221, 20);
            this.txtCodice.TabIndex = 8;
            this.txtCodice.TextChanged += new System.EventHandler(this.txtCodice_TextChanged);
            // 
            // frm_zvface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 499);
            this.Controls.Add(this.txtCodice);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_file);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.tabControl1);
            this.Name = "frm_zvface";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tpGeneral.ResumeLayout(false);
            this.tpGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkb_autofanFixedSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkb_tempbed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkb_tempextruder)).EndInit();
            this.tpOther.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tpScripts.ResumeLayout(false);
            this.tpScripts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpGeneral;
        private System.Windows.Forms.CheckBox chkAutoFanFixedEnabled;
        private System.Windows.Forms.CheckBox chkEnableBridge;
        private System.Windows.Forms.CheckBox chkVisibleBottomFirst;
        private System.Windows.Forms.CheckBox chkEnableFirstLayer;
        private System.Windows.Forms.Label lbl_autofanfixedSpeed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trkb_autofanFixedSpeed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtAutofanMaxTime;
        private System.Windows.Forms.MaskedTextBox txtAutofanMinTime;
        private System.Windows.Forms.CheckBox chkAutofanEnable;
        private System.Windows.Forms.CheckBox chkEnableSupport;
        private System.Windows.Forms.CheckBox chkEnableRaft;
        private System.Windows.Forms.Label lbl_tempbed;
        private System.Windows.Forms.TrackBar trkb_tempbed;
        private System.Windows.Forms.Label lbl_tempextruder;
        private System.Windows.Forms.TrackBar trkb_tempextruder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpOther;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tpScripts;
        private System.Windows.Forms.TabPage tpUtility;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label lbl_file;
        private System.Windows.Forms.TextBox txtEndGCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStartGCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCodice;
    }
}

