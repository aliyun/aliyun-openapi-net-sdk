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
    public class GetNodeGroupResponseUnmarshaller
    {
        public static GetNodeGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetNodeGroupResponse getNodeGroupResponse = new GetNodeGroupResponse();

			getNodeGroupResponse.HttpResponse = _ctx.HttpResponse;
			getNodeGroupResponse.RequestId = _ctx.StringValue("GetNodeGroup.RequestId");
			getNodeGroupResponse.Success = _ctx.BooleanValue("GetNodeGroup.Success");

			GetNodeGroupResponse.GetNodeGroup_Data data = new GetNodeGroupResponse.GetNodeGroup_Data();
			data.NodeGroupId = _ctx.StringValue("GetNodeGroup.Data.NodeGroupId");
			data.NodeGroupName = _ctx.StringValue("GetNodeGroup.Data.NodeGroupName");
			data.NodesCnt = _ctx.LongValue("GetNodeGroup.Data.NodesCnt");
			data.DataDispatchEnabled = _ctx.BooleanValue("GetNodeGroup.Data.DataDispatchEnabled");
			data.JoinPermissionId = _ctx.StringValue("GetNodeGroup.Data.JoinPermissionId");
			data.JoinPermissionOwnerAliyunId = _ctx.StringValue("GetNodeGroup.Data.JoinPermissionOwnerAliyunId");
			data.JoinEui = _ctx.StringValue("GetNodeGroup.Data.JoinEui");
			data.FreqBandPlanGroupId = _ctx.LongValue("GetNodeGroup.Data.FreqBandPlanGroupId");
			data.ClassMode = _ctx.StringValue("GetNodeGroup.Data.ClassMode");
			data.JoinPermissionType = _ctx.StringValue("GetNodeGroup.Data.JoinPermissionType");
			data.JoinPermissionEnabled = _ctx.BooleanValue("GetNodeGroup.Data.JoinPermissionEnabled");
			data.RxDailySum = _ctx.StringValue("GetNodeGroup.Data.RxDailySum");
			data.RxMonthSum = _ctx.LongValue("GetNodeGroup.Data.RxMonthSum");
			data.TxDailySum = _ctx.LongValue("GetNodeGroup.Data.TxDailySum");
			data.TxMonthSum = _ctx.LongValue("GetNodeGroup.Data.TxMonthSum");
			data.CreateMillis = _ctx.LongValue("GetNodeGroup.Data.CreateMillis");
			data.JoinPermissionName = _ctx.StringValue("GetNodeGroup.Data.JoinPermissionName");
			data.MulticastGroupId = _ctx.StringValue("GetNodeGroup.Data.MulticastGroupId");
			data.MulticastEnabled = _ctx.BooleanValue("GetNodeGroup.Data.MulticastEnabled");
			data.MulticastNodeCapacity = _ctx.IntegerValue("GetNodeGroup.Data.MulticastNodeCapacity");
			data.MulticastNodeCount = _ctx.IntegerValue("GetNodeGroup.Data.MulticastNodeCount");

			GetNodeGroupResponse.GetNodeGroup_Data.GetNodeGroup_DataDispatchConfig dataDispatchConfig = new GetNodeGroupResponse.GetNodeGroup_Data.GetNodeGroup_DataDispatchConfig();
			dataDispatchConfig.Destination = _ctx.StringValue("GetNodeGroup.Data.DataDispatchConfig.Destination");

			GetNodeGroupResponse.GetNodeGroup_Data.GetNodeGroup_DataDispatchConfig.GetNodeGroup_IotProduct iotProduct = new GetNodeGroupResponse.GetNodeGroup_Data.GetNodeGroup_DataDispatchConfig.GetNodeGroup_IotProduct();
			iotProduct.ProductName = _ctx.StringValue("GetNodeGroup.Data.DataDispatchConfig.IotProduct.ProductName");
			iotProduct.ProductKey = _ctx.StringValue("GetNodeGroup.Data.DataDispatchConfig.IotProduct.ProductKey");
			iotProduct.ProductType = _ctx.StringValue("GetNodeGroup.Data.DataDispatchConfig.IotProduct.ProductType");
			iotProduct.DebugSwitch = _ctx.BooleanValue("GetNodeGroup.Data.DataDispatchConfig.IotProduct.DebugSwitch");
			dataDispatchConfig.IotProduct = iotProduct;

			GetNodeGroupResponse.GetNodeGroup_Data.GetNodeGroup_DataDispatchConfig.GetNodeGroup_OnsTopics onsTopics = new GetNodeGroupResponse.GetNodeGroup_Data.GetNodeGroup_DataDispatchConfig.GetNodeGroup_OnsTopics();
			onsTopics.DownlinkRegionName = _ctx.StringValue("GetNodeGroup.Data.DataDispatchConfig.OnsTopics.DownlinkRegionName");
			onsTopics.DownlinkTopic = _ctx.StringValue("GetNodeGroup.Data.DataDispatchConfig.OnsTopics.DownlinkTopic");
			onsTopics.UplinkRegionName = _ctx.StringValue("GetNodeGroup.Data.DataDispatchConfig.OnsTopics.UplinkRegionName");
			onsTopics.UplinkTopic = _ctx.StringValue("GetNodeGroup.Data.DataDispatchConfig.OnsTopics.UplinkTopic");
			dataDispatchConfig.OnsTopics = onsTopics;
			data.DataDispatchConfig = dataDispatchConfig;

			List<GetNodeGroupResponse.GetNodeGroup_Data.GetNodeGroup_LocksItem> data_locks = new List<GetNodeGroupResponse.GetNodeGroup_Data.GetNodeGroup_LocksItem>();
			for (int i = 0; i < _ctx.Length("GetNodeGroup.Data.Locks.Length"); i++) {
				GetNodeGroupResponse.GetNodeGroup_Data.GetNodeGroup_LocksItem locksItem = new GetNodeGroupResponse.GetNodeGroup_Data.GetNodeGroup_LocksItem();
				locksItem.LockId = _ctx.StringValue("GetNodeGroup.Data.Locks["+ i +"].LockId");
				locksItem.LockType = _ctx.StringValue("GetNodeGroup.Data.Locks["+ i +"].LockType");
				locksItem.Enabled = _ctx.BooleanValue("GetNodeGroup.Data.Locks["+ i +"].Enabled");
				locksItem.CreateMillis = _ctx.LongValue("GetNodeGroup.Data.Locks["+ i +"].CreateMillis");

				data_locks.Add(locksItem);
			}
			data.Locks = data_locks;
			getNodeGroupResponse.Data = data;
        
			return getNodeGroupResponse;
        }
    }
}
