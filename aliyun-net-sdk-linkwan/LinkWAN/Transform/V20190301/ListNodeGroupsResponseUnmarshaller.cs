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
    public class ListNodeGroupsResponseUnmarshaller
    {
        public static ListNodeGroupsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListNodeGroupsResponse listNodeGroupsResponse = new ListNodeGroupsResponse();

			listNodeGroupsResponse.HttpResponse = _ctx.HttpResponse;
			listNodeGroupsResponse.RequestId = _ctx.StringValue("ListNodeGroups.RequestId");
			listNodeGroupsResponse.Success = _ctx.BooleanValue("ListNodeGroups.Success");

			ListNodeGroupsResponse.ListNodeGroups_Data data = new ListNodeGroupsResponse.ListNodeGroups_Data();
			data.TotalCount = _ctx.LongValue("ListNodeGroups.Data.TotalCount");

			List<ListNodeGroupsResponse.ListNodeGroups_Data.ListNodeGroups_NodeGroup> data_list = new List<ListNodeGroupsResponse.ListNodeGroups_Data.ListNodeGroups_NodeGroup>();
			for (int i = 0; i < _ctx.Length("ListNodeGroups.Data.List.Length"); i++) {
				ListNodeGroupsResponse.ListNodeGroups_Data.ListNodeGroups_NodeGroup nodeGroup = new ListNodeGroupsResponse.ListNodeGroups_Data.ListNodeGroups_NodeGroup();
				nodeGroup.NodeGroupId = _ctx.StringValue("ListNodeGroups.Data.List["+ i +"].NodeGroupId");
				nodeGroup.NodeGroupName = _ctx.StringValue("ListNodeGroups.Data.List["+ i +"].NodeGroupName");
				nodeGroup.NodesCnt = _ctx.LongValue("ListNodeGroups.Data.List["+ i +"].NodesCnt");
				nodeGroup.DataDispatchEnabled = _ctx.BooleanValue("ListNodeGroups.Data.List["+ i +"].DataDispatchEnabled");
				nodeGroup.JoinPermissionId = _ctx.StringValue("ListNodeGroups.Data.List["+ i +"].JoinPermissionId");
				nodeGroup.JoinPermissionOwnerAliyunId = _ctx.StringValue("ListNodeGroups.Data.List["+ i +"].JoinPermissionOwnerAliyunId");
				nodeGroup.JoinEui = _ctx.StringValue("ListNodeGroups.Data.List["+ i +"].JoinEui");
				nodeGroup.FreqBandPlanGroupId = _ctx.LongValue("ListNodeGroups.Data.List["+ i +"].FreqBandPlanGroupId");
				nodeGroup.ClassMode = _ctx.StringValue("ListNodeGroups.Data.List["+ i +"].ClassMode");
				nodeGroup.JoinPermissionType = _ctx.StringValue("ListNodeGroups.Data.List["+ i +"].JoinPermissionType");
				nodeGroup.JoinPermissionEnabled = _ctx.BooleanValue("ListNodeGroups.Data.List["+ i +"].JoinPermissionEnabled");
				nodeGroup.RxDailySum = _ctx.LongValue("ListNodeGroups.Data.List["+ i +"].RxDailySum");
				nodeGroup.RxMonthSum = _ctx.LongValue("ListNodeGroups.Data.List["+ i +"].RxMonthSum");
				nodeGroup.TxDailySum = _ctx.LongValue("ListNodeGroups.Data.List["+ i +"].TxDailySum");
				nodeGroup.TxMonthSum = _ctx.LongValue("ListNodeGroups.Data.List["+ i +"].TxMonthSum");
				nodeGroup.CreateMillis = _ctx.LongValue("ListNodeGroups.Data.List["+ i +"].CreateMillis");
				nodeGroup.JoinPermissionName = _ctx.StringValue("ListNodeGroups.Data.List["+ i +"].JoinPermissionName");

				ListNodeGroupsResponse.ListNodeGroups_Data.ListNodeGroups_NodeGroup.ListNodeGroups_DataDispatchConfig dataDispatchConfig = new ListNodeGroupsResponse.ListNodeGroups_Data.ListNodeGroups_NodeGroup.ListNodeGroups_DataDispatchConfig();
				dataDispatchConfig.Destination = _ctx.StringValue("ListNodeGroups.Data.List["+ i +"].DataDispatchConfig.Destination");

				ListNodeGroupsResponse.ListNodeGroups_Data.ListNodeGroups_NodeGroup.ListNodeGroups_DataDispatchConfig.ListNodeGroups_IotProduct iotProduct = new ListNodeGroupsResponse.ListNodeGroups_Data.ListNodeGroups_NodeGroup.ListNodeGroups_DataDispatchConfig.ListNodeGroups_IotProduct();
				iotProduct.ProductName = _ctx.StringValue("ListNodeGroups.Data.List["+ i +"].DataDispatchConfig.IotProduct.ProductName");
				iotProduct.ProductKey = _ctx.StringValue("ListNodeGroups.Data.List["+ i +"].DataDispatchConfig.IotProduct.ProductKey");
				iotProduct.ProductType = _ctx.StringValue("ListNodeGroups.Data.List["+ i +"].DataDispatchConfig.IotProduct.ProductType");
				iotProduct.DebugSwitch = _ctx.BooleanValue("ListNodeGroups.Data.List["+ i +"].DataDispatchConfig.IotProduct.DebugSwitch");
				dataDispatchConfig.IotProduct = iotProduct;

				ListNodeGroupsResponse.ListNodeGroups_Data.ListNodeGroups_NodeGroup.ListNodeGroups_DataDispatchConfig.ListNodeGroups_OnsTopics onsTopics = new ListNodeGroupsResponse.ListNodeGroups_Data.ListNodeGroups_NodeGroup.ListNodeGroups_DataDispatchConfig.ListNodeGroups_OnsTopics();
				onsTopics.DownlinkRegionName = _ctx.StringValue("ListNodeGroups.Data.List["+ i +"].DataDispatchConfig.OnsTopics.DownlinkRegionName");
				onsTopics.DownlinkTopic = _ctx.StringValue("ListNodeGroups.Data.List["+ i +"].DataDispatchConfig.OnsTopics.DownlinkTopic");
				onsTopics.UplinkRegionName = _ctx.StringValue("ListNodeGroups.Data.List["+ i +"].DataDispatchConfig.OnsTopics.UplinkRegionName");
				onsTopics.UplinkTopic = _ctx.StringValue("ListNodeGroups.Data.List["+ i +"].DataDispatchConfig.OnsTopics.UplinkTopic");
				dataDispatchConfig.OnsTopics = onsTopics;
				nodeGroup.DataDispatchConfig = dataDispatchConfig;

				List<ListNodeGroupsResponse.ListNodeGroups_Data.ListNodeGroups_NodeGroup.ListNodeGroups__Lock> nodeGroup_locks = new List<ListNodeGroupsResponse.ListNodeGroups_Data.ListNodeGroups_NodeGroup.ListNodeGroups__Lock>();
				for (int j = 0; j < _ctx.Length("ListNodeGroups.Data.List["+ i +"].Locks.Length"); j++) {
					ListNodeGroupsResponse.ListNodeGroups_Data.ListNodeGroups_NodeGroup.ListNodeGroups__Lock _lock = new ListNodeGroupsResponse.ListNodeGroups_Data.ListNodeGroups_NodeGroup.ListNodeGroups__Lock();
					_lock.LockId = _ctx.StringValue("ListNodeGroups.Data.List["+ i +"].Locks["+ j +"].LockId");
					_lock.LockType = _ctx.StringValue("ListNodeGroups.Data.List["+ i +"].Locks["+ j +"].LockType");
					_lock.Enabled = _ctx.BooleanValue("ListNodeGroups.Data.List["+ i +"].Locks["+ j +"].Enabled");
					_lock.CreateMillis = _ctx.LongValue("ListNodeGroups.Data.List["+ i +"].Locks["+ j +"].CreateMillis");

					nodeGroup_locks.Add(_lock);
				}
				nodeGroup.Locks = nodeGroup_locks;

				data_list.Add(nodeGroup);
			}
			data.List = data_list;
			listNodeGroupsResponse.Data = data;
        
			return listNodeGroupsResponse;
        }
    }
}
