using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPForward
{
    class cmd
    {
        //執行CMD(StringBuilder)
        public string run_cmd(StringBuilder str)
        {
            return run_cmd(str.ToString());
        }
        //執行CMD(String)
        public string run_cmd(String str)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;//是否使用作業系統shell啟動
            p.StartInfo.RedirectStandardInput = true;//接受來自呼叫程式的輸入資訊
            p.StartInfo.RedirectStandardOutput = true;//由呼叫程式獲取輸出資訊
            p.StartInfo.RedirectStandardError = true;//重定向標準錯誤輸出
            p.StartInfo.CreateNoWindow = true;//不顯示程式視窗
            p.Start();//啟動程式
            p.StandardInput.WriteLine(@"@echo off");
            p.StandardInput.WriteLine(@str);
            p.StandardInput.AutoFlush = true;
            p.StandardInput.WriteLine("exit");
            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();//等待程式執行完退出程序
            p.Close();
            return output;
        }
    }
}
