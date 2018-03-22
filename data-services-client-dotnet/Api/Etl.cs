using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Quadient.DataServices.Model;
using Quadient.DataServices.Utility;

namespace Quadient.DataServices.Api
{
    internal class Etl: Service
    {
        protected Etl(Session session, Configuration configuration): base(session, configuration)
        {
            const string BaseUrl = "etl/v1/files/";
            const string GetTransformUrl = BaseUrl + "{0}/_transform";
            const string DeleteFileUrl = BaseUrl + "{0}";
            const string TableUrl = "etl/v1/tables/";
            const string DeleteTableUrl = TableUrl + "{0}";

            Task<FileInformation> UploadFile(Stream file, string fileName)
            {
                var content = new MultipartFormDataContent
                {
                    {new StreamContent(file), "upfile", fileName},
                };
                return Post<FileInformation>(BaseUrl, content);
            }

            Task<TransformResponse> GetTransform(string fileId,
                TransformRequest transformRequest)
            {
                return Post<TransformRequest, TransformResponse>(string.Format(GetTransformUrl, fileId),
                    transformRequest);
            }

            Task<TransformResponse> UploadTable(Stream file, string fileName)
            {
                var content = new MultipartFormDataContent
                {
                    {new StreamContent(file), "upfile", fileName},
                };
                return Post<TransformResponse>(TableUrl, content);
            }

            Task DeleteFile(string fileId)
            {
                return Delete(string.Format(DeleteFileUrl, fileId));
            }

            Task DeleteTable(string tableId)
            {
                return Delete(string.Format(DeleteTableUrl, tableId));
            }
            
        }
    }
}
