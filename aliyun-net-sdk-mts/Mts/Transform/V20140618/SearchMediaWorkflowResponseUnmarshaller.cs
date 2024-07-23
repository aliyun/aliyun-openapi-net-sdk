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
    public class SearchMediaWorkflowResponseUnmarshaller
    {
        public static SearchMediaWorkflowResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SearchMediaWorkflowResponse searchMediaWorkflowResponse = new SearchMediaWorkflowResponse();

			searchMediaWorkflowResponse.HttpResponse = _ctx.HttpResponse;
			searchMediaWorkflowResponse.TotalCount = _ctx.LongValue("SearchMediaWorkflow.TotalCount");
			searchMediaWorkflowResponse.PageSize = _ctx.LongValue("SearchMediaWorkflow.PageSize");
			searchMediaWorkflowResponse.RequestId = _ctx.StringValue("SearchMediaWorkflow.RequestId");
			searchMediaWorkflowResponse.PageNumber = _ctx.LongValue("SearchMediaWorkflow.PageNumber");

			List<SearchMediaWorkflowResponse.SearchMediaWorkflow_MediaWorkflow> searchMediaWorkflowResponse_mediaWorkflowList = new List<SearchMediaWorkflowResponse.SearchMediaWorkflow_MediaWorkflow>();
			for (int i = 0; i < _ctx.Length("SearchMediaWorkflow.MediaWorkflowList.Length"); i++) {
				SearchMediaWorkflowResponse.SearchMediaWorkflow_MediaWorkflow mediaWorkflow = new SearchMediaWorkflowResponse.SearchMediaWorkflow_MediaWorkflow();
				mediaWorkflow.CreationTime = _ctx.StringValue("SearchMediaWorkflow.MediaWorkflowList["+ i +"].CreationTime");
				mediaWorkflow.MediaWorkflowId = _ctx.StringValue("SearchMediaWorkflow.MediaWorkflowList["+ i +"].MediaWorkflowId");
				mediaWorkflow.State = _ctx.StringValue("SearchMediaWorkflow.MediaWorkflowList["+ i +"].State");
				mediaWorkflow.TriggerMode = _ctx.StringValue("SearchMediaWorkflow.MediaWorkflowList["+ i +"].TriggerMode");
				mediaWorkflow.Name = _ctx.StringValue("SearchMediaWorkflow.MediaWorkflowList["+ i +"].Name");
				mediaWorkflow.Topology = _ctx.StringValue("SearchMediaWorkflow.MediaWorkflowList["+ i +"].Topology");

				searchMediaWorkflowResponse_mediaWorkflowList.Add(mediaWorkflow);
			}
			searchMediaWorkflowResponse.MediaWorkflowList = searchMediaWorkflowResponse_mediaWorkflowList;
        
			return searchMediaWorkflowResponse;
        }
    }
}
