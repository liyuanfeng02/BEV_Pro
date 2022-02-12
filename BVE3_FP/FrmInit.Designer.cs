
namespace BVE3_FP
{
    partial class FrmInit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInit));
            this.labTheme = new System.Windows.Forms.Label();
            this.labVer = new System.Windows.Forms.Label();
            this.btnStart = new Common.RoundButton();
            this.btnSystem = new Common.RoundButton();
            this.btnExit = new Common.RoundButton();
            this.btnCheck = new Common.RoundButton();
            this.SuspendLayout();
            // 
            // labTheme
            // 
            this.labTheme.AutoSize = true;
            this.labTheme.Font = new System.Drawing.Font("宋体", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTheme.Location = new System.Drawing.Point(28, 30);
            this.labTheme.Name = "labTheme";
            this.labTheme.Size = new System.Drawing.Size(267, 35);
            this.labTheme.TabIndex = 1;
            this.labTheme.Text = "主继电器预组立";
            // 
            // labVer
            // 
            this.labVer.AutoSize = true;
            this.labVer.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labVer.Location = new System.Drawing.Point(31, 94);
            this.labVer.Name = "labVer";
            this.labVer.Size = new System.Drawing.Size(98, 16);
            this.labVer.TabIndex = 2;
            this.labVer.Text = "Ver1.0.0.0";
            // 
            // btnStart
            // 
            this.btnStart.EnterBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(120)))));
            this.btnStart.EnterForeColor = System.Drawing.Color.White;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold);
            this.btnStart.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(169)))));
            this.btnStart.HoverForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(118, 158);
            this.btnStart.Name = "btnStart";
            this.btnStart.PressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(190)))));
            this.btnStart.PressForeColor = System.Drawing.Color.White;
            this.btnStart.Radius = 18;
            this.btnStart.Size = new System.Drawing.Size(177, 55);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "开始";
            this.btnStart.UpBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(120)))));
            this.btnStart.UpForeColor = System.Drawing.Color.White;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnSystem
            // 
            this.btnSystem.EnterBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(120)))));
            this.btnSystem.EnterForeColor = System.Drawing.Color.White;
            this.btnSystem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSystem.FlatAppearance.BorderSize = 0;
            this.btnSystem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSystem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSystem.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold);
            this.btnSystem.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(169)))));
            this.btnSystem.HoverForeColor = System.Drawing.Color.White;
            this.btnSystem.Location = new System.Drawing.Point(118, 344);
            this.btnSystem.Name = "btnSystem";
            this.btnSystem.PressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(190)))));
            this.btnSystem.PressForeColor = System.Drawing.Color.White;
            this.btnSystem.Radius = 18;
            this.btnSystem.Size = new System.Drawing.Size(177, 55);
            this.btnSystem.TabIndex = 6;
            this.btnSystem.Text = "设定";
            this.btnSystem.UpBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(120)))));
            this.btnSystem.UpForeColor = System.Drawing.Color.White;
            this.btnSystem.UseVisualStyleBackColor = true;
            this.btnSystem.Click += new System.EventHandler(this.btnSystem_Click);
            // 
            // btnExit
            // 
            this.btnExit.EnterBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(120)))));
            this.btnExit.EnterForeColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold);
            this.btnExit.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(169)))));
            this.btnExit.HoverForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(118, 437);
            this.btnExit.Name = "btnExit";
            this.btnExit.PressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(190)))));
            this.btnExit.PressForeColor = System.Drawing.Color.White;
            this.btnExit.Radius = 18;
            this.btnExit.Size = new System.Drawing.Size(177, 55);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "退出";
            this.btnExit.UpBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(120)))));
            this.btnExit.UpForeColor = System.Drawing.Color.White;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.EnterBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(120)))));
            this.btnCheck.EnterForeColor = System.Drawing.Color.White;
            this.btnCheck.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCheck.FlatAppearance.BorderSize = 0;
            this.btnCheck.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCheck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold);
            this.btnCheck.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(169)))));
            this.btnCheck.HoverForeColor = System.Drawing.Color.White;
            this.btnCheck.Location = new System.Drawing.Point(118, 251);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.PressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(190)))));
            this.btnCheck.PressForeColor = System.Drawing.Color.White;
            this.btnCheck.Radius = 18;
            this.btnCheck.Size = new System.Drawing.Size(177, 55);
            this.btnCheck.TabIndex = 8;
            this.btnCheck.Text = "点检";
            this.btnCheck.UpBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(120)))));
            this.btnCheck.UpForeColor = System.Drawing.Color.White;
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // FrmInit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(404, 530);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSystem);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.labVer);
            this.Controls.Add(this.labTheme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmInit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInit";
            this.Load += new System.EventHandler(this.FrmInit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labTheme;
        private System.Windows.Forms.Label labVer;
        private Common.RoundButton btnStart;
        private Common.RoundButton btnSystem;
        private Common.RoundButton btnExit;
        private Common.RoundButton btnCheck;
    }
}