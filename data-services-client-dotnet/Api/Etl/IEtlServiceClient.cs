using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Quadient.DataServices.Api.Etl
{
	/// <summary>
	/// Provides a client class that's useful for interacting with the ETL Service of Quadient Data Services.
	/// The ETL service deals with bulk of data and transformation hereof.
	/// </summary>
	public interface IEtlServiceClient
	{
		/// <summary>
		/// Creates a file in Quadient Data Services by uploading it from a local file.
		/// </summary>
		Task<IEtlServiceFile> CreateFile(string sourceFile);
		/// <summary>
		/// Creates a file in Quadient Data Services by uploading it from a stream of bytes.
		/// </summary>
		Task<IEtlServiceFile> CreateFile(Stream sourceStream);
		/// <summary>
		/// Gets an existing file in Quadient Data Services.
		/// </summary>
		Task<IEtlServiceFile> GetFile(string fileId);
		/// <summary>
		/// Deletes a file in Quadient Data Services.
		/// </summary>
		Task DeleteFile(string fileId);
		/// <summary>
		/// Creates an empty table in Quadient Data Services by defining it's schema (column names).
		/// </summary>
		Task<IEtlServiceTable> CreateTable(IList<string> columnNames);
		/// <summary>
		/// Creates a table in Quadient Data Services by uploading a stream of bytes to be interpreted as a data source of the table.
		/// </summary>
		Task<IEtlServiceTable> CreateTable(Stream sourceStream);
		/// <summary>
		/// Creates a table in Quadient Data Services by uploading a local file to be interpreted as a data source of the table.
		/// </summary>
		Task<IEtlServiceTable> CreateTable(string sourceFile);
		/// <summary>
		/// Gets an existing table in Quadient Data Services.
		/// </summary>
		Task<IEtlServiceTable> GetTable(string tableId);
		/// <summary>
		/// Deletes a table in Quadient Data Services.
		/// </summary>
		Task DeleteTable(string tableId);
	}
}
