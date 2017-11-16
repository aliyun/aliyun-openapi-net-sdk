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
    public class AddPipelineResponseUnmarshaller
    {
        public static AddPipelineResponse Unmarshall(UnmarshallerContext context)
        {
			AddPipelineResponse addPipelineResponse = new AddPipelineResponse();

			addPipelineResponse.HttpResponse = context.HttpResponse;
			addPipelineResponse.RequestId = context.StringValue("AddPipeline.RequestId");

			AddPipelineResponse.AddPipeline_Pipeline pipeline = new AddPipelineResponse.AddPipeline_Pipeline();
			pipeline.Id = context.StringValue("AddPipeline.Pipeline.Id");
			pipeline.Name = context.StringValue("AddPipeline.Pipeline.Name");
			pipeline.State = context.StringValue("AddPipeline.Pipeline.State");
			pipeline.Speed = context.StringValue("AddPipeline.Pipeline.Speed");
			pipeline.SpeedLevel = context.LongValue("AddPipeline.Pipeline.SpeedLevel");
			pipeline.Role = context.StringValue("AddPipeline.Pipeline.Role");

			AddPipelineResponse.AddPipeline_Pipeline.AddPipeline_NotifyConfig notifyConfig = new AddPipelineResponse.AddPipeline_Pipeline.AddPipeline_NotifyConfig();
			notifyConfig.Topic = context.StringValue("AddPipeline.Pipeline.NotifyConfig.Topic");
			notifyConfig.QueueName = context.StringValue("AddPipeline.Pipeline.NotifyConfig.QueueName");
			pipeline.NotifyConfig = notifyConfig;
			addPipelineResponse.Pipeline = pipeline;
        
			return addPipelineResponse;
        }
    }
}