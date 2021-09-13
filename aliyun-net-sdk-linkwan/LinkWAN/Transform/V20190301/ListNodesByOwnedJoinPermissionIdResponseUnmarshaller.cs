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
    public class ListNodesByOwnedJoinPermissionIdResponseUnmarshaller
    {
        public static ListNodesByOwnedJoinPermissionIdResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListNodesByOwnedJoinPermissionIdResponse listNodesByOwnedJoinPermissionIdResponse = new ListNodesByOwnedJoinPermissionIdResponse();

			listNodesByOwnedJoinPermissionIdResponse.HttpResponse = _ctx.HttpResponse;
			listNodesByOwnedJoinPermissionIdResponse.RequestId = _ctx.StringValue("ListNodesByOwnedJoinPermissionId.RequestId");
			listNodesByOwnedJoinPermissionIdResponse.Success = _ctx.BooleanValue("ListNodesByOwnedJoinPermissionId.Success");

			ListNodesByOwnedJoinPermissionIdResponse.ListNodesByOwnedJoinPermissionId_Data data = new ListNodesByOwnedJoinPermissionIdResponse.ListNodesByOwnedJoinPermissionId_Data();
			data.TotalCount = _ctx.LongValue("ListNodesByOwnedJoinPermissionId.Data.TotalCount");

			List<ListNodesByOwnedJoinPermissionIdResponse.ListNodesByOwnedJoinPermissionId_Data.ListNodesByOwnedJoinPermissionId_Node> data_list = new List<ListNodesByOwnedJoinPermissionIdResponse.ListNodesByOwnedJoinPermissionId_Data.ListNodesByOwnedJoinPermissionId_Node>();
			for (int i = 0; i < _ctx.Length("ListNodesByOwnedJoinPermissionId.Data.List.Length"); i++) {
				ListNodesByOwnedJoinPermissionIdResponse.ListNodesByOwnedJoinPermissionId_Data.ListNodesByOwnedJoinPermissionId_Node node = new ListNodesByOwnedJoinPermissionIdResponse.ListNodesByOwnedJoinPermissionId_Data.ListNodesByOwnedJoinPermissionId_Node();
				node.DevEui = _ctx.StringValue("ListNodesByOwnedJoinPermissionId.Data.List["+ i +"].DevEui");
				node.DevAddr = _ctx.StringValue("ListNodesByOwnedJoinPermissionId.Data.List["+ i +"].DevAddr");
				node.ClassMode = _ctx.StringValue("ListNodesByOwnedJoinPermissionId.Data.List["+ i +"].ClassMode");
				node.LastJoinMillis = _ctx.LongValue("ListNodesByOwnedJoinPermissionId.Data.List["+ i +"].LastJoinMillis");
				node.BoundMillis = _ctx.LongValue("ListNodesByOwnedJoinPermissionId.Data.List["+ i +"].BoundMillis");

				data_list.Add(node);
			}
			data.List = data_list;
			listNodesByOwnedJoinPermissionIdResponse.Data = data;
        
			return listNodesByOwnedJoinPermissionIdResponse;
        }
    }
}
