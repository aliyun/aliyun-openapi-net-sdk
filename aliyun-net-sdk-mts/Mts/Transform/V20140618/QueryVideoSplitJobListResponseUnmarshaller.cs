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
    public class QueryVideoSplitJobListResponseUnmarshaller
    {
        public static QueryVideoSplitJobListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryVideoSplitJobListResponse queryVideoSplitJobListResponse = new QueryVideoSplitJobListResponse();

			queryVideoSplitJobListResponse.HttpResponse = context.HttpResponse;
			queryVideoSplitJobListResponse.RequestId = context.StringValue("QueryVideoSplitJobList.RequestId");

			List<string> queryVideoSplitJobListResponse_nonExistIds = new List<string>();
			for (int i = 0; i < context.Length("QueryVideoSplitJobList.NonExistIds.Length"); i++) {
				queryVideoSplitJobListResponse_nonExistIds.Add(context.StringValue("QueryVideoSplitJobList.NonExistIds["+ i +"]"));
			}
			queryVideoSplitJobListResponse.NonExistIds = queryVideoSplitJobListResponse_nonExistIds;

			List<QueryVideoSplitJobListResponse.QueryVideoSplitJobList_Job> queryVideoSplitJobListResponse_jobList = new List<QueryVideoSplitJobListResponse.QueryVideoSplitJobList_Job>();
			for (int i = 0; i < context.Length("QueryVideoSplitJobList.JobList.Length"); i++) {
				QueryVideoSplitJobListResponse.QueryVideoSplitJobList_Job job = new QueryVideoSplitJobListResponse.QueryVideoSplitJobList_Job();
				job.Id = context.StringValue("QueryVideoSplitJobList.JobList["+ i +"].Id");
				job.UserData = context.StringValue("QueryVideoSplitJobList.JobList["+ i +"].UserData");
				job.PipelineId = context.StringValue("QueryVideoSplitJobList.JobList["+ i +"].PipelineId");
				job.State = context.StringValue("QueryVideoSplitJobList.JobList["+ i +"].State");
				job.Code = context.StringValue("QueryVideoSplitJobList.JobList["+ i +"].Code");
				job.Message = context.StringValue("QueryVideoSplitJobList.JobList["+ i +"].Message");
				job.CreationTime = context.StringValue("QueryVideoSplitJobList.JobList["+ i +"].CreationTime");

				QueryVideoSplitJobListResponse.QueryVideoSplitJobList_Job.QueryVideoSplitJobList_Input input = new QueryVideoSplitJobListResponse.QueryVideoSplitJobList_Job.QueryVideoSplitJobList_Input();
				input.Bucket = context.StringValue("QueryVideoSplitJobList.JobList["+ i +"].Input.Bucket");
				input.Location = context.StringValue("QueryVideoSplitJobList.JobList["+ i +"].Input.Location");
				input._Object = context.StringValue("QueryVideoSplitJobList.JobList["+ i +"].Input.Object");
				job.Input = input;

				QueryVideoSplitJobListResponse.QueryVideoSplitJobList_Job.QueryVideoSplitJobList_VideoSplitResult videoSplitResult = new QueryVideoSplitJobListResponse.QueryVideoSplitJobList_Job.QueryVideoSplitJobList_VideoSplitResult();

				List<QueryVideoSplitJobListResponse.QueryVideoSplitJobList_Job.QueryVideoSplitJobList_VideoSplitResult.QueryVideoSplitJobList_VideoSplit> videoSplitResult_videoSplitList = new List<QueryVideoSplitJobListResponse.QueryVideoSplitJobList_Job.QueryVideoSplitJobList_VideoSplitResult.QueryVideoSplitJobList_VideoSplit>();
				for (int j = 0; j < context.Length("QueryVideoSplitJobList.JobList["+ i +"].VideoSplitResult.VideoSplitList.Length"); j++) {
					QueryVideoSplitJobListResponse.QueryVideoSplitJobList_Job.QueryVideoSplitJobList_VideoSplitResult.QueryVideoSplitJobList_VideoSplit videoSplit = new QueryVideoSplitJobListResponse.QueryVideoSplitJobList_Job.QueryVideoSplitJobList_VideoSplitResult.QueryVideoSplitJobList_VideoSplit();
					videoSplit.StartTime = context.StringValue("QueryVideoSplitJobList.JobList["+ i +"].VideoSplitResult.VideoSplitList["+ j +"].StartTime");
					videoSplit.EndTime = context.StringValue("QueryVideoSplitJobList.JobList["+ i +"].VideoSplitResult.VideoSplitList["+ j +"].EndTime");
					videoSplit.Path = context.StringValue("QueryVideoSplitJobList.JobList["+ i +"].VideoSplitResult.VideoSplitList["+ j +"].Path");

					videoSplitResult_videoSplitList.Add(videoSplit);
				}
				videoSplitResult.VideoSplitList = videoSplitResult_videoSplitList;
				job.VideoSplitResult = videoSplitResult;

				queryVideoSplitJobListResponse_jobList.Add(job);
			}
			queryVideoSplitJobListResponse.JobList = queryVideoSplitJobListResponse_jobList;
        
			return queryVideoSplitJobListResponse;
        }
    }
}
