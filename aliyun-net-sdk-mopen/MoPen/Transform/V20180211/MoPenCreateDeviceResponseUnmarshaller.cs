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
using Aliyun.Acs.MoPen.Model.V20180211;

namespace Aliyun.Acs.MoPen.Transform.V20180211
{
    public class MoPenCreateDeviceResponseUnmarshaller
    {
        public static MoPenCreateDeviceResponse Unmarshall(UnmarshallerContext context)
        {
			MoPenCreateDeviceResponse moPenCreateDeviceResponse = new MoPenCreateDeviceResponse();

			moPenCreateDeviceResponse.HttpResponse = context.HttpResponse;
			moPenCreateDeviceResponse.Code = context.BooleanValue("MoPenCreateDevice.Code");
			moPenCreateDeviceResponse.Message = context.StringValue("MoPenCreateDevice.Message");
			moPenCreateDeviceResponse.Success = context.BooleanValue("MoPenCreateDevice.Success");
			moPenCreateDeviceResponse.Description = context.StringValue("MoPenCreateDevice.Description");

			MoPenCreateDeviceResponse.MoPenCreateDevice_Data data = new MoPenCreateDeviceResponse.MoPenCreateDevice_Data();
			data.DeviceName = context.StringValue("MoPenCreateDevice.Data.DeviceName");
			data.Product = context.StringValue("MoPenCreateDevice.Data.Product");
			data.DeviceSecret = context.StringValue("MoPenCreateDevice.Data.DeviceSecret");
			moPenCreateDeviceResponse.Data = data;
        
			return moPenCreateDeviceResponse;
        }
    }
}
