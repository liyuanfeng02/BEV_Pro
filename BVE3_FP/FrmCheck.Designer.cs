
namespace BVE3_FP
{
    partial class FrmCheck
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
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labProj = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkA1 = new System.Windows.Forms.CheckBox();
            this.groupHandy = new System.Windows.Forms.GroupBox();
            this.raBtn2 = new System.Windows.Forms.RadioButton();
            this.raBtn1 = new System.Windows.Forms.RadioButton();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkA5 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupHandy.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Location = new System.Drawing.Point(5, 149);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.RowTemplate.Height = 23;
            this.dataGridViewData.Size = new System.Drawing.Size(844, 213);
            this.dataGridViewData.TabIndex = 42;
            // 
            // txtMsg
            // 
            this.txtMsg.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMsg.Location = new System.Drawing.Point(5, 368);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMsg.Size = new System.Drawing.Size(733, 92);
            this.txtMsg.TabIndex = 43;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.checkA5);
            this.groupBox1.Controls.Add(this.labProj);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.checkA1);
            this.groupBox1.Controls.Add(this.groupHandy);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Location = new System.Drawing.Point(5, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(839, 131);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设定";
            // 
            // labProj
            // 
            this.labProj.AutoSize = true;
            this.labProj.BackColor = System.Drawing.Color.White;
            this.labProj.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labProj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labProj.Location = new System.Drawing.Point(135, 27);
            this.labProj.Name = "labProj";
            this.labProj.Size = new System.Drawing.Size(175, 24);
            this.labProj.TabIndex = 20;
            this.labProj.Text = "端子压入-980A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(31, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "工程名:";
            // 
            // checkA1
            // 
            this.checkA1.AutoSize = true;
            this.checkA1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold);
            this.checkA1.Location = new System.Drawing.Point(139, 64);
            this.checkA1.Name = "checkA1";
            this.checkA1.Size = new System.Drawing.Size(327, 28);
            this.checkA1.TabIndex = 18;
            this.checkA1.Text = "M5(3.5±0.25Nm)BasbarA1";
            this.checkA1.UseVisualStyleBackColor = true;
            // 
            // groupHandy
            // 
            this.groupHandy.Controls.Add(this.raBtn2);
            this.groupHandy.Controls.Add(this.raBtn1);
            this.groupHandy.Location = new System.Drawing.Point(530, 16);
            this.groupHandy.Name = "groupHandy";
            this.groupHandy.Size = new System.Drawing.Size(145, 109);
            this.groupHandy.TabIndex = 17;
            this.groupHandy.TabStop = false;
            // 
            // raBtn2
            // 
            this.raBtn2.AutoSize = true;
            this.raBtn2.Enabled = false;
            this.raBtn2.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold);
            this.raBtn2.Location = new System.Drawing.Point(20, 66);
            this.raBtn2.Name = "raBtn2";
            this.raBtn2.Size = new System.Drawing.Size(91, 28);
            this.raBtn2.TabIndex = 1;
            this.raBtn2.TabStop = true;
            this.raBtn2.Text = "电批2";
            this.raBtn2.UseVisualStyleBackColor = true;
            // 
            // raBtn1
            // 
            this.raBtn1.AutoSize = true;
            this.raBtn1.Enabled = false;
            this.raBtn1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold);
            this.raBtn1.Location = new System.Drawing.Point(20, 21);
            this.raBtn1.Name = "raBtn1";
            this.raBtn1.Size = new System.Drawing.Size(91, 28);
            this.raBtn1.TabIndex = 0;
            this.raBtn1.TabStop = true;
            this.raBtn1.Text = "电批1";
            this.raBtn1.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStart.Location = new System.Drawing.Point(730, 27);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(103, 51);
            this.btnStart.TabIndex = 14;
            this.btnStart.Text = "开始点检";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExit.Location = new System.Drawing.Point(741, 368);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(108, 92);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // checkA5
            // 
            this.checkA5.AutoSize = true;
            this.checkA5.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold);
            this.checkA5.Location = new System.Drawing.Point(139, 97);
            this.checkA5.Name = "checkA5";
            this.checkA5.Size = new System.Drawing.Size(327, 28);
            this.checkA5.TabIndex = 21;
            this.checkA5.Text = "M6(9.0±0.5Nm)BarcketA5";
            this.checkA5.UseVisualStyleBackColor = true;
            // 
            // FrmCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 472);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.dataGridViewData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmCheck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "电批点检";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCheck_FormClosing);
            this.Load += new System.EventHandler(this.FrmCheck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupHandy.ResumeLayout(false);
            this.groupHandy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupHandy;
        private System.Windows.Forms.RadioButton raBtn2;
        private System.Windows.Forms.RadioButton raBtn1;
        private System.Windows.Forms.CheckBox checkA1;
        private System.Windows.Forms.Label labProj;
        private System.Windows.Forms.Label label2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox checkA5;
    }
}