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
    public class JoinDeviceMeetingResponseUnmarshaller
    {
        public static JoinDeviceMeetingResponse Unmarshall(UnmarshallerContext _ctx)
        {
			JoinDeviceMeetingResponse joinDeviceMeetingResponse = new JoinDeviceMeetingResponse();

			joinDeviceMeetingResponse.HttpResponse = _ctx.HttpResponse;
			joinDeviceMeetingResponse.ErrorCode = _ctx.IntegerValue("JoinDeviceMeeting.ErrorCode");
			joinDeviceMeetingResponse.Message = _ctx.StringValue("JoinDeviceMeeting.Message");
			joinDeviceMeetingResponse.Success = _ctx.BooleanValue("JoinDeviceMeeting.Success");
			joinDeviceMeetingResponse.RequestId = _ctx.StringValue("JoinDeviceMeeting.RequestId");

			JoinDeviceMeetingResponse.JoinDeviceMeeting_Device device = new JoinDeviceMeetingResponse.JoinDeviceMeeting_Device();
			device.MeetingDomain = _ctx.StringValue("JoinDeviceMeeting.Device.MeetingDomain");
			device.MeetingToken = _ctx.StringValue("JoinDeviceMeeting.Device.MeetingToken");
			device.MeetingCode = _ctx.StringValue("JoinDeviceMeeting.Device.MeetingCode");
			device.MemberUUID = _ctx.StringValue("JoinDeviceMeeting.Device.MemberUUID");
			device.ClientAppId = _ctx.StringValue("JoinDeviceMeeting.Device.ClientAppId");
			device.MeetingUUID = _ctx.StringValue("JoinDeviceMeeting.Device.MeetingUUID");
			device.MeetingAppId = _ctx.StringValue("JoinDeviceMeeting.Device.MeetingAppId");

			JoinDeviceMeetingResponse.JoinDeviceMeeting_Device.JoinDeviceMeeting_SlsInfo slsInfo = new JoinDeviceMeetingResponse.JoinDeviceMeeting_Device.JoinDeviceMeeting_SlsInfo();
			slsInfo.LogServiceEndpoint = _ctx.StringValue("JoinDeviceMeeting.Device.SlsInfo.LogServiceEndpoint");
			slsInfo.Project = _ctx.StringValue("JoinDeviceMeeting.Device.SlsInfo.Project");
			slsInfo.Logstore = _ctx.StringValue("JoinDeviceMeeting.Device.SlsInfo.Logstore");
			device.SlsInfo = slsInfo;
			joinDeviceMeetingResponse.Device = device;
        
			return joinDeviceMeetingResponse;
        }
    }
}
