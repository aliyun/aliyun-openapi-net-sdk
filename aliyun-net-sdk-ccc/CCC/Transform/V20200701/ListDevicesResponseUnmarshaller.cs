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
using Aliyun.Acs.CCC.Model.V20200701;

namespace Aliyun.Acs.CCC.Transform.V20200701
{
    public class ListDevicesResponseUnmarshaller
    {
        public static ListDevicesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDevicesResponse listDevicesResponse = new ListDevicesResponse();

			listDevicesResponse.HttpResponse = _ctx.HttpResponse;
			listDevicesResponse.Code = _ctx.StringValue("ListDevices.Code");
			listDevicesResponse.HttpStatusCode = _ctx.IntegerValue("ListDevices.HttpStatusCode");
			listDevicesResponse.Message = _ctx.StringValue("ListDevices.Message");
			listDevicesResponse.RequestId = _ctx.StringValue("ListDevices.RequestId");

			List<string> listDevicesResponse_params = new List<string>();
			for (int i = 0; i < _ctx.Length("ListDevices.Params.Length"); i++) {
				listDevicesResponse_params.Add(_ctx.StringValue("ListDevices.Params["+ i +"]"));
			}
			listDevicesResponse._Params = listDevicesResponse_params;

			List<ListDevicesResponse.ListDevices_Device> listDevicesResponse_data = new List<ListDevicesResponse.ListDevices_Device>();
			for (int i = 0; i < _ctx.Length("ListDevices.Data.Length"); i++) {
				ListDevicesResponse.ListDevices_Device device = new ListDevicesResponse.ListDevices_Device();
				device.CallId = _ctx.StringValue("ListDevices.Data["+ i +"].CallId");
				device.Contact = _ctx.StringValue("ListDevices.Data["+ i +"].Contact");
				device.DeviceId = _ctx.StringValue("ListDevices.Data["+ i +"].DeviceId");
				device.Expires = _ctx.LongValue("ListDevices.Data["+ i +"].Expires");
				device.Extension = _ctx.StringValue("ListDevices.Data["+ i +"].Extension");
				device.InstanceId = _ctx.StringValue("ListDevices.Data["+ i +"].InstanceId");
				device.UserId = _ctx.StringValue("ListDevices.Data["+ i +"].UserId");

				listDevicesResponse_data.Add(device);
			}
			listDevicesResponse.Data = listDevicesResponse_data;
        
			return listDevicesResponse;
        }
    }
}
