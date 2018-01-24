using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.Net;
using System.Collections;
using System.IO;
using System.Security.Cryptography;


//git commit Test 2018.1.24
// 바이러스토탈 API키 23964f80447c21a81c6bf9588d28387041a1b15ec6f778544d008f206644b15d

namespace Secure_P2P_project
{
    public partial class Form1 : Form
    {
        public static String IPinfo;
        public static String PORTinfo;
        public static String FilePath;
        public static String FileName;
        Socket mySocket;
        
        IPAddress serverIP;
        int serverPort;
        IPEndPoint point;

        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            configIMG.BackgroundImage = Properties.Resources._1;
        }

        private void configIMG_MouseUp(object sender, MouseEventArgs e)
        {
            configIMG.BackgroundImage = Properties.Resources._0;
        }

        private void pictureBox1_MouseDown_1(object sender, MouseEventArgs e)
        {
            shieldIMG.BackgroundImage = Properties.Resources.shiled1;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            shieldIMG.BackgroundImage = Properties.Resources.shiled0;
        }


        private void FileSend_MouseDown_1(object sender, MouseEventArgs e)
        {
            FileSend.BackgroundImage = Properties.Resources.FileSend1;
        }

        private void FileSend_MouseUp(object sender, MouseEventArgs e)
        {
            FileSend.BackgroundImage = Properties.Resources.FileSend;
        }

        private void configIMG_Click(object sender, EventArgs e)
        {

            Form2 Form2 = new Form2();
            Form2.Show();


        }


        private void ConnectBtn_Click(object sender, EventArgs e)
        {

            serverIP = IPAddress.Parse(IPinfo);
            serverPort = Convert.ToInt32(PORTinfo);


            // 클라이언트 소켓 생성 
            mySocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            // 서버와 연결 
            mySocket.Connect(serverIP, 8192);
            ConnectCheck.Text = "Connect";


        }

        private void FileFind_Click(object sender, EventArgs e)
        {

            string fileName = string.Empty;

            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory + "\\XmlData\\";
                dlg.Filter = "텍스트파일 (*.*)|*.*|모든파일 (*.*)|*.*";
                dlg.FilterIndex = 1;
                dlg.RestoreDirectory = true;

                if (dlg.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                FilePath = dlg.FileName;

            }



        }

        private void FileSend_Click(object sender, EventArgs e)
        {
            FileName = Path.GetFileName(FilePath);
            string sendString = FileName;
            byte[] sendBuffer = Encoding.UTF8.GetBytes(sendString);

            mySocket.Send(sendBuffer);


            // 파일을 엶 
            FileStream fileStr = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
            // 파일 크기를 가져옴 
            int fileLength = (int)fileStr.Length;
            // 파일 크기를 서버에 전송하기 위해 바이트 배열로 변환 
            byte[] buffer = BitConverter.GetBytes(fileLength);
            // 파일 크기 전송 
            mySocket.Send(buffer);


            // 파일을 보낼 횟수 
            int count = fileLength / 1024 + 1;
            // 파일을 읽기 위해 BinaryReader 객체 생성 
            BinaryReader reader = new BinaryReader(fileStr);

            // 파일 송신 작업 
            for (int i = 0; i < count; i++)
            {

                // 파일을 읽음 
                buffer = reader.ReadBytes(1024);
                // 읽은 파일을 서버로 전송 
                mySocket.Send(buffer);
            }



            // 종료 작업 
            reader.Close();
            mySocket.Close();

        }


        private void shieldIMG_Click(object sender, EventArgs e)

        {
            //String name = System.Windows.Forms.Application.ExecutablePath;

            String name = System.IO.Directory.GetCurrentDirectory();
            FilePath = name+"\\"+FileName;
            backgroundWorker1.RunWorkerAsync(name+"\\"+FileName);
            
        }

        private void backgroundWorker1_DoWork_1(object sender, DoWorkEventArgs e)
        {
            
            string filePath = e.Argument.ToString();
            byte[] buffer;
            int bytesRead;
            long size;
            long totalBytesRead = 0;

            using (Stream file = File.OpenRead(filePath))
            {
                size = file.Length;

                using (HashAlgorithm hasher = MD5.Create())
                {
                    do
                    {
                        buffer = new byte[4096];

                        bytesRead = file.Read(buffer, 0, buffer.Length);

                        totalBytesRead += bytesRead;

                        hasher.TransformBlock(buffer, 0, bytesRead, null, 0);


                    }
                    while (bytesRead != 0);

                    hasher.TransformFinalBlock(buffer, 0, 0);

                    e.Result = MakeHashString(hasher.Hash);
                }
            }
        }

        private static string MakeHashString(byte[] hashBytes)
        {
            
            StringBuilder hash = new StringBuilder(32);

            foreach (byte b in hashBytes)
                hash.Append(b.ToString("X2").ToLower());
            return hash.ToString();
        }

        private void backgroundWorker1_RunWorkerCompleted_1(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("전송받은 파일의 해쉬값 : \r" + e.Result.ToString());
            MessageBox.Show("해당 해쉬값이 DB에 있는지 확인 중");
            richTextBox1.Clear();
            dataGridView1.Rows.Clear();
            Execute.ScanFile(FilePath, richTextBox1, dataGridView1);

            richTextBox1.ForeColor = Color.DarkBlue;
            richTextBox1.Text = "Scanning in Progress... Please wait!";

        }


    }


}
