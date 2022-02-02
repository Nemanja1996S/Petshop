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
	public partial class CtrStart : UserControl
	{
		private Form1 form;
		private Client client;
		private City city;
		private PetShop selected;
		private DataProvider dataProvider = new DataProvider();
		private List<PetShop> shops;
		private List<String> tipoviUsluge = new List<String>(){"psi","macke","ribice","igracke","odeca"," *Svi u vasem gradu " };
		private CheckedListBox checkbox1;
		

		public CtrStart(Form1 form)
		{
			InitializeComponent();
			this.form = form;
			form.refreshClient();
			this.client = form.returnClient();
			this.city = dataProvider.getCity(this.client);
			this.shops = dataProvider.getAllCityPetShops(this.city);

			foreach (PetShop s in shops)
			{
				s.ocena = dataProvider.GetValue(s);
			}

			if (this.shops.Count == 0)
			{
				lbIn.Font = new Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				lbIn.Items.Add("There is no petshop in your city");
			}
			else
			{
				lbIn.Font = new Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				foreach (PetShop ser in shops)
				{
					lbIn.Items.Add(ser.name);
				}
			}

			foreach (String el in this.tipoviUsluge)
			{
				comboBox1.Items.Add(el);
			}
		}

		public void btnSort_Click(object sender, EventArgs e)
		{
			if (comboBox1.SelectedItem != null)
			{
				String tipUsluge = comboBox1.SelectedItem.ToString();
				this.shops.Clear();
				lbIn.Items.Clear();
				labela.Text = "";
				labela.Visible = false;
				this.panel1.Controls.Clear();
				btnAddRating.Visible = false;

				if (tipUsluge == " *Svi u vasem gradu ")
				{
					this.shops = dataProvider.getAllCityPetShops(this.city);
					lbIn.Font = new Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
					foreach (PetShop ser in shops)
					{
						lbIn.Items.Add(ser.name);
					}
				}
				else
				{
					this.shops = dataProvider.getPetShopByServiceType(tipUsluge);
					lbIn.Items.Clear();
					labela.Text = "";
					if (this.shops.Count == 0)
					{
						lbIn.Font = new Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						lbIn.Items.Add("There is no such petshop in your city");
					}
					else
					{
						lbIn.Font = new Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						foreach (PetShop ser in shops)
						{
							lbIn.Items.Add(ser.name);
						}
					}
				}
			}
		}

		public void LbIn_SelectedIndexChanged(object sender, EventArgs e)
		{
			btnAddRating.Visible = true;
			labela.Visible = true;
			if (lbIn.SelectedIndex != -1)
			{
				this.selected = shops[lbIn.SelectedIndex];
				this.selected.ocena = dataProvider.GetValue(this.selected);

				labela.Text = "Selected petshop:  \r"
									+ "\r       Ime:               " + selected.name
									+ "\r       Grad:             " +dataProvider.getCity1(selected)
									+ "\r       Adresa:         " + dataProvider.getPetShopsByAddress(selected)
									+ "\r       Telefon:        " + selected.telefon
									+ "\r       TipUsluge:      " + selected.tipUsluge
									+ "\r       Ocena:          " + selected.ocena;
				this.panel1.Controls.Clear();
				this.checkbox();
			}
	

		}

		public void checkbox()
		{
		 CheckedListBox checkedListBox1 = new CheckedListBox();

			checkedListBox1.CheckOnClick = true;
			checkedListBox1.BackColor =  System.Drawing.Color.Azure;
			checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			checkedListBox1.FormattingEnabled = true;
			checkedListBox1.Items.AddRange(new object[] {
			"10",
			"9",
			"8",
			"7",
			"6",
			"5"});
			checkedListBox1.Name = "checkedListBox1";
			checkedListBox1.Size = new System.Drawing.Size(60, 130);
			checkedListBox1.TabIndex = 6;
			checkedListBox1.SelectedIndexChanged += new EventHandler(this.SelectedIndexChanged_Click);

			this.checkbox1 = checkedListBox1;
			this.panel1.Controls.Add(checkedListBox1);
		}

		public void SelectedIndexChanged_Click(object sender, EventArgs e)
		{
			int index = checkbox1.SelectedIndex;
			int count = checkbox1.Items.Count;
			for (int k = 0; k < count; k++)
			{
				if (index != k)
				{
					checkbox1.SetItemChecked(k, false);
				}
			}
		}

		public void btnAddRating_Click(object sender, EventArgs e)
		{
			foreach (String s in checkbox1.CheckedItems)
			{ 
				dataProvider.CreateRating(this.selected, this.client, s);
				this.selected.ocena = dataProvider.GetValue(this.selected);
				labela.Text = "";
				labela.Text = "Selected petshop:  \r"
									+ "\r       Ime:               " + selected.name
									+ "\r       Grad:             " + dataProvider.getCity1(selected)
									+ "\r       Adresa:         " + dataProvider.getPetShopsByAddress(selected)
									+ "\r       Telefon:        " + selected.telefon
									+ "\r       TipUsluge:      " + selected.tipUsluge
									+ "\r       Ocena:          " + selected.ocena;
			}
		}

		private void btnAllCities_Click(object sender, EventArgs e)
		{
			this.panel1.Controls.Clear();
			this.shops = dataProvider.getAllPetShops();
			lbIn.Items.Clear();
			labela.Text = "";
			labela.Visible = false;
			btnAddRating.Visible = false;
			
			lbIn.Font = new Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			foreach (PetShop ser in shops)
			{
				lbIn.Items.Add(ser.name);
			}
			
		}

		
	}
}
