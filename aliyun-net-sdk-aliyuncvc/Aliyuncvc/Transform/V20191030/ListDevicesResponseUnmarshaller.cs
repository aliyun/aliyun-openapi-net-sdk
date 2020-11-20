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
using Aliyun.Acs.aliyuncvc.Model.V20191030;

namespace Aliyun.Acs.aliyuncvc.Transform.V20191030
{
    public class ListDevicesResponseUnmarshaller
    {
        public static ListDevicesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDevicesResponse listDevicesResponse = new ListDevicesResponse();

			listDevicesResponse.HttpResponse = _ctx.HttpResponse;
			listDevicesResponse.ErrorCode = _ctx.IntegerValue("ListDevices.ErrorCode");
			listDevicesResponse.Message = _ctx.StringValue("ListDevices.Message");
			listDevicesResponse.Success = _ctx.BooleanValue("ListDevices.Success");
			listDevicesResponse.RequestId = _ctx.StringValue("ListDevices.RequestId");

			ListDevicesResponse.ListDevices_Data data = new ListDevicesResponse.ListDevices_Data();
			data.Total = _ctx.IntegerValue("ListDevices.Data.Total");
			data.PageSize = _ctx.IntegerValue("ListDevices.Data.PageSize");
			data.PageNumber = _ctx.IntegerValue("ListDevices.Data.PageNumber");

			List<ListDevicesResponse.ListDevices_Data.ListDevices_Device> data_devices = new List<ListDevicesResponse.ListDevices_Data.ListDevices_Device>();
			for (int i = 0; i < _ctx.Length("ListDevices.Data.Devices.Length"); i++) {
				ListDevicesResponse.ListDevices_Data.ListDevices_Device device = new ListDevicesResponse.ListDevices_Data.ListDevices_Device();
				device.ActivationCode = _ctx.StringValue("ListDevices.Data.Devices["+ i +"].ActivationCode");
				device.ConferenceCode = _ctx.StringValue("ListDevices.Data.Devices["+ i +"].ConferenceCode");
				device.ConferenceName = _ctx.StringValue("ListDevices.Data.Devices["+ i +"].ConferenceName");
				device.CreateTime = _ctx.StringValue("ListDevices.Data.Devices["+ i +"].CreateTime");
				device.PictureUrl = _ctx.StringValue("ListDevices.Data.Devices["+ i +"].PictureUrl");
				device.SN = _ctx.StringValue("ListDevices.Data.Devices["+ i +"].SN");
				device.Status = _ctx.StringValue("ListDevices.Data.Devices["+ i +"].Status");
				device.CastScreenCode = _ctx.StringValue("ListDevices.Data.Devices["+ i +"].CastScreenCode");

				data_devices.Add(device);
			}
			data.Devices = data_devices;
			listDevicesResponse.Data = data;
        
			return listDevicesResponse;
        }
    }
}
