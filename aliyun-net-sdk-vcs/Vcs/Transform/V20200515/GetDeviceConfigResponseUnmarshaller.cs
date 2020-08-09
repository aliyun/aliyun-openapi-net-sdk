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
using Aliyun.Acs.Vcs.Model.V20200515;

namespace Aliyun.Acs.Vcs.Transform.V20200515
{
    public class GetDeviceConfigResponseUnmarshaller
    {
        public static GetDeviceConfigResponse Unmarshall(UnmarshallerContext context)
        {
			GetDeviceConfigResponse getDeviceConfigResponse = new GetDeviceConfigResponse();

			getDeviceConfigResponse.HttpResponse = context.HttpResponse;
			getDeviceConfigResponse.AudioEnable = context.BooleanValue("GetDeviceConfig.AudioEnable");
			getDeviceConfigResponse.AudioFormat = context.StringValue("GetDeviceConfig.AudioFormat");
			getDeviceConfigResponse.BitRate = context.StringValue("GetDeviceConfig.BitRate");
			getDeviceConfigResponse.Code = context.StringValue("GetDeviceConfig.Code");
			getDeviceConfigResponse.DeviceAddress = context.StringValue("GetDeviceConfig.DeviceAddress");
			getDeviceConfigResponse.DeviceName = context.StringValue("GetDeviceConfig.DeviceName");
			getDeviceConfigResponse.EncodeFormat = context.StringValue("GetDeviceConfig.EncodeFormat");
			getDeviceConfigResponse.FrameRate = context.StringValue("GetDeviceConfig.FrameRate");
			getDeviceConfigResponse.GovLength = context.IntegerValue("GetDeviceConfig.GovLength");
			getDeviceConfigResponse.Latitude = context.StringValue("GetDeviceConfig.Latitude");
			getDeviceConfigResponse.Longitude = context.StringValue("GetDeviceConfig.Longitude");
			getDeviceConfigResponse.Message = context.StringValue("GetDeviceConfig.Message");
			getDeviceConfigResponse.OSDTimeEnable = context.StringValue("GetDeviceConfig.OSDTimeEnable");
			getDeviceConfigResponse.OSDTimeType = context.StringValue("GetDeviceConfig.OSDTimeType");
			getDeviceConfigResponse.OSDTimeX = context.StringValue("GetDeviceConfig.OSDTimeX");
			getDeviceConfigResponse.OSDTimeY = context.StringValue("GetDeviceConfig.OSDTimeY");
			getDeviceConfigResponse.RequestId = context.StringValue("GetDeviceConfig.RequestId");
			getDeviceConfigResponse.Resolution = context.StringValue("GetDeviceConfig.Resolution");
			getDeviceConfigResponse.RetryInterval = context.StringValue("GetDeviceConfig.RetryInterval");
			getDeviceConfigResponse.DeviceId = context.StringValue("GetDeviceConfig.DeviceId");
			getDeviceConfigResponse.UserName = context.StringValue("GetDeviceConfig.UserName");
			getDeviceConfigResponse.PassWord = context.StringValue("GetDeviceConfig.PassWord");
			getDeviceConfigResponse.Protocol = context.StringValue("GetDeviceConfig.Protocol");
			getDeviceConfigResponse.ServerId = context.StringValue("GetDeviceConfig.ServerId");
			getDeviceConfigResponse.ServerPort = context.StringValue("GetDeviceConfig.ServerPort");
			getDeviceConfigResponse.ServerIp = context.StringValue("GetDeviceConfig.ServerIp");

			List<GetDeviceConfigResponse.GetDeviceConfig_OSDListItem> getDeviceConfigResponse_oSDList = new List<GetDeviceConfigResponse.GetDeviceConfig_OSDListItem>();
			for (int i = 0; i < context.Length("GetDeviceConfig.OSDList.Length"); i++) {
				GetDeviceConfigResponse.GetDeviceConfig_OSDListItem oSDListItem = new GetDeviceConfigResponse.GetDeviceConfig_OSDListItem();
				oSDListItem.Text = context.StringValue("GetDeviceConfig.OSDList["+ i +"].Text");
				oSDListItem.LeftTopX = context.StringValue("GetDeviceConfig.OSDList["+ i +"].LeftTopX");
				oSDListItem.LeftTopY = context.StringValue("GetDeviceConfig.OSDList["+ i +"].LeftTopY");

				getDeviceConfigResponse_oSDList.Add(oSDListItem);
			}
			getDeviceConfigResponse.OSDList = getDeviceConfigResponse_oSDList;
        
			return getDeviceConfigResponse;
        }
    }
}
