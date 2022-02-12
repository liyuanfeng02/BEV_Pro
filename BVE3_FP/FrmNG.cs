using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BVE3_FP
{
    public enum NGBtnClick
    {
        Again,
        OK,
        NG,
        CLEAR,
        ERR,

    }
    public enum NGTpye
    { 
        CCD,
        Operator
    }

    public partial class FrmNG : Form
    {

        public FrmNG()
        {
            InitializeComponent();
        }
        public string MsgShow = "目前CCD判定NG 执行人工判定";
        public NGBtnClick ClickBtn;
        public NGTpye NGTpye = NGTpye.CCD;

        private void FrmCCDJudge_Load(object sender, EventArgs e)
        {
            if(NGTpye == NGTpye.CCD)
            {
                ClickBtn = NGBtnClick.NG;
                btnReTry.Enabled = true;
                btnJudgeOK.Enabled = true;
                btnJudgeNG.Enabled = true;
            }
            else if(NGTpye == NGTpye.Operator)
            {
                ClickBtn = NGBtnClick.ERR;
                btnClearErr.Enabled = true;
                btnSetErr.Enabled = true;
            }
            labMsg.Text = MsgShow;
            txtPassword.Enabled = false;
            txtPassword.Select();
            txtPassword.Focus();
        }

        private void btnReTry_Click(object sender, EventArgs e)
        {
            ClickBtn = NGBtnClick.Again;
            this.Close();
        }

        private void btnJudgeOK_Click(object sender, EventArgs e)
        {
            ClickBtn = NGBtnClick.OK;
            this.Close();

        }

        private void btnJudgeNG_Click(object sender, EventArgs e)
        {
            ClickBtn = NGBtnClick.NG;
            this.Close();

        }

        private void btnClearErr_Click(object sender, EventArgs e)
        {
            ClickBtn = NGBtnClick.CLEAR;
            this.Close();
        }

        private void btnSetErr_Click(object sender, EventArgs e)
        {
            ClickBtn = NGBtnClick.ERR;
            this.Close();
        }
    }
}
