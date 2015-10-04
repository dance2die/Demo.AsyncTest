using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo.AsyncTest.AsyncDownloadForm
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void closeButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		private async void downloadButton_Click(object sender, EventArgs e)
		{
			// http://www.dotnetperls.com/httpclient
			using (var client = new HttpClient())
			using (HttpResponseMessage responseMessage = await client.GetAsync("http://www.huffingtonpost.com/feeds/index.xml"))
			using (HttpContent content = responseMessage.Content)
			{
				await Task.Delay(5000);
				string result = await content.ReadAsStringAsync();
				resultTextBox.Text = result;
			}
		}
	}
}
