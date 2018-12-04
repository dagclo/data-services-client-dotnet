using System.IO;
using System.Threading.Tasks;
using Quadient.DataServices.Model.Etl;

namespace Quadient.DataServices.Api.Etl
{
	public interface IEtlServiceFile
	{
		string FileId { get; }
		Task<FileInformation> GetFileInformation();
		Task<Stream> Download();
		Task<IEtlServiceTable> TransformToTable(bool deleteFile);
		Task<IEtlServiceTable> TransformToTable(TransformRequest transformRequest);
		Task DeleteFile();
	}
}