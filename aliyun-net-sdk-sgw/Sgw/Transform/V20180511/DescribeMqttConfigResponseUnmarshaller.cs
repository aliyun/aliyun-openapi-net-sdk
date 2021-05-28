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
using Aliyun.Acs.sgw.Model.V20180511;

namespace Aliyun.Acs.sgw.Transform.V20180511
{
    public class DescribeMqttConfigResponseUnmarshaller
    {
        public static DescribeMqttConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeMqttConfigResponse describeMqttConfigResponse = new DescribeMqttConfigResponse();

			describeMqttConfigResponse.HttpResponse = _ctx.HttpResponse;
			describeMqttConfigResponse.RequestId = _ctx.StringValue("DescribeMqttConfig.RequestId");
			describeMqttConfigResponse.Success = _ctx.BooleanValue("DescribeMqttConfig.Success");
			describeMqttConfigResponse.Code = _ctx.StringValue("DescribeMqttConfig.Code");
			describeMqttConfigResponse.Message = _ctx.StringValue("DescribeMqttConfig.Message");
			describeMqttConfigResponse.IsEnabled = _ctx.BooleanValue("DescribeMqttConfig.IsEnabled");
			describeMqttConfigResponse.BrokerUrl = _ctx.StringValue("DescribeMqttConfig.BrokerUrl");
			describeMqttConfigResponse.InternalBrokerUrl = _ctx.StringValue("DescribeMqttConfig.InternalBrokerUrl");
			describeMqttConfigResponse.PublishTopic = _ctx.StringValue("DescribeMqttConfig.PublishTopic");
			describeMqttConfigResponse.SubscribeTopic = _ctx.StringValue("DescribeMqttConfig.SubscribeTopic");
			describeMqttConfigResponse.GroupId = _ctx.StringValue("DescribeMqttConfig.GroupId");
			describeMqttConfigResponse.MqttInstanceId = _ctx.StringValue("DescribeMqttConfig.MqttInstanceId");
			describeMqttConfigResponse.AuthType = _ctx.StringValue("DescribeMqttConfig.AuthType");
			describeMqttConfigResponse.Username = _ctx.StringValue("DescribeMqttConfig.Username");
			describeMqttConfigResponse.Password = _ctx.StringValue("DescribeMqttConfig.Password");
        
			return describeMqttConfigResponse;
        }
    }
}
