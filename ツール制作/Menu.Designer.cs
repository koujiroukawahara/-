namespace tool
{
	partial class Menu
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Table = new System.Windows.Forms.DataGridView();
			this.Add = new System.Windows.Forms.Button();
			this.Modify = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
			this.SuspendLayout();
			// 
			// Table
			// 
			this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Table.Location = new System.Drawing.Point(12, 12);
			this.Table.Name = "Table";
			this.Table.RowTemplate.Height = 21;
			this.Table.Size = new System.Drawing.Size(776, 361);
			this.Table.TabIndex = 0;
			// 
			// Add
			// 
			this.Add.Location = new System.Drawing.Point(79, 379);
			this.Add.Name = "Add";
			this.Add.Size = new System.Drawing.Size(194, 58);
			this.Add.TabIndex = 1;
			this.Add.Text = "記入";
			this.Add.UseVisualStyleBackColor = true;
			this.Add.Click += new System.EventHandler(this.Add_Click);
			// 
			// Modify
			// 
			this.Modify.Location = new System.Drawing.Point(519, 379);
			this.Modify.Name = "Modify";
			this.Modify.Size = new System.Drawing.Size(209, 59);
			this.Modify.TabIndex = 2;
			this.Modify.Text = "修正";
			this.Modify.UseVisualStyleBackColor = true;
			this.Modify.Click += new System.EventHandler(this.Modify_Click);
			// 
			// Menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.Modify);
			this.Controls.Add(this.Add);
			this.Controls.Add(this.Table);
			this.Name = "Menu";
			this.Text = "Menu";
			((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView Table;
		private System.Windows.Forms.Button Add;
		private System.Windows.Forms.Button Modify;
	}
}