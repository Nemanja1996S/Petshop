using Neo4jClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using petshop.DomainModel;
using Neo4jClient.Cypher;

namespace petshop
{
	class DataProvider
	{
		private Uri uri;
		private GraphClient graphClient;


		public DataProvider()
		{
			graphClient = new GraphClient(new Uri("http://localhost:7474/db/data"), "neo4j", "1234567890");
			graphClient.Connect();
		}

		#region Client

		public Client CreateClient(String name, String username, String password)
		{

			//query koj izvrsavamo u bazi
			String queryText = "create (c:Client{name:'" +
									name + "', username:'" +
									username + "', password:'" +
									password + "'}) with(c) set c.id = id(c) return c";


			var query = new Neo4jClient.Cypher.CypherQuery(queryText, new Dictionary<string, object>(), CypherResultMode.Set);


			//rezultat izvrsenja bi trebalo da bude 1 klijent kojeg smo sad stvorili
			List<Client> clients = ((IRawGraphClient)graphClient).ExecuteGetCypherResults<Client>(query)
															.ToList();


			return clients[0];


		}

		//ispituje da li username za tog korisnika vec postoji true=vec postoji false=ne postoji
		public bool doesUsernameExist(String username)
		{
			String queryText = "match (n:Client) where n.username='" + username + "' return n";
			var query = new Neo4jClient.Cypher.CypherQuery(queryText, new Dictionary<string, object>(), CypherResultMode.Set);
			List<Client> clients = ((IRawGraphClient)graphClient).ExecuteGetCypherResults<Client>(query)
															.ToList();

			if (clients.Count == 0) return false;
			else return true;

		}


		public Client getClientByUsername(String username)
		{
			String queryText = "match (n:Client) where n.username='" + username + "' return n";
			var query = new Neo4jClient.Cypher.CypherQuery(queryText, new Dictionary<string, object>(), CypherResultMode.Set);
			List<Client> clients = ((IRawGraphClient)graphClient).ExecuteGetCypherResults<Client>(query)
															.ToList();


			if (clients.Count == 0)
			{
				Console.WriteLine("Query faild");
				return null;
			}
			else
			{
				Client client = clients[0];

				return client;
			}

		}
		#endregion

		#region City

		public void CreateCity(String name)
		{
			String queryText = "merge (c:City{name:'" + name + "'}) with(c) set c.id = id(c) return c";


			var query = new Neo4jClient.Cypher.CypherQuery(queryText, new Dictionary<string, object>(), CypherResultMode.Set);


			((IRawGraphClient)graphClient).ExecuteGetCypherResults<City>(query);
															
		}

		public City getCity(Client c)
		{
			String queryText = "match (n:Client)-[:LiveIn]->(s:City) where n.username='" + c.username+ "'   return s";

			var query = new Neo4jClient.Cypher.CypherQuery(queryText, new Dictionary<string, object>(), CypherResultMode.Set);

			List<City> citys = ((IRawGraphClient)graphClient).ExecuteGetCypherResults<City>(query)
															.ToList();
			return citys[0];

		}

		#endregion

		#region PetShops

		public PetShop CreatePetShop(String name, int telefon, String serviceType)
		{
			String queryText = "create (c:PetShop{name:'" +
									name + "', tipUsluge:'" +
									serviceType + "', telefon:"+
									telefon + "}) with(c) set c.id = id(c) return c";


			var query = new Neo4jClient.Cypher.CypherQuery(queryText, new Dictionary<string, object>(), CypherResultMode.Set);


			List<PetShop> shops = ((IRawGraphClient)graphClient).ExecuteGetCypherResults<PetShop>(query)
															.ToList();


			return shops[0];

		}

		public List<PetShop> getAllCityPetShops(City city)
		{
			String queryText = "match (s:PetShop)-[ :In]->( k:City) where k.name='" +city.name+ "' return s";
			var query = new Neo4jClient.Cypher.CypherQuery(queryText, new Dictionary<string, object>(), CypherResultMode.Set);
		    List<PetShop> shops = ((IRawGraphClient)graphClient).ExecuteGetCypherResults<PetShop>(query)
														.ToList();


			return shops;
		}

		public List<PetShop> getPetShopByServiceType(String tipUsluge)
		{
			String queryText = "match (s:PetShop) where s.tipUsluge='" + tipUsluge + "' return s";
			var query = new Neo4jClient.Cypher.CypherQuery(queryText, new Dictionary<string, object>(), CypherResultMode.Set);
			List<PetShop> shops = ((IRawGraphClient)graphClient).ExecuteGetCypherResults<PetShop>(query)
														.ToList();


			return shops;
		}

		public List<PetShop> getAllPetShops()
		{
			String queryText = "match (s:PetShop)  return s";
			var query = new Neo4jClient.Cypher.CypherQuery(queryText, new Dictionary<string, object>(), CypherResultMode.Set);
			List<PetShop> shops = ((IRawGraphClient)graphClient).ExecuteGetCypherResults<PetShop>(query)
														.ToList();


			return shops;
		}

		public String getPetShopsByAddress(PetShop shop)
		{
			String queryText = "match (s:PetShop)-[l:In]->(c:City) where s.name='"+shop.name+"'  return l.address";
			var query = new Neo4jClient.Cypher.CypherQuery(queryText, new Dictionary<string, object>(), CypherResultMode.Set);
			List<String> address = ((IRawGraphClient)graphClient).ExecuteGetCypherResults<String>(query).ToList();



			return address[0] ;
		}

		#endregion


		#region Relations

		public void RelLiveIn(Client c, String s)
		{

			String queryText = " match (c:Client),(s: City)" +
							 " where c.id= " + c.id + " and s.name='" + s +
							 "' merge (c)-[:LiveIn]->(s)";

			var query = new Neo4jClient.Cypher.CypherQuery(queryText, new Dictionary<string, object>(), CypherResultMode.Set);
			((IRawGraphClient)graphClient).ExecuteCypher(query);

		}
		public void RelIn(PetShop c, String city, String address)
		{
			String queryText = "match (c:PetShop),(s:City)" +
							" where c.id=" + c.id + " and s.name='" + city +
							"' merge (c)-[:In{address:'" + address + "'}]->(s)";

			var query = new Neo4jClient.Cypher.CypherQuery(queryText, new Dictionary<string, object>(), CypherResultMode.Set);
			((IRawGraphClient)graphClient).ExecuteCypher(query);
		}

		public void CreateRating(PetShop shop, Client klijent, String ocena)
		{
			String queryText = "match (s:PetShop),(c:Client)" +
						" where s.name='" + shop.name + "' and c.username='" + klijent.username +
						"' merge (c)-[r:Rated]->(s) set r.value='"+ocena+"'";

			var query = new Neo4jClient.Cypher.CypherQuery(queryText, new Dictionary<string, object>(), CypherResultMode.Set);
			((IRawGraphClient)graphClient).ExecuteCypher(query);
		}

		public double GetValue(PetShop shop)
		{
			String queryText = "match (c:Client)-[r:Rated]->(s:PetShop) where s.name='" + shop.name + "'  return r.value";
			var query = new Neo4jClient.Cypher.CypherQuery(queryText, new Dictionary<string, object>(), CypherResultMode.Set);
			List<String> ocene = ((IRawGraphClient)graphClient).ExecuteGetCypherResults<String>(query).ToList();

			int vrednost=0;

			foreach (String s in ocene)
			{
				vrednost += Int32.Parse(s);
			}

			double rez = 0;
			if (ocene.Count != 0)
			{
				rez = vrednost / ocene.Count;
			}

			return rez;
		}

		public string getCity1(PetShop shop)
		{
			String queryText = "match (s:PetShop)-[i:In]->(c:City) where s.id=" + shop.id + "   return c.name";

			var query = new Neo4jClient.Cypher.CypherQuery(queryText, new Dictionary<string, object>(), CypherResultMode.Set);

			List<String> citys = ((IRawGraphClient)graphClient).ExecuteGetCypherResults<String>(query)
															.ToList();
			return citys[0];
		}
	
		#endregion
	}
}
