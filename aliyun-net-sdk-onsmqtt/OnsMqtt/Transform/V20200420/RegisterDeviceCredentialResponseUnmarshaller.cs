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
    public class RegisterDeviceCredentialResponseUnmarshaller
    {
        public static RegisterDeviceCredentialResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RegisterDeviceCredentialResponse registerDeviceCredentialResponse = new RegisterDeviceCredentialResponse();

			registerDeviceCredentialResponse.HttpResponse = _ctx.HttpResponse;
			registerDeviceCredentialResponse.RequestId = _ctx.StringValue("RegisterDeviceCredential.RequestId");

			RegisterDeviceCredentialResponse.RegisterDeviceCredential_DeviceCredential deviceCredential = new RegisterDeviceCredentialResponse.RegisterDeviceCredential_DeviceCredential();
			deviceCredential.ClientId = _ctx.StringValue("RegisterDeviceCredential.DeviceCredential.ClientId");
			deviceCredential.DeviceAccessKeyId = _ctx.StringValue("RegisterDeviceCredential.DeviceCredential.DeviceAccessKeyId");
			deviceCredential.DeviceAccessKeySecret = _ctx.StringValue("RegisterDeviceCredential.DeviceCredential.DeviceAccessKeySecret");
			deviceCredential.InstanceId = _ctx.StringValue("RegisterDeviceCredential.DeviceCredential.InstanceId");
			deviceCredential.CreateTime = _ctx.LongValue("RegisterDeviceCredential.DeviceCredential.CreateTime");
			deviceCredential.UpdateTime = _ctx.LongValue("RegisterDeviceCredential.DeviceCredential.UpdateTime");
			registerDeviceCredentialResponse.DeviceCredential = deviceCredential;
        
			return registerDeviceCredentialResponse;
        }
    }
}
