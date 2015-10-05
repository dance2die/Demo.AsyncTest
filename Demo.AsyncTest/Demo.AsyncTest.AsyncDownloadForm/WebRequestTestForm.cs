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

		private async void processButton_Click(object sender, EventArgs e)
		{

		}
	}
}
