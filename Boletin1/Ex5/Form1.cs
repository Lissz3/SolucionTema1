namespace Ex5
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}



		private void OnClick(object sender, EventArgs e)
		{
			DialogResult option = MessageBox.Show("Cambiar t�tulo", "�Desea actualizar el t�tulo del formulario?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button4);

			if (option == DialogResult.Yes)
			{
				this.Text = textBox1.Text;

			}

		}
	}
}