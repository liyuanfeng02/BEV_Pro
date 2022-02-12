using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;

namespace BVE3_FP
{
    public partial class FrmInit : Form
    {
        //public static string WorkerName;
        public FrmInit()
        {
            InitializeComponent();
        }
        private void Init()
        {
            try
            {
                int projIndex = Convert.ToInt32(INI.Read("Section Content", "Proj", "", PublicValue.ConfigPath));
                labTheme.Text = PublicValue.Projects[projIndex];
            }
            catch
            {
                MessageBox.Show("system文件异常！");
            }

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //PublicValue.WorkerName = txtWorker.Text;
            this.Hide();
            FrmMain frmMain = new FrmMain();
            frmMain.ShowDialog();
            frmMain.Dispose();
        }

        private void btnSystem_Click(object sender, EventArgs e)
        {
            FrmSystem frmSystem = new FrmSystem();
            frmSystem.Tag = 1;
            frmSystem.ShowDialog();
            if ((int)frmSystem.Tag == 2)//执行保存
            {
                PublicValue.SystemInit();
                labTheme.Text = PublicValue.Projects[PublicValue.configData.Proj];//2021.08.18追加
            }
            frmSystem.Dispose();
        }

        private void FrmInit_Load(object sender, EventArgs e)
        {
            
            PublicValue.SystemInit();
            //自动程序更新
            bool IsUpdate = PublicValue.AutoUpdate(PublicValue.configData.NewAppPath, PublicValue.configData.AutoUpdateAppPath);
            if (IsUpdate)
                this.Close();
            labTheme.Text = PublicValue.Projects[PublicValue.configData.Proj];
            labVer.Text = PublicValue.Version;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            FrmCheck frmCheck = new FrmCheck();
            frmCheck.ShowDialog();
            frmCheck.Dispose();
        }
    }
}
