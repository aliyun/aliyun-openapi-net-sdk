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
    public class QueryFaceDeviceGroupsByDeviceResponseUnmarshaller
    {
        public static QueryFaceDeviceGroupsByDeviceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryFaceDeviceGroupsByDeviceResponse queryFaceDeviceGroupsByDeviceResponse = new QueryFaceDeviceGroupsByDeviceResponse();

			queryFaceDeviceGroupsByDeviceResponse.HttpResponse = _ctx.HttpResponse;
			queryFaceDeviceGroupsByDeviceResponse.Code = _ctx.StringValue("QueryFaceDeviceGroupsByDevice.Code");
			queryFaceDeviceGroupsByDeviceResponse.ErrorMessage = _ctx.StringValue("QueryFaceDeviceGroupsByDevice.ErrorMessage");
			queryFaceDeviceGroupsByDeviceResponse.RequestId = _ctx.StringValue("QueryFaceDeviceGroupsByDevice.RequestId");
			queryFaceDeviceGroupsByDeviceResponse.Success = _ctx.BooleanValue("QueryFaceDeviceGroupsByDevice.Success");

			QueryFaceDeviceGroupsByDeviceResponse.QueryFaceDeviceGroupsByDevice_Data data = new QueryFaceDeviceGroupsByDeviceResponse.QueryFaceDeviceGroupsByDevice_Data();
			data.PageNo = _ctx.IntegerValue("QueryFaceDeviceGroupsByDevice.Data.PageNo");
			data.PageSize = _ctx.IntegerValue("QueryFaceDeviceGroupsByDevice.Data.PageSize");
			data.Total = _ctx.IntegerValue("QueryFaceDeviceGroupsByDevice.Data.Total");

			List<QueryFaceDeviceGroupsByDeviceResponse.QueryFaceDeviceGroupsByDevice_Data.QueryFaceDeviceGroupsByDevice_DeviceGroupListItem> data_deviceGroupList = new List<QueryFaceDeviceGroupsByDeviceResponse.QueryFaceDeviceGroupsByDevice_Data.QueryFaceDeviceGroupsByDevice_DeviceGroupListItem>();
			for (int i = 0; i < _ctx.Length("QueryFaceDeviceGroupsByDevice.Data.DeviceGroupList.Length"); i++) {
				QueryFaceDeviceGroupsByDeviceResponse.QueryFaceDeviceGroupsByDevice_Data.QueryFaceDeviceGroupsByDevice_DeviceGroupListItem deviceGroupListItem = new QueryFaceDeviceGroupsByDeviceResponse.QueryFaceDeviceGroupsByDevice_Data.QueryFaceDeviceGroupsByDevice_DeviceGroupListItem();
				deviceGroupListItem.DeviceGroupId = _ctx.StringValue("QueryFaceDeviceGroupsByDevice.Data.DeviceGroupList["+ i +"].DeviceGroupId");
				deviceGroupListItem.ModifiedTime = _ctx.StringValue("QueryFaceDeviceGroupsByDevice.Data.DeviceGroupList["+ i +"].ModifiedTime");
				deviceGroupListItem.DeviceGroupName = _ctx.StringValue("QueryFaceDeviceGroupsByDevice.Data.DeviceGroupList["+ i +"].DeviceGroupName");

				data_deviceGroupList.Add(deviceGroupListItem);
			}
			data.DeviceGroupList = data_deviceGroupList;
			queryFaceDeviceGroupsByDeviceResponse.Data = data;
        
			return queryFaceDeviceGroupsByDeviceResponse;
        }
    }
}
