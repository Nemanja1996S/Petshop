using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using petshop.DomainModel;
using petshop.UserControls;

namespace petshop
{
	public partial class Form1 : Form
	{
		private DataProvider dataProvider = new DataProvider();
		private Client client = new Client();

		public Form1()
		{
			InitializeComponent();

			CtrLoginOrRegister ctrlLogInOrRegister = new CtrLoginOrRegister(this);
			panel1.Controls.Clear();
			panel1.Controls.Add(ctrlLogInOrRegister);
		}

		public Client returnClient()
		{
			return this.client;
		}

		public void refreshClient()
		{
			this.client = dataProvider.getClientByUsername(client.username);
		}

		public void setUserControl(UserControl userControl)
		{
			panel1.Controls.Clear();
			panel1.Controls.Add(userControl);
		}

		public void LogIn(Client c)
		{
			this.client = c;
			this.refreshClient();

			btnLogOut.Visible = true;
			labelLogIn.Text = "Loged in as " + this.client.name;
			//labelLogIn.BackColor = white;
			
			this.LoadStartPage();
		}

		public void LoadStartPage()
		{
			CtrStart ctrlStart = new CtrStart(this);
			panel1.Controls.Clear();
			panel1.Controls.Add(ctrlStart);

		}

		public void LogOutClick(object sender, EventArgs e)
		{
			client = null;
			CtrLoginOrRegister ctrLoginOrRegister = new CtrLoginOrRegister(this);
			panel1.Controls.Clear();
			panel1.Controls.Add(ctrLoginOrRegister);
			labelLogIn.Text = "";
			btnLogOut.Visible = false;
		}

		private void labelLogIn_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
