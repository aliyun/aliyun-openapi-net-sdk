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
    public class QueryCensorJobListResponseUnmarshaller
    {
        public static QueryCensorJobListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryCensorJobListResponse queryCensorJobListResponse = new QueryCensorJobListResponse();

			queryCensorJobListResponse.HttpResponse = context.HttpResponse;
			queryCensorJobListResponse.RequestId = context.StringValue("QueryCensorJobList.RequestId");

			List<string> queryCensorJobListResponse_nonExistIds = new List<string>();
			for (int i = 0; i < context.Length("QueryCensorJobList.NonExistIds.Length"); i++) {
				queryCensorJobListResponse_nonExistIds.Add(context.StringValue("QueryCensorJobList.NonExistIds["+ i +"]"));
			}
			queryCensorJobListResponse.NonExistIds = queryCensorJobListResponse_nonExistIds;

			List<QueryCensorJobListResponse.QueryCensorJobList_CensorJob> queryCensorJobListResponse_censorJobList = new List<QueryCensorJobListResponse.QueryCensorJobList_CensorJob>();
			for (int i = 0; i < context.Length("QueryCensorJobList.CensorJobList.Length"); i++) {
				QueryCensorJobListResponse.QueryCensorJobList_CensorJob censorJob = new QueryCensorJobListResponse.QueryCensorJobList_CensorJob();
				censorJob.Id = context.StringValue("QueryCensorJobList.CensorJobList["+ i +"].Id");
				censorJob.UserData = context.StringValue("QueryCensorJobList.CensorJobList["+ i +"].UserData");
				censorJob.PipelineId = context.StringValue("QueryCensorJobList.CensorJobList["+ i +"].PipelineId");
				censorJob.State = context.StringValue("QueryCensorJobList.CensorJobList["+ i +"].State");
				censorJob.Code = context.StringValue("QueryCensorJobList.CensorJobList["+ i +"].Code");
				censorJob.Message = context.StringValue("QueryCensorJobList.CensorJobList["+ i +"].Message");
				censorJob.CreationTime = context.StringValue("QueryCensorJobList.CensorJobList["+ i +"].CreationTime");

				QueryCensorJobListResponse.QueryCensorJobList_CensorJob.QueryCensorJobList_Input input = new QueryCensorJobListResponse.QueryCensorJobList_CensorJob.QueryCensorJobList_Input();
				input.Bucket = context.StringValue("QueryCensorJobList.CensorJobList["+ i +"].Input.Bucket");
				input.Location = context.StringValue("QueryCensorJobList.CensorJobList["+ i +"].Input.Location");
				input._Object = context.StringValue("QueryCensorJobList.CensorJobList["+ i +"].Input.Object");
				censorJob.Input = input;

				QueryCensorJobListResponse.QueryCensorJobList_CensorJob.QueryCensorJobList_CensorConfig censorConfig = new QueryCensorJobListResponse.QueryCensorJobList_CensorJob.QueryCensorJobList_CensorConfig();
				censorConfig.Interval = context.StringValue("QueryCensorJobList.CensorJobList["+ i +"].CensorConfig.Interval");
				censorConfig.BizType = context.StringValue("QueryCensorJobList.CensorJobList["+ i +"].CensorConfig.BizType");

				QueryCensorJobListResponse.QueryCensorJobList_CensorJob.QueryCensorJobList_CensorConfig.QueryCensorJobList_OutputFile outputFile = new QueryCensorJobListResponse.QueryCensorJobList_CensorJob.QueryCensorJobList_CensorConfig.QueryCensorJobList_OutputFile();
				outputFile.Bucket = context.StringValue("QueryCensorJobList.CensorJobList["+ i +"].CensorConfig.OutputFile.Bucket");
				outputFile.Location = context.StringValue("QueryCensorJobList.CensorJobList["+ i +"].CensorConfig.OutputFile.Location");
				outputFile._Object = context.StringValue("QueryCensorJobList.CensorJobList["+ i +"].CensorConfig.OutputFile.Object");
				censorConfig.OutputFile = outputFile;
				censorJob.CensorConfig = censorConfig;

				QueryCensorJobListResponse.QueryCensorJobList_CensorJob.QueryCensorJobList_CensorPornResult censorPornResult = new QueryCensorJobListResponse.QueryCensorJobList_CensorJob.QueryCensorJobList_CensorPornResult();
				censorPornResult.Label = context.StringValue("QueryCensorJobList.CensorJobList["+ i +"].CensorPornResult.Label");
				censorPornResult.Suggestion = context.StringValue("QueryCensorJobList.CensorJobList["+ i +"].CensorPornResult.Suggestion");
				censorPornResult.MaxScore = context.StringValue("QueryCensorJobList.CensorJobList["+ i +"].CensorPornResult.MaxScore");
				censorPornResult.AverageScore = context.StringValue("QueryCensorJobList.CensorJobList["+ i +"].CensorPornResult.AverageScore");

				List<QueryCensorJobListResponse.QueryCensorJobList_CensorJob.QueryCensorJobList_CensorPornResult.QueryCensorJobList_Counter> censorPornResult_pornCounterList = new List<QueryCensorJobListResponse.QueryCensorJobList_CensorJob.QueryCensorJobList_CensorPornResult.QueryCensorJobList_Counter>();
				for (int j = 0; j < context.Length("QueryCensorJobList.CensorJobList["+ i +"].CensorPornResult.PornCounterList.Length"); j++) {
					QueryCensorJobListResponse.QueryCensorJobList_CensorJob.QueryCensorJobList_CensorPornResult.QueryCensorJobList_Counter counter = new QueryCensorJobListResponse.QueryCensorJobList_CensorJob.QueryCensorJobList_CensorPornResult.QueryCensorJobList_Counter();
					counter.Count = context.IntegerValue("QueryCensorJobList.CensorJobList["+ i +"].CensorPornResult.PornCounterList["+ j +"].Count");
					counter.Label = context.StringValue("QueryCensorJobList.CensorJobList["+ i +"].CensorPornResult.PornCounterList["+ j +"].Label");

					censorPornResult_pornCounterList.Add(counter);
				}
				censorPornResult.PornCounterList = censorPornResult_pornCounterList;

				List<QueryCensorJobListResponse.QueryCensorJobList_CensorJob.QueryCensorJobList_CensorPornResult.QueryCensorJobList_Top> censorPornResult_pornTopList = new List<QueryCensorJobListResponse.QueryCensorJobList_CensorJob.QueryCensorJobList_CensorPornResult.QueryCensorJobList_Top>();
				for (int j = 0; j < context.Length("QueryCensorJobList.CensorJobList["+ i +"].CensorPornResult.PornTopList.Length"); j++) {
					QueryCensorJobListResponse.QueryCensorJobList_CensorJob.QueryCensorJobList_CensorPornResult.QueryCensorJobList_Top top = new QueryCensorJobListResponse.QueryCensorJobList_CensorJob.QueryCensorJobList_CensorPornResult.QueryCensorJobList_Top();
					top.Label = context.StringValue("QueryCensorJobList.CensorJobList["+ i +"].CensorPornResult.PornTopList["+ j +"].Label");
					top.Score = context.StringValue("QueryCensorJobList.CensorJobList["+ i +"].CensorPornResult.PornTopList["+ j +"].Score");
					top.Timestamp = context.StringValue("QueryCensorJobList.CensorJobList["+ i +"].CensorPornResult.PornTopList["+ j +"].Timestamp");
					top.Index = context.StringValue("QueryCensorJobList.CensorJobList["+ i +"].CensorPornResult.PornTopList["+ j +"].Index");
					top._Object = context.StringValue("QueryCensorJobList.CensorJobList["+ i +"].CensorPornResult.PornTopList["+ j +"].Object");

					censorPornResult_pornTopList.Add(top);
				}
				censorPornResult.PornTopList = censorPornResult_pornTopList;
				censorJob.CensorPornResult = censorPornResult;

				QueryCensorJobListResponse.QueryCensorJobList_CensorJob.QueryCensorJobList_CensorTerrorismResult censorTerrorismResult = new QueryCensorJobListResponse.QueryCensorJobList_CensorJob.QueryCensorJobList_CensorTerrorismResult();
				censorTerrorismResult.Label = context.StringValue("QueryCensorJobList.CensorJobList["+ i +"].CensorTerrorismResult.Label");
				censorTerrorismResult.Suggestion = context.StringValue("QueryCensorJobList.CensorJobList["+ i +"].CensorTerrorismResult.Suggestion");
				censorTerrorismResult.MaxScore = context.StringValue("QueryCensorJobList.CensorJobList["+ i +"].CensorTerrorismResult.MaxScore");
				censorTerrorismResult.AverageScore = context.StringValue("QueryCensorJobList.CensorJobList["+ i +"].CensorTerrorismResult.AverageScore");

				List<QueryCensorJobListResponse.QueryCensorJobList_CensorJob.QueryCensorJobList_CensorTerrorismResult.QueryCensorJobList_Counter1> censorTerrorismResult_terrorismCounterList = new List<QueryCensorJobListResponse.QueryCensorJobList_CensorJob.QueryCensorJobList_CensorTerrorismResult.QueryCensorJobList_Counter1>();
				for (int j = 0; j < context.Length("QueryCensorJobList.CensorJobList["+ i +"].CensorTerrorismResult.TerrorismCounterList.Length"); j++) {
					QueryCensorJobListResponse.QueryCensorJobList_CensorJob.QueryCensorJobList_CensorTerrorismResult.QueryCensorJobList_Counter1 counter1 = new QueryCensorJobListResponse.QueryCensorJobList_CensorJob.QueryCensorJobList_CensorTerrorismResult.QueryCensorJobList_Counter1();
					counter1.Count = context.IntegerValue("QueryCensorJobList.CensorJobList["+ i +"].CensorTerrorismResult.TerrorismCounterList["+ j +"].Count");
					counter1.Label = context.StringValue("QueryCensorJobList.CensorJobList["+ i +"].CensorTerrorismResult.TerrorismCounterList["+ j +"].Label");

					censorTerrorismResult_terrorismCounterList.Add(counter1);
				}
				censorTerrorismResult.TerrorismCounterList = censorTerrorismResult_terrorismCounterList;

				List<QueryCensorJobListResponse.QueryCensorJobList_CensorJob.QueryCensorJobList_CensorTerrorismResult.QueryCensorJobList_Top2> censorTerrorismResult_terrorismTopList = new List<QueryCensorJobListResponse.QueryCensorJobList_CensorJob.QueryCensorJobList_CensorTerrorismResult.QueryCensorJobList_Top2>();
				for (int j = 0; j < context.Length("QueryCensorJobList.CensorJobList["+ i +"].CensorTerrorismResult.TerrorismTopList.Length"); j++) {
					QueryCensorJobListResponse.QueryCensorJobList_CensorJob.QueryCensorJobList_CensorTerrorismResult.QueryCensorJobList_Top2 top2 = new QueryCensorJobListResponse.QueryCensorJobList_CensorJob.QueryCensorJobList_CensorTerrorismResult.QueryCensorJobList_Top2();
					top2.Label = context.StringValue("QueryCensorJobList.CensorJobList["+ i +"].CensorTerrorismResult.TerrorismTopList["+ j +"].Label");
					top2.Score = context.StringValue("QueryCensorJobList.CensorJobList["+ i +"].CensorTerrorismResult.TerrorismTopList["+ j +"].Score");
					top2.Timestamp = context.StringValue("QueryCensorJobList.CensorJobList["+ i +"].CensorTerrorismResult.TerrorismTopList["+ j +"].Timestamp");
					top2.Index = context.StringValue("QueryCensorJobList.CensorJobList["+ i +"].CensorTerrorismResult.TerrorismTopList["+ j +"].Index");
					top2._Object = context.StringValue("QueryCensorJobList.CensorJobList["+ i +"].CensorTerrorismResult.TerrorismTopList["+ j +"].Object");

					censorTerrorismResult_terrorismTopList.Add(top2);
				}
				censorTerrorismResult.TerrorismTopList = censorTerrorismResult_terrorismTopList;
				censorJob.CensorTerrorismResult = censorTerrorismResult;

				queryCensorJobListResponse_censorJobList.Add(censorJob);
			}
			queryCensorJobListResponse.CensorJobList = queryCensorJobListResponse_censorJobList;
        
			return queryCensorJobListResponse;
        }
    }
}