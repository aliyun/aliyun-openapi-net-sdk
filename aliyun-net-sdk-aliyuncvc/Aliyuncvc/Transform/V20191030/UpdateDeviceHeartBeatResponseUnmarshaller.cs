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
using Aliyun.Acs.aliyuncvc.Model.V20191030;

namespace Aliyun.Acs.aliyuncvc.Transform.V20191030
{
    public class UpdateDeviceHeartBeatResponseUnmarshaller
    {
        public static UpdateDeviceHeartBeatResponse Unmarshall(UnmarshallerContext context)
        {
			UpdateDeviceHeartBeatResponse updateDeviceHeartBeatResponse = new UpdateDeviceHeartBeatResponse();

			updateDeviceHeartBeatResponse.HttpResponse = context.HttpResponse;
			updateDeviceHeartBeatResponse.ErrorCode = context.IntegerValue("UpdateDeviceHeartBeat.ErrorCode");
			updateDeviceHeartBeatResponse.Message = context.StringValue("UpdateDeviceHeartBeat.Message");
			updateDeviceHeartBeatResponse.Success = context.BooleanValue("UpdateDeviceHeartBeat.Success");
			updateDeviceHeartBeatResponse.RequestId = context.StringValue("UpdateDeviceHeartBeat.RequestId");

			UpdateDeviceHeartBeatResponse.UpdateDeviceHeartBeat_DeviceInfo deviceInfo = new UpdateDeviceHeartBeatResponse.UpdateDeviceHeartBeat_DeviceInfo();
			deviceInfo.ChannelType = context.StringValue("UpdateDeviceHeartBeat.DeviceInfo.ChannelType");
			updateDeviceHeartBeatResponse.DeviceInfo = deviceInfo;
        
			return updateDeviceHeartBeatResponse;
        }
    }
}
