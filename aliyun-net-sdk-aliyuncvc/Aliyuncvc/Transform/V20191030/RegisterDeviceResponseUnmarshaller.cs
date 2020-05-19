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
        public static RegisterDeviceResponse Unmarshall(UnmarshallerContext context)
        {
			RegisterDeviceResponse registerDeviceResponse = new RegisterDeviceResponse();

			registerDeviceResponse.HttpResponse = context.HttpResponse;
			registerDeviceResponse.ErrorCode = context.IntegerValue("RegisterDevice.ErrorCode");
			registerDeviceResponse.Success = context.BooleanValue("RegisterDevice.Success");
			registerDeviceResponse.RequestId = context.StringValue("RegisterDevice.RequestId");
			registerDeviceResponse.Message = context.StringValue("RegisterDevice.Message");

			RegisterDeviceResponse.RegisterDevice_DeviceInfo deviceInfo = new RegisterDeviceResponse.RegisterDevice_DeviceInfo();
			deviceInfo.ChannelType = context.StringValue("RegisterDevice.DeviceInfo.ChannelType");
			deviceInfo.RegisterTime = context.LongValue("RegisterDevice.DeviceInfo.RegisterTime");
			deviceInfo.DeviceName = context.StringValue("RegisterDevice.DeviceInfo.DeviceName");
			deviceInfo.DeviceSessionId = context.StringValue("RegisterDevice.DeviceInfo.DeviceSessionId");
			deviceInfo.MessageKey = context.StringValue("RegisterDevice.DeviceInfo.MessageKey");
			deviceInfo.ScreenCode = context.StringValue("RegisterDevice.DeviceInfo.ScreenCode");

			RegisterDeviceResponse.RegisterDevice_DeviceInfo.RegisterDevice_MqttParam mqttParam = new RegisterDeviceResponse.RegisterDevice_DeviceInfo.RegisterDevice_MqttParam();
			mqttParam.ClientId = context.StringValue("RegisterDevice.DeviceInfo.MqttParam.ClientId");
			mqttParam.GroupId = context.StringValue("RegisterDevice.DeviceInfo.MqttParam.GroupId");
			mqttParam.CleanSession = context.StringValue("RegisterDevice.DeviceInfo.MqttParam.CleanSession");
			mqttParam.Password = context.StringValue("RegisterDevice.DeviceInfo.MqttParam.Password");
			mqttParam.Port = context.StringValue("RegisterDevice.DeviceInfo.MqttParam.Port");
			mqttParam.Host = context.StringValue("RegisterDevice.DeviceInfo.MqttParam.Host");
			mqttParam.Topic = context.StringValue("RegisterDevice.DeviceInfo.MqttParam.Topic");
			mqttParam.SDKClientPort = context.StringValue("RegisterDevice.DeviceInfo.MqttParam.SDKClientPort");
			mqttParam.TLSPort = context.StringValue("RegisterDevice.DeviceInfo.MqttParam.TLSPort");
			mqttParam.UseTLS = context.StringValue("RegisterDevice.DeviceInfo.MqttParam.UseTLS");
			mqttParam.UserName = context.StringValue("RegisterDevice.DeviceInfo.MqttParam.UserName");
			mqttParam.ReconnectTimeout = context.StringValue("RegisterDevice.DeviceInfo.MqttParam.ReconnectTimeout");
			deviceInfo.MqttParam = mqttParam;

			RegisterDeviceResponse.RegisterDevice_DeviceInfo.RegisterDevice_AuthWsChannelConfig authWsChannelConfig = new RegisterDeviceResponse.RegisterDevice_DeviceInfo.RegisterDevice_AuthWsChannelConfig();
			authWsChannelConfig.AuthWsUrl = context.StringValue("RegisterDevice.DeviceInfo.AuthWsChannelConfig.AuthWsUrl");
			authWsChannelConfig.WsOuterReconnTime = context.IntegerValue("RegisterDevice.DeviceInfo.AuthWsChannelConfig.WsOuterReconnTime");
			authWsChannelConfig.Token = context.StringValue("RegisterDevice.DeviceInfo.AuthWsChannelConfig.Token");
			deviceInfo.AuthWsChannelConfig = authWsChannelConfig;

			RegisterDeviceResponse.RegisterDevice_DeviceInfo.RegisterDevice_SlsConfig slsConfig = new RegisterDeviceResponse.RegisterDevice_DeviceInfo.RegisterDevice_SlsConfig();
			slsConfig.Project = context.StringValue("RegisterDevice.DeviceInfo.SlsConfig.Project");
			slsConfig.LogStore = context.StringValue("RegisterDevice.DeviceInfo.SlsConfig.LogStore");
			slsConfig.LogServiceEndpoint = context.StringValue("RegisterDevice.DeviceInfo.SlsConfig.LogServiceEndpoint");
			deviceInfo.SlsConfig = slsConfig;
			registerDeviceResponse.DeviceInfo = deviceInfo;
        
			return registerDeviceResponse;
        }
    }
}
