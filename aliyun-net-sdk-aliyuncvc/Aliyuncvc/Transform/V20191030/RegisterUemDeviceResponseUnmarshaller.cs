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
    public class RegisterUemDeviceResponseUnmarshaller
    {
        public static RegisterUemDeviceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RegisterUemDeviceResponse registerUemDeviceResponse = new RegisterUemDeviceResponse();

			registerUemDeviceResponse.HttpResponse = _ctx.HttpResponse;
			registerUemDeviceResponse.ErrorCode = _ctx.IntegerValue("RegisterUemDevice.ErrorCode");
			registerUemDeviceResponse.Success = _ctx.BooleanValue("RegisterUemDevice.Success");
			registerUemDeviceResponse.RequestId = _ctx.StringValue("RegisterUemDevice.RequestId");
			registerUemDeviceResponse.Message = _ctx.StringValue("RegisterUemDevice.Message");

			RegisterUemDeviceResponse.RegisterUemDevice_DeviceInfo deviceInfo = new RegisterUemDeviceResponse.RegisterUemDevice_DeviceInfo();
			deviceInfo.ChannelType = _ctx.StringValue("RegisterUemDevice.DeviceInfo.ChannelType");
			deviceInfo.RegisterTime = _ctx.LongValue("RegisterUemDevice.DeviceInfo.RegisterTime");
			deviceInfo.DeviceName = _ctx.StringValue("RegisterUemDevice.DeviceInfo.DeviceName");
			deviceInfo.DeviceSessionId = _ctx.StringValue("RegisterUemDevice.DeviceInfo.DeviceSessionId");
			deviceInfo.MessageKey = _ctx.StringValue("RegisterUemDevice.DeviceInfo.MessageKey");
			deviceInfo.ScreenCode = _ctx.StringValue("RegisterUemDevice.DeviceInfo.ScreenCode");
			deviceInfo.Token = _ctx.StringValue("RegisterUemDevice.DeviceInfo.Token");

			RegisterUemDeviceResponse.RegisterUemDevice_DeviceInfo.RegisterUemDevice_MqttParam mqttParam = new RegisterUemDeviceResponse.RegisterUemDevice_DeviceInfo.RegisterUemDevice_MqttParam();
			mqttParam.ClientId = _ctx.StringValue("RegisterUemDevice.DeviceInfo.MqttParam.ClientId");
			mqttParam.GroupId = _ctx.StringValue("RegisterUemDevice.DeviceInfo.MqttParam.GroupId");
			mqttParam.CleanSession = _ctx.StringValue("RegisterUemDevice.DeviceInfo.MqttParam.CleanSession");
			mqttParam.Password = _ctx.StringValue("RegisterUemDevice.DeviceInfo.MqttParam.Password");
			mqttParam.Port = _ctx.StringValue("RegisterUemDevice.DeviceInfo.MqttParam.Port");
			mqttParam.Host = _ctx.StringValue("RegisterUemDevice.DeviceInfo.MqttParam.Host");
			mqttParam.Topic = _ctx.StringValue("RegisterUemDevice.DeviceInfo.MqttParam.Topic");
			mqttParam.SDKClientPort = _ctx.StringValue("RegisterUemDevice.DeviceInfo.MqttParam.SDKClientPort");
			mqttParam.TLSPort = _ctx.StringValue("RegisterUemDevice.DeviceInfo.MqttParam.TLSPort");
			mqttParam.UseTLS = _ctx.StringValue("RegisterUemDevice.DeviceInfo.MqttParam.UseTLS");
			mqttParam.UserName = _ctx.StringValue("RegisterUemDevice.DeviceInfo.MqttParam.UserName");
			mqttParam.ReconnectTimeout = _ctx.StringValue("RegisterUemDevice.DeviceInfo.MqttParam.ReconnectTimeout");
			deviceInfo.MqttParam = mqttParam;

			RegisterUemDeviceResponse.RegisterUemDevice_DeviceInfo.RegisterUemDevice_AuthWsChannelConfig authWsChannelConfig = new RegisterUemDeviceResponse.RegisterUemDevice_DeviceInfo.RegisterUemDevice_AuthWsChannelConfig();
			authWsChannelConfig.AuthWsUrl = _ctx.StringValue("RegisterUemDevice.DeviceInfo.AuthWsChannelConfig.AuthWsUrl");
			authWsChannelConfig.WsOuterReconnTime = _ctx.IntegerValue("RegisterUemDevice.DeviceInfo.AuthWsChannelConfig.WsOuterReconnTime");
			authWsChannelConfig.Token = _ctx.StringValue("RegisterUemDevice.DeviceInfo.AuthWsChannelConfig.Token");
			deviceInfo.AuthWsChannelConfig = authWsChannelConfig;

			RegisterUemDeviceResponse.RegisterUemDevice_DeviceInfo.RegisterUemDevice_SlsConfig slsConfig = new RegisterUemDeviceResponse.RegisterUemDevice_DeviceInfo.RegisterUemDevice_SlsConfig();
			slsConfig.Project = _ctx.StringValue("RegisterUemDevice.DeviceInfo.SlsConfig.Project");
			slsConfig.LogStore = _ctx.StringValue("RegisterUemDevice.DeviceInfo.SlsConfig.LogStore");
			slsConfig.LogServiceEndpoint = _ctx.StringValue("RegisterUemDevice.DeviceInfo.SlsConfig.LogServiceEndpoint");
			deviceInfo.SlsConfig = slsConfig;
			registerUemDeviceResponse.DeviceInfo = deviceInfo;
        
			return registerUemDeviceResponse;
        }
    }
}
