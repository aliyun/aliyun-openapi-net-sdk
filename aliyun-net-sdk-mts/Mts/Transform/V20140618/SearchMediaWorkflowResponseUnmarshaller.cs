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
    public class SearchMediaWorkflowResponseUnmarshaller
    {
        public static SearchMediaWorkflowResponse Unmarshall(UnmarshallerContext context)
        {
			SearchMediaWorkflowResponse searchMediaWorkflowResponse = new SearchMediaWorkflowResponse();

			searchMediaWorkflowResponse.HttpResponse = context.HttpResponse;
			searchMediaWorkflowResponse.RequestId = context.StringValue("SearchMediaWorkflow.RequestId");
			searchMediaWorkflowResponse.TotalCount = context.LongValue("SearchMediaWorkflow.TotalCount");
			searchMediaWorkflowResponse.PageNumber = context.LongValue("SearchMediaWorkflow.PageNumber");
			searchMediaWorkflowResponse.PageSize = context.LongValue("SearchMediaWorkflow.PageSize");

			List<SearchMediaWorkflowResponse.SearchMediaWorkflow_MediaWorkflow> searchMediaWorkflowResponse_mediaWorkflowList = new List<SearchMediaWorkflowResponse.SearchMediaWorkflow_MediaWorkflow>();
			for (int i = 0; i < context.Length("SearchMediaWorkflow.MediaWorkflowList.Length"); i++) {
				SearchMediaWorkflowResponse.SearchMediaWorkflow_MediaWorkflow mediaWorkflow = new SearchMediaWorkflowResponse.SearchMediaWorkflow_MediaWorkflow();
				mediaWorkflow.MediaWorkflowId = context.StringValue("SearchMediaWorkflow.MediaWorkflowList["+ i +"].MediaWorkflowId");
				mediaWorkflow.Name = context.StringValue("SearchMediaWorkflow.MediaWorkflowList["+ i +"].Name");
				mediaWorkflow.Topology = context.StringValue("SearchMediaWorkflow.MediaWorkflowList["+ i +"].Topology");
				mediaWorkflow.TriggerMode = context.StringValue("SearchMediaWorkflow.MediaWorkflowList["+ i +"].TriggerMode");
				mediaWorkflow.State = context.StringValue("SearchMediaWorkflow.MediaWorkflowList["+ i +"].State");
				mediaWorkflow.CreationTime = context.StringValue("SearchMediaWorkflow.MediaWorkflowList["+ i +"].CreationTime");

				searchMediaWorkflowResponse_mediaWorkflowList.Add(mediaWorkflow);
			}
			searchMediaWorkflowResponse.MediaWorkflowList = searchMediaWorkflowResponse_mediaWorkflowList;
        
			return searchMediaWorkflowResponse;
        }
    }
}