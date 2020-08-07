using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using PTU;
namespace PTUContorller
{
    public partial class Form1 : Form
    {
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        public static extern void AllocConsole();
        PTUfinder ptufinder = new PTUfinder();
        PTUfunctions ptu = new PTUfunctions();
        public Form1()
        {
            InitializeComponent();
            //AllocConsole();
        }
        private void button_Find_Click(object sender, EventArgs e)
        {
            button_Find.Enabled = false;    //防猛按
            string[] PTUIP = ptufinder.GetPTUIP();  //抓PTU的IP
            listBox_PTU_IP.Items.Clear();   //清除清單
            if (PTUIP.Length > 0)   //如果有抓到IP
            {
                foreach (string IP in PTUIP)    //加到清單裡面
                    listBox_PTU_IP.Items.Add(IP);   
                Application.DoEvents(); //先把消息處理完，不然防猛按沒有用
                button_Connect.Enabled = true;  //有IP就可以開啟連線按鈕
            }
            else
            {
                listBox_PTU_IP.Items.Add("Not found."); //在清單上顯示訊息
                listBox_PTU_IP.Items.Add("Try again.");
                Application.DoEvents(); //先把消息處理完，不然防猛按沒有用
                button_Connect.Enabled = false; //沒有IP不能開啟連線按鈕
            }
            button_Find.Enabled = true; //開啟Find按鍵
        }
        private void button_Connect_Click(object sender, EventArgs e)
        {
            button_Connect.Enabled = false; //防猛按
            button_Find.Enabled = false;
            if (listBox_PTU_IP.SelectedIndex != -1)
            {
                string PTU_IP = listBox_PTU_IP.Items[listBox_PTU_IP.SelectedIndex].ToString();
                Console.WriteLine(PTU_IP);
                 Application.DoEvents();    //處理消息列隊
                 if (ptu.Connect(PTU_IP))   //若有連線上
                 {
                     label_Connection_Status.Text = "PTU:" + PTU_IP;//顯示連到的IP
                     //設定範圍的顯示
                     label_PanRange_Now.Text = ptu.Pan_Minimum.ToString() + " ~ " + ptu.Pan_Maximum.ToString(); //設定lable文字
                     label_TiltRange_Now.Text = ptu.Tilt_Minimum.ToString() + " ~ " + ptu.Tilt_Maximum.ToString();  //設定lable文字
                     textBox_PanMin.Text = ptu.Pan_Minimum.ToString();  //設定textBox文字
                     textBox_PanMax.Text = ptu.Pan_Maximum.ToString();  //設定textBox文字
                     textBox_TiltMin.Text = ptu.Tilt_Minimum.ToString();    //設定textBox文字
                     textBox_TiltMax.Text = ptu.Tilt_Maximum.ToString();    //設定textBox文字

                     //設定位置與速度的顯示
                     string[] PS = ptu.getPS(1);    //取得位置與速度至小數點第一位
                     label_PanPos_Current.Text = PS[0]; //設定lable文字
                     label_PanSpeed.Text = PS[2];   //設定lable文字
                     label_TiltPos_Current.Text = PS[1];    //設定lable文字
                     label_TiltSpeed.Text = PS[3];  //設定lable文字

                     groupBox_Pos.Enabled = true;
                     groupBox_Speed.Enabled = true;
                     groupBox_Pos_Range.Enabled = true;
                     button_Disconnect.Enabled = true;
                 }
                 else
                 {
                     label_Connection_Status.Text = "Connection failed.";
                     button_Connect.Enabled = true;
                     button_Find.Enabled = true;
                 }
            }
            else
            {
                label_Connection_Status.Text = "Select a IP.";
                Application.DoEvents();    //處理消息列隊
                button_Connect.Enabled = true;
                button_Find.Enabled = true;
            }
        }
        private void button_Disconnect_Click(object sender, EventArgs e)
        {
            button_Disconnect.Enabled = false;
            button_Connect.Enabled = true;
            button_Find.Enabled = true;
            groupBox_Pos.Enabled = false;
            groupBox_Speed.Enabled = false;
            groupBox_Pos_Range.Enabled = false;
            label_Connection_Status.Text = "Disconnected.";
            ptu.Close();    //關閉socket

        }
        private void button_Set_Click(object sender, EventArgs e)
        {
            button_Set.Enabled = false;
            button_Go.Enabled = false;
            double Pan_Min = double.Parse(textBox_PanMin.Text); //抓字串轉小數
            double Pan_Max = double.Parse(textBox_PanMax.Text); //抓字串轉小數
            double Tilt_Min = double.Parse(textBox_TiltMin.Text);   //抓字串轉小數
            double Tilt_Max = double.Parse(textBox_TiltMax.Text);   //抓字串轉小數

            ptu.SetUserLimit(Pan_Min, Pan_Max, Tilt_Min, Tilt_Max); //設定範圍

            //設定範圍的顯示
            label_PanRange_Now.Text = ptu.Pan_Minimum.ToString() + " ~ " + ptu.Pan_Maximum.ToString(); //設定lable文字
            label_TiltRange_Now.Text = ptu.Tilt_Minimum.ToString() + " ~ " + ptu.Tilt_Maximum.ToString();  //設定lable文字

            Application.DoEvents();
            button_Set.Enabled = true;
            button_Go.Enabled = true;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ptu.Close();
        }
        private void button_Go_Click(object sender, EventArgs e)
        {
            button_Go.Enabled = false;
            button_Set.Enabled = false;
            string PPpos = textBox_PanPos_Goal.Text;
            string TPpos = textBox_TiltPos_Goal.Text;
            string[] PS;
            if (PPpos != "" && TPpos != "") //若都有輸入
            {
                ptu.gotoPT(double.Parse(PPpos), double.Parse(TPpos));   //轉至目的地
                do
                {
                    PS = ptu.getPS(1);
                    Console.WriteLine("PanPos:{0}, TiltPos:{1}, PanSpeed:{2}, TiltSpeed:{3}", PS[0], PS[1], PS[2], PS[3]);
                    label_PanPos_Current.Text = PS[0]; //設定lable文字
                    label_PanSpeed.Text = PS[2];   //設定lable文字
                    label_TiltPos_Current.Text = PS[1];    //設定lable文字
                    label_TiltSpeed.Text = PS[3];  //設定lable文字
                    label_PanPos_Current.Refresh(); //更新label，否則要等到此事件執行完才會更新
                    label_PanSpeed.Refresh();   //更新label，否則要等到此事件執行完才會更新
                    label_TiltPos_Current.Refresh();    //更新label，否則要等到此事件執行完才會更新
                    label_TiltSpeed.Refresh();  //更新label，否則要等到此事件執行完才會更新
                } while (double.Parse(PS[2]) != 0 || double.Parse(PS[3]) != 0);
            }
            Application.DoEvents();
            button_Go.Enabled = true;
            button_Set.Enabled = true;
        }

    }
}
