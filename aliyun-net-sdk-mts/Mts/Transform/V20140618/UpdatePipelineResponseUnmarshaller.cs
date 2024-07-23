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
    public class UpdatePipelineResponseUnmarshaller
    {
        public static UpdatePipelineResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdatePipelineResponse updatePipelineResponse = new UpdatePipelineResponse();

			updatePipelineResponse.HttpResponse = _ctx.HttpResponse;
			updatePipelineResponse.RequestId = _ctx.StringValue("UpdatePipeline.RequestId");

			UpdatePipelineResponse.UpdatePipeline_Pipeline pipeline = new UpdatePipelineResponse.UpdatePipeline_Pipeline();
			pipeline.Speed = _ctx.StringValue("UpdatePipeline.Pipeline.Speed");
			pipeline.State = _ctx.StringValue("UpdatePipeline.Pipeline.State");
			pipeline.Name = _ctx.StringValue("UpdatePipeline.Pipeline.Name");
			pipeline.Role = _ctx.StringValue("UpdatePipeline.Pipeline.Role");
			pipeline.Id = _ctx.StringValue("UpdatePipeline.Pipeline.Id");
			pipeline.QuotaAllocate = _ctx.LongValue("UpdatePipeline.Pipeline.QuotaAllocate");

			UpdatePipelineResponse.UpdatePipeline_Pipeline.UpdatePipeline_NotifyConfig notifyConfig = new UpdatePipelineResponse.UpdatePipeline_Pipeline.UpdatePipeline_NotifyConfig();
			notifyConfig.MqTopic = _ctx.StringValue("UpdatePipeline.Pipeline.NotifyConfig.MqTopic");
			notifyConfig.QueueName = _ctx.StringValue("UpdatePipeline.Pipeline.NotifyConfig.QueueName");
			notifyConfig.MqTag = _ctx.StringValue("UpdatePipeline.Pipeline.NotifyConfig.MqTag");
			notifyConfig.Topic = _ctx.StringValue("UpdatePipeline.Pipeline.NotifyConfig.Topic");
			pipeline.NotifyConfig = notifyConfig;

			UpdatePipelineResponse.UpdatePipeline_Pipeline.UpdatePipeline_ExtendConfig extendConfig = new UpdatePipelineResponse.UpdatePipeline_Pipeline.UpdatePipeline_ExtendConfig();
			extendConfig.IsBoostNew = _ctx.BooleanValue("UpdatePipeline.Pipeline.ExtendConfig.IsBoostNew");
			extendConfig.MaxMultiSpeed = _ctx.IntegerValue("UpdatePipeline.Pipeline.ExtendConfig.MaxMultiSpeed");
			extendConfig.MultiSpeedDowngradePolicy = _ctx.StringValue("UpdatePipeline.Pipeline.ExtendConfig.MultiSpeedDowngradePolicy");
			pipeline.ExtendConfig = extendConfig;
			updatePipelineResponse.Pipeline = pipeline;
        
			return updatePipelineResponse;
        }
    }
}
