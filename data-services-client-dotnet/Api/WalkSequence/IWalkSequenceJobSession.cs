using System.Collections.Generic;
using Quadient.DataServices.Api.Etl;
using Quadient.DataServices.Model.UsBatch;

namespace Quadient.DataServices.Api.WalkSequence
{
	public interface IWalkSequenceJobSession
	{
		string JobId { get; }
		void UploadRecords(IEnumerable<IList<string>> records);
		void Run();
		JobSummary GetJobSummary();
		IEtlServiceTable GetInputTable();
		IEtlServiceTable GetOutputTable();
		RecordTables GetRecordTables();
		RecordPages GetInputRecordPages();
		RecordPages GetOutputRecordPages();
		Records DownloadRecords(string pageId);
	}
}
