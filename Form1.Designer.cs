﻿namespace ZhengHuo
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonMagicTime = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonResumeNetwork = new System.Windows.Forms.Button();
            this.lbmsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonMagicTime
            // 
            this.buttonMagicTime.Location = new System.Drawing.Point(177, 13);
            this.buttonMagicTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonMagicTime.Name = "buttonMagicTime";
            this.buttonMagicTime.Size = new System.Drawing.Size(226, 57);
            this.buttonMagicTime.TabIndex = 1;
            this.buttonMagicTime.Text = "整活！";
            this.buttonMagicTime.UseVisualStyleBackColor = true;
            this.buttonMagicTime.Click += new System.EventHandler(this.buttonMagicTime_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 157);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "思路采自NGA@w_what，窗口程序：b站@千岛秋";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(38, 27);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(40, 26);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "秒后重连";
            // 
            // buttonResumeNetwork
            // 
            this.buttonResumeNetwork.Location = new System.Drawing.Point(38, 95);
            this.buttonResumeNetwork.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonResumeNetwork.Name = "buttonResumeNetwork";
            this.buttonResumeNetwork.Size = new System.Drawing.Size(120, 57);
            this.buttonResumeNetwork.TabIndex = 5;
            this.buttonResumeNetwork.Text = "网络恢复";
            this.buttonResumeNetwork.UseVisualStyleBackColor = true;
            this.buttonResumeNetwork.Click += new System.EventHandler(this.buttonResumeNetwork_Click);
            // 
            // lbmsg
            // 
            this.lbmsg.AutoSize = true;
            this.lbmsg.Location = new System.Drawing.Point(231, 115);
            this.lbmsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbmsg.Name = "lbmsg";
            this.lbmsg.Size = new System.Drawing.Size(0, 20);
            this.lbmsg.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(408, 192);
            this.Controls.Add(this.lbmsg);
            this.Controls.Add(this.buttonResumeNetwork);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonMagicTime);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(514, 296);
            this.Name = "Form1";
            this.Text = "酒馆战棋整活插件 2.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonMagicTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonResumeNetwork;
        private System.Windows.Forms.Label lbmsg;
    }
}

