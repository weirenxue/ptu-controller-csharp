using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using System.Net.Sockets;
namespace PTU
{
    class PTUfunctions
    {
        public Socket ptu { get; private set; }
        public float Pan_Resolution { get; private set; }
        public float Tilt_Resolution { get; private set; }
        public float Pan_Minimum { get; private set; }
        public float Pan_Maximum { get; private set; }
        public float Tilt_Minimum { get; private set; }
        public float Tilt_Maximum { get; private set; }

        public bool Connect(string PTU_IP)
        {
            ptu = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);   //設定為Tcpip Socket
            //string myIP = "192.168.0.102"; //本地端的IP
            //string PTU_IP = "192.168.0.101"; //PTU端的IP
            int remotePORT = 4000; //PTU端的PORT
            IPEndPoint localIP = new IPEndPoint(IPAddress.Any, 0);   //本地端的IP/PORT，PORT為0則交由系統指定，IPAddress.Any 為 0.0.0.0 也是交由能連線到對方的IP去通訊
            IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse(PTU_IP), remotePORT); //PTU的IP/PORT
            ptu.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true); //讓localIP可以從新被綁
            ptu.Bind(localIP);  //綁定localIP
            Console.WriteLine(ptu.LocalEndPoint);
            ptu.Connect(remoteIP);  //連接到PTU

            Console.WriteLine(ptu.LocalEndPoint);
            Initialize();
            bool status = true;
            if (!ptu.Connected) //若沒連線到
            {
                status = false;
                ptu.Close();
            }
            return status;
        }
        private void Initialize()
        {
            if (ptu.Connected)
            {
                Thread.Sleep(300); //等0.3秒，等剛開始連線的資料都收到以後再往下
                cmd("ED");  // Echoing off
                cmd("FT");  // Terse Feedback 
                cmd("LE");  // Enable Software Limit
                //Console.WriteLine(ptu.Available);
                PTResolution(); //抓解析度
                PTLimit();  //抓轉動範圍
            }
        }
        public string cmd(string CMD_str)
        {
            byte[] CMD_byte = Encoding.UTF8.GetBytes(CMD_str);  //把string轉成byte
            List<byte> temp = CMD_byte.ToList();    //byte轉成List才能Add新元素
            temp.Add(0x20); //命令最後包含空白鍵(0x20)或CR(0x0D)的話，PTU回傳會是一個封包，否則會分成兩個。
            CMD_byte = temp.ToArray();  //List 轉回byte
            ptu.Send(CMD_byte); //傳送指令
            Thread.Sleep(100); //等0.1秒
            while (ptu.Available == 0);
            byte[] result = new byte[ptu.Available];    //用來收回傳的資料
            ptu.Receive(result, 0, ptu.Available, SocketFlags.None);    //接收封包
            return Encoding.UTF8.GetString(result);
        }
        public void Close()
        {
            if(ptu != null)
                ptu.Close();    //關閉Socket
        }
        private string TrimReply(string msg)
        {
            msg = msg.TrimStart('*', ' ', '\n', '\r');  //拿掉*、空格、CRLF
            msg = msg.TrimEnd('*', ' ', '\n', '\r');    //拿掉*、空格、CRLF
            return msg;
        }
        private void PTResolution()
        {
            string PR_str = TrimReply(cmd("PR"));      //得知Pan_Resolution，去頭去尾只留數字
            Pan_Resolution = float.Parse(PR_str) / 3600;  //轉成浮點數，角秒再轉為度數
            string TR_str = TrimReply(cmd("TR"));      //得知Tilt_Resolution，去頭去尾只留數字
            Tilt_Resolution = float.Parse(TR_str) / 3600; //轉成浮點數，角秒再轉為度數

            //Console.WriteLine("PanR:{0}, TiltR:{1}", Pan_Resolution, Tilt_Resolution);
        }
        private void PTLimit()
        {
            string PN = TrimReply(cmd("PN"));   //Pan min
            string PX = TrimReply(cmd("PX"));   //Pan max
            string TN = TrimReply(cmd("TN"));   //Tilt min
            string TX = TrimReply(cmd("TX"));   //Tilt max
            Pan_Minimum = ((float)(int)(float.Parse(PN) * Pan_Resolution * 10)) / 10; //Position轉為度數，無條件捨去取到小數點第一位
            Pan_Maximum = ((float)(int)(float.Parse(PX) * Pan_Resolution * 10)) / 10; //Position轉為度數，無條件捨去取到小數點第一位
            Tilt_Minimum = ((float)(int)(float.Parse(TN) * Tilt_Resolution * 10)) / 10;   //Position轉為度數，無條件捨去取到小數點第一位
            Tilt_Maximum = ((float)(int)(float.Parse(TX) * Tilt_Resolution * 10)) / 10;   //Position轉為度數，無條件捨去取到小數點第一位
            Console.WriteLine("PanMin:{0}, PanMax:{1}, TiltMin:{2}, TiltMax:{3}", Pan_Minimum, Pan_Maximum, Tilt_Minimum, Tilt_Maximum);
        }
        private string deg2pos(char Direction, double deg)
        {
            if (Direction == 'P' || Direction == 'p')   //若為Pan的度數轉換
                deg = deg / Pan_Resolution;
            else if (Direction == 'T' || Direction == 't')  //若為Tilt的度數轉換
                deg = deg / Tilt_Resolution;
            return Math.Round(deg).ToString();  //四捨五入後轉成字串
        }
        public string gotoPT(double P_deg, double T_deg)
        {
            string Status = "Out of range";
            string P_pos, T_pos;
            if (((P_deg - Pan_Minimum) * (P_deg - Pan_Maximum) < 0) && ((T_deg - Tilt_Minimum) * (T_deg - Tilt_Maximum) < 0)) //若指定的目的地在範圍內
            {
                Status = "Destination is OK";
                P_pos = deg2pos('P', P_deg);
                T_pos = deg2pos('T', T_deg);
                P_pos = "PP" + P_pos;
                T_pos = "TP" + T_pos;
                cmd(P_pos);
                cmd(T_pos);
            }
            return Status;
        }
        public string[] getPS(int decimals) //Digit After Decimal point
        {
            string[] Pos_Speed = { "\0" };    //裝位置與速度的字串陣列
            string temp = TrimReply(cmd("B"));  //查詢位置與速度
            double tempPS;  //暫存速度與位置的浮點型態
            Pos_Speed = temp.Split(' ');    //以空格分開位置與速度的數值
            tempPS = Math.Round(float.Parse(Pos_Speed[0]) * Pan_Resolution, decimals);    //Pan Position
            Pos_Speed[0] = tempPS.ToString();
            tempPS = Math.Round(float.Parse(Pos_Speed[2]) * Pan_Resolution, decimals);    //Pan Speed
            Pos_Speed[2] = tempPS.ToString();
            tempPS = Math.Round(float.Parse(Pos_Speed[1]) * Tilt_Resolution, decimals);   //Tilt Position
            Pos_Speed[1] = tempPS.ToString();
            tempPS = Math.Round(float.Parse(Pos_Speed[3]) * Tilt_Resolution, decimals);   //Tilt Speed
            Pos_Speed[3] = tempPS.ToString();
            //Console.WriteLine("PP:{0}, TP:{1}, PS:{2}, TS:{3}", Pos_Speed[0], Pos_Speed[1], Pos_Speed[2], Pos_Speed[3]);

            return Pos_Speed;
        }
        public void SetUserLimit(double Pan_min, double Pan_max, double Tilt_min, double Tilt_max)
        {
            if (Pan_min < 0 && Pan_max > 0 && Tilt_min < 0 && Tilt_max > 0)
            {
                cmd("LU");
                string PNU = "PNU" + deg2pos('P', Pan_min);
                string PXU = "PXU" + deg2pos('P', Pan_max);
                string TNU = "TNU" + deg2pos('T', Tilt_min);
                string TXU = "TXU" + deg2pos('T', Tilt_max);

                cmd(PNU);
                cmd(PXU);
                cmd(TNU);
                cmd(TXU);
                PTLimit();
            }
        }
    }
    class PTUfinder
    {
        public string[] GetPTUIP()
        {
            //回傳的參數
            string[] PTU_IP = { "" }; //此函數回傳的值
            //發送參數
            string[] myIP = GetLocalIP();   //先拿到自己電腦IP
            IPEndPoint remoteIP = new IPEndPoint(IPAddress.Parse("255.255.255.255"), 4930); //可自行定義廣播區域跟Port
            IPEndPoint localIP = new IPEndPoint(IPAddress.Parse(myIP[0]), 4930);    //先設定端點IP與PORT
            Socket Server; //網路插座                      
            byte[] pushdata = new byte[10]; //定義要送出的封包大小
            pushdata = Encoding.UTF8.GetBytes("DCUD_PING\0"); //把要送出的資料轉成byte型態
            //接收的參數
            IPEndPoint IPEnd = new IPEndPoint(IPAddress.Any, 4930);
            EndPoint IP = (EndPoint)IPEnd; //接收端點的IP/PORT存放參數
            byte[] getdata = new byte[1024]; //要接收的封包大小
            string input;   //收到的資料
            int recv = 0;   //收到的位元數
            //迴圈內參數
            int i = 0;  //第i個IP
            foreach (string HostIP in myIP)
            {
                localIP.Address = IPAddress.Parse(HostIP);  //更改端點IP
                Server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp); //定義發送的格式及有效區域
                Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true); //可廣播的socket
                Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout, 500);    //接收等待時間 1000ms
                try
                {
                    Server.Bind(localIP); //綁定本地端點
                    Server.SendTo(pushdata, remoteIP); //送出的資料跟目的地
                }
                catch (SocketException ifx)
                {
                    Console.WriteLine("{0}", ifx);
                }
                try
                {
                    recv = Server.ReceiveFrom(getdata, ref IP); //把接收的封包放進getdata且傳回大小存入recv
                    recv = Server.ReceiveFrom(getdata, ref IP); //把接收的封包放進getdata且傳回大小存入recv
                }
                catch (SocketException ifx)
                {
                    Console.WriteLine("{0}", ifx);
                }
                input = Encoding.UTF8.GetString(getdata, 0, recv); //把接收的byte資料轉回string型態 
                if (input.Equals("DCUD_PONG\0KERNEL\0", StringComparison.Ordinal)) // 如果是PTU回傳的訊息
                {
                    System.Array.Resize(ref PTU_IP, i + 1);
                    PTU_IP[i] = IP.ToString().Remove(IP.ToString().IndexOf(":"));   //冒號與PORT都刪掉
                    Console.WriteLine(PTU_IP[i]);
                    i++;
                }
                Server.Close(); // 關掉Socket
            }
            if (PTU_IP[0] == "")
                System.Array.Resize(ref PTU_IP, 0);
            return PTU_IP;
        }
        public string[] GetLocalIP() // 抓LocalHost有的IP
        {
            string hostName = Dns.GetHostName(); // 抓電腦名稱
            string[] myIP = { "" }; // 一定要初始化才能Resize
            int i = 0; // 第i個IP
            System.Net.IPAddress[] addressList = Dns.GetHostAddresses(hostName); //抓擁有電腦名稱hostName的IP
            foreach (IPAddress ip in addressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    System.Array.Resize(ref myIP, i + 1); //i+1個大小，i初始是0
                    myIP[i] = ip.ToString();    //第i個ip
                    //Console.WriteLine(myIP[i]);
                    i++;
                }
            }
            return myIP;
        }
    }
}
