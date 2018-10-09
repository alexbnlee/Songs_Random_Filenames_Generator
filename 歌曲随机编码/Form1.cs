using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace 歌曲随机编码
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btView_Click(object sender, EventArgs e)
        {
            int count = 0;
            
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "选择需要修改歌曲的文件夹";
            fbd.RootFolder = Environment.SpecialFolder.MyComputer;
            if(fbd.ShowDialog() == DialogResult.OK)
                cbFolder.Text = fbd.SelectedPath;

            for (int i = 0; i < cbFolder.Items.Count; i++)
            {
                if (cbFolder.Text == cbFolder.Items[i].ToString())
                    count++;
            }
            if (count == 0)
                cbFolder.Items.Add(cbFolder.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbFolder.Text = Directory.GetCurrentDirectory();
        }

        private void bCalc_Click(object sender, EventArgs e)
        {
            int nowNum = Convert.ToInt32(cbNowNum.Text);
            int beforeNum;
            string leftCha = cbLeftCha.Text;
            string rightCha = cbRightCha.Text;
            string[] files = Directory.GetFiles(cbFolder.Text);

            progressBar1.Maximum = files.Length;
            progressBar1.Value = 0;
            
            Random r = new Random();

            for (int i = 0; i < files.Length; i++)
            {
                if (files[i].Contains(".exe"))
                {
                    progressBar1.Value++;
                    continue;
                }

                string beforeName = files[i];
                string afterName = files[i];
                string folderName = files[i].Substring(0, files[i].LastIndexOf('\\') + 1);
                string fileName;

                if (files[0].IndexOf('[') > 0)     //存在记录
                {
                    beforeNum = files[0].IndexOf(']') - files[0].IndexOf('[') - 1;  //计算出原来文件中数字的位数
                    fileName = files[i].Substring(files[i].LastIndexOf('\\') + 1 + beforeNum + 2);
                }
                else
                    fileName = " - " + files[i].Substring(files[i].LastIndexOf('\\') + 1);
                
                string rString = r.Next(Convert.ToInt32(Math.Pow(10,nowNum)-1)).ToString();
                if(rString.Length < nowNum) //若果产生的随机数字不是指定的位数，需要前面增加0
                {
                    string temp = rString;
                    for (int j = 0; j < nowNum - rString.Length; j++)
                        temp = "0" + temp;
                    rString = temp;
                }

                fileName = "[" + rString + "]" + fileName;
                afterName = folderName + fileName;
                File.Move(beforeName, afterName);
                progressBar1.Value++;
            }
            //    MessageBox.Show(r.Next(Convert.ToInt32(Math.Pow(10,nowNum)-1)).ToString());

            //string beforeName = files[0];
            //string afterName = files[0];
            //string folderName = files[0].Substring(0, files[0].LastIndexOf('\\') + 1);
            //string fileName = files[0].Substring(files[0].LastIndexOf('\\') + 1 + beforeNum + 2);

            //MessageBox.Show(folderName + "\n" + fileName);

            //MessageBox.Show(files[1].Substring(files[1].LastIndexOf('\\')+1));    /*文件地址*/
            //MessageBox.Show(files[1].Substring(0,files[1].LastIndexOf('\\') + 1));  /*文件夹地址*/
        }
    }
}
