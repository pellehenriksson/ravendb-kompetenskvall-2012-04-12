using Raven.Client;
using Raven.Client.Document;
using RavenDbPresentation.Tests.Demo2.Indexes;

namespace RavenDbPresentation.Tests
{
	public abstract class RavenTestBase
	{
		protected static readonly IDocumentStore Store =
			new DocumentStore { Url = "http://localhost:8080", DefaultDatabase = "SalesPeople" }.Initialize();
	
		static RavenTestBase()
		{
			Raven.Client.Indexes.IndexCreation.CreateIndexes(typeof(SimpleIndexSamples).Assembly, Store);
		}
	}
}
