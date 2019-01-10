using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Quadient.DataServices.Model.Etl;

namespace Quadient.DataServices.Api.Etl
{
	internal class EtlServiceTable : IEtlServiceTable
	{
		private readonly IClient _client;
		private readonly string _tableId;
		private IList<string> _columnNames;
		public EtlServiceTable(IClient client, string tableId) : this(client, tableId, null) { }
		public EtlServiceTable(IClient client, string tableId, IList<string> columnNames)
		{
			_client = client;
			_tableId = tableId;
			_columnNames = columnNames;
		}
		public string TableId => _tableId;
		public Task DeleteTable()
		{
			return _client.Execute(new TableDeleteRequest(_tableId));
		}
		public Task<TableUpdateResponse> AppendFile(string sourceFile)
		{
			return _client.Execute(new TableAppendFileUploadRequest(_tableId, sourceFile));
		}
		public Task<TableUpdateResponse> AppendRecords(IEnumerable<IList<string>> records)
		{
			return _client.Execute(new TableAppendRecordsRequest(_tableId, records));
		}
		public Task<TableUpdateResponse> AppendStream(string fileName, Stream stream)
		{
			return _client.Execute(new TableAppendFileUploadRequest(_tableId, fileName, stream));
		}
		public Task DeletePage(string pageId)
		{
			return _client.Execute(new TablePageDeleteRequest(_tableId, pageId));
		}
		public Task<Stream> DownloadAsCsv()
		{
			return _client.Execute(new TableDownloadAsCsvRequest(_tableId));
		}
		public Task<Stream> DownloadAsCsv(bool includeHeader, char separator, char quote, char escape)
		{
			return _client.Execute(new TableDownloadAsCsvRequest(_tableId, includeHeader, separator, quote, escape));
		}
		public async Task<IList<string>> GetColumnNames()
		{
			if (_columnNames == null)
			{
				_columnNames = (await GetTableInformation(true, false)).ColumnNames;
			}
			return _columnNames;
		}
		public Task<TablePage> GetPage(string pageId)
		{
			return _client.Execute(new TablePageRequest(_tableId, pageId));
		}
		public async Task<IList<string>> GetPageIds()
		{
			return (await GetTableInformation(false, true)).PageIds;
		}
		private async Task<TableInformation> GetTableInformation(bool retrieveColumns, bool retrievePages)
		{
			return await _client.Execute(new TableInformationRequest(_tableId, retrieveColumns, retrievePages));
		}
	}
}
