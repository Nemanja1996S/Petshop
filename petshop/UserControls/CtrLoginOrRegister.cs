using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using petshop.DomainModel;

namespace petshop.UserControls
{
	public partial class CtrLoginOrRegister : UserControl
	{
		private Form1 form;
		private DataProvider dataProvider = new DataProvider();

		public CtrLoginOrRegister()
		{
			InitializeComponent();
		}

		public CtrLoginOrRegister(Form1 form)
		{
			InitializeComponent();

			this.form = form;

		}

		private void btnLogIn_Click(object sender, EventArgs e)
		{
			String user, pass;
			user = tbUsernameL.Text;
			pass = tbPasswordL.Text;
			if (!dataProvider.doesUsernameExist(user))
			{
				MessageBox.Show("Client whit this username doesent exist!");
			}
			else
			{
				Client c = new Client();
				c = dataProvider.getClientByUsername(user);
				if (!(c.password == pass))
				{
					MessageBox.Show("Wrong password!");
				}
				else
				{
					MessageBox.Show("Welcome to Pet Shop");
					form.LogIn(c);
				}
			}
		}

		private void btnRegister_Click(object sender, EventArgs e)
		{
			String name, user, pass, city;
			user = tbUsernameR.Text;
			pass = tbPasswordR.Text;
			name = tbNameR.Text;
			city = tbCity.Text;


			if (dataProvider.doesUsernameExist(user))
			{
				MessageBox.Show("This username is alredy taken!");
			}
			else if (user != "" && pass != "" && name != "" && city != "")
			{
				Client c = new Client();
				c = dataProvider.CreateClient(name, user, pass);
				dataProvider.CreateCity(city);
				dataProvider.RelLiveIn(c, city);
				MessageBox.Show(c.name + " Welcome to Pet Shop");
				form.LogIn(c);
			}
			else
			{
				MessageBox.Show("Some field is empty!");
			}

		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			CtrAddPetShop ctr = new CtrAddPetShop(form);
			form.setUserControl(ctr);
		}

		private void CtrLoginOrRegister_Load(object sender, EventArgs e)
		{

		}

		private void splitter2_SplitterMoved(object sender, SplitterEventArgs e)
		{

		}
	}
}
