using System.Threading.Tasks;

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

		}
	}

	public interface ISearchResponse
	{
		void Foo();
	}

	public class AnimeSearchResponse : ISearchResponse
	{
		public string SearchTerm { get; set; }

		public AnimeSearchResponse(string searchTerm)
		{
			SearchTerm = searchTerm;
		}

		public void Foo() { }
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
			return new AnimeSearchResponse(searchTerm);
		}
	}
}
