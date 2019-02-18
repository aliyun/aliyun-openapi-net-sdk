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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Ons.Model.V20190214;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Ons.Transform.V20190214
{
    public class OnsMqttQueryClientByClientIdResponseUnmarshaller
    {
        public static OnsMqttQueryClientByClientIdResponse Unmarshall(UnmarshallerContext context)
        {
			OnsMqttQueryClientByClientIdResponse onsMqttQueryClientByClientIdResponse = new OnsMqttQueryClientByClientIdResponse();

			onsMqttQueryClientByClientIdResponse.HttpResponse = context.HttpResponse;
			onsMqttQueryClientByClientIdResponse.RequestId = context.StringValue("OnsMqttQueryClientByClientId.RequestId");
			onsMqttQueryClientByClientIdResponse.HelpUrl = context.StringValue("OnsMqttQueryClientByClientId.HelpUrl");

			OnsMqttQueryClientByClientIdResponse.OnsMqttQueryClientByClientId_MqttClientInfoDo mqttClientInfoDo = new OnsMqttQueryClientByClientIdResponse.OnsMqttQueryClientByClientId_MqttClientInfoDo();
			mqttClientInfoDo.Online = context.BooleanValue("OnsMqttQueryClientByClientId.MqttClientInfoDo.Online");
			mqttClientInfoDo.ClientId = context.StringValue("OnsMqttQueryClientByClientId.MqttClientInfoDo.ClientId");
			mqttClientInfoDo.SocketChannel = context.StringValue("OnsMqttQueryClientByClientId.MqttClientInfoDo.SocketChannel");
			mqttClientInfoDo.LastTouch = context.LongValue("OnsMqttQueryClientByClientId.MqttClientInfoDo.LastTouch");

			List<OnsMqttQueryClientByClientIdResponse.OnsMqttQueryClientByClientId_MqttClientInfoDo.OnsMqttQueryClientByClientId_SubscriptionDo> mqttClientInfoDo_subScriptonData = new List<OnsMqttQueryClientByClientIdResponse.OnsMqttQueryClientByClientId_MqttClientInfoDo.OnsMqttQueryClientByClientId_SubscriptionDo>();
			for (int i = 0; i < context.Length("OnsMqttQueryClientByClientId.MqttClientInfoDo.SubScriptonData.Length"); i++) {
				OnsMqttQueryClientByClientIdResponse.OnsMqttQueryClientByClientId_MqttClientInfoDo.OnsMqttQueryClientByClientId_SubscriptionDo subscriptionDo = new OnsMqttQueryClientByClientIdResponse.OnsMqttQueryClientByClientId_MqttClientInfoDo.OnsMqttQueryClientByClientId_SubscriptionDo();
				subscriptionDo.ParentTopic = context.StringValue("OnsMqttQueryClientByClientId.MqttClientInfoDo.SubScriptonData["+ i +"].ParentTopic");
				subscriptionDo.SubTopic = context.StringValue("OnsMqttQueryClientByClientId.MqttClientInfoDo.SubScriptonData["+ i +"].SubTopic");
				subscriptionDo.Qos = context.IntegerValue("OnsMqttQueryClientByClientId.MqttClientInfoDo.SubScriptonData["+ i +"].Qos");

				mqttClientInfoDo_subScriptonData.Add(subscriptionDo);
			}
			mqttClientInfoDo.SubScriptonData = mqttClientInfoDo_subScriptonData;
			onsMqttQueryClientByClientIdResponse.MqttClientInfoDo = mqttClientInfoDo;
        
			return onsMqttQueryClientByClientIdResponse;
        }
    }
}