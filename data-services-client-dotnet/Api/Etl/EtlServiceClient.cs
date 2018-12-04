using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Quadient.DataServices.Api.Etl
{
	public class EtlServiceClient : IEtlServiceClient
	{
		private readonly IClient _client;
		public EtlServiceClient(IClient client)
		{
			_client = client;
		}

		public async Task<IEtlServiceFile> CreateFile(string sourceFile)
		{
			var resp = await _client.Execute(new FileUploadRequest(sourceFile));
			return new EtlServiceFile(_client, resp.FileId);
		}

		public async Task<IEtlServiceFile> CreateFile(Stream sourceStream)
		{
			var resp = await _client.Execute(new FileUploadRequest(sourceStream));
			return new EtlServiceFile(_client, resp.FileId);
		}

		public async Task<IEtlServiceTable> CreateTable(IList<string> columnNames)
		{
			var resp = await _client.Execute(new TableCreationSchemaRequest(columnNames));
			var tableId = resp.TableId;
			var columnNamesInResponse = resp.ColumnNames;
			return new EtlServiceTable(_client, tableId, columnNamesInResponse);
		}

		public async Task<IEtlServiceTable> CreateTable(Stream sourceStream)
		{
			var resp = await _client.Execute(new TableCreationFileUploadRequest(sourceStream));
			var tableId = resp.TableId;
			var columnNamesInResponse = resp.ColumnNames;
			return new EtlServiceTable(_client, tableId, columnNamesInResponse);
		}

		public async Task<IEtlServiceTable> CreateTable(string sourceFile)
		{
			var resp = await _client.Execute(new TableCreationFileUploadRequest(sourceFile));
			var tableId = resp.TableId;
			var columnNamesInResponse = resp.ColumnNames;
			return new EtlServiceTable(_client, tableId, columnNamesInResponse);
		}

		public Task deleteFile(string fileId)
		{
			return new EtlServiceFile(_client, fileId).DeleteFile();
		}

		public Task deleteTable(string tableId)
		{
			return new EtlServiceTable(_client, tableId).DeleteTable();
		}

		public Task<IEtlServiceFile> GetFile(string fileId)
		{
			return Task.FromResult<IEtlServiceFile>(new EtlServiceFile(_client, fileId));
		}

		public Task<IEtlServiceTable> getTable(string tableId)
		{
			return Task.FromResult<IEtlServiceTable>(new EtlServiceTable(_client, tableId));
		}
	}
}
