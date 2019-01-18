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
    public class ListTerrorismPipelineResponseUnmarshaller
    {
        public static ListTerrorismPipelineResponse Unmarshall(UnmarshallerContext context)
        {
			ListTerrorismPipelineResponse listTerrorismPipelineResponse = new ListTerrorismPipelineResponse();

			listTerrorismPipelineResponse.HttpResponse = context.HttpResponse;
			listTerrorismPipelineResponse.RequestId = context.StringValue("ListTerrorismPipeline.RequestId");
			listTerrorismPipelineResponse.TotalCount = context.LongValue("ListTerrorismPipeline.TotalCount");
			listTerrorismPipelineResponse.PageNumber = context.LongValue("ListTerrorismPipeline.PageNumber");
			listTerrorismPipelineResponse.PageSize = context.LongValue("ListTerrorismPipeline.PageSize");

			List<ListTerrorismPipelineResponse.ListTerrorismPipeline_Pipeline> listTerrorismPipelineResponse_pipelineList = new List<ListTerrorismPipelineResponse.ListTerrorismPipeline_Pipeline>();
			for (int i = 0; i < context.Length("ListTerrorismPipeline.PipelineList.Length"); i++) {
				ListTerrorismPipelineResponse.ListTerrorismPipeline_Pipeline pipeline = new ListTerrorismPipelineResponse.ListTerrorismPipeline_Pipeline();
				pipeline.Id = context.StringValue("ListTerrorismPipeline.PipelineList["+ i +"].Id");
				pipeline.Name = context.StringValue("ListTerrorismPipeline.PipelineList["+ i +"].Name");
				pipeline.State = context.StringValue("ListTerrorismPipeline.PipelineList["+ i +"].State");
				pipeline.Priority = context.StringValue("ListTerrorismPipeline.PipelineList["+ i +"].Priority");

				ListTerrorismPipelineResponse.ListTerrorismPipeline_Pipeline.ListTerrorismPipeline_NotifyConfig notifyConfig = new ListTerrorismPipelineResponse.ListTerrorismPipeline_Pipeline.ListTerrorismPipeline_NotifyConfig();
				notifyConfig.Topic = context.StringValue("ListTerrorismPipeline.PipelineList["+ i +"].NotifyConfig.Topic");
				notifyConfig.Queue = context.StringValue("ListTerrorismPipeline.PipelineList["+ i +"].NotifyConfig.Queue");
				pipeline.NotifyConfig = notifyConfig;

				listTerrorismPipelineResponse_pipelineList.Add(pipeline);
			}
			listTerrorismPipelineResponse.PipelineList = listTerrorismPipelineResponse_pipelineList;
        
			return listTerrorismPipelineResponse;
        }
    }
}