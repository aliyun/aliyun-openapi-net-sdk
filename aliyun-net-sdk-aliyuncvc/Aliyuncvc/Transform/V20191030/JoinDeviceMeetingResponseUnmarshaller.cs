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
        public static JoinDeviceMeetingResponse Unmarshall(UnmarshallerContext context)
        {
			JoinDeviceMeetingResponse joinDeviceMeetingResponse = new JoinDeviceMeetingResponse();

			joinDeviceMeetingResponse.HttpResponse = context.HttpResponse;
			joinDeviceMeetingResponse.ErrorCode = context.IntegerValue("JoinDeviceMeeting.ErrorCode");
			joinDeviceMeetingResponse.Message = context.StringValue("JoinDeviceMeeting.Message");
			joinDeviceMeetingResponse.Success = context.BooleanValue("JoinDeviceMeeting.Success");
			joinDeviceMeetingResponse.RequestId = context.StringValue("JoinDeviceMeeting.RequestId");

			JoinDeviceMeetingResponse.JoinDeviceMeeting_Device device = new JoinDeviceMeetingResponse.JoinDeviceMeeting_Device();
			device.MeetingDomain = context.StringValue("JoinDeviceMeeting.Device.MeetingDomain");
			device.MeetingToken = context.StringValue("JoinDeviceMeeting.Device.MeetingToken");
			device.MeetingCode = context.StringValue("JoinDeviceMeeting.Device.MeetingCode");
			device.MemberUUID = context.StringValue("JoinDeviceMeeting.Device.MemberUUID");
			device.ClientAppId = context.StringValue("JoinDeviceMeeting.Device.ClientAppId");
			device.MeetingUUID = context.StringValue("JoinDeviceMeeting.Device.MeetingUUID");
			device.MeetingAppId = context.StringValue("JoinDeviceMeeting.Device.MeetingAppId");

			JoinDeviceMeetingResponse.JoinDeviceMeeting_Device.JoinDeviceMeeting_SlsInfo slsInfo = new JoinDeviceMeetingResponse.JoinDeviceMeeting_Device.JoinDeviceMeeting_SlsInfo();
			slsInfo.LogServiceEndpoint = context.StringValue("JoinDeviceMeeting.Device.SlsInfo.LogServiceEndpoint");
			slsInfo.Project = context.StringValue("JoinDeviceMeeting.Device.SlsInfo.Project");
			slsInfo.Logstore = context.StringValue("JoinDeviceMeeting.Device.SlsInfo.Logstore");
			device.SlsInfo = slsInfo;
			joinDeviceMeetingResponse.Device = device;
        
			return joinDeviceMeetingResponse;
        }
    }
}
