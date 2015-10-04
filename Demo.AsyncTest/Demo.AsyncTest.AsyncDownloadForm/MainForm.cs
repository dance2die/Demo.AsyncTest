using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo.AsyncTest.AsyncDownloadForm
{
	public partial class MainForm : Form
	{
		const string URI = "http://www.huffingtonpost.com/feeds/index.xml";

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
				Task<string> task = webClient.DownloadStringTaskAsync(URI);
				await Task.Delay(4000);
				string value =await task;
				resultTextBox.Text = value;
			}
		}

		private async void exceptionButton_Click(object sender, EventArgs e)
		{
			// http://www.dotnetperls.com/httpclient
			try
			{
				await SetResultTextBox();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private async Task SetResultTextBox()
		{
			using (var client = new HttpClient())
			{
				using (HttpResponseMessage responseMessage = await client.GetAsync(URI))
				using (HttpContent content = responseMessage.Content)
				{
					throw new Exception();
					await Task.Delay(3000);
					string result = await content.ReadAsStringAsync();
					resultTextBox.Text = result;
				}
			}
		}
	}
}
