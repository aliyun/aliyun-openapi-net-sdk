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
        public static RegisterUemDeviceResponse Unmarshall(UnmarshallerContext context)
        {
			RegisterUemDeviceResponse registerUemDeviceResponse = new RegisterUemDeviceResponse();

			registerUemDeviceResponse.HttpResponse = context.HttpResponse;
			registerUemDeviceResponse.ErrorCode = context.IntegerValue("RegisterUemDevice.ErrorCode");
			registerUemDeviceResponse.Success = context.BooleanValue("RegisterUemDevice.Success");
			registerUemDeviceResponse.RequestId = context.StringValue("RegisterUemDevice.RequestId");
			registerUemDeviceResponse.Message = context.StringValue("RegisterUemDevice.Message");

			RegisterUemDeviceResponse.RegisterUemDevice_DeviceInfo deviceInfo = new RegisterUemDeviceResponse.RegisterUemDevice_DeviceInfo();
			deviceInfo.ChannelType = context.StringValue("RegisterUemDevice.DeviceInfo.ChannelType");
			deviceInfo.RegisterTime = context.LongValue("RegisterUemDevice.DeviceInfo.RegisterTime");
			deviceInfo.DeviceName = context.StringValue("RegisterUemDevice.DeviceInfo.DeviceName");
			deviceInfo.DeviceSessionId = context.StringValue("RegisterUemDevice.DeviceInfo.DeviceSessionId");
			deviceInfo.MessageKey = context.StringValue("RegisterUemDevice.DeviceInfo.MessageKey");
			deviceInfo.ScreenCode = context.StringValue("RegisterUemDevice.DeviceInfo.ScreenCode");
			deviceInfo.Token = context.StringValue("RegisterUemDevice.DeviceInfo.Token");

			RegisterUemDeviceResponse.RegisterUemDevice_DeviceInfo.RegisterUemDevice_MqttParam mqttParam = new RegisterUemDeviceResponse.RegisterUemDevice_DeviceInfo.RegisterUemDevice_MqttParam();
			mqttParam.ClientId = context.StringValue("RegisterUemDevice.DeviceInfo.MqttParam.ClientId");
			mqttParam.GroupId = context.StringValue("RegisterUemDevice.DeviceInfo.MqttParam.GroupId");
			mqttParam.CleanSession = context.StringValue("RegisterUemDevice.DeviceInfo.MqttParam.CleanSession");
			mqttParam.Password = context.StringValue("RegisterUemDevice.DeviceInfo.MqttParam.Password");
			mqttParam.Port = context.StringValue("RegisterUemDevice.DeviceInfo.MqttParam.Port");
			mqttParam.Host = context.StringValue("RegisterUemDevice.DeviceInfo.MqttParam.Host");
			mqttParam.Topic = context.StringValue("RegisterUemDevice.DeviceInfo.MqttParam.Topic");
			mqttParam.SDKClientPort = context.StringValue("RegisterUemDevice.DeviceInfo.MqttParam.SDKClientPort");
			mqttParam.TLSPort = context.StringValue("RegisterUemDevice.DeviceInfo.MqttParam.TLSPort");
			mqttParam.UseTLS = context.StringValue("RegisterUemDevice.DeviceInfo.MqttParam.UseTLS");
			mqttParam.UserName = context.StringValue("RegisterUemDevice.DeviceInfo.MqttParam.UserName");
			mqttParam.ReconnectTimeout = context.StringValue("RegisterUemDevice.DeviceInfo.MqttParam.ReconnectTimeout");
			deviceInfo.MqttParam = mqttParam;

			RegisterUemDeviceResponse.RegisterUemDevice_DeviceInfo.RegisterUemDevice_AuthWsChannelConfig authWsChannelConfig = new RegisterUemDeviceResponse.RegisterUemDevice_DeviceInfo.RegisterUemDevice_AuthWsChannelConfig();
			authWsChannelConfig.AuthWsUrl = context.StringValue("RegisterUemDevice.DeviceInfo.AuthWsChannelConfig.AuthWsUrl");
			authWsChannelConfig.WsOuterReconnTime = context.IntegerValue("RegisterUemDevice.DeviceInfo.AuthWsChannelConfig.WsOuterReconnTime");
			authWsChannelConfig.Token = context.StringValue("RegisterUemDevice.DeviceInfo.AuthWsChannelConfig.Token");
			deviceInfo.AuthWsChannelConfig = authWsChannelConfig;

			RegisterUemDeviceResponse.RegisterUemDevice_DeviceInfo.RegisterUemDevice_SlsConfig slsConfig = new RegisterUemDeviceResponse.RegisterUemDevice_DeviceInfo.RegisterUemDevice_SlsConfig();
			slsConfig.Project = context.StringValue("RegisterUemDevice.DeviceInfo.SlsConfig.Project");
			slsConfig.LogStore = context.StringValue("RegisterUemDevice.DeviceInfo.SlsConfig.LogStore");
			slsConfig.LogServiceEndpoint = context.StringValue("RegisterUemDevice.DeviceInfo.SlsConfig.LogServiceEndpoint");
			deviceInfo.SlsConfig = slsConfig;
			registerUemDeviceResponse.DeviceInfo = deviceInfo;
        
			return registerUemDeviceResponse;
        }
    }
}
