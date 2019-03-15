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
        public static UpdatePipelineResponse Unmarshall(UnmarshallerContext context)
        {
			UpdatePipelineResponse updatePipelineResponse = new UpdatePipelineResponse();

			updatePipelineResponse.HttpResponse = context.HttpResponse;
			updatePipelineResponse.RequestId = context.StringValue("UpdatePipeline.RequestId");

			UpdatePipelineResponse.UpdatePipeline_Pipeline pipeline = new UpdatePipelineResponse.UpdatePipeline_Pipeline();
			pipeline.Id = context.StringValue("UpdatePipeline.Pipeline.Id");
			pipeline.Name = context.StringValue("UpdatePipeline.Pipeline.Name");
			pipeline.State = context.StringValue("UpdatePipeline.Pipeline.State");
			pipeline.Speed = context.StringValue("UpdatePipeline.Pipeline.Speed");
			pipeline.QuotaAllocate = context.LongValue("UpdatePipeline.Pipeline.QuotaAllocate");
			pipeline.Role = context.StringValue("UpdatePipeline.Pipeline.Role");

			UpdatePipelineResponse.UpdatePipeline_Pipeline.UpdatePipeline_NotifyConfig notifyConfig = new UpdatePipelineResponse.UpdatePipeline_Pipeline.UpdatePipeline_NotifyConfig();
			notifyConfig.Topic = context.StringValue("UpdatePipeline.Pipeline.NotifyConfig.Topic");
			notifyConfig.QueueName = context.StringValue("UpdatePipeline.Pipeline.NotifyConfig.QueueName");
			notifyConfig.MqTopic = context.StringValue("UpdatePipeline.Pipeline.NotifyConfig.MqTopic");
			notifyConfig.MqTag = context.StringValue("UpdatePipeline.Pipeline.NotifyConfig.MqTag");
			pipeline.NotifyConfig = notifyConfig;
			updatePipelineResponse.Pipeline = pipeline;
        
			return updatePipelineResponse;
        }
    }
}
