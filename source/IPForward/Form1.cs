using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;


using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//sockets server
using System.Net;
using System.Net.Sockets;
//NetworkInformation
using System.Net.NetworkInformation;
//Threading 延遲工具
using System.Threading;

using System.Management;
using Microsoft.Win32;

namespace IPForward
{
    public partial class Form1 : Form
    {   
        //port
        string[] portArray = { "8484", "8600", "8700", "8238", "7575", "7576", "7577", "7578", "7579", "7580" };
        //cmd
        cmd cmd = new cmd();
        //IPdetail
        IPdetail IPdetail = new IPdetail();
        //初始化
        public Form1()
        {
            InitializeComponent();
        }
        //載入應用程式時執行
        private void first_load(object sender, EventArgs e)
        {
            //確認是否已導向，變更上方狀態
            check_portproxy();
            //確認是否已建立環迴網卡，決定是否開啟環迴網卡按鈕
            check_loopbackAdapter();
        }
        //左側設定
        //點擊導向
        private void portproxy_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("")) {
                MessageBox.Show("請輸入IP");
                return;
            }
            string portproxyStatus = check_portproxy();
            var str = new StringBuilder();
            switch (portproxyStatus) {
                //執行初始化
                case "initialize":
                    string command = "netsh interface portproxy delete  v4tov4 listenport=";
                    for (int i = 0; i < portArray.Length; i++)
                    {
                        str.Clear();
                        str.Append(command);
                        str.Append(portArray[i]);
                        cmd.run_cmd(str);
                    }
                    break;
                //執行導向
                case "guide":
                    if (textBox1.Text.Equals(""))
                    {
                        MessageBox.Show("請輸入IP");
                        return;
                    }
                    string command1 = "netsh interface portproxy add v4tov4 listenport=";
                    string command2 = " connectaddress=" + textBox1.Text + " connectport=";
                    for (int i = 0; i < portArray.Length; i++)
                    {
                        str.Clear();
                        str.Append(command1);
                        str.Append(portArray[i]);
                        str.Append(command2);
                        str.Append(portArray[i]);
                        cmd.run_cmd(str);
                    }
                    break;
                default:
                    MessageBox.Show("參數接收錯誤，請回報作者！");
                    break;

            }
            check_portproxy();
            //顯示portproxy表
            //MessageBox.Show(show_portproxy());
        }
       

        //反饋導向列表
        private string show_portproxy()
        {
            string command = "netsh interface portproxy show all";
            var str = new StringBuilder();
            str.Append(command);
            return cmd.run_cmd(str);
        }
        //確認導向列表
        private string check_portproxy()
        {
            String output = show_portproxy();
            if (output.Contains(textBox1.Text))
            {
                guide_labe_sub.Text = "啟動中";
                guide_labe_sub.ForeColor = Color.Green;
                portproxy.Text = "關閉導向";
                return "initialize";
            }
            guide_labe_sub.Text = "未啟動";
            guide_labe_sub.ForeColor = Color.Black;
            portproxy.Text = "啟動導向";
            return "guide";
        }
        //查找loopbackAdapter網卡數量，將找到的網卡反饋名稱存入List
        private List<string> check_loopbackAdapter_quantity()
        {
            List<string> loopbackAdapter = new List<string>();

            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();   //取得所有網路介面類別(封裝本機網路資料)
            foreach (NetworkInterface adapter in nics)
            {
                if (adapter.NetworkInterfaceType.ToString().Equals("Ethernet"))
                {
                    //取得IPInterfaceProperties(可提供網路介面相關資訊)
                    IPInterfaceProperties ipProperties = adapter.GetIPProperties();

                    if (ipProperties.UnicastAddresses.Count > 0)
                    {
                        PhysicalAddress mac = adapter.GetPhysicalAddress();                     //取得Mac Address
                        string name = adapter.Name;                                             //網路介面名稱
                        string description = adapter.Description;                               //網路介面描述
                        string ip = ipProperties.UnicastAddresses[0].Address.ToString();        //取得IP
                        string netmask = ipProperties.UnicastAddresses[0].IPv4Mask.ToString();  //取得遮罩
                        if (description.IndexOf("Microsoft KM-TEST Loopback Adapter") == 0)
                        {
                            loopbackAdapter.Add(name);
                            //將網卡資訊寫入IPdetail
                            IPdetail.nic_into(mac, name, description, ip, netmask);
                        }
                    }
                }
            }
            return loopbackAdapter;
        }
        private string check_loopbackAdapter() {
            //呼叫函式查找loopbackAdapter網卡數量，將找到的網卡反饋名稱存入List
            List<string> loopbackAdapter = check_loopbackAdapter_quantity();
            loopbackAdapter_button.Enabled = true;
            loopbackAdapter_button.ForeColor = Color.Black;
            NIC_labe_sub.ForeColor = Color.Black;
            if (loopbackAdapter.Count >= 2 )
            {
                loopbackAdapter_button.Text = "刪除環迴網卡";
                loopbackAdapter_button.ForeColor = Color.Red;
                NIC_labe_sub.Text = "異常";
                NIC_labe_sub.ForeColor = Color.Red;
                MessageBox.Show("超過兩個環迴網卡，請手動刪除網卡。");
                return "delete";
            }
            if (loopbackAdapter.Count <= 0)
            {
                loopbackAdapter_button.Enabled = true;
                loopbackAdapter_button.Text = "建立環迴網卡";
                loopbackAdapter_button.ForeColor = Color.Red;
                NIC_labe_sub.Text = "未建立";
                NIC_labe_sub.ForeColor = Color.Orange;
                return "create";
            }
            loopbackAdapter_button.Enabled = true;
            loopbackAdapter_button.Text = "檢查環迴網卡";
            NIC_labe_sub.Text = "正常";
            NIC_labe_sub.ForeColor = Color.Green;
            return "query";
        }
        //環迴網卡
        private void loopbackAdapter_button_Click(object sender, EventArgs e)
        {
            string loopbackAdapterStatus = check_loopbackAdapter();
            List<string> loopbackAdapter = new List<string>();
            switch (loopbackAdapterStatus) {

                case "delete":
                    MessageBox.Show("請手動刪除網卡，本機>內容>裝置管理員>網路介面卡>選取[Microsoft KM-TEST Loopback Adapter]>右鍵>選取[解除安裝裝置]");
                    break;
                case "create":
                    //建立環迴網卡
                    string output = cmd.run_cmd("devcon.exe install %windir%\\inf\\netloop.inf *msloop");
                    if (output.Contains("Drivers installed successfully."))
                    {
                        //重新檢查目前網卡
                        loopbackAdapter = check_loopbackAdapter_quantity();
                        set_nic_ip_mask(loopbackAdapter, "221.231.130.70", "255.255.255.0");
                    }
                    check_loopbackAdapter();
                    break;
                case "query":
                    //重新檢查目前網卡
                    loopbackAdapter = check_loopbackAdapter_quantity();
                    set_nic_ip_mask(loopbackAdapter, "221.231.130.70", "255.255.255.0");
                    check_loopbackAdapter();
                    break;
                default:
                    MessageBox.Show("參數接收錯誤，請回報作者！");
                    break;
            }


        }
        //設定IP(name,ip,mask)
        private void set_nic_ip_mask(string name,string ip,string mask) {
            var str = new StringBuilder();
            str.Append("netsh int ip set address ");
            str.Append("name=\""+ name + "\" ");
            str.Append("static "+ip+" "+mask);
            cmd.run_cmd(str);
        }
        //設定IP(List<name>,ip,mask)
        private void set_nic_ip_mask(List<string> loopbackAdapter, string ip, string mask)
        {
            foreach (string name in loopbackAdapter)
            {
                set_nic_ip_mask(name,ip,mask);
            }
        }

        //右側登入相關

        //點擊登入
        private void login_Click(object sender, EventArgs e)
        {

        }

        private void startgame_Click(object sender, EventArgs e)
        {
            string result = cmd.run_cmd("LEProc.exe MapleStory.exe");
        }
    }

}
