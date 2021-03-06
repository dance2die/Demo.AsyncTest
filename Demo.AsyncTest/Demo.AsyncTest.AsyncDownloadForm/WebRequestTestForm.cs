﻿using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo.AsyncTest.AsyncDownloadForm
{
	public partial class WebRequestTestForm : Form
	{
		public WebRequestTestForm()
		{
			InitializeComponent();
		}

		private void closeButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		/// <remarks>
		/// Create asynchronous versions of WebRequest/Response methods using following links.
		/// <see cref="https://www.google.com/webhp?sourceid=chrome-instant&ion=1&espv=2&es_th=1&ie=UTF-8#q=task.factory.fromasync%20webrequest&es_th=1"/>
		/// <see cref="http://stackoverflow.com/a/23004036/4035"/>
		/// <see cref="http://stackoverflow.com/a/14098942/4035"/>
		/// <see cref="http://stackoverflow.com/q/17664191/4035"/>
		/// </remarks>
		private async void processButton_Click(object sender, EventArgs e)
		{
			resultTextBox.Text = string.Empty;
			const string postdata = "test";

			byte[] data = GetDataBytes(postdata);
			HttpWebRequest request = GetPostWebRequest(data);

			await WriteDataToRequestStream(request, data);
			await SendResponse(request);
		}

		private async Task SendResponse(HttpWebRequest request)
		{
			using (HttpWebResponse response = (HttpWebResponse) await Task.Factory.FromAsync<WebResponse>(
				request.BeginGetResponse, request.EndGetResponse, request))
			using (Stream responseStream = response.GetResponseStream())
			using (StreamReader reader = new StreamReader(responseStream))
			{
				string content = await reader.ReadToEndAsync();
				resultTextBox.Text = content;
			}
		}

		private async Task WriteDataToRequestStream(HttpWebRequest request, byte[] data)
		{
			using (Stream requestStream = await Task<Stream>.Factory.FromAsync(
				request.BeginGetRequestStream, request.EndGetRequestStream, request))
			{
				await requestStream.WriteAsync(data, 0, data.Length);
			}
		}

		private HttpWebRequest GetPostWebRequest(byte[] data)
		{
			HttpWebRequest request = WebRequest.Create("http://www.stackoverflow.com") as HttpWebRequest;
			request.ContentLength = data.Length;
			request.Method = "POST";
			return request;
		}

		private byte[] GetDataBytes(string data)
		{
			return Encoding.UTF8.GetBytes(data);
		}
	}
}
