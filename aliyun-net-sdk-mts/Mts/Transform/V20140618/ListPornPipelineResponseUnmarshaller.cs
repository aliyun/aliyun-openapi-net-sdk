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
    public class ListPornPipelineResponseUnmarshaller
    {
        public static ListPornPipelineResponse Unmarshall(UnmarshallerContext context)
        {
			ListPornPipelineResponse listPornPipelineResponse = new ListPornPipelineResponse();

			listPornPipelineResponse.HttpResponse = context.HttpResponse;
			listPornPipelineResponse.RequestId = context.StringValue("ListPornPipeline.RequestId");
			listPornPipelineResponse.TotalCount = context.LongValue("ListPornPipeline.TotalCount");
			listPornPipelineResponse.PageNumber = context.LongValue("ListPornPipeline.PageNumber");
			listPornPipelineResponse.PageSize = context.LongValue("ListPornPipeline.PageSize");

			List<ListPornPipelineResponse.ListPornPipeline_Pipeline> listPornPipelineResponse_pipelineList = new List<ListPornPipelineResponse.ListPornPipeline_Pipeline>();
			for (int i = 0; i < context.Length("ListPornPipeline.PipelineList.Length"); i++) {
				ListPornPipelineResponse.ListPornPipeline_Pipeline pipeline = new ListPornPipelineResponse.ListPornPipeline_Pipeline();
				pipeline.Id = context.StringValue("ListPornPipeline.PipelineList["+ i +"].Id");
				pipeline.Name = context.StringValue("ListPornPipeline.PipelineList["+ i +"].Name");
				pipeline.State = context.StringValue("ListPornPipeline.PipelineList["+ i +"].State");
				pipeline.Priority = context.StringValue("ListPornPipeline.PipelineList["+ i +"].Priority");

				ListPornPipelineResponse.ListPornPipeline_Pipeline.ListPornPipeline_NotifyConfig notifyConfig = new ListPornPipelineResponse.ListPornPipeline_Pipeline.ListPornPipeline_NotifyConfig();
				notifyConfig.Topic = context.StringValue("ListPornPipeline.PipelineList["+ i +"].NotifyConfig.Topic");
				notifyConfig.Queue = context.StringValue("ListPornPipeline.PipelineList["+ i +"].NotifyConfig.Queue");
				pipeline.NotifyConfig = notifyConfig;

				listPornPipelineResponse_pipelineList.Add(pipeline);
			}
			listPornPipelineResponse.PipelineList = listPornPipelineResponse_pipelineList;
        
			return listPornPipelineResponse;
        }
    }
}