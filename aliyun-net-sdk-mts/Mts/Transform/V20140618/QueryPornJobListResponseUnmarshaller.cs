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
    public class QueryPornJobListResponseUnmarshaller
    {
        public static QueryPornJobListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryPornJobListResponse queryPornJobListResponse = new QueryPornJobListResponse();

			queryPornJobListResponse.HttpResponse = context.HttpResponse;
			queryPornJobListResponse.RequestId = context.StringValue("QueryPornJobList.RequestId");

			List<string> queryPornJobListResponse_nonExistIds = new List<string>();
			for (int i = 0; i < context.Length("QueryPornJobList.NonExistIds.Length"); i++) {
				queryPornJobListResponse_nonExistIds.Add(context.StringValue("QueryPornJobList.NonExistIds["+ i +"]"));
			}
			queryPornJobListResponse.NonExistIds = queryPornJobListResponse_nonExistIds;

			List<QueryPornJobListResponse.QueryPornJobList_PornJob> queryPornJobListResponse_pornJobList = new List<QueryPornJobListResponse.QueryPornJobList_PornJob>();
			for (int i = 0; i < context.Length("QueryPornJobList.PornJobList.Length"); i++) {
				QueryPornJobListResponse.QueryPornJobList_PornJob pornJob = new QueryPornJobListResponse.QueryPornJobList_PornJob();
				pornJob.Id = context.StringValue("QueryPornJobList.PornJobList["+ i +"].Id");
				pornJob.UserData = context.StringValue("QueryPornJobList.PornJobList["+ i +"].UserData");
				pornJob.PipelineId = context.StringValue("QueryPornJobList.PornJobList["+ i +"].PipelineId");
				pornJob.State = context.StringValue("QueryPornJobList.PornJobList["+ i +"].State");
				pornJob.Code = context.StringValue("QueryPornJobList.PornJobList["+ i +"].Code");
				pornJob.Message = context.StringValue("QueryPornJobList.PornJobList["+ i +"].Message");
				pornJob.CreationTime = context.StringValue("QueryPornJobList.PornJobList["+ i +"].CreationTime");

				QueryPornJobListResponse.QueryPornJobList_PornJob.QueryPornJobList_Input input = new QueryPornJobListResponse.QueryPornJobList_PornJob.QueryPornJobList_Input();
				input.Bucket = context.StringValue("QueryPornJobList.PornJobList["+ i +"].Input.Bucket");
				input.Location = context.StringValue("QueryPornJobList.PornJobList["+ i +"].Input.Location");
				input._Object = context.StringValue("QueryPornJobList.PornJobList["+ i +"].Input.Object");
				pornJob.Input = input;

				QueryPornJobListResponse.QueryPornJobList_PornJob.QueryPornJobList_PornConfig pornConfig = new QueryPornJobListResponse.QueryPornJobList_PornJob.QueryPornJobList_PornConfig();
				pornConfig.Interval = context.StringValue("QueryPornJobList.PornJobList["+ i +"].PornConfig.Interval");
				pornConfig.BizType = context.StringValue("QueryPornJobList.PornJobList["+ i +"].PornConfig.BizType");

				QueryPornJobListResponse.QueryPornJobList_PornJob.QueryPornJobList_PornConfig.QueryPornJobList_OutputFile outputFile = new QueryPornJobListResponse.QueryPornJobList_PornJob.QueryPornJobList_PornConfig.QueryPornJobList_OutputFile();
				outputFile.Bucket = context.StringValue("QueryPornJobList.PornJobList["+ i +"].PornConfig.OutputFile.Bucket");
				outputFile.Location = context.StringValue("QueryPornJobList.PornJobList["+ i +"].PornConfig.OutputFile.Location");
				outputFile._Object = context.StringValue("QueryPornJobList.PornJobList["+ i +"].PornConfig.OutputFile.Object");
				pornConfig.OutputFile = outputFile;
				pornJob.PornConfig = pornConfig;

				QueryPornJobListResponse.QueryPornJobList_PornJob.QueryPornJobList_CensorPornResult censorPornResult = new QueryPornJobListResponse.QueryPornJobList_PornJob.QueryPornJobList_CensorPornResult();
				censorPornResult.Label = context.StringValue("QueryPornJobList.PornJobList["+ i +"].CensorPornResult.Label");
				censorPornResult.Suggestion = context.StringValue("QueryPornJobList.PornJobList["+ i +"].CensorPornResult.Suggestion");
				censorPornResult.MaxScore = context.StringValue("QueryPornJobList.PornJobList["+ i +"].CensorPornResult.MaxScore");
				censorPornResult.AverageScore = context.StringValue("QueryPornJobList.PornJobList["+ i +"].CensorPornResult.AverageScore");

				List<QueryPornJobListResponse.QueryPornJobList_PornJob.QueryPornJobList_CensorPornResult.QueryPornJobList_Counter> censorPornResult_pornCounterList = new List<QueryPornJobListResponse.QueryPornJobList_PornJob.QueryPornJobList_CensorPornResult.QueryPornJobList_Counter>();
				for (int j = 0; j < context.Length("QueryPornJobList.PornJobList["+ i +"].CensorPornResult.PornCounterList.Length"); j++) {
					QueryPornJobListResponse.QueryPornJobList_PornJob.QueryPornJobList_CensorPornResult.QueryPornJobList_Counter counter = new QueryPornJobListResponse.QueryPornJobList_PornJob.QueryPornJobList_CensorPornResult.QueryPornJobList_Counter();
					counter.Count = context.IntegerValue("QueryPornJobList.PornJobList["+ i +"].CensorPornResult.PornCounterList["+ j +"].Count");
					counter.Label = context.StringValue("QueryPornJobList.PornJobList["+ i +"].CensorPornResult.PornCounterList["+ j +"].Label");

					censorPornResult_pornCounterList.Add(counter);
				}
				censorPornResult.PornCounterList = censorPornResult_pornCounterList;

				List<QueryPornJobListResponse.QueryPornJobList_PornJob.QueryPornJobList_CensorPornResult.QueryPornJobList_Top> censorPornResult_pornTopList = new List<QueryPornJobListResponse.QueryPornJobList_PornJob.QueryPornJobList_CensorPornResult.QueryPornJobList_Top>();
				for (int j = 0; j < context.Length("QueryPornJobList.PornJobList["+ i +"].CensorPornResult.PornTopList.Length"); j++) {
					QueryPornJobListResponse.QueryPornJobList_PornJob.QueryPornJobList_CensorPornResult.QueryPornJobList_Top top = new QueryPornJobListResponse.QueryPornJobList_PornJob.QueryPornJobList_CensorPornResult.QueryPornJobList_Top();
					top.Label = context.StringValue("QueryPornJobList.PornJobList["+ i +"].CensorPornResult.PornTopList["+ j +"].Label");
					top.Score = context.StringValue("QueryPornJobList.PornJobList["+ i +"].CensorPornResult.PornTopList["+ j +"].Score");
					top.Timestamp = context.StringValue("QueryPornJobList.PornJobList["+ i +"].CensorPornResult.PornTopList["+ j +"].Timestamp");
					top.Index = context.StringValue("QueryPornJobList.PornJobList["+ i +"].CensorPornResult.PornTopList["+ j +"].Index");
					top._Object = context.StringValue("QueryPornJobList.PornJobList["+ i +"].CensorPornResult.PornTopList["+ j +"].Object");

					censorPornResult_pornTopList.Add(top);
				}
				censorPornResult.PornTopList = censorPornResult_pornTopList;
				pornJob.CensorPornResult = censorPornResult;

				queryPornJobListResponse_pornJobList.Add(pornJob);
			}
			queryPornJobListResponse.PornJobList = queryPornJobListResponse_pornJobList;
        
			return queryPornJobListResponse;
        }
    }
}