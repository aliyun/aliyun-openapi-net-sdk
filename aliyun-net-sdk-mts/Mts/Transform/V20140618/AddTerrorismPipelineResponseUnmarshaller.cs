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
    public class AddTerrorismPipelineResponseUnmarshaller
    {
        public static AddTerrorismPipelineResponse Unmarshall(UnmarshallerContext context)
        {
			AddTerrorismPipelineResponse addTerrorismPipelineResponse = new AddTerrorismPipelineResponse();

			addTerrorismPipelineResponse.HttpResponse = context.HttpResponse;
			addTerrorismPipelineResponse.RequestId = context.StringValue("AddTerrorismPipeline.RequestId");

			AddTerrorismPipelineResponse.AddTerrorismPipeline_Pipeline pipeline = new AddTerrorismPipelineResponse.AddTerrorismPipeline_Pipeline();
			pipeline.Id = context.StringValue("AddTerrorismPipeline.Pipeline.Id");
			pipeline.Name = context.StringValue("AddTerrorismPipeline.Pipeline.Name");
			pipeline.Priority = context.IntegerValue("AddTerrorismPipeline.Pipeline.Priority");
			pipeline.State = context.StringValue("AddTerrorismPipeline.Pipeline.State");

			AddTerrorismPipelineResponse.AddTerrorismPipeline_Pipeline.AddTerrorismPipeline_NotifyConfig notifyConfig = new AddTerrorismPipelineResponse.AddTerrorismPipeline_Pipeline.AddTerrorismPipeline_NotifyConfig();
			notifyConfig.Topic = context.StringValue("AddTerrorismPipeline.Pipeline.NotifyConfig.Topic");
			notifyConfig.Queue = context.StringValue("AddTerrorismPipeline.Pipeline.NotifyConfig.Queue");
			pipeline.NotifyConfig = notifyConfig;
			addTerrorismPipelineResponse.Pipeline = pipeline;
        
			return addTerrorismPipelineResponse;
        }
    }
}