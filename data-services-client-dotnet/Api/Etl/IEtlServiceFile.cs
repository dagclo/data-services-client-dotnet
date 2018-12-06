using System.IO;
using System.Threading.Tasks;
using Quadient.DataServices.Model.Etl;

namespace Quadient.DataServices.Api.Etl
{
	/// <summary>
	/// Represents a remote file hosted in Quadient Data Services.
	/// </summary>
	public interface IEtlServiceFile
	{
		/// <summary>
		/// The unique ID of the file.
		/// </summary>
		string FileId { get; }
		/// <summary>
		/// Gets additional information about the file.
		/// </summary>
		Task<FileInformation> GetFileInformation();
		/// <summary>
		/// Downloads the byte contents of the file.
		/// </summary>
		Task<Stream> Download();
		/// <summary>
		/// Transforms the file into a table, assuming that there is a single table described in the file.
		/// </summary>
		Task<IEtlServiceTable> TransformToTable(bool deleteFile);
		/// <summary>
		/// Transforms the file into a table.
		/// </summary>
		Task<IEtlServiceTable> TransformToTable(TransformRequest transformRequest);
		/// <summary>
		/// Deletes the file.
		/// </summary>
		Task DeleteFile();
	}
}
