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
    public class QueryMediaWorkflowListResponseUnmarshaller
    {
        public static QueryMediaWorkflowListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryMediaWorkflowListResponse queryMediaWorkflowListResponse = new QueryMediaWorkflowListResponse();

			queryMediaWorkflowListResponse.HttpResponse = _ctx.HttpResponse;
			queryMediaWorkflowListResponse.RequestId = _ctx.StringValue("QueryMediaWorkflowList.RequestId");

			List<string> queryMediaWorkflowListResponse_nonExistMediaWorkflowIds = new List<string>();
			for (int i = 0; i < _ctx.Length("QueryMediaWorkflowList.NonExistMediaWorkflowIds.Length"); i++) {
				queryMediaWorkflowListResponse_nonExistMediaWorkflowIds.Add(_ctx.StringValue("QueryMediaWorkflowList.NonExistMediaWorkflowIds["+ i +"]"));
			}
			queryMediaWorkflowListResponse.NonExistMediaWorkflowIds = queryMediaWorkflowListResponse_nonExistMediaWorkflowIds;

			List<QueryMediaWorkflowListResponse.QueryMediaWorkflowList_MediaWorkflow> queryMediaWorkflowListResponse_mediaWorkflowList = new List<QueryMediaWorkflowListResponse.QueryMediaWorkflowList_MediaWorkflow>();
			for (int i = 0; i < _ctx.Length("QueryMediaWorkflowList.MediaWorkflowList.Length"); i++) {
				QueryMediaWorkflowListResponse.QueryMediaWorkflowList_MediaWorkflow mediaWorkflow = new QueryMediaWorkflowListResponse.QueryMediaWorkflowList_MediaWorkflow();
				mediaWorkflow.CreationTime = _ctx.StringValue("QueryMediaWorkflowList.MediaWorkflowList["+ i +"].CreationTime");
				mediaWorkflow.MediaWorkflowId = _ctx.StringValue("QueryMediaWorkflowList.MediaWorkflowList["+ i +"].MediaWorkflowId");
				mediaWorkflow.State = _ctx.StringValue("QueryMediaWorkflowList.MediaWorkflowList["+ i +"].State");
				mediaWorkflow.TriggerMode = _ctx.StringValue("QueryMediaWorkflowList.MediaWorkflowList["+ i +"].TriggerMode");
				mediaWorkflow.Name = _ctx.StringValue("QueryMediaWorkflowList.MediaWorkflowList["+ i +"].Name");
				mediaWorkflow.Topology = _ctx.StringValue("QueryMediaWorkflowList.MediaWorkflowList["+ i +"].Topology");

				queryMediaWorkflowListResponse_mediaWorkflowList.Add(mediaWorkflow);
			}
			queryMediaWorkflowListResponse.MediaWorkflowList = queryMediaWorkflowListResponse_mediaWorkflowList;
        
			return queryMediaWorkflowListResponse;
        }
    }
}
