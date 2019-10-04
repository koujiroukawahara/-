using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace tool
{
	public partial class Add : Form
	{
		bool IsPriveNumber = false;

		public Add()
		{
			InitializeComponent();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			if (IsPriveNumber)
			{
				MySqlConnection cn = new MySqlConnection("Data Source=localhost;Database = test;User Id = root;Password = Koujirou6;");

				int PriceValue = int.Parse(this.Price.Text);
				Console.WriteLine(PriceValue);

				//コマンドの作成

				MySqlCommand MySqlCommand = new MySqlCommand(String.Format("INSERT INTO `test`.`usedlist` (`Bought`, `Price`) VALUES('{0}', {1});", this.Bought.Text, PriceValue), cn);
				MySqlCommand.Connection.Open();
				MySqlCommand.ExecuteNonQuery();
				MySqlCommand.Connection.Close();

				this.Bought.Text = "";
				this.Price.Text = "";

				var frmMenu = new Menu();
				frmMenu.Show();
			}
		}


		private void Price_Validating(object sender, CancelEventArgs e)
		{
			if (!Price.Text.All(char.IsDigit))
			{
				this.errorProvider1.SetError(this.Price, "数値を入力してください");
				IsPriveNumber = false;
			}
			else
			{
				this.errorProvider1.SetError(this.Price, string.Empty);
				IsPriveNumber = true;
			}
		}
	}
}