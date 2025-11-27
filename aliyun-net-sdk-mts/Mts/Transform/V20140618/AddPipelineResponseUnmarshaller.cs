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
    public class AddPipelineResponseUnmarshaller
    {
        public static AddPipelineResponse Unmarshall(UnmarshallerContext _ctx)
        {
			AddPipelineResponse addPipelineResponse = new AddPipelineResponse();

			addPipelineResponse.HttpResponse = _ctx.HttpResponse;
			addPipelineResponse.RequestId = _ctx.StringValue("AddPipeline.RequestId");

			AddPipelineResponse.AddPipeline_Pipeline pipeline = new AddPipelineResponse.AddPipeline_Pipeline();
			pipeline.Speed = _ctx.StringValue("AddPipeline.Pipeline.Speed");
			pipeline.State = _ctx.StringValue("AddPipeline.Pipeline.State");
			pipeline.SpeedLevel = _ctx.LongValue("AddPipeline.Pipeline.SpeedLevel");
			pipeline.Role = _ctx.StringValue("AddPipeline.Pipeline.Role");
			pipeline.Name = _ctx.StringValue("AddPipeline.Pipeline.Name");
			pipeline.Id = _ctx.StringValue("AddPipeline.Pipeline.Id");
			pipeline.QuotaAllocate = _ctx.LongValue("AddPipeline.Pipeline.QuotaAllocate");

			AddPipelineResponse.AddPipeline_Pipeline.AddPipeline_NotifyConfig notifyConfig = new AddPipelineResponse.AddPipeline_Pipeline.AddPipeline_NotifyConfig();
			notifyConfig.MqTopic = _ctx.StringValue("AddPipeline.Pipeline.NotifyConfig.MqTopic");
			notifyConfig.QueueName = _ctx.StringValue("AddPipeline.Pipeline.NotifyConfig.QueueName");
			notifyConfig.MqTag = _ctx.StringValue("AddPipeline.Pipeline.NotifyConfig.MqTag");
			notifyConfig.Topic = _ctx.StringValue("AddPipeline.Pipeline.NotifyConfig.Topic");
			pipeline.NotifyConfig = notifyConfig;

			AddPipelineResponse.AddPipeline_Pipeline.AddPipeline_ExtendConfig extendConfig = new AddPipelineResponse.AddPipeline_Pipeline.AddPipeline_ExtendConfig();
			extendConfig.IsBoostNew = _ctx.BooleanValue("AddPipeline.Pipeline.ExtendConfig.IsBoostNew");
			extendConfig.MaxMultiSpeed = _ctx.IntegerValue("AddPipeline.Pipeline.ExtendConfig.MaxMultiSpeed");
			extendConfig.MultiSpeedDowngradePolicy = _ctx.StringValue("AddPipeline.Pipeline.ExtendConfig.MultiSpeedDowngradePolicy");
			pipeline.ExtendConfig = extendConfig;
			addPipelineResponse.Pipeline = pipeline;
        
			return addPipelineResponse;
        }
    }
}
