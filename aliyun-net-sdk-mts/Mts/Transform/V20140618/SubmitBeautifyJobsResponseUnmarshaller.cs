/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Mts.Model.V20140618;

namespace Aliyun.Acs.Mts.Transform.V20140618
{
    public class SubmitBeautifyJobsResponseUnmarshaller
    {
        public static SubmitBeautifyJobsResponse Unmarshall(UnmarshallerContext context)
        {
			SubmitBeautifyJobsResponse submitBeautifyJobsResponse = new SubmitBeautifyJobsResponse();

			submitBeautifyJobsResponse.HttpResponse = context.HttpResponse;
			submitBeautifyJobsResponse.RequestId = context.StringValue("SubmitBeautifyJobs.RequestId");

			List<SubmitBeautifyJobsResponse.SubmitBeautifyJobs_Job> submitBeautifyJobsResponse_jobList = new List<SubmitBeautifyJobsResponse.SubmitBeautifyJobs_Job>();
			for (int i = 0; i < context.Length("SubmitBeautifyJobs.JobList.Length"); i++) {
				SubmitBeautifyJobsResponse.SubmitBeautifyJobs_Job job = new SubmitBeautifyJobsResponse.SubmitBeautifyJobs_Job();
				job.Id = context.StringValue("SubmitBeautifyJobs.JobList["+ i +"].Id");
				job.UserData = context.StringValue("SubmitBeautifyJobs.JobList["+ i +"].UserData");
				job.PipelineId = context.StringValue("SubmitBeautifyJobs.JobList["+ i +"].PipelineId");
				job.State = context.StringValue("SubmitBeautifyJobs.JobList["+ i +"].State");
				job.Code = context.StringValue("SubmitBeautifyJobs.JobList["+ i +"].Code");
				job.Message = context.StringValue("SubmitBeautifyJobs.JobList["+ i +"].Message");
				job.CreationTime = context.StringValue("SubmitBeautifyJobs.JobList["+ i +"].CreationTime");

				SubmitBeautifyJobsResponse.SubmitBeautifyJobs_Job.SubmitBeautifyJobs_Input input = new SubmitBeautifyJobsResponse.SubmitBeautifyJobs_Job.SubmitBeautifyJobs_Input();
				input.Bucket = context.StringValue("SubmitBeautifyJobs.JobList["+ i +"].Input.Bucket");
				input.Location = context.StringValue("SubmitBeautifyJobs.JobList["+ i +"].Input.Location");
				input._Object = context.StringValue("SubmitBeautifyJobs.JobList["+ i +"].Input.Object");
				input.RoleArn = context.StringValue("SubmitBeautifyJobs.JobList["+ i +"].Input.RoleArn");
				job.Input = input;

				SubmitBeautifyJobsResponse.SubmitBeautifyJobs_Job.SubmitBeautifyJobs_BeautifyConfig beautifyConfig = new SubmitBeautifyJobsResponse.SubmitBeautifyJobs_Job.SubmitBeautifyJobs_BeautifyConfig();

				SubmitBeautifyJobsResponse.SubmitBeautifyJobs_Job.SubmitBeautifyJobs_BeautifyConfig.SubmitBeautifyJobs_OutputFile outputFile = new SubmitBeautifyJobsResponse.SubmitBeautifyJobs_Job.SubmitBeautifyJobs_BeautifyConfig.SubmitBeautifyJobs_OutputFile();
				outputFile.Bucket = context.StringValue("SubmitBeautifyJobs.JobList["+ i +"].BeautifyConfig.OutputFile.Bucket");
				outputFile.Location = context.StringValue("SubmitBeautifyJobs.JobList["+ i +"].BeautifyConfig.OutputFile.Location");
				outputFile._Object = context.StringValue("SubmitBeautifyJobs.JobList["+ i +"].BeautifyConfig.OutputFile.Object");
				outputFile.RoleArn = context.StringValue("SubmitBeautifyJobs.JobList["+ i +"].BeautifyConfig.OutputFile.RoleArn");
				beautifyConfig.OutputFile = outputFile;
				job.BeautifyConfig = beautifyConfig;

				SubmitBeautifyJobsResponse.SubmitBeautifyJobs_Job.SubmitBeautifyJobs_MNSMessageResult mNSMessageResult = new SubmitBeautifyJobsResponse.SubmitBeautifyJobs_Job.SubmitBeautifyJobs_MNSMessageResult();
				mNSMessageResult.MessageId = context.StringValue("SubmitBeautifyJobs.JobList["+ i +"].MNSMessageResult.MessageId");
				mNSMessageResult.ErrorMessage = context.StringValue("SubmitBeautifyJobs.JobList["+ i +"].MNSMessageResult.ErrorMessage");
				mNSMessageResult.ErrorCode = context.StringValue("SubmitBeautifyJobs.JobList["+ i +"].MNSMessageResult.ErrorCode");
				job.MNSMessageResult = mNSMessageResult;

				submitBeautifyJobsResponse_jobList.Add(job);
			}
			submitBeautifyJobsResponse.JobList = submitBeautifyJobsResponse_jobList;
        
			return submitBeautifyJobsResponse;
        }
    }
}
