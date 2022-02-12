
namespace BVE3_FP
{
    partial class FrmNG
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
            this.labMsg = new System.Windows.Forms.Label();
            this.btnReTry = new System.Windows.Forms.Button();
            this.btnJudgeOK = new System.Windows.Forms.Button();
            this.btnJudgeNG = new System.Windows.Forms.Button();
            this.labWorker = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnClearErr = new System.Windows.Forms.Button();
            this.btnSetErr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labMsg
            // 
            this.labMsg.AutoSize = true;
            this.labMsg.BackColor = System.Drawing.Color.White;
            this.labMsg.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labMsg.ForeColor = System.Drawing.Color.Red;
            this.labMsg.Location = new System.Drawing.Point(109, 30);
            this.labMsg.Name = "labMsg";
            this.labMsg.Size = new System.Drawing.Size(338, 24);
            this.labMsg.TabIndex = 4;
            this.labMsg.Text = "目前CCD判定NG 执行人工判定";
            // 
            // btnReTry
            // 
            this.btnReTry.Enabled = false;
            this.btnReTry.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReTry.Location = new System.Drawing.Point(292, 140);
            this.btnReTry.Name = "btnReTry";
            this.btnReTry.Size = new System.Drawing.Size(135, 40);
            this.btnReTry.TabIndex = 15;
            this.btnReTry.Text = "CCD再检测";
            this.btnReTry.UseVisualStyleBackColor = true;
            this.btnReTry.Click += new System.EventHandler(this.btnReTry_Click);
            // 
            // btnJudgeOK
            // 
            this.btnJudgeOK.Enabled = false;
            this.btnJudgeOK.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnJudgeOK.Location = new System.Drawing.Point(292, 186);
            this.btnJudgeOK.Name = "btnJudgeOK";
            this.btnJudgeOK.Size = new System.Drawing.Size(135, 40);
            this.btnJudgeOK.TabIndex = 16;
            this.btnJudgeOK.Text = "目视判定OK";
            this.btnJudgeOK.UseVisualStyleBackColor = true;
            this.btnJudgeOK.Click += new System.EventHandler(this.btnJudgeOK_Click);
            // 
            // btnJudgeNG
            // 
            this.btnJudgeNG.Enabled = false;
            this.btnJudgeNG.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnJudgeNG.Location = new System.Drawing.Point(292, 232);
            this.btnJudgeNG.Name = "btnJudgeNG";
            this.btnJudgeNG.Size = new System.Drawing.Size(135, 40);
            this.btnJudgeNG.TabIndex = 17;
            this.btnJudgeNG.Text = "目视判定NG";
            this.btnJudgeNG.UseVisualStyleBackColor = true;
            this.btnJudgeNG.Click += new System.EventHandler(this.btnJudgeNG_Click);
            // 
            // labWorker
            // 
            this.labWorker.AutoSize = true;
            this.labWorker.BackColor = System.Drawing.Color.White;
            this.labWorker.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labWorker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labWorker.Location = new System.Drawing.Point(126, 90);
            this.labWorker.Name = "labWorker";
            this.labWorker.Size = new System.Drawing.Size(73, 24);
            this.labWorker.TabIndex = 18;
            this.labWorker.Text = "密码:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold);
            this.txtPassword.Location = new System.Drawing.Point(205, 87);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(222, 35);
            this.txtPassword.TabIndex = 45;
            // 
            // btnClearErr
            // 
            this.btnClearErr.Enabled = false;
            this.btnClearErr.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClearErr.Location = new System.Drawing.Point(130, 140);
            this.btnClearErr.Name = "btnClearErr";
            this.btnClearErr.Size = new System.Drawing.Size(135, 40);
            this.btnClearErr.TabIndex = 46;
            this.btnClearErr.Text = "报警解除";
            this.btnClearErr.UseVisualStyleBackColor = true;
            this.btnClearErr.Click += new System.EventHandler(this.btnClearErr_Click);
            // 
            // btnSetErr
            // 
            this.btnSetErr.Enabled = false;
            this.btnSetErr.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSetErr.Location = new System.Drawing.Point(130, 186);
            this.btnSetErr.Name = "btnSetErr";
            this.btnSetErr.Size = new System.Drawing.Size(135, 40);
            this.btnSetErr.TabIndex = 47;
            this.btnSetErr.Text = "判定异常";
            this.btnSetErr.UseVisualStyleBackColor = true;
            this.btnSetErr.Click += new System.EventHandler(this.btnSetErr_Click);
            // 
            // FrmNG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 307);
            this.Controls.Add(this.btnSetErr);
            this.Controls.Add(this.btnClearErr);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.labWorker);
            this.Controls.Add(this.btnJudgeNG);
            this.Controls.Add(this.btnJudgeOK);
            this.Controls.Add(this.btnReTry);
            this.Controls.Add(this.labMsg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmNG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "警告";
            this.Load += new System.EventHandler(this.FrmCCDJudge_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labMsg;
        private System.Windows.Forms.Button btnReTry;
        private System.Windows.Forms.Button btnJudgeOK;
        private System.Windows.Forms.Button btnJudgeNG;
        private System.Windows.Forms.Label labWorker;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnClearErr;
        private System.Windows.Forms.Button btnSetErr;
    }
}