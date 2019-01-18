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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Mts.Model.V20140618;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Mts.Transform.V20140618
{
    public class QueryVideoGifJobListResponseUnmarshaller
    {
        public static QueryVideoGifJobListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryVideoGifJobListResponse queryVideoGifJobListResponse = new QueryVideoGifJobListResponse();

			queryVideoGifJobListResponse.HttpResponse = context.HttpResponse;
			queryVideoGifJobListResponse.RequestId = context.StringValue("QueryVideoGifJobList.RequestId");

			List<string> queryVideoGifJobListResponse_nonExistIds = new List<string>();
			for (int i = 0; i < context.Length("QueryVideoGifJobList.NonExistIds.Length"); i++) {
				queryVideoGifJobListResponse_nonExistIds.Add(context.StringValue("QueryVideoGifJobList.NonExistIds["+ i +"]"));
			}
			queryVideoGifJobListResponse.NonExistIds = queryVideoGifJobListResponse_nonExistIds;

			List<QueryVideoGifJobListResponse.QueryVideoGifJobList_Job> queryVideoGifJobListResponse_jobList = new List<QueryVideoGifJobListResponse.QueryVideoGifJobList_Job>();
			for (int i = 0; i < context.Length("QueryVideoGifJobList.JobList.Length"); i++) {
				QueryVideoGifJobListResponse.QueryVideoGifJobList_Job job = new QueryVideoGifJobListResponse.QueryVideoGifJobList_Job();
				job.Id = context.StringValue("QueryVideoGifJobList.JobList["+ i +"].Id");
				job.UserData = context.StringValue("QueryVideoGifJobList.JobList["+ i +"].UserData");
				job.PipelineId = context.StringValue("QueryVideoGifJobList.JobList["+ i +"].PipelineId");
				job.State = context.StringValue("QueryVideoGifJobList.JobList["+ i +"].State");
				job.Code = context.StringValue("QueryVideoGifJobList.JobList["+ i +"].Code");
				job.Message = context.StringValue("QueryVideoGifJobList.JobList["+ i +"].Message");
				job.CreationTime = context.StringValue("QueryVideoGifJobList.JobList["+ i +"].CreationTime");

				QueryVideoGifJobListResponse.QueryVideoGifJobList_Job.QueryVideoGifJobList_Input input = new QueryVideoGifJobListResponse.QueryVideoGifJobList_Job.QueryVideoGifJobList_Input();
				input.Bucket = context.StringValue("QueryVideoGifJobList.JobList["+ i +"].Input.Bucket");
				input.Location = context.StringValue("QueryVideoGifJobList.JobList["+ i +"].Input.Location");
				input._Object = context.StringValue("QueryVideoGifJobList.JobList["+ i +"].Input.Object");
				job.Input = input;

				QueryVideoGifJobListResponse.QueryVideoGifJobList_Job.QueryVideoGifJobList_VideoGifResult videoGifResult = new QueryVideoGifJobListResponse.QueryVideoGifJobList_Job.QueryVideoGifJobList_VideoGifResult();

				QueryVideoGifJobListResponse.QueryVideoGifJobList_Job.QueryVideoGifJobList_VideoGifResult.QueryVideoGifJobList_OutputFile outputFile = new QueryVideoGifJobListResponse.QueryVideoGifJobList_Job.QueryVideoGifJobList_VideoGifResult.QueryVideoGifJobList_OutputFile();
				outputFile.Bucket = context.StringValue("QueryVideoGifJobList.JobList["+ i +"].VideoGifResult.OutputFile.Bucket");
				outputFile.Location = context.StringValue("QueryVideoGifJobList.JobList["+ i +"].VideoGifResult.OutputFile.Location");
				outputFile._Object = context.StringValue("QueryVideoGifJobList.JobList["+ i +"].VideoGifResult.OutputFile.Object");
				videoGifResult.OutputFile = outputFile;
				job.VideoGifResult = videoGifResult;

				queryVideoGifJobListResponse_jobList.Add(job);
			}
			queryVideoGifJobListResponse.JobList = queryVideoGifJobListResponse_jobList;
        
			return queryVideoGifJobListResponse;
        }
    }
}