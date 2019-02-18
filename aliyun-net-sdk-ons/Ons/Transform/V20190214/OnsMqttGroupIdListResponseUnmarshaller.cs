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
    public class OnsMqttGroupIdListResponseUnmarshaller
    {
        public static OnsMqttGroupIdListResponse Unmarshall(UnmarshallerContext context)
        {
			OnsMqttGroupIdListResponse onsMqttGroupIdListResponse = new OnsMqttGroupIdListResponse();

			onsMqttGroupIdListResponse.HttpResponse = context.HttpResponse;
			onsMqttGroupIdListResponse.RequestId = context.StringValue("OnsMqttGroupIdList.RequestId");
			onsMqttGroupIdListResponse.HelpUrl = context.StringValue("OnsMqttGroupIdList.HelpUrl");

			List<OnsMqttGroupIdListResponse.OnsMqttGroupIdList_MqttGroupIdDo> onsMqttGroupIdListResponse_data = new List<OnsMqttGroupIdListResponse.OnsMqttGroupIdList_MqttGroupIdDo>();
			for (int i = 0; i < context.Length("OnsMqttGroupIdList.Data.Length"); i++) {
				OnsMqttGroupIdListResponse.OnsMqttGroupIdList_MqttGroupIdDo mqttGroupIdDo = new OnsMqttGroupIdListResponse.OnsMqttGroupIdList_MqttGroupIdDo();
				mqttGroupIdDo.Id = context.LongValue("OnsMqttGroupIdList.Data["+ i +"].Id");
				mqttGroupIdDo.ChannelId = context.IntegerValue("OnsMqttGroupIdList.Data["+ i +"].ChannelId");
				mqttGroupIdDo.Owner = context.StringValue("OnsMqttGroupIdList.Data["+ i +"].Owner");
				mqttGroupIdDo.GroupId = context.StringValue("OnsMqttGroupIdList.Data["+ i +"].GroupId");
				mqttGroupIdDo.Topic = context.StringValue("OnsMqttGroupIdList.Data["+ i +"].Topic");
				mqttGroupIdDo.Status = context.IntegerValue("OnsMqttGroupIdList.Data["+ i +"].Status");
				mqttGroupIdDo.CreateTime = context.LongValue("OnsMqttGroupIdList.Data["+ i +"].CreateTime");
				mqttGroupIdDo.UpdateTime = context.LongValue("OnsMqttGroupIdList.Data["+ i +"].UpdateTime");
				mqttGroupIdDo.InstanceId = context.StringValue("OnsMqttGroupIdList.Data["+ i +"].InstanceId");
				mqttGroupIdDo.IndependentNaming = context.BooleanValue("OnsMqttGroupIdList.Data["+ i +"].IndependentNaming");

				onsMqttGroupIdListResponse_data.Add(mqttGroupIdDo);
			}
			onsMqttGroupIdListResponse.Data = onsMqttGroupIdListResponse_data;
        
			return onsMqttGroupIdListResponse;
        }
    }
}