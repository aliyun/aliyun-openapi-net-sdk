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
    public class ListAsrPipelineResponseUnmarshaller
    {
        public static ListAsrPipelineResponse Unmarshall(UnmarshallerContext context)
        {
			ListAsrPipelineResponse listAsrPipelineResponse = new ListAsrPipelineResponse();

			listAsrPipelineResponse.HttpResponse = context.HttpResponse;
			listAsrPipelineResponse.RequestId = context.StringValue("ListAsrPipeline.RequestId");
			listAsrPipelineResponse.TotalCount = context.LongValue("ListAsrPipeline.TotalCount");
			listAsrPipelineResponse.PageNumber = context.LongValue("ListAsrPipeline.PageNumber");
			listAsrPipelineResponse.PageSize = context.LongValue("ListAsrPipeline.PageSize");

			List<ListAsrPipelineResponse.ListAsrPipeline_Pipeline> listAsrPipelineResponse_pipelineList = new List<ListAsrPipelineResponse.ListAsrPipeline_Pipeline>();
			for (int i = 0; i < context.Length("ListAsrPipeline.PipelineList.Length"); i++) {
				ListAsrPipelineResponse.ListAsrPipeline_Pipeline pipeline = new ListAsrPipelineResponse.ListAsrPipeline_Pipeline();
				pipeline.Id = context.StringValue("ListAsrPipeline.PipelineList["+ i +"].Id");
				pipeline.Name = context.StringValue("ListAsrPipeline.PipelineList["+ i +"].Name");
				pipeline.State = context.StringValue("ListAsrPipeline.PipelineList["+ i +"].State");
				pipeline.Priority = context.StringValue("ListAsrPipeline.PipelineList["+ i +"].Priority");

				ListAsrPipelineResponse.ListAsrPipeline_Pipeline.ListAsrPipeline_NotifyConfig notifyConfig = new ListAsrPipelineResponse.ListAsrPipeline_Pipeline.ListAsrPipeline_NotifyConfig();
				notifyConfig.Topic = context.StringValue("ListAsrPipeline.PipelineList["+ i +"].NotifyConfig.Topic");
				notifyConfig.QueueName = context.StringValue("ListAsrPipeline.PipelineList["+ i +"].NotifyConfig.QueueName");
				pipeline.NotifyConfig = notifyConfig;

				listAsrPipelineResponse_pipelineList.Add(pipeline);
			}
			listAsrPipelineResponse.PipelineList = listAsrPipelineResponse_pipelineList;
        
			return listAsrPipelineResponse;
        }
    }
}