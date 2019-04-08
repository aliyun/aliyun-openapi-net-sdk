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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class RegisterDeviceResponseUnmarshaller
    {
        public static RegisterDeviceResponse Unmarshall(UnmarshallerContext context)
        {
			RegisterDeviceResponse registerDeviceResponse = new RegisterDeviceResponse();

			registerDeviceResponse.HttpResponse = context.HttpResponse;
			registerDeviceResponse.RequestId = context.StringValue("RegisterDevice.RequestId");
			registerDeviceResponse.Success = context.BooleanValue("RegisterDevice.Success");
			registerDeviceResponse.Code = context.StringValue("RegisterDevice.Code");
			registerDeviceResponse.ErrorMessage = context.StringValue("RegisterDevice.ErrorMessage");

			RegisterDeviceResponse.RegisterDevice_Data data = new RegisterDeviceResponse.RegisterDevice_Data();
			data.IotId = context.StringValue("RegisterDevice.Data.IotId");
			data.ProductKey = context.StringValue("RegisterDevice.Data.ProductKey");
			data.DeviceName = context.StringValue("RegisterDevice.Data.DeviceName");
			data.DeviceSecret = context.StringValue("RegisterDevice.Data.DeviceSecret");
			data.DevEui = context.StringValue("RegisterDevice.Data.DevEui");
			data.JoinEui = context.StringValue("RegisterDevice.Data.JoinEui");
			data.Nickname = context.StringValue("RegisterDevice.Data.Nickname");
			registerDeviceResponse.Data = data;
        
			return registerDeviceResponse;
        }
    }
}
