namespace MY_WINDOWS_FORMS_APPLICATION
{
	public partial class MainForm : System.Windows.Forms.Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, System.EventArgs e)
		{
		}

		private void ConvertButton_Click(object sender, System.EventArgs e)
		{
			Infrastructure.Documentation documentation =
				new Infrastructure.Documentation(source: sourceTextBox.Text);

			targetTextBox.Text = documentation.Result;
		}

		private void copyButton_Click(object sender, System.EventArgs e)
		{
			System.Windows.Forms.Clipboard.SetText(text: targetTextBox.Text);
		}
	}
}
