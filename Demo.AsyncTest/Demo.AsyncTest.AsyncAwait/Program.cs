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
			//TestResponseString();

			TestCustomAsyncMethod();

			Console.Read();
		}

		private static void TestCustomAsyncMethod()
		{
			var text = AsyncContext.Run(GetSomeText);
			Console.WriteLine(text);
		}

		private static Task<string> GetSomeText()
		{
			// https://msdn.microsoft.com/en-us/library/hh873177(v=vs.110).aspx
			var tcs = new TaskCompletionSource<string>();
			tcs.SetResult("some text");

			return tcs.Task;
		}

		private static void TestResponseString()
		{
			var responseString = AsyncContext.Run(GetResponseString);
			Console.WriteLine(responseString);
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
