using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Quadient.DataServices.Api.Etl;
using Quadient.DataServices.Model.UsBatch;

namespace Quadient.DataServices.Api.WalkSequence
{
	internal class WalkSequenceJobSession : IWalkSequenceJobSession
	{
		private readonly IClient _client;
		private RecordTables tables;
		public WalkSequenceJobSession(IClient client, WalkSequenceJob job) : this(client, job.JobId) {}
		public WalkSequenceJobSession(IClient client, JobSummary resp): this(client, resp.JobId) {}
		public WalkSequenceJobSession(IClient client, string jobId)
		{
			_client = client;
			JobId = jobId;
		}
		public string JobId { get; }
		public Task<Records> DownloadRecords(string pageId)
		{
			return _client.Execute(new GetWalkSequenceRecords(JobId, pageId));
		}
		public Task<RecordPages> GetInputRecordPages()
		{
			var kind = GetWalkSequenceRecordPages.RecordKind.input;
			return _client.Execute(new GetWalkSequenceRecordPages(JobId, kind));
		}
		public Task<IEtlServiceTable> GetInputTable()
		{
			return GetTableInternal("input");
		}
		public Task<JobSummary> GetJobSummary()
		{
			return _client.Execute(new GetWalkSequenceJobStatus(JobId));
		}
		public Task<RecordPages> GetOutputRecordPages()
		{
			var kind = GetWalkSequenceRecordPages.RecordKind.output;
			return _client.Execute(new GetWalkSequenceRecordPages(JobId, kind));
		}
		public Task<IEtlServiceTable> GetOutputTable()
		{
			return GetTableInternal("output");
		}
		private async Task<IEtlServiceTable> GetTableInternal(string role)
		{
			var tables = await GetRecordTables();
			foreach (RecordTable table in tables.Tables)
			{
				if (string.Equals(role, table.Role, StringComparison.OrdinalIgnoreCase)) {
					return new EtlServiceTable(_client, table.Id);
				}
			}
			throw new ArgumentException("No table with role '" + role + "'");
		}
		public async Task<RecordTables> GetRecordTables()
		{
			if (tables == null)
			{
				var req = SimpleRequest<RecordTables>.Get($"{WalkSequenceClient.BASE_PATH}/jobs/{JobId}/records/tables");
				tables = await _client.Execute(req);
			}
			return tables;
		}
		public Task Run()
		{
			return _client.Execute(new RunWalkSequenceJob(JobId));
		}
		public Task UploadRecords(IEnumerable<IList<string>> records)
		{
			return _client.Execute(new AddWalkSequenceRecords(JobId, records));
		}
	}
}
