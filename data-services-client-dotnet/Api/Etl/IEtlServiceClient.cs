using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Quadient.DataServices.Api.Etl
{
	public interface IEtlServiceClient
	{
		Task<IEtlServiceFile> CreateFile(string sourceFile);
		Task<IEtlServiceFile> CreateFile(Stream sourceStream);
		Task<IEtlServiceFile> GetFile(string fileId);

		Task deleteFile(string fileId);

		Task<IEtlServiceTable> CreateTable(IList<string> columnNames);

		Task<IEtlServiceTable> CreateTable(Stream sourceStream);
		Task<IEtlServiceTable> CreateTable(File sourceFile);

		Task<IEtlServiceTable> getTable(string tableId);

		Task deleteTable(string tableId);

	}

}