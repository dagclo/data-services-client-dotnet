using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Quadient.DataServices.Model.Etl;

namespace Quadient.DataServices.Api.Etl
{
	/// <summary>
	/// Represents a remote table of data hosted on Quadient Data Services.
	/// </summary>
	public interface IEtlServiceTable
	{
		/// <summary>
		/// The unique ID of the table.
		/// </summary>
		string TableId { get; }
		/// <summary>
		/// Gets the names of the table's columns.
		/// </summary>
		Task<IList<string>> GetColumnNames();
		/// <summary>
		/// Gets a list of page IDs where each page represents a section of the table.
		/// </summary>
		Task<IList<string>> GetPageIds();
		/// <summary>
		/// Appends the contents of a local file's data to the table
		/// </summary>
		Task<TableUpdateResponse> AppendFile(string file);
		/// <summary>
		/// Appends the contents of a stream of data to the table
		/// </summary>
		Task<TableUpdateResponse> AppendStream(Stream stream);
		/// <summary>
		/// Appends records to the table
		/// </summary>
		Task<TableUpdateResponse> AppendRecords(IEnumerable<IList<string>> records);
		/// <summary>
		/// Gets the data contents of a particular page
		/// </summary>
		Task<TablePage> GetPage(string pageId);
		/// <summary>
		/// Deletes a page of data
		/// </summary>
		Task DeletePage(string pageId);
		/// <summary>
		/// Deletes the table
		/// </summary>
		Task DeleteTable();
		/// <summary>
		/// Downloads the complete table in CSV format
		/// </summary>
		Task<Stream> DownloadAsCsv();
		/// <summary>
		/// Downloads the complete table in CSV format
		/// </summary>
		Task<Stream> DownloadAsCsv(bool includeHeader, char separator, char quote, char escape);
	}
}
