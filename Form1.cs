using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Timers;

namespace ZhengHuo
{   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int pi;
        public static int pi_tmp;
        private string GP;
        public static System.Timers.Timer timer = new System.Timers.Timer()
        {
            Interval = 1000
        };

        private void Form1_Load(object sender, EventArgs e)
        {
            //初始化位置在屏幕右下角
            int x = Screen.PrimaryScreen.WorkingArea.Size.Width - this.Width;
            int y = Screen.PrimaryScreen.WorkingArea.Size.Height - this.Height;
            Point p = new Point(x, y);
            this.PointToScreen(p);
            this.Location = p;

            //初始化时钟
            timer.Enabled = true;
            timer.Interval = 1000;


            string name = "Hearthstone";

            var processId = ProcessHelper.GetProcessIdByName(name);
            if (processId == 0)
            {

                MessageBox.Show("炉石传说未运行！请运行游戏后重启程序！","游戏未运行");
                //button1.Enabled = false;
                button2.Enabled = false;
                return;

            }
            else
            {
                //获取炉石传说游戏路径
                GP = ProcessHelper.GetProcessPathByName("Hearthstone");
                //添加整活防火墙 策略
                //string ccc1 = "netsh advfirewall firewall show rule name=\"ZhengHuo\" >nul";
                //RunCmd(ccc1);
                //string ccc2 = "netsh advfirewall firewall add rule name=\"ZhengHuo\" dir=out program=\""+GP+"\" action=block enable=no >nul";
                //RunCmd(ccc2);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //1、断线
            string ccc3 = "netsh advfirewall firewall set rule name=\"ZhengHuo\" new program=\"" + GP + "\" enable=yes >nul";
            CmdHelper.RunCmd(ccc3);
            //2、等N秒
            int seconds = Convert.ToInt32(textBox1.Text)+1;
            pi = seconds;
            pi_tmp = seconds;
            
            timer.Start();
            //3、重连
            timer.Elapsed += Timer_Elapsed;
            //timer.Stop();

        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Reconnect();
        }

        public static void Reconnect()
        {
            if (pi != 0)
            {
                pi = pi - 1;
            }
            else
            {
                timer.Stop();
                string ccc4 = "netsh advfirewall firewall set rule name=\"ZhengHuo\" new enable=no >nul";
                CmdHelper.RunCmd(ccc4);
                MessageBox.Show("网络已恢复", "整活");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string ccc4 = "netsh advfirewall firewall set rule name=\"ZhengHuo\" new enable=no >nul";
            CmdHelper.RunCmd(ccc4);
            MessageBox.Show("网络已恢复", "整活");
        }
    }
}
