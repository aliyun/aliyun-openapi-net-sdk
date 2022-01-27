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
using Aliyun.Acs.companyreg.Model.V20201022;

namespace Aliyun.Acs.companyreg.Transform.V20201022
{
    public class GetInitFlowResponseUnmarshaller
    {
        public static GetInitFlowResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetInitFlowResponse getInitFlowResponse = new GetInitFlowResponse();

			getInitFlowResponse.HttpResponse = _ctx.HttpResponse;
			getInitFlowResponse.FlowStatus = _ctx.StringValue("GetInitFlow.FlowStatus");
			getInitFlowResponse.RequestId = _ctx.StringValue("GetInitFlow.RequestId");

			List<GetInitFlowResponse.GetInitFlow_NodeListItem> getInitFlowResponse_nodeList = new List<GetInitFlowResponse.GetInitFlow_NodeListItem>();
			for (int i = 0; i < _ctx.Length("GetInitFlow.NodeList.Length"); i++) {
				GetInitFlowResponse.GetInitFlow_NodeListItem nodeListItem = new GetInitFlowResponse.GetInitFlow_NodeListItem();
				nodeListItem.Index = _ctx.IntegerValue("GetInitFlow.NodeList["+ i +"].Index");
				nodeListItem.Status = _ctx.StringValue("GetInitFlow.NodeList["+ i +"].Status");
				nodeListItem.Description = _ctx.StringValue("GetInitFlow.NodeList["+ i +"].Description");
				nodeListItem.Code = _ctx.StringValue("GetInitFlow.NodeList["+ i +"].Code");
				nodeListItem.Name = _ctx.StringValue("GetInitFlow.NodeList["+ i +"].Name");
				nodeListItem.FailReason = _ctx.StringValue("GetInitFlow.NodeList["+ i +"].FailReason");
				nodeListItem.Id = _ctx.IntegerValue("GetInitFlow.NodeList["+ i +"].Id");

				getInitFlowResponse_nodeList.Add(nodeListItem);
			}
			getInitFlowResponse.NodeList = getInitFlowResponse_nodeList;
        
			return getInitFlowResponse;
        }
    }
}
