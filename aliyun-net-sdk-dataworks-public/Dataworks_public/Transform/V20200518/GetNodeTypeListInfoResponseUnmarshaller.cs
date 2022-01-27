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
using Aliyun.Acs.dataworks_public.Model.V20200518;

namespace Aliyun.Acs.dataworks_public.Transform.V20200518
{
    public class GetNodeTypeListInfoResponseUnmarshaller
    {
        public static GetNodeTypeListInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetNodeTypeListInfoResponse getNodeTypeListInfoResponse = new GetNodeTypeListInfoResponse();

			getNodeTypeListInfoResponse.HttpResponse = _ctx.HttpResponse;
			getNodeTypeListInfoResponse.RequestId = _ctx.StringValue("GetNodeTypeListInfo.RequestId");

			GetNodeTypeListInfoResponse.GetNodeTypeListInfo_NodeTypeInfoList nodeTypeInfoList = new GetNodeTypeListInfoResponse.GetNodeTypeListInfo_NodeTypeInfoList();
			nodeTypeInfoList.PageNumber = _ctx.IntegerValue("GetNodeTypeListInfo.NodeTypeInfoList.PageNumber");
			nodeTypeInfoList.PageSize = _ctx.IntegerValue("GetNodeTypeListInfo.NodeTypeInfoList.PageSize");
			nodeTypeInfoList.TotalCount = _ctx.IntegerValue("GetNodeTypeListInfo.NodeTypeInfoList.TotalCount");

			List<GetNodeTypeListInfoResponse.GetNodeTypeListInfo_NodeTypeInfoList.GetNodeTypeListInfo_NodeTypeInfoItem> nodeTypeInfoList_nodeTypeInfo = new List<GetNodeTypeListInfoResponse.GetNodeTypeListInfo_NodeTypeInfoList.GetNodeTypeListInfo_NodeTypeInfoItem>();
			for (int i = 0; i < _ctx.Length("GetNodeTypeListInfo.NodeTypeInfoList.NodeTypeInfo.Length"); i++) {
				GetNodeTypeListInfoResponse.GetNodeTypeListInfo_NodeTypeInfoList.GetNodeTypeListInfo_NodeTypeInfoItem nodeTypeInfoItem = new GetNodeTypeListInfoResponse.GetNodeTypeListInfo_NodeTypeInfoList.GetNodeTypeListInfo_NodeTypeInfoItem();
				nodeTypeInfoItem.NodeType = _ctx.IntegerValue("GetNodeTypeListInfo.NodeTypeInfoList.NodeTypeInfo["+ i +"].NodeType");
				nodeTypeInfoItem.NodeTypeName = _ctx.StringValue("GetNodeTypeListInfo.NodeTypeInfoList.NodeTypeInfo["+ i +"].NodeTypeName");

				nodeTypeInfoList_nodeTypeInfo.Add(nodeTypeInfoItem);
			}
			nodeTypeInfoList.NodeTypeInfo = nodeTypeInfoList_nodeTypeInfo;
			getNodeTypeListInfoResponse.NodeTypeInfoList = nodeTypeInfoList;
        
			return getNodeTypeListInfoResponse;
        }
    }
}
