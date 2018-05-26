using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z_VFace.Utilities;
namespace Z_VFace
{
    public partial class frm_zvface : Form
    {
        private ZMod czmod = null;

        private bool hasmodified = false;

        public frm_zvface()
        {
            InitializeComponent();
            lbl_tempextruder.Text = this.trkb_tempextruder.Value.ToString();
            this.lbl_tempbed.Text = this.trkb_tempbed.ToString();
            //this.lbl_AutofanfixedSpeed.Text = string.Concat(this.trkb_autofanFixedSpeed.Value.ToString(), "%");
        }


        private void btn_load_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.InitialDirectory = "c:\\";
            this.openFileDialog1.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            this.openFileDialog1.FilterIndex = 1;
            this.openFileDialog1.RestoreDirectory = true;
            if (this.openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    this.czmod = new ZMod(this.openFileDialog1.FileName);
                    if (this.czmod.getData())
                    {
                        this.hasmodified = false;
                        this.chkBtnSave();
                        this.lbl_file.Text = this.openFileDialog1.FileName;
                    }
                }
                catch (Exception exception)
                {
                    Exception q = exception;
                    MessageBox.Show(string.Concat("Errore: ", q.Message), "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                this.trkb_tempextruder.Value = (this.czmod.General.TempExtruder < this.trkb_tempextruder.Minimum ? this.trkb_tempextruder.Minimum : (int)this.czmod.General.TempExtruder);
                this.trkb_tempbed.Value = (this.czmod.General.TempBed < this.trkb_tempbed.Minimum ? this.trkb_tempbed.Minimum : (int)this.czmod.General.TempBed);
                this.chkEnableRaft.Checked = this.czmod.General.EnableRaft;
                this.chkEnableSupport.Checked = this.czmod.General.EnableSupport;
                this.chkAutofanEnable.Checked = this.czmod.General.AutofanEnable;
                this.chkEnableRaft.Checked = this.czmod.General.EnableRaft;
                this.chkVisibleBottomFirst.Checked = this.czmod.General.VisibleBottomFirst;
                this.chkEnableFirstLayer.Checked = this.czmod.General.EnableFirstLayer;
                this.chkEnableBridge.Checked = this.czmod.General.EnableBridge;
                this.chkAutoFanFixedEnabled.Checked = this.czmod.General.AutofanFixedEnabled;
                MaskedTextBox str = this.txtAutofanMinTime;
                short autofanMinTime = this.czmod.General.AutofanMinTime;
                str.Text = autofanMinTime.ToString();
                MaskedTextBox maskedTextBox = this.txtAutofanMaxTime;
                autofanMinTime = this.czmod.General.AutofanMaxTime;
                maskedTextBox.Text = autofanMinTime.ToString();
                this.trkb_autofanFixedSpeed.Value = (this.czmod.General.AutofanFixedSpeed < (double)this.trkb_autofanFixedSpeed.Minimum ? this.trkb_autofanFixedSpeed.Minimum : (int)this.czmod.General.AutofanFixedSpeed);

                this.txtStartGCode.Text = this.czmod.Other.StartGCode;
                this.txtEndGCode.Text = this.czmod.Other.EndGCode;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            short num;
            short num1;
            this.saveFileDialog1.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            this.saveFileDialog1.FilterIndex = 1;
            this.saveFileDialog1.RestoreDirectory = true;
            if (this.saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (this.czmod != null)
                {
                    this.czmod.General.TempExtruder = (short)this.trkb_tempextruder.Value;
                    this.czmod.General.TempBed = (short)this.trkb_tempbed.Value;
                    this.czmod.General.AutofanFixedSpeed = (double)this.trkb_autofanFixedSpeed.Value / 100;
                    this.czmod.General.AutofanEnable = this.chkAutofanEnable.Checked;
                    ZMod zMod = this.czmod;
                    if (string.IsNullOrWhiteSpace(this.txtAutofanMinTime.Text))
                    {
                        num = 0;
                    }
                    else
                    {
                        num = Convert.ToInt16(this.txtAutofanMinTime.Text);
                    }
                    zMod.General.AutofanMinTime = num;
                    ZMod zMod1 = this.czmod;
                    if (string.IsNullOrWhiteSpace(this.txtAutofanMaxTime.Text))
                    {
                        num1 = 0;
                    }
                    else
                    {
                        num1 = Convert.ToInt16(this.txtAutofanMaxTime.Text);
                    }
                    zMod1.General.AutofanMaxTime = num1;
                    this.czmod.General.AutofanFixedEnabled = this.chkAutoFanFixedEnabled.Checked;
                    this.czmod.General.EnableRaft = this.chkEnableRaft.Checked;
                    this.czmod.General.EnableSupport = this.chkEnableSupport.Checked;
                    this.czmod.General.VisibleBottomFirst = this.chkEnableSupport.Checked;
                    this.czmod.General.EnableFirstLayer = this.chkEnableSupport.Checked;
                    this.czmod.General.EnableBridge = this.chkEnableSupport.Checked;
                    this.czmod.saveData(this.saveFileDialog1.FileName);
                }
            }
        }

        private void chkAutofanEnable_CheckedChanged(object sender, EventArgs e)
        {
            this.txtAutofanMinTime.Enabled = this.chkAutofanEnable.Checked;
            this.txtAutofanMaxTime.Enabled = this.chkAutofanEnable.Checked;
        }

        private void chkAutoFanFixedEnabled_CheckedChanged(object sender, EventArgs e)
        {
            this.trkb_autofanFixedSpeed.Enabled = this.chkAutoFanFixedEnabled.Checked;
        }

        private void chkBtnSave()
        {
            this.btn_save.Enabled = true;
            if ((this.czmod == null ? false : this.hasmodified))
            {
                this.btn_save.Enabled = false;
            }
        }
        private void trkb_autofanFixedSpeed_Scroll(object sender, EventArgs e)
        {
            Label lblAutofanfixedSpeed = this.lbl_autofanfixedSpeed;
            int value = this.trkb_autofanFixedSpeed.Value;
            lblAutofanfixedSpeed.Text = string.Concat(value.ToString(), "%");
            this.chkBtnSave();
        }

        private void trkb_autofanFixedSpeed_ValueChanged(object sender, EventArgs e)
        {
            Label lblAutofanfixedSpeed = this.lbl_autofanfixedSpeed;
            int value = this.trkb_autofanFixedSpeed.Value;
            lblAutofanfixedSpeed.Text = string.Concat(value.ToString(), "%");
            this.chkBtnSave();
        }

        private void trkb_tempbed_Scroll(object sender, EventArgs e)
        {
            this.lbl_tempbed.Text = this.trkb_tempbed.Value.ToString();
            this.btn_save.Enabled = true;
            this.chkBtnSave();
        }

        private void trkb_tempbed_ValueChanged(object sender, EventArgs e)
        {
            this.lbl_tempbed.Text = this.trkb_tempbed.Value.ToString();
            this.chkBtnSave();
        }

        private void trkb_tempextruder_Scroll(object sender, EventArgs e)
        {
            this.lbl_tempextruder.Text = this.trkb_tempextruder.Value.ToString();
            this.chkBtnSave();
        }

        private void trkb_tempextruder_ValueChanged(object sender, EventArgs e)
        {
            this.lbl_tempextruder.Text = this.trkb_tempextruder.Value.ToString();
            this.chkBtnSave();
        }

        private void txtCodice_TextChanged(object sender, EventArgs e)
        {
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string codice = Z_VFace.Classes.generatore.createPwd(this.txtCodice.Text);

            MessageBox.Show(codice);
        }
    }


}
