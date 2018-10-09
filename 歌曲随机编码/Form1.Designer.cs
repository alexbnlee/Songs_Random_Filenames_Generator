namespace 歌曲随机编码
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.cbFolder = new System.Windows.Forms.ComboBox();
            this.btView = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbNowNum = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bCalc = new System.Windows.Forms.Button();
            this.cbLeftCha = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbRightCha = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(8, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "路径选择：";
            // 
            // cbFolder
            // 
            this.cbFolder.FormattingEnabled = true;
            this.cbFolder.Location = new System.Drawing.Point(12, 71);
            this.cbFolder.Name = "cbFolder";
            this.cbFolder.Size = new System.Drawing.Size(485, 29);
            this.cbFolder.TabIndex = 1;
            // 
            // btView
            // 
            this.btView.Location = new System.Drawing.Point(394, 115);
            this.btView.Name = "btView";
            this.btView.Size = new System.Drawing.Size(103, 32);
            this.btView.TabIndex = 2;
            this.btView.Text = "浏览...";
            this.btView.UseVisualStyleBackColor = true;
            this.btView.Click += new System.EventHandler(this.btView_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(8, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "随机数字位数：";
            // 
            // cbNowNum
            // 
            this.cbNowNum.FormattingEnabled = true;
            this.cbNowNum.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cbNowNum.Location = new System.Drawing.Point(141, 31);
            this.cbNowNum.Name = "cbNowNum";
            this.cbNowNum.Size = new System.Drawing.Size(54, 29);
            this.cbNowNum.TabIndex = 3;
            this.cbNowNum.Text = "4";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbFolder);
            this.groupBox1.Controls.Add(this.btView);
            this.groupBox1.Location = new System.Drawing.Point(19, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 165);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选择需要修改的文件夹";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbRightCha);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.bCalc);
            this.groupBox2.Controls.Add(this.cbLeftCha);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbNowNum);
            this.groupBox2.Location = new System.Drawing.Point(19, 188);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(510, 167);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "产生随机数字";
            // 
            // bCalc
            // 
            this.bCalc.Location = new System.Drawing.Point(394, 119);
            this.bCalc.Name = "bCalc";
            this.bCalc.Size = new System.Drawing.Size(103, 32);
            this.bCalc.TabIndex = 2;
            this.bCalc.Text = "计算";
            this.bCalc.UseVisualStyleBackColor = true;
            this.bCalc.Click += new System.EventHandler(this.bCalc_Click);
            // 
            // cbLeftCha
            // 
            this.cbLeftCha.FormattingEnabled = true;
            this.cbLeftCha.Location = new System.Drawing.Point(141, 72);
            this.cbLeftCha.Name = "cbLeftCha";
            this.cbLeftCha.Size = new System.Drawing.Size(54, 29);
            this.cbLeftCha.TabIndex = 3;
            this.cbLeftCha.Text = "[";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(40, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "前缀字符：";
            // 
            // cbRightCha
            // 
            this.cbRightCha.FormattingEnabled = true;
            this.cbRightCha.Location = new System.Drawing.Point(406, 72);
            this.cbRightCha.Name = "cbRightCha";
            this.cbRightCha.Size = new System.Drawing.Size(54, 29);
            this.cbRightCha.TabIndex = 3;
            this.cbRightCha.Text = "]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(303, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "后缀字符：";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 124);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(372, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 373);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "歌曲随机编码";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFolder;
        private System.Windows.Forms.Button btView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbNowNum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bCalc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbRightCha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbLeftCha;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

