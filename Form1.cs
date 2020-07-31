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

            if (GetPidByProcessName(name) == 0)

            {

                MessageBox.Show("炉石传说未运行！请运行游戏后重启程序！","游戏未运行");
                //button1.Enabled = false;
                button2.Enabled = false;
                return;

            }
            else
            {
                //获取炉石传说游戏路径
                GP = game_path("Hearthstone");
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
            RunCmd(ccc3);
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

        public static int GetPidByProcessName(string processName)

        {

            Process[] arrayProcess = Process.GetProcessesByName(processName);
            foreach (Process p in arrayProcess)

            {

                return p.Id;

            }

            return 0;

        }
        private string game_path(string game_name)
        {
            string path = "";

            Process[] ps = Process.GetProcessesByName(game_name);
            foreach (Process p in ps)
            {
                path = p.MainModule.FileName;

            }
            return path;
        }
        private static string CmdPath = @"C:\Windows\System32\cmd.exe";
        public static string RunCmd(string cmd)
        {
            cmd = cmd.Trim().TrimEnd('&') + "&exit";//说明：不管命令是否成功均执行exit命令，否则当调用ReadToEnd()方法时，会处于假死状态
            using (Process p = new Process())
            {
                p.StartInfo.FileName = CmdPath;
                p.StartInfo.UseShellExecute = false;        //是否使用操作系统shell启动
                p.StartInfo.RedirectStandardInput = true;   //接受来自调用程序的输入信息
                p.StartInfo.RedirectStandardOutput = true;  //由调用程序获取输出信息
                p.StartInfo.RedirectStandardError = true;   //重定向标准错误输出
                p.StartInfo.CreateNoWindow = true;          //不显示程序窗口
                p.Start();//启动程序

                //向cmd窗口写入命令
                p.StandardInput.WriteLine(cmd);
                p.StandardInput.AutoFlush = true;

                //获取cmd窗口的输出信息
                string output = p.StandardOutput.ReadToEnd();
                p.WaitForExit();//等待程序执行完退出进程
                p.Close();

                return output;
            }
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
                RunCmd(ccc4);
                MessageBox.Show("网络已恢复", "整活");
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            string ccc4 = "netsh advfirewall firewall set rule name=\"ZhengHuo\" new enable=no >nul";
            RunCmd(ccc4);
            MessageBox.Show("网络已恢复", "整活");
        }
    }
}
