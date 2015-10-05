using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

		}
	}
}
