using System;
using System.Net;
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
			const string uri = "http://www.huffingtonpost.com/feeds/index.xml";

			resultTextBox.Text = string.Empty;

			//// http://www.dotnetperls.com/httpclient
			//using (var client = new HttpClient())
			//{
			//	using (HttpResponseMessage responseMessage = await client.GetAsync(uri))
			//	using (HttpContent content = responseMessage.Content)
			//	{
			//		await Task.Delay(3000);
			//		string result = await content.ReadAsStringAsync();
			//		resultTextBox.Text = result;
			//	}
			//}

			using (var webClient = new WebClient())
			{
				Task<string> task = webClient.DownloadStringTaskAsync(uri);
				await Task.Delay(4000);
				string value =await task;
				resultTextBox.Text = value;
			}
		}
	}
}
