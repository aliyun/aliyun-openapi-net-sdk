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
    public class QueryTerrorismPipelineListResponseUnmarshaller
    {
        public static QueryTerrorismPipelineListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryTerrorismPipelineListResponse queryTerrorismPipelineListResponse = new QueryTerrorismPipelineListResponse();

			queryTerrorismPipelineListResponse.HttpResponse = context.HttpResponse;
			queryTerrorismPipelineListResponse.RequestId = context.StringValue("QueryTerrorismPipelineList.RequestId");

			List<string> queryTerrorismPipelineListResponse_nonExistIds = new List<string>();
			for (int i = 0; i < context.Length("QueryTerrorismPipelineList.NonExistIds.Length"); i++) {
				queryTerrorismPipelineListResponse_nonExistIds.Add(context.StringValue("QueryTerrorismPipelineList.NonExistIds["+ i +"]"));
			}
			queryTerrorismPipelineListResponse.NonExistIds = queryTerrorismPipelineListResponse_nonExistIds;

			List<QueryTerrorismPipelineListResponse.QueryTerrorismPipelineList_Pipeline> queryTerrorismPipelineListResponse_pipelineList = new List<QueryTerrorismPipelineListResponse.QueryTerrorismPipelineList_Pipeline>();
			for (int i = 0; i < context.Length("QueryTerrorismPipelineList.PipelineList.Length"); i++) {
				QueryTerrorismPipelineListResponse.QueryTerrorismPipelineList_Pipeline pipeline = new QueryTerrorismPipelineListResponse.QueryTerrorismPipelineList_Pipeline();
				pipeline.Id = context.StringValue("QueryTerrorismPipelineList.PipelineList["+ i +"].Id");
				pipeline.Name = context.StringValue("QueryTerrorismPipelineList.PipelineList["+ i +"].Name");
				pipeline.State = context.StringValue("QueryTerrorismPipelineList.PipelineList["+ i +"].State");
				pipeline.Priority = context.StringValue("QueryTerrorismPipelineList.PipelineList["+ i +"].Priority");

				QueryTerrorismPipelineListResponse.QueryTerrorismPipelineList_Pipeline.QueryTerrorismPipelineList_NotifyConfig notifyConfig = new QueryTerrorismPipelineListResponse.QueryTerrorismPipelineList_Pipeline.QueryTerrorismPipelineList_NotifyConfig();
				notifyConfig.Topic = context.StringValue("QueryTerrorismPipelineList.PipelineList["+ i +"].NotifyConfig.Topic");
				notifyConfig.Queue = context.StringValue("QueryTerrorismPipelineList.PipelineList["+ i +"].NotifyConfig.Queue");
				pipeline.NotifyConfig = notifyConfig;

				queryTerrorismPipelineListResponse_pipelineList.Add(pipeline);
			}
			queryTerrorismPipelineListResponse.PipelineList = queryTerrorismPipelineListResponse_pipelineList;
        
			return queryTerrorismPipelineListResponse;
        }
    }
}