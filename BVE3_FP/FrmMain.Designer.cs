
namespace BVE3_FP
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panel6 = new System.Windows.Forms.Panel();
            this.labType = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comOperator = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.labTime = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.progWork = new System.Windows.Forms.ProgressBar();
            this.label9 = new System.Windows.Forms.Label();
            this.labDeviceNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labProj = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labLineNo = new System.Windows.Forms.Label();
            this.panJudge = new System.Windows.Forms.Panel();
            this.labJudge = new System.Windows.Forms.Label();
            this.panCheck = new System.Windows.Forms.Panel();
            this.labCheck = new System.Windows.Forms.Label();
            this.txtPana = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolLacalIP = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolLocalMesIP = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolPLCIP = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolServerIP = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolNowTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.serialHandy1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialHandy2 = new System.IO.Ports.SerialPort(this.components);
            this.txtQRScan = new System.Windows.Forms.TextBox();
            this.fileWatcher = new System.IO.FileSystemWatcher();
            this.panel6.SuspendLayout();
            this.panJudge.SuspendLayout();
            this.panCheck.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileWatcher)).BeginInit();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.labType);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.comOperator);
            this.panel6.Controls.Add(this.btnReset);
            this.panel6.Controls.Add(this.labTime);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.progWork);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.labDeviceNo);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.labProj);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.labLineNo);
            this.panel6.Location = new System.Drawing.Point(12, 12);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(968, 124);
            this.panel6.TabIndex = 34;
            // 
            // labType
            // 
            this.labType.AutoSize = true;
            this.labType.BackColor = System.Drawing.Color.White;
            this.labType.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labType.Location = new System.Drawing.Point(768, 13);
            this.labType.Name = "labType";
            this.labType.Size = new System.Drawing.Size(75, 24);
            this.labType.TabIndex = 16;
            this.labType.Text = "A1-A4";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(689, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 24);
            this.label11.TabIndex = 15;
            this.label11.Text = "式样:";
            // 
            // comOperator
            // 
            this.comOperator.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold);
            this.comOperator.FormattingEnabled = true;
            this.comOperator.Location = new System.Drawing.Point(536, 48);
            this.comOperator.Name = "comOperator";
            this.comOperator.Size = new System.Drawing.Size(121, 32);
            this.comOperator.TabIndex = 14;
            this.comOperator.SelectedIndexChanged += new System.EventHandler(this.comOperator_SelectedIndexChanged);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReset.Location = new System.Drawing.Point(860, 68);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(103, 51);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "复位";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // labTime
            // 
            this.labTime.AutoSize = true;
            this.labTime.BackColor = System.Drawing.Color.White;
            this.labTime.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labTime.Location = new System.Drawing.Point(532, 90);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(62, 24);
            this.labTime.TabIndex = 12;
            this.labTime.Text = "167s";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(403, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 24);
            this.label10.TabIndex = 11;
            this.label10.Text = "作业时长:";
            // 
            // progWork
            // 
            this.progWork.Location = new System.Drawing.Point(159, 90);
            this.progWork.Name = "progWork";
            this.progWork.Size = new System.Drawing.Size(228, 23);
            this.progWork.TabIndex = 10;
            this.progWork.Value = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(26, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 24);
            this.label9.TabIndex = 9;
            this.label9.Text = "作业进度:";
            // 
            // labDeviceNo
            // 
            this.labDeviceNo.AutoSize = true;
            this.labDeviceNo.BackColor = System.Drawing.Color.White;
            this.labDeviceNo.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labDeviceNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labDeviceNo.Location = new System.Drawing.Point(532, 13);
            this.labDeviceNo.Name = "labDeviceNo";
            this.labDeviceNo.Size = new System.Drawing.Size(36, 24);
            this.labDeviceNo.TabIndex = 3;
            this.labDeviceNo.Text = "M1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(26, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "生产线名:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(403, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "设备号:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(403, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "作业工号:";
            // 
            // labProj
            // 
            this.labProj.AutoSize = true;
            this.labProj.BackColor = System.Drawing.Color.White;
            this.labProj.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labProj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labProj.Location = new System.Drawing.Point(155, 51);
            this.labProj.Name = "labProj";
            this.labProj.Size = new System.Drawing.Size(175, 24);
            this.labProj.TabIndex = 3;
            this.labProj.Text = "端子压入-980A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(26, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "工程名:";
            // 
            // labLineNo
            // 
            this.labLineNo.AutoSize = true;
            this.labLineNo.BackColor = System.Drawing.Color.White;
            this.labLineNo.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labLineNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labLineNo.Location = new System.Drawing.Point(155, 13);
            this.labLineNo.Name = "labLineNo";
            this.labLineNo.Size = new System.Drawing.Size(36, 24);
            this.labLineNo.TabIndex = 3;
            this.labLineNo.Text = "01";
            // 
            // panJudge
            // 
            this.panJudge.BackColor = System.Drawing.Color.LimeGreen;
            this.panJudge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panJudge.Controls.Add(this.labJudge);
            this.panJudge.Location = new System.Drawing.Point(986, 12);
            this.panJudge.Name = "panJudge";
            this.panJudge.Size = new System.Drawing.Size(266, 124);
            this.panJudge.TabIndex = 35;
            // 
            // labJudge
            // 
            this.labJudge.AutoSize = true;
            this.labJudge.Font = new System.Drawing.Font("微软雅黑", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labJudge.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labJudge.Location = new System.Drawing.Point(32, -3);
            this.labJudge.Name = "labJudge";
            this.labJudge.Size = new System.Drawing.Size(201, 128);
            this.labJudge.TabIndex = 8;
            this.labJudge.Text = "OK";
            // 
            // panCheck
            // 
            this.panCheck.BackColor = System.Drawing.Color.LimeGreen;
            this.panCheck.Controls.Add(this.labCheck);
            this.panCheck.Location = new System.Drawing.Point(12, 142);
            this.panCheck.Name = "panCheck";
            this.panCheck.Size = new System.Drawing.Size(1240, 37);
            this.panCheck.TabIndex = 36;
            // 
            // labCheck
            // 
            this.labCheck.AutoSize = true;
            this.labCheck.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labCheck.ForeColor = System.Drawing.Color.White;
            this.labCheck.Location = new System.Drawing.Point(565, 6);
            this.labCheck.Name = "labCheck";
            this.labCheck.Size = new System.Drawing.Size(110, 24);
            this.labCheck.TabIndex = 35;
            this.labCheck.Text = "正常运行";
            // 
            // txtPana
            // 
            this.txtPana.Enabled = false;
            this.txtPana.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold);
            this.txtPana.Location = new System.Drawing.Point(329, 182);
            this.txtPana.Name = "txtPana";
            this.txtPana.Size = new System.Drawing.Size(878, 35);
            this.txtPana.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(47, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 24);
            this.label4.TabIndex = 37;
            this.label4.Text = "PANA铭板/生产指示No：";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(12, 185);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(29, 289);
            this.panel4.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(-1, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 40);
            this.label6.TabIndex = 35;
            this.label6.Text = "项\r\n目";
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Location = new System.Drawing.Point(47, 223);
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.RowTemplate.Height = 23;
            this.dataGridViewItems.Size = new System.Drawing.Size(1205, 251);
            this.dataGridViewItems.TabIndex = 40;
            this.dataGridViewItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewItems_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(12, 482);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(29, 213);
            this.panel1.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(-1, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 80);
            this.label8.TabIndex = 36;
            this.label8.Text = "螺\r\n钉\r\n数\r\n据";
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Location = new System.Drawing.Point(47, 482);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.RowTemplate.Height = 23;
            this.dataGridViewData.Size = new System.Drawing.Size(844, 213);
            this.dataGridViewData.TabIndex = 41;
            // 
            // txtMsg
            // 
            this.txtMsg.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMsg.Location = new System.Drawing.Point(897, 482);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMsg.Size = new System.Drawing.Size(355, 213);
            this.txtMsg.TabIndex = 42;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolVersion,
            this.toolLacalIP,
            this.toolLocalMesIP,
            this.toolPLCIP,
            this.toolServerIP,
            this.toolNowTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 706);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1264, 25);
            this.statusStrip1.TabIndex = 43;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolVersion
            // 
            this.toolVersion.Name = "toolVersion";
            this.toolVersion.Size = new System.Drawing.Size(104, 20);
            this.toolVersion.Text = "Version 1.0.0.0";
            // 
            // toolLacalIP
            // 
            this.toolLacalIP.Name = "toolLacalIP";
            this.toolLacalIP.Size = new System.Drawing.Size(173, 20);
            this.toolLacalIP.Text = "本机设备IP：10.73.107.33";
            // 
            // toolLocalMesIP
            // 
            this.toolLocalMesIP.Name = "toolLocalMesIP";
            this.toolLocalMesIP.Size = new System.Drawing.Size(179, 20);
            this.toolLocalMesIP.Text = "本机MES IP：200.1.13.181";
            // 
            // toolPLCIP
            // 
            this.toolPLCIP.Name = "toolPLCIP";
            this.toolPLCIP.Size = new System.Drawing.Size(146, 20);
            this.toolPLCIP.Text = "PLC IP：10.73.107.89";
            // 
            // toolServerIP
            // 
            this.toolServerIP.Name = "toolServerIP";
            this.toolServerIP.Size = new System.Drawing.Size(159, 20);
            this.toolServerIP.Text = "服务器IP：200.1.13.100";
            // 
            // toolNowTime
            // 
            this.toolNowTime.Name = "toolNowTime";
            this.toolNowTime.Size = new System.Drawing.Size(185, 20);
            this.toolNowTime.Text = "时间：2021/07/05 14:35:56";
            // 
            // serialHandy1
            // 
            this.serialHandy1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialHandy_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // serialHandy2
            // 
            this.serialHandy2.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialHandy2_DataReceived);
            // 
            // txtQRScan
            // 
            this.txtQRScan.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold);
            this.txtQRScan.Location = new System.Drawing.Point(1213, 182);
            this.txtQRScan.Name = "txtQRScan";
            this.txtQRScan.Size = new System.Drawing.Size(39, 35);
            this.txtQRScan.TabIndex = 44;
            this.txtQRScan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQRScan_KeyDown);
            // 
            // fileWatcher
            // 
            this.fileWatcher.EnableRaisingEvents = true;
            this.fileWatcher.SynchronizingObject = this;
            this.fileWatcher.Created += new System.IO.FileSystemEventHandler(this.fileWatcher_Created);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 731);
            this.Controls.Add(this.txtQRScan);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.dataGridViewData);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewItems);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtPana);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panCheck);
            this.Controls.Add(this.panJudge);
            this.Controls.Add(this.panel6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BVE3_FP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Shown += new System.EventHandler(this.FrmMain_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMain_KeyDown);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panJudge.ResumeLayout(false);
            this.panJudge.PerformLayout();
            this.panCheck.ResumeLayout(false);
            this.panCheck.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileWatcher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label labDeviceNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labProj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labLineNo;
        private System.Windows.Forms.Panel panJudge;
        private System.Windows.Forms.Label labJudge;
        private System.Windows.Forms.Panel panCheck;
        private System.Windows.Forms.Label labCheck;
        private System.Windows.Forms.TextBox txtPana;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewItems;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolLacalIP;
        private System.Windows.Forms.ToolStripStatusLabel toolServerIP;
        private System.Windows.Forms.ToolStripStatusLabel toolPLCIP;
        private System.Windows.Forms.Label labTime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ProgressBar progWork;
        private System.Windows.Forms.Label label9;
        private System.IO.Ports.SerialPort serialHandy1;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialHandy2;
        private System.Windows.Forms.ToolStripStatusLabel toolLocalMesIP;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtQRScan;
        private System.Windows.Forms.ToolStripStatusLabel toolNowTime;
        private System.IO.FileSystemWatcher fileWatcher;
        private System.Windows.Forms.ToolStripStatusLabel toolVersion;
        private System.Windows.Forms.ComboBox comOperator;
        private System.Windows.Forms.Label labType;
        private System.Windows.Forms.Label label11;
    }
}

