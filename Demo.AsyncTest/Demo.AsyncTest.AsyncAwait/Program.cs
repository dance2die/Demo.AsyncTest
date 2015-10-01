using System;
using System.Net.Http;
using System.Threading.Tasks;
using Nito.AsyncEx;

namespace Demo.AsyncTest.AsyncAwait
{
	/// <summary>
	/// <see cref="http://blog.stephencleary.com/2012/02/async-and-await.html"/>
	/// </summary>
	public class Program
	{
		public static void Main(string[] args)
		{
			//TestResponseString();
			//TestCustomAsyncMethod();
			//TestCountTo();

			TestFirstToRespond();

			Console.Read();
		}

		private static void TestFirstToRespond()
		{
			AsyncContext.Run(async () =>
			{
				string firstToRespondAsync = await GetFirstToRespondAsync();
				Console.WriteLine(firstToRespondAsync);
			});
		}

		public static async Task<string> GetFirstToRespondAsync()
		{
			// Call two web services; take the first response.
			Task<string>[] tasks = { WebService1Async(), WebService2Async() };

			// Await for the first one to respond.
			Task<string> firstTask = await Task.WhenAny(tasks);

			// Return the result.
			return await firstTask;
		}

		private static async Task<string> WebService1Async()
		{
			await Task.Delay(1000);
			return nameof(WebService1Async);
		}

		private static async Task<string> WebService2Async()
		{
			await Task.Delay(100);
			return nameof(WebService2Async);
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
					Task.Delay(1000);
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
