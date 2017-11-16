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
    public class QueryAsrJobListResponseUnmarshaller
    {
        public static QueryAsrJobListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryAsrJobListResponse queryAsrJobListResponse = new QueryAsrJobListResponse();

			queryAsrJobListResponse.HttpResponse = context.HttpResponse;
			queryAsrJobListResponse.RequestId = context.StringValue("QueryAsrJobList.RequestId");

			List<string> queryAsrJobListResponse_nonExistIds = new List<string>();
			for (int i = 0; i < context.Length("QueryAsrJobList.NonExistIds.Length"); i++) {
				queryAsrJobListResponse_nonExistIds.Add(context.StringValue("QueryAsrJobList.NonExistIds["+ i +"]"));
			}
			queryAsrJobListResponse.NonExistIds = queryAsrJobListResponse_nonExistIds;

			List<QueryAsrJobListResponse.QueryAsrJobList_Job> queryAsrJobListResponse_jobList = new List<QueryAsrJobListResponse.QueryAsrJobList_Job>();
			for (int i = 0; i < context.Length("QueryAsrJobList.JobList.Length"); i++) {
				QueryAsrJobListResponse.QueryAsrJobList_Job job = new QueryAsrJobListResponse.QueryAsrJobList_Job();
				job.Id = context.StringValue("QueryAsrJobList.JobList["+ i +"].Id");
				job.UserData = context.StringValue("QueryAsrJobList.JobList["+ i +"].UserData");
				job.PipelineId = context.StringValue("QueryAsrJobList.JobList["+ i +"].PipelineId");
				job.State = context.StringValue("QueryAsrJobList.JobList["+ i +"].State");
				job.Code = context.StringValue("QueryAsrJobList.JobList["+ i +"].Code");
				job.Message = context.StringValue("QueryAsrJobList.JobList["+ i +"].Message");
				job.CreationTime = context.StringValue("QueryAsrJobList.JobList["+ i +"].CreationTime");

				QueryAsrJobListResponse.QueryAsrJobList_Job.QueryAsrJobList_Input input = new QueryAsrJobListResponse.QueryAsrJobList_Job.QueryAsrJobList_Input();
				input.Bucket = context.StringValue("QueryAsrJobList.JobList["+ i +"].Input.Bucket");
				input.Location = context.StringValue("QueryAsrJobList.JobList["+ i +"].Input.Location");
				input._Object = context.StringValue("QueryAsrJobList.JobList["+ i +"].Input.Object");
				job.Input = input;

				QueryAsrJobListResponse.QueryAsrJobList_Job.QueryAsrJobList_AsrConfig asrConfig = new QueryAsrJobListResponse.QueryAsrJobList_Job.QueryAsrJobList_AsrConfig();
				asrConfig.Scene = context.StringValue("QueryAsrJobList.JobList["+ i +"].AsrConfig.Scene");
				job.AsrConfig = asrConfig;

				QueryAsrJobListResponse.QueryAsrJobList_Job.QueryAsrJobList_AsrResult asrResult = new QueryAsrJobListResponse.QueryAsrJobList_Job.QueryAsrJobList_AsrResult();
				asrResult.Duration = context.StringValue("QueryAsrJobList.JobList["+ i +"].AsrResult.Duration");

				List<QueryAsrJobListResponse.QueryAsrJobList_Job.QueryAsrJobList_AsrResult.QueryAsrJobList_AsrText> asrResult_asrTextList = new List<QueryAsrJobListResponse.QueryAsrJobList_Job.QueryAsrJobList_AsrResult.QueryAsrJobList_AsrText>();
				for (int j = 0; j < context.Length("QueryAsrJobList.JobList["+ i +"].AsrResult.AsrTextList.Length"); j++) {
					QueryAsrJobListResponse.QueryAsrJobList_Job.QueryAsrJobList_AsrResult.QueryAsrJobList_AsrText asrText = new QueryAsrJobListResponse.QueryAsrJobList_Job.QueryAsrJobList_AsrResult.QueryAsrJobList_AsrText();
					asrText.StartTime = context.IntegerValue("QueryAsrJobList.JobList["+ i +"].AsrResult.AsrTextList["+ j +"].StartTime");
					asrText.EndTime = context.StringValue("QueryAsrJobList.JobList["+ i +"].AsrResult.AsrTextList["+ j +"].EndTime");
					asrText.ChannelId = context.StringValue("QueryAsrJobList.JobList["+ i +"].AsrResult.AsrTextList["+ j +"].ChannelId");
					asrText.SpeechRate = context.StringValue("QueryAsrJobList.JobList["+ i +"].AsrResult.AsrTextList["+ j +"].SpeechRate");
					asrText.Text = context.StringValue("QueryAsrJobList.JobList["+ i +"].AsrResult.AsrTextList["+ j +"].Text");

					asrResult_asrTextList.Add(asrText);
				}
				asrResult.AsrTextList = asrResult_asrTextList;
				job.AsrResult = asrResult;

				queryAsrJobListResponse_jobList.Add(job);
			}
			queryAsrJobListResponse.JobList = queryAsrJobListResponse_jobList;
        
			return queryAsrJobListResponse;
        }
    }
}