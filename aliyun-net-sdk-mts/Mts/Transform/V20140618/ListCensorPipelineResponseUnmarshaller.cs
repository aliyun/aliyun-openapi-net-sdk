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
    public class ListCensorPipelineResponseUnmarshaller
    {
        public static ListCensorPipelineResponse Unmarshall(UnmarshallerContext context)
        {
			ListCensorPipelineResponse listCensorPipelineResponse = new ListCensorPipelineResponse();

			listCensorPipelineResponse.HttpResponse = context.HttpResponse;
			listCensorPipelineResponse.RequestId = context.StringValue("ListCensorPipeline.RequestId");
			listCensorPipelineResponse.TotalCount = context.LongValue("ListCensorPipeline.TotalCount");
			listCensorPipelineResponse.PageNumber = context.LongValue("ListCensorPipeline.PageNumber");
			listCensorPipelineResponse.PageSize = context.LongValue("ListCensorPipeline.PageSize");

			List<ListCensorPipelineResponse.ListCensorPipeline_Pipeline> listCensorPipelineResponse_pipelineList = new List<ListCensorPipelineResponse.ListCensorPipeline_Pipeline>();
			for (int i = 0; i < context.Length("ListCensorPipeline.PipelineList.Length"); i++) {
				ListCensorPipelineResponse.ListCensorPipeline_Pipeline pipeline = new ListCensorPipelineResponse.ListCensorPipeline_Pipeline();
				pipeline.Id = context.StringValue("ListCensorPipeline.PipelineList["+ i +"].Id");
				pipeline.Name = context.StringValue("ListCensorPipeline.PipelineList["+ i +"].Name");
				pipeline.State = context.StringValue("ListCensorPipeline.PipelineList["+ i +"].State");
				pipeline.Priority = context.StringValue("ListCensorPipeline.PipelineList["+ i +"].Priority");

				ListCensorPipelineResponse.ListCensorPipeline_Pipeline.ListCensorPipeline_NotifyConfig notifyConfig = new ListCensorPipelineResponse.ListCensorPipeline_Pipeline.ListCensorPipeline_NotifyConfig();
				notifyConfig.Topic = context.StringValue("ListCensorPipeline.PipelineList["+ i +"].NotifyConfig.Topic");
				notifyConfig.Queue = context.StringValue("ListCensorPipeline.PipelineList["+ i +"].NotifyConfig.Queue");
				pipeline.NotifyConfig = notifyConfig;

				listCensorPipelineResponse_pipelineList.Add(pipeline);
			}
			listCensorPipelineResponse.PipelineList = listCensorPipelineResponse_pipelineList;
        
			return listCensorPipelineResponse;
        }
    }
}