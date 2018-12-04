using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Quadient.DataServices.Model.Etl;

namespace Quadient.DataServices.Api.Etl
{
	public interface IEtlServiceTable
	{
		string TableId { get; }
		IList<string> GetColumnNames();
		IList<string> GetPageIds();
		Task<TableUpdateResponse> AppendFile(string file);
		Task<TableUpdateResponse> AppendStream(Stream stream);
		Task<TableUpdateResponse> AppendRecords(IList<IList<string>> records);
		Task<TablePage> GetPage(string pageId);
		Task DeletePage(string pageId);
		Task DeleteTable();
		Task<Stream> DownloadAsCsv();
		Task<Task> DownloadAsCsv(bool includeHeader, char separator, char quote, char escape);
	}
}