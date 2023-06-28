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
using Aliyun.Acs.lto.Model.V20210707;

namespace Aliyun.Acs.lto.Transform.V20210707
{
    public class ListAllDeviceGroupResponseUnmarshaller
    {
        public static ListAllDeviceGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAllDeviceGroupResponse listAllDeviceGroupResponse = new ListAllDeviceGroupResponse();

			listAllDeviceGroupResponse.HttpResponse = _ctx.HttpResponse;
			listAllDeviceGroupResponse.Code = _ctx.StringValue("ListAllDeviceGroup.Code");
			listAllDeviceGroupResponse.HttpStatusCode = _ctx.IntegerValue("ListAllDeviceGroup.HttpStatusCode");
			listAllDeviceGroupResponse.Message = _ctx.StringValue("ListAllDeviceGroup.Message");
			listAllDeviceGroupResponse.RequestId = _ctx.StringValue("ListAllDeviceGroup.RequestId");
			listAllDeviceGroupResponse.Success = _ctx.BooleanValue("ListAllDeviceGroup.Success");

			List<ListAllDeviceGroupResponse.ListAllDeviceGroup_DeviceGroupInfo> listAllDeviceGroupResponse_data = new List<ListAllDeviceGroupResponse.ListAllDeviceGroup_DeviceGroupInfo>();
			for (int i = 0; i < _ctx.Length("ListAllDeviceGroup.Data.Length"); i++) {
				ListAllDeviceGroupResponse.ListAllDeviceGroup_DeviceGroupInfo deviceGroupInfo = new ListAllDeviceGroupResponse.ListAllDeviceGroup_DeviceGroupInfo();
				deviceGroupInfo.Name = _ctx.StringValue("ListAllDeviceGroup.Data["+ i +"].Name");
				deviceGroupInfo.DeviceGroupId = _ctx.StringValue("ListAllDeviceGroup.Data["+ i +"].DeviceGroupId");

				listAllDeviceGroupResponse_data.Add(deviceGroupInfo);
			}
			listAllDeviceGroupResponse.Data = listAllDeviceGroupResponse_data;
        
			return listAllDeviceGroupResponse;
        }
    }
}
