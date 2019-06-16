using SignalR.Common.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SingnalR.NoughtsAndCrosses.WinFormsClient
{
    public partial class NaCClientForm : Form
    {

        private const string _connectionString = "https://localhost:5001/NoughtsAndCrosses";
        //private static HubConnection _hubConnection;
        private static List<Table> _tables;

        public NaCClientForm()
        {
            InitializeComponent();
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {

        }
    }
}
