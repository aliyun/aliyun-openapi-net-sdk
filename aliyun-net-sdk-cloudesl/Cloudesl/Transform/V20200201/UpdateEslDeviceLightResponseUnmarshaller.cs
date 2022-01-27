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
    public class UpdateEslDeviceLightResponseUnmarshaller
    {
        public static UpdateEslDeviceLightResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateEslDeviceLightResponse updateEslDeviceLightResponse = new UpdateEslDeviceLightResponse();

			updateEslDeviceLightResponse.HttpResponse = _ctx.HttpResponse;
			updateEslDeviceLightResponse.ErrorMessage = _ctx.StringValue("UpdateEslDeviceLight.ErrorMessage");
			updateEslDeviceLightResponse.ErrorCode = _ctx.StringValue("UpdateEslDeviceLight.ErrorCode");
			updateEslDeviceLightResponse.Message = _ctx.StringValue("UpdateEslDeviceLight.Message");
			updateEslDeviceLightResponse.SuccessCount = _ctx.IntegerValue("UpdateEslDeviceLight.SuccessCount");
			updateEslDeviceLightResponse.FailCount = _ctx.IntegerValue("UpdateEslDeviceLight.FailCount");
			updateEslDeviceLightResponse.DynamicCode = _ctx.StringValue("UpdateEslDeviceLight.DynamicCode");
			updateEslDeviceLightResponse.Code = _ctx.StringValue("UpdateEslDeviceLight.Code");
			updateEslDeviceLightResponse.DynamicMessage = _ctx.StringValue("UpdateEslDeviceLight.DynamicMessage");
			updateEslDeviceLightResponse.RequestId = _ctx.StringValue("UpdateEslDeviceLight.RequestId");
			updateEslDeviceLightResponse.Success = _ctx.BooleanValue("UpdateEslDeviceLight.Success");

			List<UpdateEslDeviceLightResponse.UpdateEslDeviceLight_LightFailEslInfo> updateEslDeviceLightResponse_lightFailEslInfos = new List<UpdateEslDeviceLightResponse.UpdateEslDeviceLight_LightFailEslInfo>();
			for (int i = 0; i < _ctx.Length("UpdateEslDeviceLight.LightFailEslInfos.Length"); i++) {
				UpdateEslDeviceLightResponse.UpdateEslDeviceLight_LightFailEslInfo lightFailEslInfo = new UpdateEslDeviceLightResponse.UpdateEslDeviceLight_LightFailEslInfo();
				lightFailEslInfo.ErrorMessage = _ctx.StringValue("UpdateEslDeviceLight.LightFailEslInfos["+ i +"].ErrorMessage");
				lightFailEslInfo.EslBarCode = _ctx.StringValue("UpdateEslDeviceLight.LightFailEslInfos["+ i +"].EslBarCode");

				updateEslDeviceLightResponse_lightFailEslInfos.Add(lightFailEslInfo);
			}
			updateEslDeviceLightResponse.LightFailEslInfos = updateEslDeviceLightResponse_lightFailEslInfos;
        
			return updateEslDeviceLightResponse;
        }
    }
}
