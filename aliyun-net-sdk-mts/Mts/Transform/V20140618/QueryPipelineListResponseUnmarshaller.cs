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
    public class QueryPipelineListResponseUnmarshaller
    {
        public static QueryPipelineListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryPipelineListResponse queryPipelineListResponse = new QueryPipelineListResponse();

			queryPipelineListResponse.HttpResponse = _ctx.HttpResponse;
			queryPipelineListResponse.RequestId = _ctx.StringValue("QueryPipelineList.RequestId");

			List<string> queryPipelineListResponse_nonExistPids = new List<string>();
			for (int i = 0; i < _ctx.Length("QueryPipelineList.NonExistPids.Length"); i++) {
				queryPipelineListResponse_nonExistPids.Add(_ctx.StringValue("QueryPipelineList.NonExistPids["+ i +"]"));
			}
			queryPipelineListResponse.NonExistPids = queryPipelineListResponse_nonExistPids;

			List<QueryPipelineListResponse.QueryPipelineList_Pipeline> queryPipelineListResponse_pipelineList = new List<QueryPipelineListResponse.QueryPipelineList_Pipeline>();
			for (int i = 0; i < _ctx.Length("QueryPipelineList.PipelineList.Length"); i++) {
				QueryPipelineListResponse.QueryPipelineList_Pipeline pipeline = new QueryPipelineListResponse.QueryPipelineList_Pipeline();
				pipeline.Speed = _ctx.StringValue("QueryPipelineList.PipelineList["+ i +"].Speed");
				pipeline.State = _ctx.StringValue("QueryPipelineList.PipelineList["+ i +"].State");
				pipeline.SpeedLevel = _ctx.LongValue("QueryPipelineList.PipelineList["+ i +"].SpeedLevel");
				pipeline.Role = _ctx.StringValue("QueryPipelineList.PipelineList["+ i +"].Role");
				pipeline.Name = _ctx.StringValue("QueryPipelineList.PipelineList["+ i +"].Name");
				pipeline.Id = _ctx.StringValue("QueryPipelineList.PipelineList["+ i +"].Id");
				pipeline.QuotaAllocate = _ctx.LongValue("QueryPipelineList.PipelineList["+ i +"].QuotaAllocate");

				QueryPipelineListResponse.QueryPipelineList_Pipeline.QueryPipelineList_NotifyConfig notifyConfig = new QueryPipelineListResponse.QueryPipelineList_Pipeline.QueryPipelineList_NotifyConfig();
				notifyConfig.MqTopic = _ctx.StringValue("QueryPipelineList.PipelineList["+ i +"].NotifyConfig.MqTopic");
				notifyConfig.QueueName = _ctx.StringValue("QueryPipelineList.PipelineList["+ i +"].NotifyConfig.QueueName");
				notifyConfig.MqTag = _ctx.StringValue("QueryPipelineList.PipelineList["+ i +"].NotifyConfig.MqTag");
				notifyConfig.Topic = _ctx.StringValue("QueryPipelineList.PipelineList["+ i +"].NotifyConfig.Topic");
				pipeline.NotifyConfig = notifyConfig;

				QueryPipelineListResponse.QueryPipelineList_Pipeline.QueryPipelineList_ExtendConfig extendConfig = new QueryPipelineListResponse.QueryPipelineList_Pipeline.QueryPipelineList_ExtendConfig();
				extendConfig.IsBoostNew = _ctx.BooleanValue("QueryPipelineList.PipelineList["+ i +"].ExtendConfig.IsBoostNew");
				extendConfig.MaxMultiSpeed = _ctx.IntegerValue("QueryPipelineList.PipelineList["+ i +"].ExtendConfig.MaxMultiSpeed");
				extendConfig.MultiSpeedDowngradePolicy = _ctx.StringValue("QueryPipelineList.PipelineList["+ i +"].ExtendConfig.MultiSpeedDowngradePolicy");
				pipeline.ExtendConfig = extendConfig;

				queryPipelineListResponse_pipelineList.Add(pipeline);
			}
			queryPipelineListResponse.PipelineList = queryPipelineListResponse_pipelineList;
        
			return queryPipelineListResponse;
        }
    }
}
