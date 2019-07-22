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


namespace ツール制作
{
	public partial class Add : Form
	{
		public Add()
		{
			InitializeComponent();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			MySqlConnection cn = new MySqlConnection("Data Source=localhost;Database = test;User Id = root;Password = Koujirou6;");

			//コマンドの作成

			MySqlCommand MySqlCommand = new MySqlCommand(String.Format("INSERT INTO `test`.`usedlist` (`Number`, `Bought`, `Price`) VALUES('{0}', {1}, '{2}');", this.Number.Text, this.Bought.Text, this.Price.Text), cn);
			MySqlCommand.Connection.Open();
			MySqlCommand.ExecuteNonQuery();
			MySqlCommand.Connection.Close();
		}

		private void Label3_Click(object sender, EventArgs e)
		{

		}

		private void Price_TextChanged(object sender, EventArgs e)
		{

		}


		private void Price_Validating(object sender, CancelEventArgs e)
		{
			if (!Price.Text.All(char.IsDigit))
			{
			this.errorProvider1.SetError(this.Price, "数値を入力してください");
			}
			else
			{
				this.errorProvider1.SetError(this.Price, string.Empty);
			}
		}

		private void Number_TextChanged(object sender, EventArgs e)
		{

		}

		private void Number_Validating(object sender, CancelEventArgs e)
		{
			if (!Number.Text.All(char.IsDigit))
			{
				this.errorProvider1.SetError(this.Number, "数値を入力してください");
			}
			else
			{
				this.errorProvider1.SetError(this.Number, string.Empty);
			}
		}

		private void Add_Load(object sender, EventArgs e)
		{

		}

		private void Label1_Click(object sender, EventArgs e)
		{

		}
	}
}