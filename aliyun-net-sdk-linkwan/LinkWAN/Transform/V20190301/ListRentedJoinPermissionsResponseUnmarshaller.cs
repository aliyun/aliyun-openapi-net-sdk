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
    public class ListRentedJoinPermissionsResponseUnmarshaller
    {
        public static ListRentedJoinPermissionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListRentedJoinPermissionsResponse listRentedJoinPermissionsResponse = new ListRentedJoinPermissionsResponse();

			listRentedJoinPermissionsResponse.HttpResponse = _ctx.HttpResponse;
			listRentedJoinPermissionsResponse.RequestId = _ctx.StringValue("ListRentedJoinPermissions.RequestId");
			listRentedJoinPermissionsResponse.Success = _ctx.BooleanValue("ListRentedJoinPermissions.Success");

			ListRentedJoinPermissionsResponse.ListRentedJoinPermissions_Data data = new ListRentedJoinPermissionsResponse.ListRentedJoinPermissions_Data();
			data.TotalCount = _ctx.LongValue("ListRentedJoinPermissions.Data.TotalCount");

			List<ListRentedJoinPermissionsResponse.ListRentedJoinPermissions_Data.ListRentedJoinPermissions_JoinPermission> data_list = new List<ListRentedJoinPermissionsResponse.ListRentedJoinPermissions_Data.ListRentedJoinPermissions_JoinPermission>();
			for (int i = 0; i < _ctx.Length("ListRentedJoinPermissions.Data.List.Length"); i++) {
				ListRentedJoinPermissionsResponse.ListRentedJoinPermissions_Data.ListRentedJoinPermissions_JoinPermission joinPermission = new ListRentedJoinPermissionsResponse.ListRentedJoinPermissions_Data.ListRentedJoinPermissions_JoinPermission();
				joinPermission.JoinPermissionId = _ctx.StringValue("ListRentedJoinPermissions.Data.List["+ i +"].JoinPermissionId");
				joinPermission.OwnerAliyunId = _ctx.StringValue("ListRentedJoinPermissions.Data.List["+ i +"].OwnerAliyunId");
				joinPermission.JoinEui = _ctx.StringValue("ListRentedJoinPermissions.Data.List["+ i +"].JoinEui");
				joinPermission.FreqBandPlanGroupId = _ctx.StringValue("ListRentedJoinPermissions.Data.List["+ i +"].FreqBandPlanGroupId");
				joinPermission.ClassMode = _ctx.StringValue("ListRentedJoinPermissions.Data.List["+ i +"].ClassMode");
				joinPermission.Enabled = _ctx.BooleanValue("ListRentedJoinPermissions.Data.List["+ i +"].Enabled");
				joinPermission.BoundNodeGroup = _ctx.BooleanValue("ListRentedJoinPermissions.Data.List["+ i +"].BoundNodeGroup");
				joinPermission.Type = _ctx.StringValue("ListRentedJoinPermissions.Data.List["+ i +"].Type");
				joinPermission.BoundNodeGroupName = _ctx.StringValue("ListRentedJoinPermissions.Data.List["+ i +"].BoundNodeGroupName");
				joinPermission.BoundNodeGroupId = _ctx.StringValue("ListRentedJoinPermissions.Data.List["+ i +"].BoundNodeGroupId");
				joinPermission.RxDelay = _ctx.StringValue("ListRentedJoinPermissions.Data.List["+ i +"].RxDelay");
				joinPermission.DataRate = _ctx.StringValue("ListRentedJoinPermissions.Data.List["+ i +"].DataRate");
				joinPermission.JoinPermissionName = _ctx.StringValue("ListRentedJoinPermissions.Data.List["+ i +"].JoinPermissionName");

				ListRentedJoinPermissionsResponse.ListRentedJoinPermissions_Data.ListRentedJoinPermissions_JoinPermission.ListRentedJoinPermissions_DataDispatchConfig dataDispatchConfig = new ListRentedJoinPermissionsResponse.ListRentedJoinPermissions_Data.ListRentedJoinPermissions_JoinPermission.ListRentedJoinPermissions_DataDispatchConfig();
				dataDispatchConfig.Destination = _ctx.StringValue("ListRentedJoinPermissions.Data.List["+ i +"].DataDispatchConfig.Destination");

				ListRentedJoinPermissionsResponse.ListRentedJoinPermissions_Data.ListRentedJoinPermissions_JoinPermission.ListRentedJoinPermissions_DataDispatchConfig.ListRentedJoinPermissions_IotProduct iotProduct = new ListRentedJoinPermissionsResponse.ListRentedJoinPermissions_Data.ListRentedJoinPermissions_JoinPermission.ListRentedJoinPermissions_DataDispatchConfig.ListRentedJoinPermissions_IotProduct();
				iotProduct.ProductName = _ctx.StringValue("ListRentedJoinPermissions.Data.List["+ i +"].DataDispatchConfig.IotProduct.ProductName");
				iotProduct.ProductKey = _ctx.StringValue("ListRentedJoinPermissions.Data.List["+ i +"].DataDispatchConfig.IotProduct.ProductKey");
				iotProduct.ProductType = _ctx.StringValue("ListRentedJoinPermissions.Data.List["+ i +"].DataDispatchConfig.IotProduct.ProductType");
				iotProduct.DebugSwitch = _ctx.BooleanValue("ListRentedJoinPermissions.Data.List["+ i +"].DataDispatchConfig.IotProduct.DebugSwitch");
				dataDispatchConfig.IotProduct = iotProduct;

				ListRentedJoinPermissionsResponse.ListRentedJoinPermissions_Data.ListRentedJoinPermissions_JoinPermission.ListRentedJoinPermissions_DataDispatchConfig.ListRentedJoinPermissions_OnsTopics onsTopics = new ListRentedJoinPermissionsResponse.ListRentedJoinPermissions_Data.ListRentedJoinPermissions_JoinPermission.ListRentedJoinPermissions_DataDispatchConfig.ListRentedJoinPermissions_OnsTopics();
				onsTopics.DownlinkRegionName = _ctx.StringValue("ListRentedJoinPermissions.Data.List["+ i +"].DataDispatchConfig.OnsTopics.DownlinkRegionName");
				onsTopics.DownlinkTopic = _ctx.StringValue("ListRentedJoinPermissions.Data.List["+ i +"].DataDispatchConfig.OnsTopics.DownlinkTopic");
				onsTopics.UplinkRegionName = _ctx.StringValue("ListRentedJoinPermissions.Data.List["+ i +"].DataDispatchConfig.OnsTopics.UplinkRegionName");
				onsTopics.UplinkTopic = _ctx.StringValue("ListRentedJoinPermissions.Data.List["+ i +"].DataDispatchConfig.OnsTopics.UplinkTopic");
				dataDispatchConfig.OnsTopics = onsTopics;
				joinPermission.DataDispatchConfig = dataDispatchConfig;

				data_list.Add(joinPermission);
			}
			data.List = data_list;
			listRentedJoinPermissionsResponse.Data = data;
        
			return listRentedJoinPermissionsResponse;
        }
    }
}
