using System;
using System.Threading.Tasks;
using Nito.AsyncEx;

namespace Demo.AsyncTest.AsyncSearcher
{
	/// <summary>
	/// To test solution on StackOverflow.
	/// <see cref="http://stackoverflow.com/a/32897068/4035"/>
	/// </summary>
	public class Program
	{
		public static void Main(string[] args)
		{
			Searcher searcher = new AnimeSearcher();
			Task<ISearchResponse> task = searcher.SearchAsync("Full metal panic");

			AsyncContext.Run(() => task).PrintSearchTerm();

			Console.Read();
		}
	}

	public interface ISearchResponse
	{
		void PrintSearchTerm();
	}

	public class AnimeSearchResponse : ISearchResponse
	{
		public string SearchTerm { get; set; }

		public AnimeSearchResponse(string searchTerm)
		{
			SearchTerm = searchTerm;
		}

		public void PrintSearchTerm()
		{
			Console.WriteLine(SearchTerm);
		}
	}

	public abstract class Searcher
	{
		public abstract ISearchResponse Search(string searchTerm);
		public abstract Task<ISearchResponse> SearchAsync(string searchTerm);
	}

	public class AnimeSearcher : Searcher
	{
		public override ISearchResponse Search(string searchTerm)
		{
			return new AnimeSearchResponse(searchTerm);
		}

		public async override Task<ISearchResponse> SearchAsync(string searchTerm)
		{
			Func<ISearchResponse> function = () => new AnimeSearchResponse(searchTerm);
			Task<ISearchResponse> task = Task.Run(function);
			return await task;
		}
	}
}
