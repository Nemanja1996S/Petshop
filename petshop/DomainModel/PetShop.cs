using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petshop.DomainModel
{
	class PetShop
	{
		public int id { get; set; }
		public String name { get; set; }
		public int telefon { get; set; }
		public String tipUsluge { get; set; }
		public double ocena { get; set; }
	}
}
