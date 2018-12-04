using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Quadient.DataServices.Model.Etl;

namespace Quadient.DataServices.Api.Etl
{
	public interface IEtlServiceTable
	{
		string TableId { get; }
		Task<IList<string>> GetColumnNames();
		Task<IList<string>> GetPageIds();
		Task<TableUpdateResponse> AppendFile(string file);
		Task<TableUpdateResponse> AppendStream(Stream stream);
		Task<TableUpdateResponse> AppendRecords(IEnumerable<IList<string>> records);
		Task<TablePage> GetPage(string pageId);
		Task DeletePage(string pageId);
		Task DeleteTable();
		Task<Stream> DownloadAsCsv();
		Task<Stream> DownloadAsCsv(bool includeHeader, char separator, char quote, char escape);
	}
}
