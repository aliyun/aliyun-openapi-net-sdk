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
    public class QueryAsrPipelineListResponseUnmarshaller
    {
        public static QueryAsrPipelineListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryAsrPipelineListResponse queryAsrPipelineListResponse = new QueryAsrPipelineListResponse();

			queryAsrPipelineListResponse.HttpResponse = context.HttpResponse;
			queryAsrPipelineListResponse.RequestId = context.StringValue("QueryAsrPipelineList.RequestId");

			List<string> queryAsrPipelineListResponse_nonExistIds = new List<string>();
			for (int i = 0; i < context.Length("QueryAsrPipelineList.NonExistIds.Length"); i++) {
				queryAsrPipelineListResponse_nonExistIds.Add(context.StringValue("QueryAsrPipelineList.NonExistIds["+ i +"]"));
			}
			queryAsrPipelineListResponse.NonExistIds = queryAsrPipelineListResponse_nonExistIds;

			List<QueryAsrPipelineListResponse.QueryAsrPipelineList_Pipeline> queryAsrPipelineListResponse_pipelineList = new List<QueryAsrPipelineListResponse.QueryAsrPipelineList_Pipeline>();
			for (int i = 0; i < context.Length("QueryAsrPipelineList.PipelineList.Length"); i++) {
				QueryAsrPipelineListResponse.QueryAsrPipelineList_Pipeline pipeline = new QueryAsrPipelineListResponse.QueryAsrPipelineList_Pipeline();
				pipeline.Id = context.StringValue("QueryAsrPipelineList.PipelineList["+ i +"].Id");
				pipeline.Name = context.StringValue("QueryAsrPipelineList.PipelineList["+ i +"].Name");
				pipeline.State = context.StringValue("QueryAsrPipelineList.PipelineList["+ i +"].State");
				pipeline.Priority = context.StringValue("QueryAsrPipelineList.PipelineList["+ i +"].Priority");

				QueryAsrPipelineListResponse.QueryAsrPipelineList_Pipeline.QueryAsrPipelineList_NotifyConfig notifyConfig = new QueryAsrPipelineListResponse.QueryAsrPipelineList_Pipeline.QueryAsrPipelineList_NotifyConfig();
				notifyConfig.Topic = context.StringValue("QueryAsrPipelineList.PipelineList["+ i +"].NotifyConfig.Topic");
				notifyConfig.QueueName = context.StringValue("QueryAsrPipelineList.PipelineList["+ i +"].NotifyConfig.QueueName");
				pipeline.NotifyConfig = notifyConfig;

				queryAsrPipelineListResponse_pipelineList.Add(pipeline);
			}
			queryAsrPipelineListResponse.PipelineList = queryAsrPipelineListResponse_pipelineList;
        
			return queryAsrPipelineListResponse;
        }
    }
}