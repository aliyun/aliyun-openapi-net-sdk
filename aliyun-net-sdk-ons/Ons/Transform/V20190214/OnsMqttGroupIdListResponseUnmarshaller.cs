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
using Aliyun.Acs.Ons.Model.V20190214;

namespace Aliyun.Acs.Ons.Transform.V20190214
{
    public class OnsMqttGroupIdListResponseUnmarshaller
    {
        public static OnsMqttGroupIdListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			OnsMqttGroupIdListResponse onsMqttGroupIdListResponse = new OnsMqttGroupIdListResponse();

			onsMqttGroupIdListResponse.HttpResponse = _ctx.HttpResponse;
			onsMqttGroupIdListResponse.RequestId = _ctx.StringValue("OnsMqttGroupIdList.RequestId");
			onsMqttGroupIdListResponse.HelpUrl = _ctx.StringValue("OnsMqttGroupIdList.HelpUrl");

			List<OnsMqttGroupIdListResponse.OnsMqttGroupIdList_MqttGroupIdDo> onsMqttGroupIdListResponse_data = new List<OnsMqttGroupIdListResponse.OnsMqttGroupIdList_MqttGroupIdDo>();
			for (int i = 0; i < _ctx.Length("OnsMqttGroupIdList.Data.Length"); i++) {
				OnsMqttGroupIdListResponse.OnsMqttGroupIdList_MqttGroupIdDo mqttGroupIdDo = new OnsMqttGroupIdListResponse.OnsMqttGroupIdList_MqttGroupIdDo();
				mqttGroupIdDo.Id = _ctx.LongValue("OnsMqttGroupIdList.Data["+ i +"].Id");
				mqttGroupIdDo.ChannelId = _ctx.IntegerValue("OnsMqttGroupIdList.Data["+ i +"].ChannelId");
				mqttGroupIdDo.Owner = _ctx.StringValue("OnsMqttGroupIdList.Data["+ i +"].Owner");
				mqttGroupIdDo.GroupId = _ctx.StringValue("OnsMqttGroupIdList.Data["+ i +"].GroupId");
				mqttGroupIdDo.Topic = _ctx.StringValue("OnsMqttGroupIdList.Data["+ i +"].Topic");
				mqttGroupIdDo.Status = _ctx.IntegerValue("OnsMqttGroupIdList.Data["+ i +"].Status");
				mqttGroupIdDo.CreateTime = _ctx.LongValue("OnsMqttGroupIdList.Data["+ i +"].CreateTime");
				mqttGroupIdDo.UpdateTime = _ctx.LongValue("OnsMqttGroupIdList.Data["+ i +"].UpdateTime");
				mqttGroupIdDo.InstanceId = _ctx.StringValue("OnsMqttGroupIdList.Data["+ i +"].InstanceId");
				mqttGroupIdDo.IndependentNaming = _ctx.BooleanValue("OnsMqttGroupIdList.Data["+ i +"].IndependentNaming");

				onsMqttGroupIdListResponse_data.Add(mqttGroupIdDo);
			}
			onsMqttGroupIdListResponse.Data = onsMqttGroupIdListResponse_data;
        
			return onsMqttGroupIdListResponse;
        }
    }
}
