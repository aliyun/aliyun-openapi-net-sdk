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
    public class QueryVideoSummaryPipelineListResponseUnmarshaller
    {
        public static QueryVideoSummaryPipelineListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryVideoSummaryPipelineListResponse queryVideoSummaryPipelineListResponse = new QueryVideoSummaryPipelineListResponse();

			queryVideoSummaryPipelineListResponse.HttpResponse = context.HttpResponse;
			queryVideoSummaryPipelineListResponse.RequestId = context.StringValue("QueryVideoSummaryPipelineList.RequestId");

			List<string> queryVideoSummaryPipelineListResponse_nonExistIds = new List<string>();
			for (int i = 0; i < context.Length("QueryVideoSummaryPipelineList.NonExistIds.Length"); i++) {
				queryVideoSummaryPipelineListResponse_nonExistIds.Add(context.StringValue("QueryVideoSummaryPipelineList.NonExistIds["+ i +"]"));
			}
			queryVideoSummaryPipelineListResponse.NonExistIds = queryVideoSummaryPipelineListResponse_nonExistIds;

			List<QueryVideoSummaryPipelineListResponse.QueryVideoSummaryPipelineList_Pipeline> queryVideoSummaryPipelineListResponse_pipelineList = new List<QueryVideoSummaryPipelineListResponse.QueryVideoSummaryPipelineList_Pipeline>();
			for (int i = 0; i < context.Length("QueryVideoSummaryPipelineList.PipelineList.Length"); i++) {
				QueryVideoSummaryPipelineListResponse.QueryVideoSummaryPipelineList_Pipeline pipeline = new QueryVideoSummaryPipelineListResponse.QueryVideoSummaryPipelineList_Pipeline();
				pipeline.Id = context.StringValue("QueryVideoSummaryPipelineList.PipelineList["+ i +"].Id");
				pipeline.Name = context.StringValue("QueryVideoSummaryPipelineList.PipelineList["+ i +"].Name");
				pipeline.State = context.StringValue("QueryVideoSummaryPipelineList.PipelineList["+ i +"].State");
				pipeline.Priority = context.StringValue("QueryVideoSummaryPipelineList.PipelineList["+ i +"].Priority");

				QueryVideoSummaryPipelineListResponse.QueryVideoSummaryPipelineList_Pipeline.QueryVideoSummaryPipelineList_NotifyConfig notifyConfig = new QueryVideoSummaryPipelineListResponse.QueryVideoSummaryPipelineList_Pipeline.QueryVideoSummaryPipelineList_NotifyConfig();
				notifyConfig.Topic = context.StringValue("QueryVideoSummaryPipelineList.PipelineList["+ i +"].NotifyConfig.Topic");
				notifyConfig.QueueName = context.StringValue("QueryVideoSummaryPipelineList.PipelineList["+ i +"].NotifyConfig.QueueName");
				pipeline.NotifyConfig = notifyConfig;

				queryVideoSummaryPipelineListResponse_pipelineList.Add(pipeline);
			}
			queryVideoSummaryPipelineListResponse.PipelineList = queryVideoSummaryPipelineListResponse_pipelineList;
        
			return queryVideoSummaryPipelineListResponse;
        }
    }
}