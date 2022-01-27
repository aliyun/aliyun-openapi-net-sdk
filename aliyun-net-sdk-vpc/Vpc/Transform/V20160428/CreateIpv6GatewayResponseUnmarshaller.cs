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
using Aliyun.Acs.Vpc.Model.V20160428;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class CreateIpv6GatewayResponseUnmarshaller
    {
        public static CreateIpv6GatewayResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateIpv6GatewayResponse createIpv6GatewayResponse = new CreateIpv6GatewayResponse();

			createIpv6GatewayResponse.HttpResponse = _ctx.HttpResponse;
			createIpv6GatewayResponse.RequestId = _ctx.StringValue("CreateIpv6Gateway.RequestId");
			createIpv6GatewayResponse.Ipv6GatewayId = _ctx.StringValue("CreateIpv6Gateway.Ipv6GatewayId");
        
			return createIpv6GatewayResponse;
        }
    }
}
