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
	public partial class CtrAddPetShop : UserControl
	{
		private Form1 form;
		private DataProvider dataProvider = new DataProvider();
		private List<String> tipoviUsluge = new List<String>() { "psi", "macke", "ribice", "igracke", "odeca", " *Svi u vasem gradu " };
		public CtrAddPetShop(Form1 form)
		{
			InitializeComponent();
			this.form = form;

			foreach (String el in this.tipoviUsluge)
			{
				comboBox1.Items.Add(el);
			}
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			CtrLoginOrRegister ctr = new CtrLoginOrRegister(form);
			form.setUserControl(ctr);
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			String name, city, address, tipUsluge;
			int telefon;
			name = tbName.Text;
			city = tbCity.Text;
			address = tbAddress.Text;
			telefon = Int32.Parse(tbTelefon.Text);
		    tipUsluge = comboBox1.SelectedItem.ToString();

			PetShop c = new PetShop();
			c = dataProvider.CreatePetShop(name,telefon, tipUsluge);
			dataProvider.CreateCity(city);
			dataProvider.RelIn(c, city, address);
			MessageBox.Show(" Add petshop in database");

		}

		
	}
}
