using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace MyClient
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        

        private void saveSetupButton_Click(object sender, EventArgs e)
        {
            if (ipBox.Text != "" && ipBox.Text != " ")
            {
                try
                {
                    DirectoryInfo data = new DirectoryInfo("client_info");
                    data.Create();

                    var sw = new StreamWriter(@"client_info/data.txt");
                    sw.WriteLine(ipBox.Text + ":" + portBox.Text);
                    sw.Close();

                    this.Hide();
                    Application.Restart();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }
    }
}
