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
	public partial class Modify : Form
	{
		bool IsNumber = false;

		public Modify()
		{
			InitializeComponent();
		}

		private void Number_TextChanged(object sender, EventArgs e)
		{

		}

		private void NumberLavel_Click(object sender, EventArgs e)
		{

		}

		private void ModifyEnter_Click(object sender, EventArgs e)
		{
			if (IsNumber)
			{
				int ID = int.Parse(this.Number.Text);

				MySqlConnection cn = new MySqlConnection("Data Source=localhost;Database = test;User Id = root;Password = Koujirou6;");

				MySqlCommand Command = new MySqlCommand(String.Format("DELETE FROM `test`.`usedlist` WHERE(`Number` = {0});", ID), cn);

				Command.Connection.Open();
				Command.ExecuteNonQuery();
				Command.Connection.Close();

				var frmMenu = new Menu();
				frmMenu.Show();
			}
		}

		private void Number_Validating(object sender, CancelEventArgs e)
		{
			if (!Number.Text.All(char.IsDigit))
			{
				this.errorProvider1.SetError(this.Number, "数値を入力してください");
				IsNumber = false;
			}
			else
			{
				this.errorProvider1.SetError(this.Number, string.Empty);
				IsNumber = true;
			}
		}

		private void Modify_Load(object sender, EventArgs e)
		{

		}
	}
}
