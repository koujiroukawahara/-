namespace tool
{
	partial class Modify
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
			this.Number = new System.Windows.Forms.TextBox();
			this.ModifyEnter = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.NumberLavel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// Number
			// 
			this.Number.Location = new System.Drawing.Point(325, 167);
			this.Number.Name = "Number";
			this.Number.Size = new System.Drawing.Size(100, 19);
			this.Number.TabIndex = 1;
			this.Number.Validating += new System.ComponentModel.CancelEventHandler(this.Number_Validating);
			// 
			// ModifyEnter
			// 
			this.ModifyEnter.Location = new System.Drawing.Point(492, 328);
			this.ModifyEnter.Name = "ModifyEnter";
			this.ModifyEnter.Size = new System.Drawing.Size(191, 64);
			this.ModifyEnter.TabIndex = 3;
			this.ModifyEnter.Text = "修正";
			this.ModifyEnter.UseVisualStyleBackColor = true;
			this.ModifyEnter.Click += new System.EventHandler(this.ModifyEnter_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// NumberLavel
			// 
			this.NumberLavel.AutoSize = true;
			this.NumberLavel.Location = new System.Drawing.Point(211, 170);
			this.NumberLavel.Name = "NumberLavel";
			this.NumberLavel.Size = new System.Drawing.Size(87, 12);
			this.NumberLavel.TabIndex = 2;
			this.NumberLavel.Text = "修正するNumber";
			// 
			// Modify
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.ModifyEnter);
			this.Controls.Add(this.NumberLavel);
			this.Controls.Add(this.Number);
			this.Name = "Modify";
			this.Text = "Modify";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox Number;
		private System.Windows.Forms.Button ModifyEnter;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Label NumberLavel;
	}
}