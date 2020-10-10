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
using Aliyun.Acs.Vcs.Model.V20200515;

namespace Aliyun.Acs.Vcs.Transform.V20200515
{
    public class ListDeviceGroupsResponseUnmarshaller
    {
        public static ListDeviceGroupsResponse Unmarshall(UnmarshallerContext context)
        {
			ListDeviceGroupsResponse listDeviceGroupsResponse = new ListDeviceGroupsResponse();

			listDeviceGroupsResponse.HttpResponse = context.HttpResponse;
			listDeviceGroupsResponse.RequestId = context.StringValue("ListDeviceGroups.RequestId");
			listDeviceGroupsResponse.Code = context.StringValue("ListDeviceGroups.Code");
			listDeviceGroupsResponse.Message = context.StringValue("ListDeviceGroups.Message");

			List<ListDeviceGroupsResponse.ListDeviceGroups_DataItem> listDeviceGroupsResponse_data = new List<ListDeviceGroupsResponse.ListDeviceGroups_DataItem>();
			for (int i = 0; i < context.Length("ListDeviceGroups.Data.Length"); i++) {
				ListDeviceGroupsResponse.ListDeviceGroups_DataItem dataItem = new ListDeviceGroupsResponse.ListDeviceGroups_DataItem();
				dataItem.TotalCount = context.StringValue("ListDeviceGroups.Data["+ i +"].TotalCount");

				List<ListDeviceGroupsResponse.ListDeviceGroups_DataItem.ListDeviceGroups_ListItem> dataItem_list = new List<ListDeviceGroupsResponse.ListDeviceGroups_DataItem.ListDeviceGroups_ListItem>();
				for (int j = 0; j < context.Length("ListDeviceGroups.Data["+ i +"].List.Length"); j++) {
					ListDeviceGroupsResponse.ListDeviceGroups_DataItem.ListDeviceGroups_ListItem listItem = new ListDeviceGroupsResponse.ListDeviceGroups_DataItem.ListDeviceGroups_ListItem();
					listItem.DeviceGroup = context.StringValue("ListDeviceGroups.Data["+ i +"].List["+ j +"].DeviceGroup");
					listItem.DeviceName = context.StringValue("ListDeviceGroups.Data["+ i +"].List["+ j +"].DeviceName");
					listItem.DeviceCode = context.StringValue("ListDeviceGroups.Data["+ i +"].List["+ j +"].DeviceCode");
					listItem.BitRate = context.StringValue("ListDeviceGroups.Data["+ i +"].List["+ j +"].BitRate");
					listItem.CodingFormat = context.StringValue("ListDeviceGroups.Data["+ i +"].List["+ j +"].CodingFormat");
					listItem.ResolvingPower = context.StringValue("ListDeviceGroups.Data["+ i +"].List["+ j +"].ResolvingPower");
					listItem.DataSourceType = context.StringValue("ListDeviceGroups.Data["+ i +"].List["+ j +"].DataSourceType");
					listItem.RegionName = context.StringValue("ListDeviceGroups.Data["+ i +"].List["+ j +"].RegionName");
					listItem.RegionId = context.StringValue("ListDeviceGroups.Data["+ i +"].List["+ j +"].RegionId");
					listItem.InstallAddress = context.StringValue("ListDeviceGroups.Data["+ i +"].List["+ j +"].InstallAddress");
					listItem.DeviceSn = context.StringValue("ListDeviceGroups.Data["+ i +"].List["+ j +"].DeviceSn");
					listItem.DeviceStatus = context.StringValue("ListDeviceGroups.Data["+ i +"].List["+ j +"].DeviceStatus");
					listItem.DeviceStreamStatus = context.StringValue("ListDeviceGroups.Data["+ i +"].List["+ j +"].DeviceStreamStatus");
					listItem.DeviceComputeStatus = context.StringValue("ListDeviceGroups.Data["+ i +"].List["+ j +"].DeviceComputeStatus");

					dataItem_list.Add(listItem);
				}
				dataItem.List = dataItem_list;

				listDeviceGroupsResponse_data.Add(dataItem);
			}
			listDeviceGroupsResponse.Data = listDeviceGroupsResponse_data;
        
			return listDeviceGroupsResponse;
        }
    }
}
