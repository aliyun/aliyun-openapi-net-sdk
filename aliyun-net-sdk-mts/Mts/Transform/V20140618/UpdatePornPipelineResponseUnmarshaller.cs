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
    public class UpdatePornPipelineResponseUnmarshaller
    {
        public static UpdatePornPipelineResponse Unmarshall(UnmarshallerContext context)
        {
			UpdatePornPipelineResponse updatePornPipelineResponse = new UpdatePornPipelineResponse();

			updatePornPipelineResponse.HttpResponse = context.HttpResponse;
			updatePornPipelineResponse.RequestId = context.StringValue("UpdatePornPipeline.RequestId");

			UpdatePornPipelineResponse.UpdatePornPipeline_Pipeline pipeline = new UpdatePornPipelineResponse.UpdatePornPipeline_Pipeline();
			pipeline.Id = context.StringValue("UpdatePornPipeline.Pipeline.Id");
			pipeline.Name = context.StringValue("UpdatePornPipeline.Pipeline.Name");
			pipeline.State = context.StringValue("UpdatePornPipeline.Pipeline.State");
			pipeline.Priority = context.IntegerValue("UpdatePornPipeline.Pipeline.Priority");

			UpdatePornPipelineResponse.UpdatePornPipeline_Pipeline.UpdatePornPipeline_NotifyConfig notifyConfig = new UpdatePornPipelineResponse.UpdatePornPipeline_Pipeline.UpdatePornPipeline_NotifyConfig();
			notifyConfig.Topic = context.StringValue("UpdatePornPipeline.Pipeline.NotifyConfig.Topic");
			notifyConfig.Queue = context.StringValue("UpdatePornPipeline.Pipeline.NotifyConfig.Queue");
			pipeline.NotifyConfig = notifyConfig;
			updatePornPipelineResponse.Pipeline = pipeline;
        
			return updatePornPipelineResponse;
        }
    }
}