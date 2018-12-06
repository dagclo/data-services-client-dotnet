using System.IO;
using System.Threading.Tasks;
using Quadient.DataServices.Model.Etl;

namespace Quadient.DataServices.Api.Etl
{
	internal class EtlServiceFile : IEtlServiceFile
	{
		private readonly IClient _client;
		private readonly string _fileId;

		public EtlServiceFile(IClient client, string fileId)
		{
			_client = client;
			_fileId = fileId;
		}

		public string FileId => _fileId;

		public Task DeleteFile()
		{
			return _client.Execute(new TableDeleteRequest(_fileId));
		}

		public Task<Stream> Download()
		{
			return _client.Execute(new FileDownloadRequest(_fileId));
		}

		public Task<FileInformation> GetFileInformation()
		{
			return _client.Execute(new FileInformationRequest(_fileId));
		}

		public Task<IEtlServiceTable> TransformToTable(bool deleteFile)
		{
			TransformRequest req = new TransformRequest(null, deleteFile, 0, null);
			return TransformToTable(req);
		}

		public async Task<IEtlServiceTable> TransformToTable(TransformRequest transformRequest)
		{
			var response = await _client.Execute(new FileTransformToTableRequest(_fileId, transformRequest));
			var tableId = response.TableId;
			var columnNames = response.ColumnNames;
			return new EtlServiceTable(_client, tableId, columnNames);
		}
	}
}
