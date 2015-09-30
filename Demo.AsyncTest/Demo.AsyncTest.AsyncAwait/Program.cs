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
			//TestCustomAsyncMethod();

			TestCountTo();

			Console.Read();
		}

		private static void TestCountTo()
		{
			AsyncContext.Run(() => CountToAsync(100));
		}

		public async static Task CountToAsync(int upto = 10)
		{
			await Task.Run(() =>
			{
				for (int i = 0; i < upto; i++)
				{
					Console.WriteLine(i + 1);
				}
			});
		}

		private static void TestCustomAsyncMethod()
		{
			var text = AsyncContext.Run(GetSomeTextAsync);
			Console.WriteLine(text);
		}

		private static Task<string> GetSomeTextAsync()
		{
			// https://msdn.microsoft.com/en-us/library/hh873177(v=vs.110).aspx
			var tcs = new TaskCompletionSource<string>();
			tcs.SetResult("some text");

			return tcs.Task;
		}

		private static void TestResponseString()
		{
			var responseString = AsyncContext.Run(GetResponseStringAsync);
			Console.WriteLine(responseString);
		}

		private async static Task<string> GetResponseStringAsync()
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
