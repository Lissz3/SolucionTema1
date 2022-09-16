namespace Ex1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}


		private void button1_Click(object sender, EventArgs e)
		{
			double first = 0;
			double second = 0;
			try
			{
				first = Convert.ToDouble(textBox1.Text);
				second = Convert.ToDouble(textBox2.Text);
				
				label2.Text = "= "+ (first + second);

			}
			catch (FormatException)
			{
				
			}
			

		}
	}
}