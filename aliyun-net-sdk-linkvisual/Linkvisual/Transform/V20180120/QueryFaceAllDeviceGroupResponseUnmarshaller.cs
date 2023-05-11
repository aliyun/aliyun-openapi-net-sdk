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
using Aliyun.Acs.Linkvisual.Model.V20180120;

namespace Aliyun.Acs.Linkvisual.Transform.V20180120
{
    public class QueryFaceAllDeviceGroupResponseUnmarshaller
    {
        public static QueryFaceAllDeviceGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryFaceAllDeviceGroupResponse queryFaceAllDeviceGroupResponse = new QueryFaceAllDeviceGroupResponse();

			queryFaceAllDeviceGroupResponse.HttpResponse = _ctx.HttpResponse;
			queryFaceAllDeviceGroupResponse.Code = _ctx.StringValue("QueryFaceAllDeviceGroup.Code");
			queryFaceAllDeviceGroupResponse.ErrorMessage = _ctx.StringValue("QueryFaceAllDeviceGroup.ErrorMessage");
			queryFaceAllDeviceGroupResponse.RequestId = _ctx.StringValue("QueryFaceAllDeviceGroup.RequestId");
			queryFaceAllDeviceGroupResponse.Success = _ctx.BooleanValue("QueryFaceAllDeviceGroup.Success");

			QueryFaceAllDeviceGroupResponse.QueryFaceAllDeviceGroup_Data data = new QueryFaceAllDeviceGroupResponse.QueryFaceAllDeviceGroup_Data();
			data.PageNo = _ctx.IntegerValue("QueryFaceAllDeviceGroup.Data.PageNo");
			data.PageSize = _ctx.IntegerValue("QueryFaceAllDeviceGroup.Data.PageSize");
			data.Total = _ctx.IntegerValue("QueryFaceAllDeviceGroup.Data.Total");

			List<QueryFaceAllDeviceGroupResponse.QueryFaceAllDeviceGroup_Data.QueryFaceAllDeviceGroup_DeviceGroupListItem> data_deviceGroupList = new List<QueryFaceAllDeviceGroupResponse.QueryFaceAllDeviceGroup_Data.QueryFaceAllDeviceGroup_DeviceGroupListItem>();
			for (int i = 0; i < _ctx.Length("QueryFaceAllDeviceGroup.Data.DeviceGroupList.Length"); i++) {
				QueryFaceAllDeviceGroupResponse.QueryFaceAllDeviceGroup_Data.QueryFaceAllDeviceGroup_DeviceGroupListItem deviceGroupListItem = new QueryFaceAllDeviceGroupResponse.QueryFaceAllDeviceGroup_Data.QueryFaceAllDeviceGroup_DeviceGroupListItem();
				deviceGroupListItem.DeviceGroupId = _ctx.StringValue("QueryFaceAllDeviceGroup.Data.DeviceGroupList["+ i +"].DeviceGroupId");
				deviceGroupListItem.ModifiedTime = _ctx.StringValue("QueryFaceAllDeviceGroup.Data.DeviceGroupList["+ i +"].ModifiedTime");
				deviceGroupListItem.DeviceGroupName = _ctx.StringValue("QueryFaceAllDeviceGroup.Data.DeviceGroupList["+ i +"].DeviceGroupName");

				data_deviceGroupList.Add(deviceGroupListItem);
			}
			data.DeviceGroupList = data_deviceGroupList;
			queryFaceAllDeviceGroupResponse.Data = data;
        
			return queryFaceAllDeviceGroupResponse;
        }
    }
}
