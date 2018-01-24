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

namespace Secure_P2P_project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
                                   
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form1.IPinfo = IP.Text;
            Form1.PORTinfo = Port.Text;
            MessageBox.Show("IP : " + Form1.IPinfo+ "\r"+"Port : "+Form1.PORTinfo);

          

            


        }
    }
}
