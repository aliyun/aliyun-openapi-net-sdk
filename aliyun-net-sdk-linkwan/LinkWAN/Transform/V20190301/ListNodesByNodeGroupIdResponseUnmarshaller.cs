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
using Aliyun.Acs.LinkWAN.Model.V20190301;

namespace Aliyun.Acs.LinkWAN.Transform.V20190301
{
    public class ListNodesByNodeGroupIdResponseUnmarshaller
    {
        public static ListNodesByNodeGroupIdResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListNodesByNodeGroupIdResponse listNodesByNodeGroupIdResponse = new ListNodesByNodeGroupIdResponse();

			listNodesByNodeGroupIdResponse.HttpResponse = _ctx.HttpResponse;
			listNodesByNodeGroupIdResponse.RequestId = _ctx.StringValue("ListNodesByNodeGroupId.RequestId");
			listNodesByNodeGroupIdResponse.Success = _ctx.BooleanValue("ListNodesByNodeGroupId.Success");

			ListNodesByNodeGroupIdResponse.ListNodesByNodeGroupId_Data data = new ListNodesByNodeGroupIdResponse.ListNodesByNodeGroupId_Data();
			data.TotalCount = _ctx.LongValue("ListNodesByNodeGroupId.Data.TotalCount");

			List<ListNodesByNodeGroupIdResponse.ListNodesByNodeGroupId_Data.ListNodesByNodeGroupId_Node> data_list = new List<ListNodesByNodeGroupIdResponse.ListNodesByNodeGroupId_Data.ListNodesByNodeGroupId_Node>();
			for (int i = 0; i < _ctx.Length("ListNodesByNodeGroupId.Data.List.Length"); i++) {
				ListNodesByNodeGroupIdResponse.ListNodesByNodeGroupId_Data.ListNodesByNodeGroupId_Node node = new ListNodesByNodeGroupIdResponse.ListNodesByNodeGroupId_Data.ListNodesByNodeGroupId_Node();
				node.DevEui = _ctx.StringValue("ListNodesByNodeGroupId.Data.List["+ i +"].DevEui");
				node.DevAddr = _ctx.StringValue("ListNodesByNodeGroupId.Data.List["+ i +"].DevAddr");
				node.ClassMode = _ctx.StringValue("ListNodesByNodeGroupId.Data.List["+ i +"].ClassMode");
				node.LastJoinMillis = _ctx.LongValue("ListNodesByNodeGroupId.Data.List["+ i +"].LastJoinMillis");
				node.BoundMillis = _ctx.LongValue("ListNodesByNodeGroupId.Data.List["+ i +"].BoundMillis");
				node.MulticastGroupId = _ctx.StringValue("ListNodesByNodeGroupId.Data.List["+ i +"].MulticastGroupId");
				node.AuthTypes = _ctx.StringValue("ListNodesByNodeGroupId.Data.List["+ i +"].AuthTypes");
				node.JoinEui = _ctx.StringValue("ListNodesByNodeGroupId.Data.List["+ i +"].JoinEui");
				node.Appkey = _ctx.StringValue("ListNodesByNodeGroupId.Data.List["+ i +"].Appkey");
				node.NodeType = _ctx.StringValue("ListNodesByNodeGroupId.Data.List["+ i +"].NodeType");

				data_list.Add(node);
			}
			data.List = data_list;
			listNodesByNodeGroupIdResponse.Data = data;
        
			return listNodesByNodeGroupIdResponse;
        }
    }
}
