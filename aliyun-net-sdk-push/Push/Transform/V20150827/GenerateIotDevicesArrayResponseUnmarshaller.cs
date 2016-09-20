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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Push.Model.V20150827;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Push.Transform.V20150827
{
    public class GenerateIotDevicesArrayResponseUnmarshaller
    {
        public static GenerateIotDevicesArrayResponse Unmarshall(UnmarshallerContext context)
        {
			GenerateIotDevicesArrayResponse generateIotDevicesArrayResponse = new GenerateIotDevicesArrayResponse();

			generateIotDevicesArrayResponse.HttpResponse = context.HttpResponse;

			List<GenerateIotDevicesArrayResponse.DeviceInfo> deviceInfos = new List<GenerateIotDevicesArrayResponse.DeviceInfo>();
			for (int i = 0; i < context.Length("GenerateIotDevicesArray.DeviceInfos.Length"); i++) {
				GenerateIotDevicesArrayResponse.DeviceInfo deviceInfo = new GenerateIotDevicesArrayResponse.DeviceInfo();
				deviceInfo.DeviceSn = context.StringValue("GenerateIotDevicesArray.DeviceInfos["+ i +"].DeviceSn");
				deviceInfo.DeviceSecret = context.StringValue("GenerateIotDevicesArray.DeviceInfos["+ i +"].DeviceSecret");

				deviceInfos.Add(deviceInfo);
			}
			generateIotDevicesArrayResponse.DeviceInfos = deviceInfos;
        
			return generateIotDevicesArrayResponse;
        }
    }
}