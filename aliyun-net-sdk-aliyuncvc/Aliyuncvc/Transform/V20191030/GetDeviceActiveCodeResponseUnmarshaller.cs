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
    public class GetDeviceActiveCodeResponseUnmarshaller
    {
        public static GetDeviceActiveCodeResponse Unmarshall(UnmarshallerContext context)
        {
			GetDeviceActiveCodeResponse getDeviceActiveCodeResponse = new GetDeviceActiveCodeResponse();

			getDeviceActiveCodeResponse.HttpResponse = context.HttpResponse;
			getDeviceActiveCodeResponse.ErrorCode = context.IntegerValue("GetDeviceActiveCode.ErrorCode");
			getDeviceActiveCodeResponse.Message = context.StringValue("GetDeviceActiveCode.Message");
			getDeviceActiveCodeResponse.Success = context.BooleanValue("GetDeviceActiveCode.Success");

			List<GetDeviceActiveCodeResponse.GetDeviceActiveCode_Data> getDeviceActiveCodeResponse_devices = new List<GetDeviceActiveCodeResponse.GetDeviceActiveCode_Data>();
			for (int i = 0; i < context.Length("GetDeviceActiveCode.Devices.Length"); i++) {
				GetDeviceActiveCodeResponse.GetDeviceActiveCode_Data data = new GetDeviceActiveCodeResponse.GetDeviceActiveCode_Data();
				data.DeviceErrorCode = context.IntegerValue("GetDeviceActiveCode.Devices["+ i +"].DeviceErrorCode");
				data.DeviceMessage = context.StringValue("GetDeviceActiveCode.Devices["+ i +"].DeviceMessage");
				data.SN = context.StringValue("GetDeviceActiveCode.Devices["+ i +"].SN");
				data.ActiveCode = context.StringValue("GetDeviceActiveCode.Devices["+ i +"].ActiveCode");

				getDeviceActiveCodeResponse_devices.Add(data);
			}
			getDeviceActiveCodeResponse.Devices = getDeviceActiveCodeResponse_devices;
        
			return getDeviceActiveCodeResponse;
        }
    }
}
