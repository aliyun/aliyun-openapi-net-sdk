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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Mts.Model.V20140618;

namespace Aliyun.Acs.Mts.Transform.V20140618
{
    public class ListCoverPipelineResponseUnmarshaller
    {
        public static ListCoverPipelineResponse Unmarshall(UnmarshallerContext context)
        {
			ListCoverPipelineResponse listCoverPipelineResponse = new ListCoverPipelineResponse();

			listCoverPipelineResponse.HttpResponse = context.HttpResponse;
			listCoverPipelineResponse.RequestId = context.StringValue("ListCoverPipeline.RequestId");
			listCoverPipelineResponse.TotalCount = context.LongValue("ListCoverPipeline.TotalCount");
			listCoverPipelineResponse.PageNumber = context.LongValue("ListCoverPipeline.PageNumber");
			listCoverPipelineResponse.PageSize = context.LongValue("ListCoverPipeline.PageSize");

			List<ListCoverPipelineResponse.ListCoverPipeline_Pipeline> listCoverPipelineResponse_pipelineList = new List<ListCoverPipelineResponse.ListCoverPipeline_Pipeline>();
			for (int i = 0; i < context.Length("ListCoverPipeline.PipelineList.Length"); i++) {
				ListCoverPipelineResponse.ListCoverPipeline_Pipeline pipeline = new ListCoverPipelineResponse.ListCoverPipeline_Pipeline();
				pipeline.UserId = context.LongValue("ListCoverPipeline.PipelineList["+ i +"].UserId");
				pipeline.PipelineId = context.StringValue("ListCoverPipeline.PipelineList["+ i +"].PipelineId");
				pipeline.Name = context.StringValue("ListCoverPipeline.PipelineList["+ i +"].Name");
				pipeline.State = context.StringValue("ListCoverPipeline.PipelineList["+ i +"].State");
				pipeline.Priority = context.StringValue("ListCoverPipeline.PipelineList["+ i +"].Priority");
				pipeline.QuotaNum = context.IntegerValue("ListCoverPipeline.PipelineList["+ i +"].quotaNum");
				pipeline.QuotaUsed = context.IntegerValue("ListCoverPipeline.PipelineList["+ i +"].quotaUsed");
				pipeline.NotifyConfig = context.StringValue("ListCoverPipeline.PipelineList["+ i +"].NotifyConfig");
				pipeline.Role = context.StringValue("ListCoverPipeline.PipelineList["+ i +"].Role");
				pipeline.ExtendConfig = context.StringValue("ListCoverPipeline.PipelineList["+ i +"].ExtendConfig");

				listCoverPipelineResponse_pipelineList.Add(pipeline);
			}
			listCoverPipelineResponse.PipelineList = listCoverPipelineResponse_pipelineList;
        
			return listCoverPipelineResponse;
        }
    }
}
