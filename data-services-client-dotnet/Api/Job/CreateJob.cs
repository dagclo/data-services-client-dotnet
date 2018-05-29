﻿using System.Collections.Generic;
using System.Net.Http;
using Quadient.DataServices.Model.Job;
using Quadient.DataServices.Utility;

namespace Quadient.DataServices.Api.Job
{
    /// <summary>
    /// Creates a new job. By default the `owner` will be the currently authenticated user, and the `job_status` will be `CREATED`.
    /// </summary>
    public class CreateJob : IRequest<JobCreationRequest, JobInformationResponse>
    {
        public string ServicePath { get; } = "jobs/v1";
        public HttpMethod Method { get; } = HttpMethod.Post;
        public JobCreationRequest Content { get; set; }
        public IDictionary<string, string> QueryStringParams { get; }

        /// <summary>
        /// Creates a new job. By default the `owner` will be the currently authenticated user, and the `job_status` will be `CREATED`.
        /// </summary>
        public CreateJob()
        {
            Content = new JobCreationRequest(Constants.Origin);
        }

        /// <summary>
        /// Creates a new job. By default the `owner` will be the currently authenticated user, and the `job_status` will be `CREATED`.
        /// </summary>
        /// <param name="origin">The originating product/application/service for which this job is being created.</param>
        public CreateJob(string origin)
        {
            Content = new JobCreationRequest(origin);
        }
    }
}
