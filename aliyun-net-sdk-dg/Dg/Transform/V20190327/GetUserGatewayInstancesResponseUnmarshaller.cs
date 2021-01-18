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
using Aliyun.Acs.dg.Model.V20190327;

namespace Aliyun.Acs.dg.Transform.V20190327
{
    public class GetUserGatewayInstancesResponseUnmarshaller
    {
        public static GetUserGatewayInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetUserGatewayInstancesResponse getUserGatewayInstancesResponse = new GetUserGatewayInstancesResponse();

			getUserGatewayInstancesResponse.HttpResponse = _ctx.HttpResponse;
			getUserGatewayInstancesResponse.RequestId = _ctx.StringValue("GetUserGatewayInstances.RequestId");
			getUserGatewayInstancesResponse.Success = _ctx.BooleanValue("GetUserGatewayInstances.Success");
			getUserGatewayInstancesResponse.Code = _ctx.StringValue("GetUserGatewayInstances.Code");
			getUserGatewayInstancesResponse.ErrorMsg = _ctx.StringValue("GetUserGatewayInstances.ErrorMsg");
			getUserGatewayInstancesResponse.Data = _ctx.StringValue("GetUserGatewayInstances.Data");
        
			return getUserGatewayInstancesResponse;
        }
    }
}
