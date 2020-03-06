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
using Aliyun.Acs.cloudesl.Model.V20190801;

namespace Aliyun.Acs.cloudesl.Transform.V20190801
{
    public class UpdateEslDeviceLightResponseUnmarshaller
    {
        public static UpdateEslDeviceLightResponse Unmarshall(UnmarshallerContext context)
        {
			UpdateEslDeviceLightResponse updateEslDeviceLightResponse = new UpdateEslDeviceLightResponse();

			updateEslDeviceLightResponse.HttpResponse = context.HttpResponse;
			updateEslDeviceLightResponse.ErrorMessage = context.StringValue("UpdateEslDeviceLight.ErrorMessage");
			updateEslDeviceLightResponse.ErrorCode = context.StringValue("UpdateEslDeviceLight.ErrorCode");
			updateEslDeviceLightResponse.FailEslBarCodes = context.StringValue("UpdateEslDeviceLight.FailEslBarCodes");
			updateEslDeviceLightResponse.Message = context.StringValue("UpdateEslDeviceLight.Message");
			updateEslDeviceLightResponse.SuccessCount = context.LongValue("UpdateEslDeviceLight.SuccessCount");
			updateEslDeviceLightResponse.FailCount = context.LongValue("UpdateEslDeviceLight.FailCount");
			updateEslDeviceLightResponse.DynamicCode = context.StringValue("UpdateEslDeviceLight.DynamicCode");
			updateEslDeviceLightResponse.Code = context.StringValue("UpdateEslDeviceLight.Code");
			updateEslDeviceLightResponse.DynamicMessage = context.StringValue("UpdateEslDeviceLight.DynamicMessage");
			updateEslDeviceLightResponse.RequestId = context.StringValue("UpdateEslDeviceLight.RequestId");
			updateEslDeviceLightResponse.Success = context.BooleanValue("UpdateEslDeviceLight.Success");
        
			return updateEslDeviceLightResponse;
        }
    }
}
