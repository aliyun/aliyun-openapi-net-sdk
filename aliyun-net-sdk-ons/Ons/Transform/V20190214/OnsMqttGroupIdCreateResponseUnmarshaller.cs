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
    public class OnsMqttGroupIdCreateResponseUnmarshaller
    {
        public static OnsMqttGroupIdCreateResponse Unmarshall(UnmarshallerContext context)
        {
			OnsMqttGroupIdCreateResponse onsMqttGroupIdCreateResponse = new OnsMqttGroupIdCreateResponse();

			onsMqttGroupIdCreateResponse.HttpResponse = context.HttpResponse;
			onsMqttGroupIdCreateResponse.RequestId = context.StringValue("OnsMqttGroupIdCreate.RequestId");
			onsMqttGroupIdCreateResponse.HelpUrl = context.StringValue("OnsMqttGroupIdCreate.HelpUrl");
        
			return onsMqttGroupIdCreateResponse;
        }
    }
}