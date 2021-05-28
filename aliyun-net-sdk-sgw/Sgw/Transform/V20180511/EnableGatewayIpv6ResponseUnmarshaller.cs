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
    public class EnableGatewayIpv6ResponseUnmarshaller
    {
        public static EnableGatewayIpv6Response Unmarshall(UnmarshallerContext _ctx)
        {
			EnableGatewayIpv6Response enableGatewayIpv6Response = new EnableGatewayIpv6Response();

			enableGatewayIpv6Response.HttpResponse = _ctx.HttpResponse;
			enableGatewayIpv6Response.RequestId = _ctx.StringValue("EnableGatewayIpv6.RequestId");
			enableGatewayIpv6Response.Success = _ctx.BooleanValue("EnableGatewayIpv6.Success");
			enableGatewayIpv6Response.Code = _ctx.StringValue("EnableGatewayIpv6.Code");
			enableGatewayIpv6Response.Message = _ctx.StringValue("EnableGatewayIpv6.Message");
			enableGatewayIpv6Response.TaskId = _ctx.StringValue("EnableGatewayIpv6.TaskId");
        
			return enableGatewayIpv6Response;
        }
    }
}
