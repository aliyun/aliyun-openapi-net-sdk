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
    public class QueryTerrorismJobListResponseUnmarshaller
    {
        public static QueryTerrorismJobListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryTerrorismJobListResponse queryTerrorismJobListResponse = new QueryTerrorismJobListResponse();

			queryTerrorismJobListResponse.HttpResponse = context.HttpResponse;
			queryTerrorismJobListResponse.RequestId = context.StringValue("QueryTerrorismJobList.RequestId");

			List<string> queryTerrorismJobListResponse_nonExistIds = new List<string>();
			for (int i = 0; i < context.Length("QueryTerrorismJobList.NonExistIds.Length"); i++) {
				queryTerrorismJobListResponse_nonExistIds.Add(context.StringValue("QueryTerrorismJobList.NonExistIds["+ i +"]"));
			}
			queryTerrorismJobListResponse.NonExistIds = queryTerrorismJobListResponse_nonExistIds;

			List<QueryTerrorismJobListResponse.QueryTerrorismJobList_TerrorismJob> queryTerrorismJobListResponse_terrorismJobList = new List<QueryTerrorismJobListResponse.QueryTerrorismJobList_TerrorismJob>();
			for (int i = 0; i < context.Length("QueryTerrorismJobList.TerrorismJobList.Length"); i++) {
				QueryTerrorismJobListResponse.QueryTerrorismJobList_TerrorismJob terrorismJob = new QueryTerrorismJobListResponse.QueryTerrorismJobList_TerrorismJob();
				terrorismJob.Id = context.StringValue("QueryTerrorismJobList.TerrorismJobList["+ i +"].Id");
				terrorismJob.UserData = context.StringValue("QueryTerrorismJobList.TerrorismJobList["+ i +"].UserData");
				terrorismJob.PipelineId = context.StringValue("QueryTerrorismJobList.TerrorismJobList["+ i +"].PipelineId");
				terrorismJob.State = context.StringValue("QueryTerrorismJobList.TerrorismJobList["+ i +"].State");
				terrorismJob.Code = context.StringValue("QueryTerrorismJobList.TerrorismJobList["+ i +"].Code");
				terrorismJob.Message = context.StringValue("QueryTerrorismJobList.TerrorismJobList["+ i +"].Message");
				terrorismJob.CreationTime = context.StringValue("QueryTerrorismJobList.TerrorismJobList["+ i +"].CreationTime");

				QueryTerrorismJobListResponse.QueryTerrorismJobList_TerrorismJob.QueryTerrorismJobList_Input input = new QueryTerrorismJobListResponse.QueryTerrorismJobList_TerrorismJob.QueryTerrorismJobList_Input();
				input.Bucket = context.StringValue("QueryTerrorismJobList.TerrorismJobList["+ i +"].Input.Bucket");
				input.Location = context.StringValue("QueryTerrorismJobList.TerrorismJobList["+ i +"].Input.Location");
				input._Object = context.StringValue("QueryTerrorismJobList.TerrorismJobList["+ i +"].Input.Object");
				terrorismJob.Input = input;

				QueryTerrorismJobListResponse.QueryTerrorismJobList_TerrorismJob.QueryTerrorismJobList_TerrorismConfig terrorismConfig = new QueryTerrorismJobListResponse.QueryTerrorismJobList_TerrorismJob.QueryTerrorismJobList_TerrorismConfig();
				terrorismConfig.Interval = context.StringValue("QueryTerrorismJobList.TerrorismJobList["+ i +"].TerrorismConfig.Interval");
				terrorismConfig.BizType = context.StringValue("QueryTerrorismJobList.TerrorismJobList["+ i +"].TerrorismConfig.BizType");

				QueryTerrorismJobListResponse.QueryTerrorismJobList_TerrorismJob.QueryTerrorismJobList_TerrorismConfig.QueryTerrorismJobList_OutputFile outputFile = new QueryTerrorismJobListResponse.QueryTerrorismJobList_TerrorismJob.QueryTerrorismJobList_TerrorismConfig.QueryTerrorismJobList_OutputFile();
				outputFile.Bucket = context.StringValue("QueryTerrorismJobList.TerrorismJobList["+ i +"].TerrorismConfig.OutputFile.Bucket");
				outputFile.Location = context.StringValue("QueryTerrorismJobList.TerrorismJobList["+ i +"].TerrorismConfig.OutputFile.Location");
				outputFile._Object = context.StringValue("QueryTerrorismJobList.TerrorismJobList["+ i +"].TerrorismConfig.OutputFile.Object");
				terrorismConfig.OutputFile = outputFile;
				terrorismJob.TerrorismConfig = terrorismConfig;

				QueryTerrorismJobListResponse.QueryTerrorismJobList_TerrorismJob.QueryTerrorismJobList_CensorTerrorismResult censorTerrorismResult = new QueryTerrorismJobListResponse.QueryTerrorismJobList_TerrorismJob.QueryTerrorismJobList_CensorTerrorismResult();
				censorTerrorismResult.Label = context.StringValue("QueryTerrorismJobList.TerrorismJobList["+ i +"].CensorTerrorismResult.Label");
				censorTerrorismResult.Suggestion = context.StringValue("QueryTerrorismJobList.TerrorismJobList["+ i +"].CensorTerrorismResult.Suggestion");
				censorTerrorismResult.MaxScore = context.StringValue("QueryTerrorismJobList.TerrorismJobList["+ i +"].CensorTerrorismResult.MaxScore");
				censorTerrorismResult.AverageScore = context.StringValue("QueryTerrorismJobList.TerrorismJobList["+ i +"].CensorTerrorismResult.AverageScore");

				List<QueryTerrorismJobListResponse.QueryTerrorismJobList_TerrorismJob.QueryTerrorismJobList_CensorTerrorismResult.QueryTerrorismJobList_Counter> censorTerrorismResult_terrorismCounterList = new List<QueryTerrorismJobListResponse.QueryTerrorismJobList_TerrorismJob.QueryTerrorismJobList_CensorTerrorismResult.QueryTerrorismJobList_Counter>();
				for (int j = 0; j < context.Length("QueryTerrorismJobList.TerrorismJobList["+ i +"].CensorTerrorismResult.TerrorismCounterList.Length"); j++) {
					QueryTerrorismJobListResponse.QueryTerrorismJobList_TerrorismJob.QueryTerrorismJobList_CensorTerrorismResult.QueryTerrorismJobList_Counter counter = new QueryTerrorismJobListResponse.QueryTerrorismJobList_TerrorismJob.QueryTerrorismJobList_CensorTerrorismResult.QueryTerrorismJobList_Counter();
					counter.Count = context.IntegerValue("QueryTerrorismJobList.TerrorismJobList["+ i +"].CensorTerrorismResult.TerrorismCounterList["+ j +"].Count");
					counter.Label = context.StringValue("QueryTerrorismJobList.TerrorismJobList["+ i +"].CensorTerrorismResult.TerrorismCounterList["+ j +"].Label");

					censorTerrorismResult_terrorismCounterList.Add(counter);
				}
				censorTerrorismResult.TerrorismCounterList = censorTerrorismResult_terrorismCounterList;

				List<QueryTerrorismJobListResponse.QueryTerrorismJobList_TerrorismJob.QueryTerrorismJobList_CensorTerrorismResult.QueryTerrorismJobList_Top> censorTerrorismResult_terrorismTopList = new List<QueryTerrorismJobListResponse.QueryTerrorismJobList_TerrorismJob.QueryTerrorismJobList_CensorTerrorismResult.QueryTerrorismJobList_Top>();
				for (int j = 0; j < context.Length("QueryTerrorismJobList.TerrorismJobList["+ i +"].CensorTerrorismResult.TerrorismTopList.Length"); j++) {
					QueryTerrorismJobListResponse.QueryTerrorismJobList_TerrorismJob.QueryTerrorismJobList_CensorTerrorismResult.QueryTerrorismJobList_Top top = new QueryTerrorismJobListResponse.QueryTerrorismJobList_TerrorismJob.QueryTerrorismJobList_CensorTerrorismResult.QueryTerrorismJobList_Top();
					top.Label = context.StringValue("QueryTerrorismJobList.TerrorismJobList["+ i +"].CensorTerrorismResult.TerrorismTopList["+ j +"].Label");
					top.Score = context.StringValue("QueryTerrorismJobList.TerrorismJobList["+ i +"].CensorTerrorismResult.TerrorismTopList["+ j +"].Score");
					top.Timestamp = context.StringValue("QueryTerrorismJobList.TerrorismJobList["+ i +"].CensorTerrorismResult.TerrorismTopList["+ j +"].Timestamp");
					top.Index = context.StringValue("QueryTerrorismJobList.TerrorismJobList["+ i +"].CensorTerrorismResult.TerrorismTopList["+ j +"].Index");
					top._Object = context.StringValue("QueryTerrorismJobList.TerrorismJobList["+ i +"].CensorTerrorismResult.TerrorismTopList["+ j +"].Object");

					censorTerrorismResult_terrorismTopList.Add(top);
				}
				censorTerrorismResult.TerrorismTopList = censorTerrorismResult_terrorismTopList;
				terrorismJob.CensorTerrorismResult = censorTerrorismResult;

				queryTerrorismJobListResponse_terrorismJobList.Add(terrorismJob);
			}
			queryTerrorismJobListResponse.TerrorismJobList = queryTerrorismJobListResponse_terrorismJobList;
        
			return queryTerrorismJobListResponse;
        }
    }
}