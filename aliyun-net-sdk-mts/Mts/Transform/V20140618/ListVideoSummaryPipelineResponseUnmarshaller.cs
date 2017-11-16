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
    public class ListVideoSummaryPipelineResponseUnmarshaller
    {
        public static ListVideoSummaryPipelineResponse Unmarshall(UnmarshallerContext context)
        {
			ListVideoSummaryPipelineResponse listVideoSummaryPipelineResponse = new ListVideoSummaryPipelineResponse();

			listVideoSummaryPipelineResponse.HttpResponse = context.HttpResponse;
			listVideoSummaryPipelineResponse.RequestId = context.StringValue("ListVideoSummaryPipeline.RequestId");
			listVideoSummaryPipelineResponse.TotalCount = context.LongValue("ListVideoSummaryPipeline.TotalCount");
			listVideoSummaryPipelineResponse.PageNumber = context.LongValue("ListVideoSummaryPipeline.PageNumber");
			listVideoSummaryPipelineResponse.PageSize = context.LongValue("ListVideoSummaryPipeline.PageSize");

			List<ListVideoSummaryPipelineResponse.ListVideoSummaryPipeline_Pipeline> listVideoSummaryPipelineResponse_pipelineList = new List<ListVideoSummaryPipelineResponse.ListVideoSummaryPipeline_Pipeline>();
			for (int i = 0; i < context.Length("ListVideoSummaryPipeline.PipelineList.Length"); i++) {
				ListVideoSummaryPipelineResponse.ListVideoSummaryPipeline_Pipeline pipeline = new ListVideoSummaryPipelineResponse.ListVideoSummaryPipeline_Pipeline();
				pipeline.Id = context.StringValue("ListVideoSummaryPipeline.PipelineList["+ i +"].Id");
				pipeline.Name = context.StringValue("ListVideoSummaryPipeline.PipelineList["+ i +"].Name");
				pipeline.State = context.StringValue("ListVideoSummaryPipeline.PipelineList["+ i +"].State");
				pipeline.Priority = context.StringValue("ListVideoSummaryPipeline.PipelineList["+ i +"].Priority");

				ListVideoSummaryPipelineResponse.ListVideoSummaryPipeline_Pipeline.ListVideoSummaryPipeline_NotifyConfig notifyConfig = new ListVideoSummaryPipelineResponse.ListVideoSummaryPipeline_Pipeline.ListVideoSummaryPipeline_NotifyConfig();
				notifyConfig.Topic = context.StringValue("ListVideoSummaryPipeline.PipelineList["+ i +"].NotifyConfig.Topic");
				notifyConfig.QueueName = context.StringValue("ListVideoSummaryPipeline.PipelineList["+ i +"].NotifyConfig.QueueName");
				pipeline.NotifyConfig = notifyConfig;

				listVideoSummaryPipelineResponse_pipelineList.Add(pipeline);
			}
			listVideoSummaryPipelineResponse.PipelineList = listVideoSummaryPipelineResponse_pipelineList;
        
			return listVideoSummaryPipelineResponse;
        }
    }
}