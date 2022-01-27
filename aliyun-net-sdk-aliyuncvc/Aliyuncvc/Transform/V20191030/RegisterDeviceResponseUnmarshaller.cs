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
    public class RegisterDeviceResponseUnmarshaller
    {
        public static RegisterDeviceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RegisterDeviceResponse registerDeviceResponse = new RegisterDeviceResponse();

			registerDeviceResponse.HttpResponse = _ctx.HttpResponse;
			registerDeviceResponse.ErrorCode = _ctx.IntegerValue("RegisterDevice.ErrorCode");
			registerDeviceResponse.Success = _ctx.BooleanValue("RegisterDevice.Success");
			registerDeviceResponse.RequestId = _ctx.StringValue("RegisterDevice.RequestId");
			registerDeviceResponse.Message = _ctx.StringValue("RegisterDevice.Message");

			RegisterDeviceResponse.RegisterDevice_DeviceInfo deviceInfo = new RegisterDeviceResponse.RegisterDevice_DeviceInfo();
			deviceInfo.ChannelType = _ctx.StringValue("RegisterDevice.DeviceInfo.ChannelType");
			deviceInfo.RegisterTime = _ctx.LongValue("RegisterDevice.DeviceInfo.RegisterTime");
			deviceInfo.DeviceName = _ctx.StringValue("RegisterDevice.DeviceInfo.DeviceName");
			deviceInfo.DeviceSessionId = _ctx.StringValue("RegisterDevice.DeviceInfo.DeviceSessionId");
			deviceInfo.MessageKey = _ctx.StringValue("RegisterDevice.DeviceInfo.MessageKey");
			deviceInfo.ScreenCode = _ctx.StringValue("RegisterDevice.DeviceInfo.ScreenCode");

			RegisterDeviceResponse.RegisterDevice_DeviceInfo.RegisterDevice_MqttParam mqttParam = new RegisterDeviceResponse.RegisterDevice_DeviceInfo.RegisterDevice_MqttParam();
			mqttParam.ClientId = _ctx.StringValue("RegisterDevice.DeviceInfo.MqttParam.ClientId");
			mqttParam.GroupId = _ctx.StringValue("RegisterDevice.DeviceInfo.MqttParam.GroupId");
			mqttParam.CleanSession = _ctx.StringValue("RegisterDevice.DeviceInfo.MqttParam.CleanSession");
			mqttParam.Password = _ctx.StringValue("RegisterDevice.DeviceInfo.MqttParam.Password");
			mqttParam.Port = _ctx.StringValue("RegisterDevice.DeviceInfo.MqttParam.Port");
			mqttParam.Host = _ctx.StringValue("RegisterDevice.DeviceInfo.MqttParam.Host");
			mqttParam.Topic = _ctx.StringValue("RegisterDevice.DeviceInfo.MqttParam.Topic");
			mqttParam.SDKClientPort = _ctx.StringValue("RegisterDevice.DeviceInfo.MqttParam.SDKClientPort");
			mqttParam.TLSPort = _ctx.StringValue("RegisterDevice.DeviceInfo.MqttParam.TLSPort");
			mqttParam.UseTLS = _ctx.StringValue("RegisterDevice.DeviceInfo.MqttParam.UseTLS");
			mqttParam.UserName = _ctx.StringValue("RegisterDevice.DeviceInfo.MqttParam.UserName");
			mqttParam.ReconnectTimeout = _ctx.StringValue("RegisterDevice.DeviceInfo.MqttParam.ReconnectTimeout");
			deviceInfo.MqttParam = mqttParam;

			RegisterDeviceResponse.RegisterDevice_DeviceInfo.RegisterDevice_AuthWsChannelConfig authWsChannelConfig = new RegisterDeviceResponse.RegisterDevice_DeviceInfo.RegisterDevice_AuthWsChannelConfig();
			authWsChannelConfig.AuthWsUrl = _ctx.StringValue("RegisterDevice.DeviceInfo.AuthWsChannelConfig.AuthWsUrl");
			authWsChannelConfig.WsOuterReconnTime = _ctx.IntegerValue("RegisterDevice.DeviceInfo.AuthWsChannelConfig.WsOuterReconnTime");
			authWsChannelConfig.Token = _ctx.StringValue("RegisterDevice.DeviceInfo.AuthWsChannelConfig.Token");
			deviceInfo.AuthWsChannelConfig = authWsChannelConfig;

			RegisterDeviceResponse.RegisterDevice_DeviceInfo.RegisterDevice_SlsConfig slsConfig = new RegisterDeviceResponse.RegisterDevice_DeviceInfo.RegisterDevice_SlsConfig();
			slsConfig.Project = _ctx.StringValue("RegisterDevice.DeviceInfo.SlsConfig.Project");
			slsConfig.LogStore = _ctx.StringValue("RegisterDevice.DeviceInfo.SlsConfig.LogStore");
			slsConfig.LogServiceEndpoint = _ctx.StringValue("RegisterDevice.DeviceInfo.SlsConfig.LogServiceEndpoint");
			deviceInfo.SlsConfig = slsConfig;
			registerDeviceResponse.DeviceInfo = deviceInfo;
        
			return registerDeviceResponse;
        }
    }
}
