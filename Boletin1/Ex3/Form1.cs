#define NOTPREMIO

namespace Ex3
{
	public partial class Tragaperras : Form
	{
		private int money = 50;
		public Tragaperras()
		{
			InitializeComponent();
		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void onClickPlay(object sender, EventArgs e)
		{
			Random random = new Random();
			textBox1.Text = random.Next(1, 8).ToString();
			textBox2.Text = random.Next(1, 8).ToString(); 
			textBox3.Text = random.Next(1, 8).ToString();

			if (Convert.ToInt32(textBox1.Text) == Convert.ToInt32(textBox2.Text) && Convert.ToInt32(textBox1.Text) == Convert.ToInt32(textBox3.Text))
			{
				lblInfo.Text = "¡Has ganado 20€!";
				money += 20;
			}
			else if (Convert.ToInt32(textBox1.Text) == Convert.ToInt32(textBox2.Text) || Convert.ToInt32(textBox1.Text) == Convert.ToInt32(textBox3.Text) || Convert.ToInt32(textBox2.Text) == Convert.ToInt32(textBox3.Text))
			{
				lblInfo.Text = "¡Has ganado 10€!";

#if (NOTPREMIO)
	money -= 5;

#else
	money += 5;

#endif
			}
			else
			{
				lblInfo.Text = "Has perdido.";
				money -= 2;
			}

			lblMoney.Text = "Crédito actual = " + money +"€";

		}

		private void addMoneyOnClick(object sender, EventArgs e)
		{
			money += 10;
			lblMoney.Text = "Crédito actual = " + money + "€";
		}
	}
}