using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BVE3_FP
{
    public partial class FrmSystem : Form
    {
        public FrmSystem()
        {
            InitializeComponent();
        }
        


        private void toolSave_Click(object sender, EventArgs e)
        {
            try
            {
                INI.Write("Section Content", "Proj", comProj.SelectedIndex.ToString(), PublicValue.ConfigPath);
                INI.Write("Section Content", "LineNo", comLineNo.Text.Trim(), PublicValue.ConfigPath);
                INI.Write("Section Content", "DeviceNo", comDeviceNo.Text.Trim(), PublicValue.ConfigPath);
                INI.Write("Section Content", "LD1", comLD1.Text.Trim(), PublicValue.ConfigPath);
                INI.Write("Section Content", "LD2", comLD2.Text.Trim(), PublicValue.ConfigPath);
                INI.Write("Section Content", "ImgPath", txtImgPath.Text, PublicValue.ConfigPath);

                INI.Write("Section Content", "QR1", checkQR1.Checked == true?"ON":"OFF", PublicValue.ConfigPath);
                INI.Write("Section Content", "QRIP1", txtQRIP1.Text, PublicValue.ConfigPath);
                INI.Write("Section Content", "QRPort1", txtQRPort1.Text, PublicValue.ConfigPath);

                INI.Write("Section Content", "QR2", checkQR2.Checked == true ? "ON" : "OFF", PublicValue.ConfigPath);
                INI.Write("Section Content", "QRIP2", txtQRIP2.Text, PublicValue.ConfigPath);
                INI.Write("Section Content", "QRPort2", txtQRPort2.Text, PublicValue.ConfigPath);

                INI.Write("Section Content", "QR3", checkQR3.Checked == true ? "ON" : "OFF", PublicValue.ConfigPath);
                INI.Write("Section Content", "QRIP3", txtQRIP3.Text, PublicValue.ConfigPath);
                INI.Write("Section Content", "QRPort3", txtQRPort3.Text, PublicValue.ConfigPath);

                INI.Write("Section Content", "QR4", checkQR4.Checked == true ? "ON" : "OFF", PublicValue.ConfigPath);
                INI.Write("Section Content", "QRIP4", txtQRIP4.Text, PublicValue.ConfigPath);
                INI.Write("Section Content", "QRPort4", txtQRPort4.Text, PublicValue.ConfigPath);

                INI.Write("Section Content", "QR5", checkQR5.Checked == true ? "ON" : "OFF", PublicValue.ConfigPath);
                INI.Write("Section Content", "QRIP5", txtQRIP5.Text, PublicValue.ConfigPath);
                INI.Write("Section Content", "QRPort5", txtQRPort5.Text, PublicValue.ConfigPath);

                INI.Write("Section Content", "QR6", checkQR6.Checked == true ? "ON" : "OFF", PublicValue.ConfigPath);
                INI.Write("Section Content", "QRIP6", txtQRIP6.Text, PublicValue.ConfigPath);
                INI.Write("Section Content", "QRPort6", txtQRPort6.Text, PublicValue.ConfigPath);

                INI.Write("Section Content", "Handy1", checkHandy1.Checked == true ? "ON" : "OFF", PublicValue.ConfigPath);
                INI.Write("Section Content", "HandyPort1", comHandyPort1.Text, PublicValue.ConfigPath);
                INI.Write("Section Content", "HandyBaud1", comHandyBaud1.Text, PublicValue.ConfigPath);

                INI.Write("Section Content", "Handy2", checkHandy2.Checked == true ? "ON" : "OFF", PublicValue.ConfigPath);
                INI.Write("Section Content", "HandyPort2", comHandyPort2.Text, PublicValue.ConfigPath);
                INI.Write("Section Content", "HandyBaud2", comHandyBaud2.Text, PublicValue.ConfigPath);

                INI.Write("Section Content", "PLCIP", txtPLCIP.Text, PublicValue.ConfigPath);
                INI.Write("Section Content", "PLCPort", txtPLCPort.Text, PublicValue.ConfigPath);

                INI.Write("Section Content", "ServerIP", txtServerIP.Text, PublicValue.ConfigPath);
                INI.Write("Section Content", "ServerPort", txtServerPort.Text, PublicValue.ConfigPath);

                INI.Write("Section Content", "CCD1", checkCCD1.Checked == true ? "ON" : "OFF", PublicValue.ConfigPath);
                INI.Write("Section Content", "CCDIP1", txtCCDIP1.Text, PublicValue.ConfigPath);
                INI.Write("Section Content", "CCDPort1", txtCCDPort1.Text, PublicValue.ConfigPath);

                INI.Write("Section Content", "CCD2", checkCCD2.Checked == true ? "ON" : "OFF", PublicValue.ConfigPath);
                INI.Write("Section Content", "CCDIP2", txtCCDIP2.Text, PublicValue.ConfigPath);
                INI.Write("Section Content", "CCDPort2", txtCCDPort2.Text, PublicValue.ConfigPath);

                INI.Write("Section Content", "CCD3", checkCCD3.Checked == true ? "ON" : "OFF", PublicValue.ConfigPath);
                INI.Write("Section Content", "CCDIP3", txtCCDIP3.Text, PublicValue.ConfigPath);
                INI.Write("Section Content", "CCDPort3", txtCCDPort3.Text, PublicValue.ConfigPath);

                INI.Write("Section Content", "CCD4", checkCCD4.Checked == true ? "ON" : "OFF", PublicValue.ConfigPath);
                INI.Write("Section Content", "CCDIP4", txtCCDIP4.Text, PublicValue.ConfigPath);
                INI.Write("Section Content", "CCDPort4", txtCCDPort4.Text, PublicValue.ConfigPath);

                INI.Write("Section Content", "TYPE", comType.SelectedIndex.ToString(), PublicValue.ConfigPath);
                INI.Write("Section Content", "REPEAT", checkRepeat.Checked == true ? "ON" : "OFF", PublicValue.ConfigPath);
                INI.Write("Section Content", "CCDUSE", checkCCDUSE.Checked == true ? "OFF" : "ON", PublicValue.ConfigPath);
                INI.Write("Section Content", "WatchImg", checkWatchImg.Checked == true ? "ON" : "OFF", PublicValue.ConfigPath);
                INI.Write("Section Content", "LDErr", checkLDErr.Checked == true ? "ON" : "OFF", PublicValue.ConfigPath);


                this.Tag = 2;//Save flat
                MessageBox.Show("保存成功！", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch
            {
                MessageBox.Show("保存出错！");
            }
        }

        private void toolExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSys_Load(object sender, EventArgs e)
        {
            if (File.Exists(PublicValue.ConfigPath) == false)
            {
                MessageBox.Show("system.ini 文件丢失!");
                return;
            }

            string[] now_port_name = PublicValue.GetPortNames();
            foreach (string port_name in now_port_name)
            {
                comHandyPort1.Items.Add(port_name);
                comHandyPort2.Items.Add(port_name);
            }
            foreach (string proj in PublicValue.Projects)
            {
                comProj.Items.Add(proj);
            }
            comProj.Select();

            comProj.SelectedIndex = Convert.ToInt32(INI.Read("Section Content", "Proj", "", PublicValue.ConfigPath));
            comLineNo.Text = INI.Read("Section Content", "LineNo", "", PublicValue.ConfigPath);
            comDeviceNo.Text = INI.Read("Section Content", "DeviceNo", "", PublicValue.ConfigPath);
            comLD1.Text = INI.Read("Section Content", "LD1", "", PublicValue.ConfigPath);
            comLD2.Text = INI.Read("Section Content", "LD2", "", PublicValue.ConfigPath);
            txtImgPath.Text = INI.Read("Section Content", "ImgPath", "", PublicValue.ConfigPath);

            checkQR1.Checked = INI.Read("Section Content", "QR1", "", PublicValue.ConfigPath) == "ON" ? true : false;
            txtQRIP1.Text = INI.Read("Section Content", "QRIP1", "", PublicValue.ConfigPath);
            txtQRPort1.Text = INI.Read("Section Content", "QRPort1", "", PublicValue.ConfigPath);

            checkQR2.Checked = INI.Read("Section Content", "QR2", "", PublicValue.ConfigPath) == "ON" ? true : false;
            txtQRIP2.Text = INI.Read("Section Content", "QRIP2", "", PublicValue.ConfigPath);
            txtQRPort2.Text = INI.Read("Section Content", "QRPort2", "", PublicValue.ConfigPath);

            checkQR3.Checked = INI.Read("Section Content", "QR3", "", PublicValue.ConfigPath) == "ON" ? true : false;
            txtQRIP3.Text = INI.Read("Section Content", "QRIP3", "", PublicValue.ConfigPath);
            txtQRPort3.Text = INI.Read("Section Content", "QRPort3", "", PublicValue.ConfigPath);

            checkQR4.Checked = INI.Read("Section Content", "QR4", "", PublicValue.ConfigPath) == "ON" ? true : false;
            txtQRIP4.Text = INI.Read("Section Content", "QRIP4", "", PublicValue.ConfigPath);
            txtQRPort4.Text = INI.Read("Section Content", "QRPort4", "", PublicValue.ConfigPath);

            checkQR5.Checked = INI.Read("Section Content", "QR5", "", PublicValue.ConfigPath) == "ON" ? true : false;
            txtQRIP5.Text = INI.Read("Section Content", "QRIP5", "", PublicValue.ConfigPath);
            txtQRPort5.Text = INI.Read("Section Content", "QRPort5", "", PublicValue.ConfigPath);

            checkQR6.Checked = INI.Read("Section Content", "QR6", "", PublicValue.ConfigPath) == "ON" ? true : false;
            txtQRIP6.Text = INI.Read("Section Content", "QRIP6", "", PublicValue.ConfigPath);
            txtQRPort6.Text = INI.Read("Section Content", "QRPort6", "", PublicValue.ConfigPath);

            checkHandy1.Checked = INI.Read("Section Content", "Handy1", "", PublicValue.ConfigPath) == "ON" ? true : false;
            comHandyPort1.Text = INI.Read("Section Content", "HandyPort1", "", PublicValue.ConfigPath);
            comHandyBaud1.Text = INI.Read("Section Content", "HandyBaud1", "", PublicValue.ConfigPath);

            checkHandy2.Checked = INI.Read("Section Content", "Handy2", "", PublicValue.ConfigPath) == "ON" ? true : false;
            comHandyPort2.Text = INI.Read("Section Content", "HandyPort2", "", PublicValue.ConfigPath);
            comHandyBaud2.Text = INI.Read("Section Content", "HandyBaud2", "", PublicValue.ConfigPath);

            txtPLCIP.Text = INI.Read("Section Content", "PLCIP", "", PublicValue.ConfigPath);
            txtPLCPort.Text = INI.Read("Section Content", "PLCPort", "", PublicValue.ConfigPath);

            txtServerIP.Text = INI.Read("Section Content", "ServerIP", "", PublicValue.ConfigPath);
            txtServerPort.Text = INI.Read("Section Content", "ServerPort", "", PublicValue.ConfigPath);

            checkCCD1.Checked = INI.Read("Section Content", "CCD1", "", PublicValue.ConfigPath) == "ON" ? true : false;
            txtCCDIP1.Text = INI.Read("Section Content", "CCDIP1", "", PublicValue.ConfigPath);
            txtCCDPort1.Text = INI.Read("Section Content", "CCDPort1", "", PublicValue.ConfigPath);

            checkCCD2.Checked = INI.Read("Section Content", "CCD2", "", PublicValue.ConfigPath) == "ON" ? true : false;
            txtCCDIP2.Text = INI.Read("Section Content", "CCDIP2", "", PublicValue.ConfigPath);
            txtCCDPort2.Text = INI.Read("Section Content", "CCDPort2", "", PublicValue.ConfigPath);

            checkCCD3.Checked = INI.Read("Section Content", "CCD3", "", PublicValue.ConfigPath) == "ON" ? true : false;
            txtCCDIP3.Text = INI.Read("Section Content", "CCDIP3", "", PublicValue.ConfigPath);
            txtCCDPort3.Text = INI.Read("Section Content", "CCDPort3", "", PublicValue.ConfigPath);

            checkCCD4.Checked = INI.Read("Section Content", "CCD4", "", PublicValue.ConfigPath) == "ON" ? true : false;
            txtCCDIP4.Text = INI.Read("Section Content", "CCDIP4", "", PublicValue.ConfigPath);
            txtCCDPort4.Text = INI.Read("Section Content", "CCDPort4", "", PublicValue.ConfigPath);

            comType.SelectedIndex = Convert.ToInt32(INI.Read("Section Content", "TYPE", "", PublicValue.ConfigPath));
            checkRepeat.Checked = INI.Read("Section Content", "REPEAT", "", PublicValue.ConfigPath) == "ON" ? true : false;
            checkCCDUSE.Checked = INI.Read("Section Content", "CCDUSE", "", PublicValue.ConfigPath) == "OFF" ? true : false;
            checkLDErr.Checked = INI.Read("Section Content", "LDErr", "", PublicValue.ConfigPath) == "ON" ? true : false;
            checkWatchImg.Checked = INI.Read("Section Content", "WatchImg", "", PublicValue.ConfigPath) == "ON" ? true : false;
            if(checkWatchImg.Checked == false)
                txtImgPath.Enabled = false;
        }

        private void checkCCDUSE_CheckedChanged(object sender, EventArgs e)
        {
            if(checkCCDUSE.Checked == true)
            {
                foreach(Control control in groupCCD.Controls)
                {
                    control.Enabled = false;
                }
            }
            else
            {
                foreach (Control control in groupCCD.Controls)
                {
                    control.Enabled = true;
                }
            }
        }

        private void checkWatchImg_CheckedChanged(object sender, EventArgs e)
        {
            if (checkWatchImg.Checked == true)
            {
                txtImgPath.Enabled = true;
            }
            else
            {
                txtImgPath.Enabled = false;

            }
        }
    }
}
