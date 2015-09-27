using System;
using System.Net.Http;
using System.Threading.Tasks;
using Nito.AsyncEx;

namespace Demo.AsyncTest.AsyncAwait
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var responseString = AsyncContext.Run(GetResponseString);

			Console.WriteLine(responseString);

			Console.Read();
		}

		private async static Task<string> GetResponseString()
		{
			var requestUri = new Uri("http://www.google.com");
			using (var client = new HttpClient())
			{
				var result = await client.GetStringAsync(requestUri);
				return result;
			}
		}
	}
}
