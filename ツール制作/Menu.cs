using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tool
{
	public partial class Menu : Form
	{
		public Menu()
		{
			InitializeComponent();
			Table.DataSource = Connection.Load();
		}

		private void Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void Add_Click(object sender, EventArgs e)
		{
			var frmAdd = new Add();
			frmAdd.Show();
		}

		private void Modify_Click(object sender, EventArgs e)
		{
			var frmModify = new Modify();
			frmModify.Show();
		}		
	}
}
