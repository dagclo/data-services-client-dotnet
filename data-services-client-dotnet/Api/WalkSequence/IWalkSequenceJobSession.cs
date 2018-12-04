using System.Collections.Generic;
using System.Threading.Tasks;
using Quadient.DataServices.Api.Etl;
using Quadient.DataServices.Model.UsBatch;

namespace Quadient.DataServices.Api.WalkSequence
{
	public interface IWalkSequenceJobSession
	{
		string JobId { get; }
		Task UploadRecords(IEnumerable<IList<string>> records);
		Task Run();
		Task<JobSummary> GetJobSummary();
		Task<IEtlServiceTable> GetInputTable();
		Task<IEtlServiceTable> GetOutputTable();
		Task<RecordTables> GetRecordTables();
		Task<RecordPages> GetInputRecordPages();
		Task<RecordPages> GetOutputRecordPages();
		Task<Records> DownloadRecords(string pageId);
	}
}
