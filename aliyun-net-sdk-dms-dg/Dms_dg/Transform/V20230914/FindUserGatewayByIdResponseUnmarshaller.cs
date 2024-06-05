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
using Aliyun.Acs.dms_dg.Model.V20230914;

namespace Aliyun.Acs.dms_dg.Transform.V20230914
{
    public class FindUserGatewayByIdResponseUnmarshaller
    {
        public static FindUserGatewayByIdResponse Unmarshall(UnmarshallerContext _ctx)
        {
			FindUserGatewayByIdResponse findUserGatewayByIdResponse = new FindUserGatewayByIdResponse();

			findUserGatewayByIdResponse.HttpResponse = _ctx.HttpResponse;
			findUserGatewayByIdResponse.Code = _ctx.StringValue("FindUserGatewayById.Code");
			findUserGatewayByIdResponse.ErrorMsg = _ctx.StringValue("FindUserGatewayById.ErrorMsg");
			findUserGatewayByIdResponse.RequestId = _ctx.StringValue("FindUserGatewayById.RequestId");
			findUserGatewayByIdResponse.Success = _ctx.BooleanValue("FindUserGatewayById.Success");

			FindUserGatewayByIdResponse.FindUserGatewayById_Gateway gateway = new FindUserGatewayByIdResponse.FindUserGatewayById_Gateway();
			gateway.GatewayDesc = _ctx.StringValue("FindUserGatewayById.Gateway.GatewayDesc");
			gateway.GatewayName = _ctx.StringValue("FindUserGatewayById.Gateway.GatewayName");
			gateway.RegionId = _ctx.StringValue("FindUserGatewayById.Gateway.RegionId");
			gateway.GatewayId = _ctx.StringValue("FindUserGatewayById.Gateway.GatewayId");
			gateway.Status = _ctx.StringValue("FindUserGatewayById.Gateway.Status");
			gateway.UserId = _ctx.StringValue("FindUserGatewayById.Gateway.UserId");
			gateway.CreatorId = _ctx.StringValue("FindUserGatewayById.Gateway.CreatorId");
			gateway.DgVersion = _ctx.StringValue("FindUserGatewayById.Gateway.DgVersion");
			gateway.ExceptionMsg = _ctx.StringValue("FindUserGatewayById.Gateway.ExceptionMsg");
			gateway.NumOfExceptionInstance = _ctx.IntegerValue("FindUserGatewayById.Gateway.NumOfExceptionInstance");
			gateway.NumOfRunningInstance = _ctx.IntegerValue("FindUserGatewayById.Gateway.NumOfRunningInstance");
			findUserGatewayByIdResponse.Gateway = gateway;
        
			return findUserGatewayByIdResponse;
        }
    }
}
