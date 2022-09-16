namespace Ex3
{
	partial class Tragaperras
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.play = new System.Windows.Forms.Button();
			this.lblInfo = new System.Windows.Forms.Label();
			this.lblMoney = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Enabled = false;
			this.textBox1.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textBox1.Location = new System.Drawing.Point(195, 115);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 64);
			this.textBox1.TabIndex = 0;
			// 
			// textBox2
			// 
			this.textBox2.Enabled = false;
			this.textBox2.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textBox2.Location = new System.Drawing.Point(345, 115);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 64);
			this.textBox2.TabIndex = 1;
			// 
			// textBox3
			// 
			this.textBox3.Enabled = false;
			this.textBox3.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textBox3.Location = new System.Drawing.Point(497, 115);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 64);
			this.textBox3.TabIndex = 2;
			this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			// 
			// play
			// 
			this.play.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.play.Location = new System.Drawing.Point(302, 233);
			this.play.Name = "play";
			this.play.Size = new System.Drawing.Size(185, 69);
			this.play.TabIndex = 3;
			this.play.Text = "PLAY";
			this.play.UseVisualStyleBackColor = true;
			this.play.Click += new System.EventHandler(this.onClickPlay);
			// 
			// lblInfo
			// 
			this.lblInfo.AutoSize = true;
			this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblInfo.Location = new System.Drawing.Point(227, 352);
			this.lblInfo.Name = "lblInfo";
			this.lblInfo.Size = new System.Drawing.Size(341, 37);
			this.lblInfo.TabIndex = 4;
			this.lblInfo.Text = "¡Dale al play para empezar!";
			// 
			// lblMoney
			// 
			this.lblMoney.AutoSize = true;
			this.lblMoney.Location = new System.Drawing.Point(21, 24);
			this.lblMoney.Name = "lblMoney";
			this.lblMoney.Size = new System.Drawing.Size(113, 15);
			this.lblMoney.TabIndex = 5;
			this.lblMoney.Text = "Crédito actual = 50€";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(669, 16);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(106, 23);
			this.button1.TabIndex = 6;
			this.button1.Text = "Añadir saldo";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.addMoneyOnClick);
			// 
			// Tragaperras
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lblMoney);
			this.Controls.Add(this.lblInfo);
			this.Controls.Add(this.play);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Name = "Tragaperras";
			this.Text = "Tragaperras";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private TextBox textBox1;
		private TextBox textBox2;
		private TextBox textBox3;
		private Button play;
		private Label lblInfo;
		private Label lblMoney;
		private Button button1;
	}
}