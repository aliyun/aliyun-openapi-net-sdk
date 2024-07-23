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
    public class SearchPipelineResponseUnmarshaller
    {
        public static SearchPipelineResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SearchPipelineResponse searchPipelineResponse = new SearchPipelineResponse();

			searchPipelineResponse.HttpResponse = _ctx.HttpResponse;
			searchPipelineResponse.TotalCount = _ctx.LongValue("SearchPipeline.TotalCount");
			searchPipelineResponse.PageSize = _ctx.LongValue("SearchPipeline.PageSize");
			searchPipelineResponse.RequestId = _ctx.StringValue("SearchPipeline.RequestId");
			searchPipelineResponse.PageNumber = _ctx.LongValue("SearchPipeline.PageNumber");

			List<SearchPipelineResponse.SearchPipeline_Pipeline> searchPipelineResponse_pipelineList = new List<SearchPipelineResponse.SearchPipeline_Pipeline>();
			for (int i = 0; i < _ctx.Length("SearchPipeline.PipelineList.Length"); i++) {
				SearchPipelineResponse.SearchPipeline_Pipeline pipeline = new SearchPipelineResponse.SearchPipeline_Pipeline();
				pipeline.Speed = _ctx.StringValue("SearchPipeline.PipelineList["+ i +"].Speed");
				pipeline.State = _ctx.StringValue("SearchPipeline.PipelineList["+ i +"].State");
				pipeline.SpeedLevel = _ctx.LongValue("SearchPipeline.PipelineList["+ i +"].SpeedLevel");
				pipeline.Role = _ctx.StringValue("SearchPipeline.PipelineList["+ i +"].Role");
				pipeline.Name = _ctx.StringValue("SearchPipeline.PipelineList["+ i +"].Name");
				pipeline.Id = _ctx.StringValue("SearchPipeline.PipelineList["+ i +"].Id");
				pipeline.QuotaAllocate = _ctx.LongValue("SearchPipeline.PipelineList["+ i +"].QuotaAllocate");
				pipeline.CreationTime = _ctx.StringValue("SearchPipeline.PipelineList["+ i +"].CreationTime");

				SearchPipelineResponse.SearchPipeline_Pipeline.SearchPipeline_NotifyConfig notifyConfig = new SearchPipelineResponse.SearchPipeline_Pipeline.SearchPipeline_NotifyConfig();
				notifyConfig.MqTopic = _ctx.StringValue("SearchPipeline.PipelineList["+ i +"].NotifyConfig.MqTopic");
				notifyConfig.QueueName = _ctx.StringValue("SearchPipeline.PipelineList["+ i +"].NotifyConfig.QueueName");
				notifyConfig.MqTag = _ctx.StringValue("SearchPipeline.PipelineList["+ i +"].NotifyConfig.MqTag");
				notifyConfig.Topic = _ctx.StringValue("SearchPipeline.PipelineList["+ i +"].NotifyConfig.Topic");
				pipeline.NotifyConfig = notifyConfig;

				SearchPipelineResponse.SearchPipeline_Pipeline.SearchPipeline_ExtendConfig extendConfig = new SearchPipelineResponse.SearchPipeline_Pipeline.SearchPipeline_ExtendConfig();
				extendConfig.IsBoostNew = _ctx.BooleanValue("SearchPipeline.PipelineList["+ i +"].ExtendConfig.IsBoostNew");
				extendConfig.MaxMultiSpeed = _ctx.IntegerValue("SearchPipeline.PipelineList["+ i +"].ExtendConfig.MaxMultiSpeed");
				extendConfig.MultiSpeedDowngradePolicy = _ctx.StringValue("SearchPipeline.PipelineList["+ i +"].ExtendConfig.MultiSpeedDowngradePolicy");
				pipeline.ExtendConfig = extendConfig;

				searchPipelineResponse_pipelineList.Add(pipeline);
			}
			searchPipelineResponse.PipelineList = searchPipelineResponse_pipelineList;
        
			return searchPipelineResponse;
        }
    }
}
