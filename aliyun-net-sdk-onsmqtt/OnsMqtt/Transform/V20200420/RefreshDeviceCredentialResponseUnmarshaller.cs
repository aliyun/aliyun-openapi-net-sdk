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
    public class RefreshDeviceCredentialResponseUnmarshaller
    {
        public static RefreshDeviceCredentialResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RefreshDeviceCredentialResponse refreshDeviceCredentialResponse = new RefreshDeviceCredentialResponse();

			refreshDeviceCredentialResponse.HttpResponse = _ctx.HttpResponse;
			refreshDeviceCredentialResponse.RequestId = _ctx.StringValue("RefreshDeviceCredential.RequestId");

			RefreshDeviceCredentialResponse.RefreshDeviceCredential_DeviceCredential deviceCredential = new RefreshDeviceCredentialResponse.RefreshDeviceCredential_DeviceCredential();
			deviceCredential.ClientId = _ctx.StringValue("RefreshDeviceCredential.DeviceCredential.ClientId");
			deviceCredential.DeviceAccessKeyId = _ctx.StringValue("RefreshDeviceCredential.DeviceCredential.DeviceAccessKeyId");
			deviceCredential.DeviceAccessKeySecret = _ctx.StringValue("RefreshDeviceCredential.DeviceCredential.DeviceAccessKeySecret");
			deviceCredential.InstanceId = _ctx.StringValue("RefreshDeviceCredential.DeviceCredential.InstanceId");
			deviceCredential.CreateTime = _ctx.LongValue("RefreshDeviceCredential.DeviceCredential.CreateTime");
			deviceCredential.UpdateTime = _ctx.LongValue("RefreshDeviceCredential.DeviceCredential.UpdateTime");
			refreshDeviceCredentialResponse.DeviceCredential = deviceCredential;
        
			return refreshDeviceCredentialResponse;
        }
    }
}
