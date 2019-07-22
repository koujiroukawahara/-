using System.Configuration;
using System.Data;
using MySql.Data.MySqlClient;

namespace ツール制作
{
	static class Connection
	{
		public static readonly string Connectr;
		static Connection()
		{
			string str = ConfigurationManager.AppSettings["DBName"];
			Connectr = ConfigurationManager.ConnectionStrings[str].ConnectionString;
		}
		public static DataTable Load()
		{
			MySqlConnection con = new MySqlConnection(Connectr);

			con.Open();

			DataTable dt = new DataTable();



			MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM usedlist", con);

			da.Fill(dt);
			return dt;
		}

	}
}
