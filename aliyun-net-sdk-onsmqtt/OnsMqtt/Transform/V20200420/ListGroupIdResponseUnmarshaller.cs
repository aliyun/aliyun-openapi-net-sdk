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
using Aliyun.Acs.OnsMqtt.Model.V20200420;

namespace Aliyun.Acs.OnsMqtt.Transform.V20200420
{
    public class ListGroupIdResponseUnmarshaller
    {
        public static ListGroupIdResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListGroupIdResponse listGroupIdResponse = new ListGroupIdResponse();

			listGroupIdResponse.HttpResponse = _ctx.HttpResponse;
			listGroupIdResponse.RequestId = _ctx.StringValue("ListGroupId.RequestId");

			List<ListGroupIdResponse.ListGroupId_MqttGroupIdDo> listGroupIdResponse_data = new List<ListGroupIdResponse.ListGroupId_MqttGroupIdDo>();
			for (int i = 0; i < _ctx.Length("ListGroupId.Data.Length"); i++) {
				ListGroupIdResponse.ListGroupId_MqttGroupIdDo mqttGroupIdDo = new ListGroupIdResponse.ListGroupId_MqttGroupIdDo();
				mqttGroupIdDo.CreateTime = _ctx.LongValue("ListGroupId.Data["+ i +"].CreateTime");
				mqttGroupIdDo.GroupId = _ctx.StringValue("ListGroupId.Data["+ i +"].GroupId");
				mqttGroupIdDo.IndependentNaming = _ctx.BooleanValue("ListGroupId.Data["+ i +"].IndependentNaming");
				mqttGroupIdDo.InstanceId = _ctx.StringValue("ListGroupId.Data["+ i +"].InstanceId");
				mqttGroupIdDo.UpdateTime = _ctx.LongValue("ListGroupId.Data["+ i +"].UpdateTime");

				listGroupIdResponse_data.Add(mqttGroupIdDo);
			}
			listGroupIdResponse.Data = listGroupIdResponse_data;
        
			return listGroupIdResponse;
        }
    }
}
