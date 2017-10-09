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
using Aliyun.Acs.Ram.Model.V20150501;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Ram.Transform.V20150501
{
    public class CreateVirtualMFADeviceResponseUnmarshaller
    {
        public static CreateVirtualMFADeviceResponse Unmarshall(UnmarshallerContext context)
        {
			CreateVirtualMFADeviceResponse createVirtualMFADeviceResponse = new CreateVirtualMFADeviceResponse();

			createVirtualMFADeviceResponse.HttpResponse = context.HttpResponse;
			createVirtualMFADeviceResponse.RequestId = context.StringValue("CreateVirtualMFADevice.RequestId");

			CreateVirtualMFADeviceResponse.CreateVirtualMFADevice_VirtualMFADevice virtualMFADevice = new CreateVirtualMFADeviceResponse.CreateVirtualMFADevice_VirtualMFADevice();
			virtualMFADevice.SerialNumber = context.StringValue("CreateVirtualMFADevice.VirtualMFADevice.SerialNumber");
			virtualMFADevice.Base32StringSeed = context.StringValue("CreateVirtualMFADevice.VirtualMFADevice.Base32StringSeed");
			virtualMFADevice.QRCodePNG = context.StringValue("CreateVirtualMFADevice.VirtualMFADevice.QRCodePNG");
			createVirtualMFADeviceResponse.VirtualMFADevice = virtualMFADevice;
        
			return createVirtualMFADeviceResponse;
        }
    }
}