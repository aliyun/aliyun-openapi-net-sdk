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
    public class ExportEslDevicesResponseUnmarshaller
    {
        public static ExportEslDevicesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ExportEslDevicesResponse exportEslDevicesResponse = new ExportEslDevicesResponse();

			exportEslDevicesResponse.HttpResponse = _ctx.HttpResponse;
			exportEslDevicesResponse.RequestId = _ctx.StringValue("ExportEslDevices.RequestId");
			exportEslDevicesResponse.ErrorMessage = _ctx.StringValue("ExportEslDevices.ErrorMessage");
			exportEslDevicesResponse.Success = _ctx.BooleanValue("ExportEslDevices.Success");
			exportEslDevicesResponse.ErrorCode = _ctx.StringValue("ExportEslDevices.ErrorCode");
			exportEslDevicesResponse.Code = _ctx.StringValue("ExportEslDevices.Code");
			exportEslDevicesResponse.Message = _ctx.StringValue("ExportEslDevices.Message");
			exportEslDevicesResponse.DynamicMessage = _ctx.StringValue("ExportEslDevices.DynamicMessage");
			exportEslDevicesResponse.DynamicCode = _ctx.StringValue("ExportEslDevices.DynamicCode");
			exportEslDevicesResponse.DownloadAddress = _ctx.StringValue("ExportEslDevices.DownloadAddress");
        
			return exportEslDevicesResponse;
        }
    }
}
