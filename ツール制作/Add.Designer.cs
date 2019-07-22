namespace ツール制作
{
	partial class Add
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
			this.components = new System.ComponentModel.Container();
			this.Bought = new System.Windows.Forms.TextBox();
			this.Price = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
			this.SuspendLayout();
			// 
			// Bought
			// 
			this.Bought.Location = new System.Drawing.Point(209, 177);
			this.Bought.Name = "Bought";
			this.Bought.Size = new System.Drawing.Size(100, 19);
			this.Bought.TabIndex = 1;
			this.Bought.TextChanged += new System.EventHandler(this.Bought_TextChanged);
			// 
			// Price
			// 
			this.Price.Location = new System.Drawing.Point(551, 177);
			this.Price.Name = "Price";
			this.Price.Size = new System.Drawing.Size(100, 19);
			this.Price.TabIndex = 2;
			this.Price.TextChanged += new System.EventHandler(this.Price_TextChanged);
			this.Price.Validating += new System.ComponentModel.CancelEventHandler(this.Price_Validating);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(118, 180);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 12);
			this.label2.TabIndex = 4;
			this.label2.Text = "購入物";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(452, 180);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 12);
			this.label3.TabIndex = 5;
			this.label3.Text = "値段(数字)";
			this.label3.Click += new System.EventHandler(this.Label3_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(497, 360);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(180, 53);
			this.button1.TabIndex = 6;
			this.button1.Text = "追加";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// errorProvider2
			// 
			this.errorProvider2.ContainerControl = this;
			// 
			// Add
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Price);
			this.Controls.Add(this.Bought);
			this.Name = "Add";
			this.Text = "Add";
			this.Load += new System.EventHandler(this.Add_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox Bought;
		private System.Windows.Forms.TextBox Price;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.ErrorProvider errorProvider2;
	}
}