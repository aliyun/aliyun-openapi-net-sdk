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
using Aliyun.Acs.cloudesl.Model.V20200201;

namespace Aliyun.Acs.cloudesl.Transform.V20200201
{
    public class GetEslDevicesResponseUnmarshaller
    {
        public static GetEslDevicesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetEslDevicesResponse getEslDevicesResponse = new GetEslDevicesResponse();

			getEslDevicesResponse.HttpResponse = _ctx.HttpResponse;
			getEslDevicesResponse.RequestId = _ctx.StringValue("GetEslDevices.RequestId");
			getEslDevicesResponse.Success = _ctx.BooleanValue("GetEslDevices.Success");
			getEslDevicesResponse.Message = _ctx.StringValue("GetEslDevices.Message");
			getEslDevicesResponse.ErrorCode = _ctx.StringValue("GetEslDevices.ErrorCode");
			getEslDevicesResponse.ErrorMessage = _ctx.StringValue("GetEslDevices.ErrorMessage");
			getEslDevicesResponse.Code = _ctx.StringValue("GetEslDevices.Code");
			getEslDevicesResponse.DynamicCode = _ctx.StringValue("GetEslDevices.DynamicCode");
			getEslDevicesResponse.DynamicMessage = _ctx.StringValue("GetEslDevices.DynamicMessage");
			getEslDevicesResponse.EslBarCode = _ctx.StringValue("GetEslDevices.EslBarCode");
			getEslDevicesResponse.Type = _ctx.StringValue("GetEslDevices.Type");
        
			return getEslDevicesResponse;
        }
    }
}
