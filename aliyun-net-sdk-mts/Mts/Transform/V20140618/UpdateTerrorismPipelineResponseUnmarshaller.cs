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
    public class UpdateTerrorismPipelineResponseUnmarshaller
    {
        public static UpdateTerrorismPipelineResponse Unmarshall(UnmarshallerContext context)
        {
			UpdateTerrorismPipelineResponse updateTerrorismPipelineResponse = new UpdateTerrorismPipelineResponse();

			updateTerrorismPipelineResponse.HttpResponse = context.HttpResponse;
			updateTerrorismPipelineResponse.RequestId = context.StringValue("UpdateTerrorismPipeline.RequestId");

			UpdateTerrorismPipelineResponse.UpdateTerrorismPipeline_Pipeline pipeline = new UpdateTerrorismPipelineResponse.UpdateTerrorismPipeline_Pipeline();
			pipeline.Id = context.StringValue("UpdateTerrorismPipeline.Pipeline.Id");
			pipeline.Name = context.StringValue("UpdateTerrorismPipeline.Pipeline.Name");
			pipeline.State = context.StringValue("UpdateTerrorismPipeline.Pipeline.State");
			pipeline.Priority = context.IntegerValue("UpdateTerrorismPipeline.Pipeline.Priority");

			UpdateTerrorismPipelineResponse.UpdateTerrorismPipeline_Pipeline.UpdateTerrorismPipeline_NotifyConfig notifyConfig = new UpdateTerrorismPipelineResponse.UpdateTerrorismPipeline_Pipeline.UpdateTerrorismPipeline_NotifyConfig();
			notifyConfig.Topic = context.StringValue("UpdateTerrorismPipeline.Pipeline.NotifyConfig.Topic");
			notifyConfig.Queue = context.StringValue("UpdateTerrorismPipeline.Pipeline.NotifyConfig.Queue");
			pipeline.NotifyConfig = notifyConfig;
			updateTerrorismPipelineResponse.Pipeline = pipeline;
        
			return updateTerrorismPipelineResponse;
        }
    }
}