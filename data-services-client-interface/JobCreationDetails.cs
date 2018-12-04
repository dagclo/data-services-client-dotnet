using System.Collections.Generic;

namespace Quadient.DataServices.Api
{
    public class JobCreationDetails
    {
        public string ParentJob { get; set; }
        public string Origin { get; set; }
        public IEnumerable<string> ExpectedServices { get; set; }
        public int? ExpectedRecordCount { get; set; }
        public IDictionary<string, object> AdditionalDetails { get; set; }
    }
}