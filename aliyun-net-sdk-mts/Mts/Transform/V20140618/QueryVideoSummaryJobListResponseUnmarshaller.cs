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
    public class QueryVideoSummaryJobListResponseUnmarshaller
    {
        public static QueryVideoSummaryJobListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryVideoSummaryJobListResponse queryVideoSummaryJobListResponse = new QueryVideoSummaryJobListResponse();

			queryVideoSummaryJobListResponse.HttpResponse = context.HttpResponse;
			queryVideoSummaryJobListResponse.RequestId = context.StringValue("QueryVideoSummaryJobList.RequestId");

			List<string> queryVideoSummaryJobListResponse_nonExistIds = new List<string>();
			for (int i = 0; i < context.Length("QueryVideoSummaryJobList.NonExistIds.Length"); i++) {
				queryVideoSummaryJobListResponse_nonExistIds.Add(context.StringValue("QueryVideoSummaryJobList.NonExistIds["+ i +"]"));
			}
			queryVideoSummaryJobListResponse.NonExistIds = queryVideoSummaryJobListResponse_nonExistIds;

			List<QueryVideoSummaryJobListResponse.QueryVideoSummaryJobList_Job> queryVideoSummaryJobListResponse_jobList = new List<QueryVideoSummaryJobListResponse.QueryVideoSummaryJobList_Job>();
			for (int i = 0; i < context.Length("QueryVideoSummaryJobList.JobList.Length"); i++) {
				QueryVideoSummaryJobListResponse.QueryVideoSummaryJobList_Job job = new QueryVideoSummaryJobListResponse.QueryVideoSummaryJobList_Job();
				job.Id = context.StringValue("QueryVideoSummaryJobList.JobList["+ i +"].Id");
				job.UserData = context.StringValue("QueryVideoSummaryJobList.JobList["+ i +"].UserData");
				job.PipelineId = context.StringValue("QueryVideoSummaryJobList.JobList["+ i +"].PipelineId");
				job.State = context.StringValue("QueryVideoSummaryJobList.JobList["+ i +"].State");
				job.Code = context.StringValue("QueryVideoSummaryJobList.JobList["+ i +"].Code");
				job.Message = context.StringValue("QueryVideoSummaryJobList.JobList["+ i +"].Message");
				job.CreationTime = context.StringValue("QueryVideoSummaryJobList.JobList["+ i +"].CreationTime");

				QueryVideoSummaryJobListResponse.QueryVideoSummaryJobList_Job.QueryVideoSummaryJobList_Input input = new QueryVideoSummaryJobListResponse.QueryVideoSummaryJobList_Job.QueryVideoSummaryJobList_Input();
				input.Bucket = context.StringValue("QueryVideoSummaryJobList.JobList["+ i +"].Input.Bucket");
				input.Location = context.StringValue("QueryVideoSummaryJobList.JobList["+ i +"].Input.Location");
				input._Object = context.StringValue("QueryVideoSummaryJobList.JobList["+ i +"].Input.Object");
				job.Input = input;

				QueryVideoSummaryJobListResponse.QueryVideoSummaryJobList_Job.QueryVideoSummaryJobList_VideoSummaryResult videoSummaryResult = new QueryVideoSummaryJobListResponse.QueryVideoSummaryJobList_Job.QueryVideoSummaryJobList_VideoSummaryResult();

				List<QueryVideoSummaryJobListResponse.QueryVideoSummaryJobList_Job.QueryVideoSummaryJobList_VideoSummaryResult.QueryVideoSummaryJobList_VideoSummary> videoSummaryResult_videoSummaryList = new List<QueryVideoSummaryJobListResponse.QueryVideoSummaryJobList_Job.QueryVideoSummaryJobList_VideoSummaryResult.QueryVideoSummaryJobList_VideoSummary>();
				for (int j = 0; j < context.Length("QueryVideoSummaryJobList.JobList["+ i +"].VideoSummaryResult.VideoSummaryList.Length"); j++) {
					QueryVideoSummaryJobListResponse.QueryVideoSummaryJobList_Job.QueryVideoSummaryJobList_VideoSummaryResult.QueryVideoSummaryJobList_VideoSummary videoSummary = new QueryVideoSummaryJobListResponse.QueryVideoSummaryJobList_Job.QueryVideoSummaryJobList_VideoSummaryResult.QueryVideoSummaryJobList_VideoSummary();
					videoSummary.StartTime = context.StringValue("QueryVideoSummaryJobList.JobList["+ i +"].VideoSummaryResult.VideoSummaryList["+ j +"].StartTime");
					videoSummary.EndTime = context.StringValue("QueryVideoSummaryJobList.JobList["+ i +"].VideoSummaryResult.VideoSummaryList["+ j +"].EndTime");

					videoSummaryResult_videoSummaryList.Add(videoSummary);
				}
				videoSummaryResult.VideoSummaryList = videoSummaryResult_videoSummaryList;
				job.VideoSummaryResult = videoSummaryResult;

				queryVideoSummaryJobListResponse_jobList.Add(job);
			}
			queryVideoSummaryJobListResponse.JobList = queryVideoSummaryJobListResponse_jobList;
        
			return queryVideoSummaryJobListResponse;
        }
    }
}