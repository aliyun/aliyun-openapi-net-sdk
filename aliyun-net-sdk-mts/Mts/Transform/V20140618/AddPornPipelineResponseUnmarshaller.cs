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
    public class AddPornPipelineResponseUnmarshaller
    {
        public static AddPornPipelineResponse Unmarshall(UnmarshallerContext context)
        {
			AddPornPipelineResponse addPornPipelineResponse = new AddPornPipelineResponse();

			addPornPipelineResponse.HttpResponse = context.HttpResponse;
			addPornPipelineResponse.RequestId = context.StringValue("AddPornPipeline.RequestId");

			AddPornPipelineResponse.AddPornPipeline_Pipeline pipeline = new AddPornPipelineResponse.AddPornPipeline_Pipeline();
			pipeline.Id = context.StringValue("AddPornPipeline.Pipeline.Id");
			pipeline.Name = context.StringValue("AddPornPipeline.Pipeline.Name");
			pipeline.Priority = context.IntegerValue("AddPornPipeline.Pipeline.Priority");
			pipeline.State = context.StringValue("AddPornPipeline.Pipeline.State");

			AddPornPipelineResponse.AddPornPipeline_Pipeline.AddPornPipeline_NotifyConfig notifyConfig = new AddPornPipelineResponse.AddPornPipeline_Pipeline.AddPornPipeline_NotifyConfig();
			notifyConfig.Topic = context.StringValue("AddPornPipeline.Pipeline.NotifyConfig.Topic");
			notifyConfig.Queue = context.StringValue("AddPornPipeline.Pipeline.NotifyConfig.Queue");
			pipeline.NotifyConfig = notifyConfig;
			addPornPipelineResponse.Pipeline = pipeline;
        
			return addPornPipelineResponse;
        }
    }
}