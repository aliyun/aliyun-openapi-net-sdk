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

namespace Aliyun.Acs.Mts.Transform.V20140618
{
    public class AddPipelineResponseUnmarshaller
    {
        public static AddPipelineResponse Unmarshall(UnmarshallerContext context)
        {
            AddPipelineResponse addPipelineResponse = new AddPipelineResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("AddPipeline.RequestId")
            };
            AddPipelineResponse.Pipeline_ pipeline = new AddPipelineResponse.Pipeline_()
            {
                Id = context.StringValue("AddPipeline.Pipeline.Id"),
                Name = context.StringValue("AddPipeline.Pipeline.Name"),
                State = context.StringValue("AddPipeline.Pipeline.State"),
                Speed = context.StringValue("AddPipeline.Pipeline.Speed"),
                Role = context.StringValue("AddPipeline.Pipeline.Role")
            };
            AddPipelineResponse.Pipeline_.NotifyConfig_ notifyConfig = new AddPipelineResponse.Pipeline_.NotifyConfig_()
            {
                Topic = context.StringValue("AddPipeline.Pipeline.NotifyConfig.Topic"),
                QueueName = context.StringValue("AddPipeline.Pipeline.NotifyConfig.QueueName")
            };
            pipeline.NotifyConfig = notifyConfig;
			addPipelineResponse.Pipeline = pipeline;
        
			return addPipelineResponse;
        }
    }
}