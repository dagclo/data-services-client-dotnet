using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Quadient.DataServices.Model.Etl;

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

		public async Task<IEtlServiceFile> CreateFile(string fileName, Stream sourceStream)
		{
			var resp = await _client.Execute(new FileUploadRequest(fileName, sourceStream));
			return new EtlServiceFile(_client, resp.FileId);
		}

		public async Task<IEtlServiceTable> CreateTable(IList<string> columnNames)
		{
			var resp = await _client.Execute(new TableCreationSchemaRequest(columnNames));
			return CreateTableFromResponse(resp);
		}

		public async Task<IEtlServiceTable> CreateTable(string fileName, Stream sourceStream)
		{
			var resp = await _client.Execute(new TableCreationFileUploadRequest(fileName, sourceStream));
			return CreateTableFromResponse(resp);
		}

		public async Task<IEtlServiceTable> CreateTable(string sourceFile)
		{
			var resp = await _client.Execute(new TableCreationFileUploadRequest(sourceFile));
			return CreateTableFromResponse(resp);
		}

		public Task DeleteFile(string fileId)
		{
			return new EtlServiceFile(_client, fileId).DeleteFile();
		}

		public Task DeleteTable(string tableId)
		{
			return new EtlServiceTable(_client, tableId).DeleteTable();
		}

		public Task<IEtlServiceFile> GetFile(string fileId)
		{
			return Task.FromResult<IEtlServiceFile>(new EtlServiceFile(_client, fileId));
		}

		public Task<IEtlServiceTable> GetTable(string tableId)
		{
			return Task.FromResult<IEtlServiceTable>(new EtlServiceTable(_client, tableId));
		}
		private IEtlServiceTable CreateTableFromResponse(TableInformation resp)
		{
			var tableId = resp.TableId;
			var columnNamesInResponse = resp.ColumnNames;
			return new EtlServiceTable(_client, tableId, columnNamesInResponse);
		}

	}
}
