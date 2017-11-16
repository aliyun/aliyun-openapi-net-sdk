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
    public class AddCensorPipelineResponseUnmarshaller
    {
        public static AddCensorPipelineResponse Unmarshall(UnmarshallerContext context)
        {
			AddCensorPipelineResponse addCensorPipelineResponse = new AddCensorPipelineResponse();

			addCensorPipelineResponse.HttpResponse = context.HttpResponse;
			addCensorPipelineResponse.RequestId = context.StringValue("AddCensorPipeline.RequestId");

			AddCensorPipelineResponse.AddCensorPipeline_Pipeline pipeline = new AddCensorPipelineResponse.AddCensorPipeline_Pipeline();
			pipeline.Id = context.StringValue("AddCensorPipeline.Pipeline.Id");
			pipeline.Name = context.StringValue("AddCensorPipeline.Pipeline.Name");
			pipeline.Priority = context.IntegerValue("AddCensorPipeline.Pipeline.Priority");
			pipeline.State = context.StringValue("AddCensorPipeline.Pipeline.State");

			AddCensorPipelineResponse.AddCensorPipeline_Pipeline.AddCensorPipeline_NotifyConfig notifyConfig = new AddCensorPipelineResponse.AddCensorPipeline_Pipeline.AddCensorPipeline_NotifyConfig();
			notifyConfig.Topic = context.StringValue("AddCensorPipeline.Pipeline.NotifyConfig.Topic");
			notifyConfig.Queue = context.StringValue("AddCensorPipeline.Pipeline.NotifyConfig.Queue");
			pipeline.NotifyConfig = notifyConfig;
			addCensorPipelineResponse.Pipeline = pipeline;
        
			return addCensorPipelineResponse;
        }
    }
}