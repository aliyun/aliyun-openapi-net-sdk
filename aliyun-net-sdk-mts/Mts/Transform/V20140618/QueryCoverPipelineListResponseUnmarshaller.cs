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
    public class QueryCoverPipelineListResponseUnmarshaller
    {
        public static QueryCoverPipelineListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryCoverPipelineListResponse queryCoverPipelineListResponse = new QueryCoverPipelineListResponse();

			queryCoverPipelineListResponse.HttpResponse = context.HttpResponse;
			queryCoverPipelineListResponse.RequestId = context.StringValue("QueryCoverPipelineList.RequestId");

			List<string> queryCoverPipelineListResponse_nonExistIds = new List<string>();
			for (int i = 0; i < context.Length("QueryCoverPipelineList.NonExistIds.Length"); i++) {
				queryCoverPipelineListResponse_nonExistIds.Add(context.StringValue("QueryCoverPipelineList.NonExistIds["+ i +"]"));
			}
			queryCoverPipelineListResponse.NonExistIds = queryCoverPipelineListResponse_nonExistIds;

			List<QueryCoverPipelineListResponse.QueryCoverPipelineList_Pipeline> queryCoverPipelineListResponse_pipelineList = new List<QueryCoverPipelineListResponse.QueryCoverPipelineList_Pipeline>();
			for (int i = 0; i < context.Length("QueryCoverPipelineList.PipelineList.Length"); i++) {
				QueryCoverPipelineListResponse.QueryCoverPipelineList_Pipeline pipeline = new QueryCoverPipelineListResponse.QueryCoverPipelineList_Pipeline();
				pipeline.Id = context.StringValue("QueryCoverPipelineList.PipelineList["+ i +"].Id");
				pipeline.Name = context.StringValue("QueryCoverPipelineList.PipelineList["+ i +"].Name");
				pipeline.State = context.StringValue("QueryCoverPipelineList.PipelineList["+ i +"].State");
				pipeline.Priority = context.StringValue("QueryCoverPipelineList.PipelineList["+ i +"].Priority");
				pipeline.Role = context.StringValue("QueryCoverPipelineList.PipelineList["+ i +"].Role");

				QueryCoverPipelineListResponse.QueryCoverPipelineList_Pipeline.QueryCoverPipelineList_NotifyConfig notifyConfig = new QueryCoverPipelineListResponse.QueryCoverPipelineList_Pipeline.QueryCoverPipelineList_NotifyConfig();
				notifyConfig.Topic = context.StringValue("QueryCoverPipelineList.PipelineList["+ i +"].NotifyConfig.Topic");
				notifyConfig.Queue = context.StringValue("QueryCoverPipelineList.PipelineList["+ i +"].NotifyConfig.Queue");
				pipeline.NotifyConfig = notifyConfig;

				queryCoverPipelineListResponse_pipelineList.Add(pipeline);
			}
			queryCoverPipelineListResponse.PipelineList = queryCoverPipelineListResponse_pipelineList;
        
			return queryCoverPipelineListResponse;
        }
    }
}