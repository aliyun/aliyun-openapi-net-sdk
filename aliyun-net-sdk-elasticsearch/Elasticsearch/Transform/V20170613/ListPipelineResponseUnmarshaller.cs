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
using Aliyun.Acs.elasticsearch.Model.V20170613;

namespace Aliyun.Acs.elasticsearch.Transform.V20170613
{
    public class ListPipelineResponseUnmarshaller
    {
        public static ListPipelineResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListPipelineResponse listPipelineResponse = new ListPipelineResponse();

			listPipelineResponse.HttpResponse = _ctx.HttpResponse;
			listPipelineResponse.RequestId = _ctx.StringValue("ListPipeline.RequestId");

			ListPipelineResponse.ListPipeline_Headers headers = new ListPipelineResponse.ListPipeline_Headers();
			headers.XTotalCount = _ctx.IntegerValue("ListPipeline.Headers.X-Total-Count");
			listPipelineResponse.Headers = headers;

			List<ListPipelineResponse.ListPipeline_ResultItem> listPipelineResponse_result = new List<ListPipelineResponse.ListPipeline_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListPipeline.Result.Length"); i++) {
				ListPipelineResponse.ListPipeline_ResultItem resultItem = new ListPipelineResponse.ListPipeline_ResultItem();
				resultItem.PipelineId = _ctx.StringValue("ListPipeline.Result["+ i +"].pipelineId");
				resultItem.PipelineStatus = _ctx.StringValue("ListPipeline.Result["+ i +"].pipelineStatus");
				resultItem.GmtCreatedTime = _ctx.StringValue("ListPipeline.Result["+ i +"].gmtCreatedTime");
				resultItem.GmtUpdateTime = _ctx.StringValue("ListPipeline.Result["+ i +"].gmtUpdateTime");

				listPipelineResponse_result.Add(resultItem);
			}
			listPipelineResponse.Result = listPipelineResponse_result;
        
			return listPipelineResponse;
        }
    }
}
