using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Npgsql;



namespace AppConfig
{
    public partial class EditAppConfig : Form
    {
        public EditAppConfig()
        {
            InitializeComponent();
        }
        
                private void EditAppConfig_Load(object sender, EventArgs e)
                {
                    string str = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;
                    textBoxServer.Text = str.Split('=', ';')[1];
                    textBoxPort.Text = str.Split('=', ';')[3];
                    textBoxUserID.Text = str.Split('=', ';')[5];
                    textBoxPassword.Text = str.Split('=', ';')[7];
                    textBoxDatabase.Text = str.Split('=', ';')[9];
                    labelInfo.Text = " Системное сообщение: конфигурация загружена";
                }

                private void buttonSave_Click(object sender, EventArgs e)
                {
            
                    string connectionString = string.Format("Server={0}; port={1}; user id={2}; password={3}; database={4};", textBoxServer.Text, textBoxPort.Text, textBoxUserID.Text, textBoxPassword.Text, textBoxDatabase.Text);
                    try
                    {
                Connection conn = new Connection();
                        //Connection connection = new Connection(connectionString);
                        if (conn.isConnection)
                        {
                            Config setting = new Config();
                            setting.SaveConnectionString("Database", connectionString);
                            labelInfo.Text = " Системное сообщение: конфигурация сохранена";
                        }
                    }
                    catch (Exception ex)
                    {
                        labelInfo.Text = " Системное сообщение: конфигурация недоступна";
                    }
            
                }

                private void buttonTest_Click(object sender, EventArgs e)
                {
           
                    string connectionString = string.Format("Server={0}; port={1}; user id={2}; password={3}; database={4};", textBoxServer.Text, textBoxPort.Text, textBoxUserID.Text, textBoxPassword.Text, textBoxDatabase.Text);
                    try
                    {
                        Connection conn = new Connection();
                        if (conn.isConnection)
                            labelInfo.Text = " Системное сообщение: успешное подключение";
                    }
                    catch (Exception ex)
                    {
                        labelInfo.Text = " Системное сообщение: ошика подключения";
                    }
    
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
