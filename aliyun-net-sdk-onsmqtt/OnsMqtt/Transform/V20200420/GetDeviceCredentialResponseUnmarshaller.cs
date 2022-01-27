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
using Aliyun.Acs.OnsMqtt.Model.V20200420;

namespace Aliyun.Acs.OnsMqtt.Transform.V20200420
{
    public class GetDeviceCredentialResponseUnmarshaller
    {
        public static GetDeviceCredentialResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetDeviceCredentialResponse getDeviceCredentialResponse = new GetDeviceCredentialResponse();

			getDeviceCredentialResponse.HttpResponse = _ctx.HttpResponse;
			getDeviceCredentialResponse.RequestId = _ctx.StringValue("GetDeviceCredential.RequestId");

			GetDeviceCredentialResponse.GetDeviceCredential_DeviceCredential deviceCredential = new GetDeviceCredentialResponse.GetDeviceCredential_DeviceCredential();
			deviceCredential.ClientId = _ctx.StringValue("GetDeviceCredential.DeviceCredential.ClientId");
			deviceCredential.DeviceAccessKeyId = _ctx.StringValue("GetDeviceCredential.DeviceCredential.DeviceAccessKeyId");
			deviceCredential.DeviceAccessKeySecret = _ctx.StringValue("GetDeviceCredential.DeviceCredential.DeviceAccessKeySecret");
			deviceCredential.InstanceId = _ctx.StringValue("GetDeviceCredential.DeviceCredential.InstanceId");
			deviceCredential.CreateTime = _ctx.LongValue("GetDeviceCredential.DeviceCredential.CreateTime");
			deviceCredential.UpdateTime = _ctx.LongValue("GetDeviceCredential.DeviceCredential.UpdateTime");
			getDeviceCredentialResponse.DeviceCredential = deviceCredential;
        
			return getDeviceCredentialResponse;
        }
    }
}
