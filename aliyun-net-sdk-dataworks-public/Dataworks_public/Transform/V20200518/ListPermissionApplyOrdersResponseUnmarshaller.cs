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
    public class ListPermissionApplyOrdersResponseUnmarshaller
    {
        public static ListPermissionApplyOrdersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListPermissionApplyOrdersResponse listPermissionApplyOrdersResponse = new ListPermissionApplyOrdersResponse();

			listPermissionApplyOrdersResponse.HttpResponse = _ctx.HttpResponse;
			listPermissionApplyOrdersResponse.RequestId = _ctx.StringValue("ListPermissionApplyOrders.RequestId");

			ListPermissionApplyOrdersResponse.ListPermissionApplyOrders_ApplyOrders applyOrders = new ListPermissionApplyOrdersResponse.ListPermissionApplyOrders_ApplyOrders();
			applyOrders.PageSize = _ctx.IntegerValue("ListPermissionApplyOrders.ApplyOrders.PageSize");
			applyOrders.PageNumber = _ctx.IntegerValue("ListPermissionApplyOrders.ApplyOrders.PageNumber");
			applyOrders.TotalCount = _ctx.IntegerValue("ListPermissionApplyOrders.ApplyOrders.TotalCount");

			List<ListPermissionApplyOrdersResponse.ListPermissionApplyOrders_ApplyOrders.ListPermissionApplyOrders_Orders> applyOrders_applyOrder = new List<ListPermissionApplyOrdersResponse.ListPermissionApplyOrders_ApplyOrders.ListPermissionApplyOrders_Orders>();
			for (int i = 0; i < _ctx.Length("ListPermissionApplyOrders.ApplyOrders.ApplyOrder.Length"); i++) {
				ListPermissionApplyOrdersResponse.ListPermissionApplyOrders_ApplyOrders.ListPermissionApplyOrders_Orders orders = new ListPermissionApplyOrdersResponse.ListPermissionApplyOrders_ApplyOrders.ListPermissionApplyOrders_Orders();
				orders.FlowId = _ctx.StringValue("ListPermissionApplyOrders.ApplyOrders.ApplyOrder["+ i +"].FlowId");
				orders.ApplyBaseId = _ctx.StringValue("ListPermissionApplyOrders.ApplyOrders.ApplyOrder["+ i +"].ApplyBaseId");
				orders.ApplyTimestamp = _ctx.LongValue("ListPermissionApplyOrders.ApplyOrders.ApplyOrder["+ i +"].ApplyTimestamp");
				orders.FlowStatus = _ctx.IntegerValue("ListPermissionApplyOrders.ApplyOrders.ApplyOrder["+ i +"].FlowStatus");

				ListPermissionApplyOrdersResponse.ListPermissionApplyOrders_ApplyOrders.ListPermissionApplyOrders_Orders.ListPermissionApplyOrders_ApproveContent approveContent = new ListPermissionApplyOrdersResponse.ListPermissionApplyOrders_ApplyOrders.ListPermissionApplyOrders_Orders.ListPermissionApplyOrders_ApproveContent();
				approveContent.ApplyReason = _ctx.StringValue("ListPermissionApplyOrders.ApplyOrders.ApplyOrder["+ i +"].ApproveContent.ApplyReason");
				approveContent.OrderType = _ctx.IntegerValue("ListPermissionApplyOrders.ApplyOrders.ApplyOrder["+ i +"].ApproveContent.OrderType");

				ListPermissionApplyOrdersResponse.ListPermissionApplyOrders_ApplyOrders.ListPermissionApplyOrders_Orders.ListPermissionApplyOrders_ApproveContent.ListPermissionApplyOrders_ProjectMeta projectMeta = new ListPermissionApplyOrdersResponse.ListPermissionApplyOrders_ApplyOrders.ListPermissionApplyOrders_Orders.ListPermissionApplyOrders_ApproveContent.ListPermissionApplyOrders_ProjectMeta();
				projectMeta.WorkspaceName = _ctx.StringValue("ListPermissionApplyOrders.ApplyOrders.ApplyOrder["+ i +"].ApproveContent.ProjectMeta.WorkspaceName");

				List<ListPermissionApplyOrdersResponse.ListPermissionApplyOrders_ApplyOrders.ListPermissionApplyOrders_Orders.ListPermissionApplyOrders_ApproveContent.ListPermissionApplyOrders_ProjectMeta.ListPermissionApplyOrders_ObjectMetaListItem> projectMeta_objectMetaList = new List<ListPermissionApplyOrdersResponse.ListPermissionApplyOrders_ApplyOrders.ListPermissionApplyOrders_Orders.ListPermissionApplyOrders_ApproveContent.ListPermissionApplyOrders_ProjectMeta.ListPermissionApplyOrders_ObjectMetaListItem>();
				for (int j = 0; j < _ctx.Length("ListPermissionApplyOrders.ApplyOrders.ApplyOrder["+ i +"].ApproveContent.ProjectMeta.ObjectMetaList.Length"); j++) {
					ListPermissionApplyOrdersResponse.ListPermissionApplyOrders_ApplyOrders.ListPermissionApplyOrders_Orders.ListPermissionApplyOrders_ApproveContent.ListPermissionApplyOrders_ProjectMeta.ListPermissionApplyOrders_ObjectMetaListItem objectMetaListItem = new ListPermissionApplyOrdersResponse.ListPermissionApplyOrders_ApplyOrders.ListPermissionApplyOrders_Orders.ListPermissionApplyOrders_ApproveContent.ListPermissionApplyOrders_ProjectMeta.ListPermissionApplyOrders_ObjectMetaListItem();
					objectMetaListItem.ObjectName = _ctx.StringValue("ListPermissionApplyOrders.ApplyOrders.ApplyOrder["+ i +"].ApproveContent.ProjectMeta.ObjectMetaList["+ j +"].ObjectName");

					List<string> objectMetaListItem_actions = new List<string>();
					for (int k = 0; k < _ctx.Length("ListPermissionApplyOrders.ApplyOrders.ApplyOrder["+ i +"].ApproveContent.ProjectMeta.ObjectMetaList["+ j +"].Actions.Length"); k++) {
						objectMetaListItem_actions.Add(_ctx.StringValue("ListPermissionApplyOrders.ApplyOrders.ApplyOrder["+ i +"].ApproveContent.ProjectMeta.ObjectMetaList["+ j +"].Actions["+ k +"]"));
					}
					objectMetaListItem.Actions = objectMetaListItem_actions;

					projectMeta_objectMetaList.Add(objectMetaListItem);
				}
				projectMeta.ObjectMetaList = projectMeta_objectMetaList;
				approveContent.ProjectMeta = projectMeta;
				orders.ApproveContent = approveContent;

				applyOrders_applyOrder.Add(orders);
			}
			applyOrders.ApplyOrder = applyOrders_applyOrder;
			listPermissionApplyOrdersResponse.ApplyOrders = applyOrders;
        
			return listPermissionApplyOrdersResponse;
        }
    }
}
