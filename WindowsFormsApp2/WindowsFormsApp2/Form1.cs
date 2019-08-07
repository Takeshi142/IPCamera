using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPCamera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //インスタンス共有のため読み込まれたタイミングでインスタンス作成、入力されたUrlなどをセット
        private void Form1_Load(object sender, EventArgs e)
        {
            GetPicture getPic1 = new GetPicture(txtUrl1.Text,txtUser1.Text,txtPass1.Text);
            GetPicture getPic2 = new GetPicture(txtUrl2.Text,txtUser2.Text,txtPass2.Text);
        }

      

        private void setPicBox(Bitmap bitmap, PictureBox picBox)
        {
            picBox.Image = bitmap;
        }
        void setTxt(string txt , TextBox txtbox)
        {
            Invoke((MethodInvoker)(()=>txtbox.Text = txt));
        }

        private void strButton(GroupBox gb,Button start,Button stop,MaskedTextBox delay)
        {
            gb.Enabled = false;
            start.Enabled = false;
            stop.Enabled = true;
            delay.Enabled = false;
        }
        private void stopButton(GroupBox gb, Button start, Button stop, MaskedTextBox delay)
        {
            gb.Enabled = true;
            start.Enabled = true;
            stop.Enabled = false;
            delay.Enabled = true;
        }

        private void BtnStart1_Click(object sender, EventArgs e)
        {

        }

        private void BtnStart2_Click(object sender, EventArgs e)
        {

        }

        private void BtnStop1_Click(object sender, EventArgs e)
        {

        }

        private void BtnStop2_Click(object sender, EventArgs e)
        {

        }

        private void getBit1(Bitmap bitmap)
        {
            setPicBox(bitmap, picBox1);
        }
        private void getBit2(Bitmap bitmap)
        {
            setPicBox(bitmap, picBox2);
        }
    }

}
