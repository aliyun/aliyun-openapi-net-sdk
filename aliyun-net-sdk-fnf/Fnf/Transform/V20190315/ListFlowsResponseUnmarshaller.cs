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
using Aliyun.Acs.fnf.Model.V20190315;

namespace Aliyun.Acs.fnf.Transform.V20190315
{
    public class ListFlowsResponseUnmarshaller
    {
        public static ListFlowsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListFlowsResponse listFlowsResponse = new ListFlowsResponse();

			listFlowsResponse.HttpResponse = _ctx.HttpResponse;
			listFlowsResponse.RequestId = _ctx.StringValue("ListFlows.RequestId");
			listFlowsResponse.NextToken = _ctx.StringValue("ListFlows.NextToken");

			List<ListFlowsResponse.ListFlows_FlowsItem> listFlowsResponse_flows = new List<ListFlowsResponse.ListFlows_FlowsItem>();
			for (int i = 0; i < _ctx.Length("ListFlows.Flows.Length"); i++) {
				ListFlowsResponse.ListFlows_FlowsItem flowsItem = new ListFlowsResponse.ListFlows_FlowsItem();
				flowsItem.Name = _ctx.StringValue("ListFlows.Flows["+ i +"].Name");
				flowsItem.Description = _ctx.StringValue("ListFlows.Flows["+ i +"].Description");
				flowsItem.Definition = _ctx.StringValue("ListFlows.Flows["+ i +"].Definition");
				flowsItem.Id = _ctx.StringValue("ListFlows.Flows["+ i +"].Id");
				flowsItem.Type = _ctx.StringValue("ListFlows.Flows["+ i +"].Type");
				flowsItem.RoleArn = _ctx.StringValue("ListFlows.Flows["+ i +"].RoleArn");
				flowsItem.CreatedTime = _ctx.StringValue("ListFlows.Flows["+ i +"].CreatedTime");
				flowsItem.LastModifiedTime = _ctx.StringValue("ListFlows.Flows["+ i +"].LastModifiedTime");
				flowsItem.ExternalStorageLocation = _ctx.StringValue("ListFlows.Flows["+ i +"].ExternalStorageLocation");

				listFlowsResponse_flows.Add(flowsItem);
			}
			listFlowsResponse.Flows = listFlowsResponse_flows;
        
			return listFlowsResponse;
        }
    }
}
