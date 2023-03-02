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
using Aliyun.Acs.ltl.Model.V20190510;

namespace Aliyun.Acs.ltl.Transform.V20190510
{
    public class ListDeviceResponseUnmarshaller
    {
        public static ListDeviceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDeviceResponse listDeviceResponse = new ListDeviceResponse();

			listDeviceResponse.HttpResponse = _ctx.HttpResponse;
			listDeviceResponse.Code = _ctx.IntegerValue("ListDevice.Code");
			listDeviceResponse.Message = _ctx.StringValue("ListDevice.Message");
			listDeviceResponse.RequestId = _ctx.StringValue("ListDevice.RequestId");
			listDeviceResponse.Success = _ctx.BooleanValue("ListDevice.Success");

			ListDeviceResponse.ListDevice_Data data = new ListDeviceResponse.ListDevice_Data();
			data.Num = _ctx.IntegerValue("ListDevice.Data.Num");
			data.Total = _ctx.IntegerValue("ListDevice.Data.Total");
			data.Size = _ctx.IntegerValue("ListDevice.Data.Size");

			List<ListDeviceResponse.ListDevice_Data.ListDevice_DeviceInfo> data_pageData = new List<ListDeviceResponse.ListDevice_Data.ListDevice_DeviceInfo>();
			for (int i = 0; i < _ctx.Length("ListDevice.Data.PageData.Length"); i++) {
				ListDeviceResponse.ListDevice_Data.ListDevice_DeviceInfo deviceInfo = new ListDeviceResponse.ListDevice_Data.ListDevice_DeviceInfo();
				deviceInfo.Status = _ctx.StringValue("ListDevice.Data.PageData["+ i +"].Status");
				deviceInfo.LastSaveTime = _ctx.LongValue("ListDevice.Data.PageData["+ i +"].LastSaveTime");
				deviceInfo.DeviceId = _ctx.StringValue("ListDevice.Data.PageData["+ i +"].DeviceId");
				deviceInfo.IotId = _ctx.StringValue("ListDevice.Data.PageData["+ i +"].IotId");

				data_pageData.Add(deviceInfo);
			}
			data.PageData = data_pageData;
			listDeviceResponse.Data = data;
        
			return listDeviceResponse;
        }
    }
}
