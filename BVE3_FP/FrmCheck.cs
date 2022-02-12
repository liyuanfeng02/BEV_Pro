using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;

namespace BVE3_FP
{
    public partial class FrmCheck : Form
    {
        HandyControl handyControl1;
        HandyControl handyControl2;
        
        public FrmCheck()
        {
            InitializeComponent();
        }
        private void DataGridUiInit()
        {
            dataGridViewData.Columns.Add("c0", "No");
            dataGridViewData.Columns.Add("c1", "扭矩值");
            dataGridViewData.Columns.Add("c2", "角度");
            dataGridViewData.Columns.Add("c3", "位置X");
            dataGridViewData.Columns.Add("c4", "位置Y");
            dataGridViewData.Columns.Add("c5", "位置Z");
            dataGridViewData.Columns.Add("c6", "判定");
            dataGridViewData.Columns[0].Width = 70;
            dataGridViewData.Columns[1].Width = 122;
            dataGridViewData.Columns[2].Width = 122;
            dataGridViewData.Columns[3].Width = 122;
            dataGridViewData.Columns[4].Width = 122;
            dataGridViewData.Columns[5].Width = 122;
            dataGridViewData.Columns[6].Width = 122;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            dataGridViewData.AllowUserToAddRows = false;//允许用户新增行
            dataGridViewData.AllowUserToDeleteRows = false;//允许用户删除行
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(237)))), ((int)(((byte)(244)))));//System.Drawing.Color.LightCyan;//表格1的背景色
            dataGridViewData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;//设置计数行单元格
            dataGridViewData.BackgroundColor = System.Drawing.Color.White;//设置本表格背景色为白色
            dataGridViewData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;//标题头样式
            dataGridViewData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;//设置标题头的样式
            dataGridViewData.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));//单元格字体
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));//标题头颜色
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewData.EnableHeadersVisualStyles = false;
            dataGridViewData.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewData.ReadOnly = true;
            dataGridViewData.RowHeadersVisible = false;
            dataGridViewData.RowTemplate.Height = 43;
            dataGridViewData.RowTemplate.ReadOnly = true;

            for (int i = 0; i < dataGridViewData.Columns.Count; i++)
            {
                dataGridViewData.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private bool Handy1Init()
        {
            handyControl1 = new HandyControl(serialPort1,PublicValue.configData.HandyIP1);
            return handyControl1.SerialPortOpen(PublicValue.configData.HandyPort1, Int32.Parse(PublicValue.configData.HandyBaud1));
        }
        private bool Handy2Init()
        {
            handyControl2 = new HandyControl(serialPort2, PublicValue.configData.HandyIP2);
            return handyControl2.SerialPortOpen(PublicValue.configData.HandyPort2, Int32.Parse(PublicValue.configData.HandyBaud2));
        }
        private void ShowMsg(string str)
        {
            txtMsg.AppendText(str + Environment.NewLine);
        }
        private void FrmCheck_Load(object sender, EventArgs e)
        {
            DataGridUiInit();
            PublicValue.SystemInit();
            labProj.Text = PublicValue.Projects[PublicValue.configData.Proj];
            
            raBtn1.Checked = true;
            //电批
            if (PublicValue.configData.Handy1 == "ON")
            {
                bool rel = Handy1Init();
                if (!rel)
                    ShowMsg("电批端口1打开失败");
                raBtn1.Enabled = true;
            }
            if (PublicValue.configData.Handy2 == "ON")
            {
                bool rel = Handy2Init();
                if (!rel)
                    ShowMsg("电批端口2打开失败");
                raBtn2.Enabled = true;
            }
            timer1.Enabled = true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            PROINDEX NowProj = (PROINDEX)PublicValue.configData.Proj;
            if (NowProj == PROINDEX.RelayLine)
            {
                if(checkA1.Checked)
                {
                    handyControl1.SelectJob(19);
                }
                else
                {
                    handyControl1.SelectJob(1);
                }
                Thread.Sleep(100);
                handyControl1.CloseJobMode();
            }
            else if(NowProj == PROINDEX.MainLine6 && checkA5.Checked == true)
            {
                handyControl2.SelectJob(8);//9Nm
                Thread.Sleep(100);
                handyControl2.CloseJobMode();
            }
            else
            {

                if(raBtn1.Checked)
                {
                    handyControl1.SelectJob(1);
                    Thread.Sleep(100);
                    handyControl1.CloseJobMode();
                }
                else
                {
                    handyControl2.SelectJob(1);
                    Thread.Sleep(100);
                    handyControl2.CloseJobMode();
                }
            
            }
            checkA1.Enabled = false;
            checkA5.Enabled = false;
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            if (raBtn1.Checked)
            {
                handyControl1.OpenJobMode();
            }
            else
            {
                handyControl2.OpenJobMode();
            }
        }
        private void AddGridHandyData(Common.HandyData handyData)
        {
            dataGridViewData.Rows.Add(new string[] { (dataGridViewData.Rows.Count+1).ToString(), handyData.f_trq,
                        handyData.rundown_time, handyData.pos_x, handyData.pos_y, handyData.pos_z, handyData.judge=="O"?"OK":"NG" });
            if (handyData.judge == "O")
                dataGridViewData.Rows[dataGridViewData.Rows.Count - 1].Cells[6].Style.BackColor = Color.LimeGreen;
            else
                dataGridViewData.Rows[dataGridViewData.Rows.Count - 1].Cells[6].Style.BackColor = Color.Red;
            dataGridViewData.FirstDisplayedScrollingRowIndex = dataGridViewData.Rows.Count - 1;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (PublicValue.configData.Handy1 == "ON")
            {
                Common.HandyData handyData1 = handyControl1.GetSerialData();
                if (handyData1.length != 0)
                {
                    if(handyData1.rundown_time.Trim() != "0.0")
                        AddGridHandyData(handyData1);
                }
            }
            if(PublicValue.configData.Handy2 == "ON")
            {
                Common.HandyData handyData2 = handyControl2.GetSerialData();
                if (handyData2.length != 0)
                {
                    if (handyData2.rundown_time.Trim() != "0.0")
                        AddGridHandyData(handyData2);
                }
            }
   
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCheck_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (PublicValue.configData.Handy1 == "ON")
            {
                handyControl1.OpenJobMode();
                handyControl1.SerialPortClose();

            }
            if (PublicValue.configData.Handy2 == "ON")
            {
                handyControl2.OpenJobMode();
                handyControl2.SerialPortClose();

            }
        }
    }
}
