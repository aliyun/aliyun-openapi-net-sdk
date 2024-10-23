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
using Aliyun.Acs.Ims.Model.V20190815;

namespace Aliyun.Acs.Ims.Transform.V20190815
{
    public class ListVirtualMFADevicesResponseUnmarshaller
    {
        public static ListVirtualMFADevicesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListVirtualMFADevicesResponse listVirtualMFADevicesResponse = new ListVirtualMFADevicesResponse();

			listVirtualMFADevicesResponse.HttpResponse = _ctx.HttpResponse;
			listVirtualMFADevicesResponse.RequestId = _ctx.StringValue("ListVirtualMFADevices.RequestId");
			listVirtualMFADevicesResponse.IsTruncated = _ctx.BooleanValue("ListVirtualMFADevices.IsTruncated");
			listVirtualMFADevicesResponse.Marker = _ctx.StringValue("ListVirtualMFADevices.Marker");

			List<ListVirtualMFADevicesResponse.ListVirtualMFADevices_VirtualMFADevice> listVirtualMFADevicesResponse_virtualMFADevices = new List<ListVirtualMFADevicesResponse.ListVirtualMFADevices_VirtualMFADevice>();
			for (int i = 0; i < _ctx.Length("ListVirtualMFADevices.VirtualMFADevices.Length"); i++) {
				ListVirtualMFADevicesResponse.ListVirtualMFADevices_VirtualMFADevice virtualMFADevice = new ListVirtualMFADevicesResponse.ListVirtualMFADevices_VirtualMFADevice();
				virtualMFADevice.SerialNumber = _ctx.StringValue("ListVirtualMFADevices.VirtualMFADevices["+ i +"].SerialNumber");
				virtualMFADevice.ActivateDate = _ctx.StringValue("ListVirtualMFADevices.VirtualMFADevices["+ i +"].ActivateDate");

				ListVirtualMFADevicesResponse.ListVirtualMFADevices_VirtualMFADevice.ListVirtualMFADevices_User user = new ListVirtualMFADevicesResponse.ListVirtualMFADevices_VirtualMFADevice.ListVirtualMFADevices_User();
				user.UserPrincipalName = _ctx.StringValue("ListVirtualMFADevices.VirtualMFADevices["+ i +"].User.UserPrincipalName");
				user.DisplayName = _ctx.StringValue("ListVirtualMFADevices.VirtualMFADevices["+ i +"].User.DisplayName");
				user.UserId = _ctx.StringValue("ListVirtualMFADevices.VirtualMFADevices["+ i +"].User.UserId");
				virtualMFADevice.User = user;

				listVirtualMFADevicesResponse_virtualMFADevices.Add(virtualMFADevice);
			}
			listVirtualMFADevicesResponse.VirtualMFADevices = listVirtualMFADevicesResponse_virtualMFADevices;
        
			return listVirtualMFADevicesResponse;
        }
    }
}
