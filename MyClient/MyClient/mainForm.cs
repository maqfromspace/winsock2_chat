using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
namespace MyClient
{
    public partial class mainForm : Form
    {
        static private Socket Client;
        private IPAddress ip = null;
        private int port = 0;
        private Thread th;
        public mainForm()
        {
            InitializeComponent();
            sendBox.Enabled = false;
            sendButton.Enabled = false;
            try
            {
                var info = new StreamReader(@"client_info/data.txt");
                string buffer = info.ReadToEnd();
                info.Close();
                string[] connect_info = buffer.Split(':');
                ip = IPAddress.Parse(connect_info[0]);
                port = int.Parse(connect_info[1]);
                setupLabel.ForeColor = Color.Green;
                setupLabel.Text = "Настройки сохранены \nIP: " + connect_info[0] + "\nПорт: " + connect_info[1];

            }
            catch (Exception ex)
            {
                setupLabel.ForeColor = Color.Red;
                setupLabel.Text = "Настройки не найдены!";
                Form2 form = new Form2();
                form.Show();
            }
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Form2();
            form.Show();
        }
        //отправляем набор битов
        void SendMessage(string message)
        {
            if (message != "")
            {
                byte[] buffer = new byte[1024];
                buffer = Encoding.UTF8.GetBytes(message);
                Client.Send(buffer);
            }
        }
        void RecvMessage()
        {
            byte[] buffer = new byte[1024];
            for (int i = 0; i < buffer.Length; i++)
                buffer[i] = 0;
            for (;;)
                try
                {
                    Client.Receive(buffer);
                    string message = Encoding.UTF8.GetString(buffer);
                    int count = message.IndexOf(";;;5");
                    if (count == -1) continue;
                    string clean_message = "";
                    for (int i = 0; i < count; i++)
                    {
                        clean_message += message[i];
                    }
                    for (int i = 0; i < buffer.Length; i++)
                    {
                        buffer[i] = 0;
                    }
                    this.Invoke((MethodInvoker)delegate ()
                    {
                        ChatBox.AppendText(clean_message);
                    });
                }
                catch (Exception ex) { }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (nameBox.Text == "")
            {
                MessageBox.Show("Вы должны ввести ник.", "Внимание!", MessageBoxButtons.OK);
            }
            else
            {
                nameBox.Enabled = false;
                enterButton.Enabled = false;
                sendButton.Enabled = true;
                sendBox.Enabled = true;
                
                Client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                if (ip != null) Client.Connect(ip, port);
                th = new Thread(RecvMessage);//ПОТОК ПРИНИМАЮЩИЙ СООБЩЕНИЯ ОТ СЕРВЕРА          
                th.Start();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendMessage("\n" + nameBox.Text + ": " + sendBox.Text + ";;;5");
            sendBox.Clear();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (th != null) th.Abort();
            Application.Exit();
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SendMessage("\n" + nameBox.Text + " отключился от чата." + ";;;5");
            th.Abort();
            Application.Exit();
        }     

        private void sendBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendMessage(nameBox.Text + ": " + sendBox.Text + ";;;5");
                sendBox.Clear();
            }
        }

        private void ChatBox_TextChanged(object sender, EventArgs e)
        {
            ChatBox.ScrollToCaret();
        }
    }
}
