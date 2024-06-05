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
    public class GetUserGatewaysResponseUnmarshaller
    {
        public static GetUserGatewaysResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetUserGatewaysResponse getUserGatewaysResponse = new GetUserGatewaysResponse();

			getUserGatewaysResponse.HttpResponse = _ctx.HttpResponse;
			getUserGatewaysResponse.RequestId = _ctx.StringValue("GetUserGateways.RequestId");
			getUserGatewaysResponse.Success = _ctx.BooleanValue("GetUserGateways.Success");
			getUserGatewaysResponse.Code = _ctx.StringValue("GetUserGateways.Code");
			getUserGatewaysResponse.ErrorMsg = _ctx.StringValue("GetUserGateways.ErrorMsg");
			getUserGatewaysResponse.Count = _ctx.IntegerValue("GetUserGateways.Count");

			List<GetUserGatewaysResponse.GetUserGateways_Gateway> getUserGatewaysResponse_gatewayList = new List<GetUserGatewaysResponse.GetUserGateways_Gateway>();
			for (int i = 0; i < _ctx.Length("GetUserGateways.GatewayList.Length"); i++) {
				GetUserGatewaysResponse.GetUserGateways_Gateway gateway = new GetUserGatewaysResponse.GetUserGateways_Gateway();
				gateway.GatewayDesc = _ctx.StringValue("GetUserGateways.GatewayList["+ i +"].GatewayDesc");
				gateway.GatewayName = _ctx.StringValue("GetUserGateways.GatewayList["+ i +"].GatewayName");
				gateway.RegionId = _ctx.StringValue("GetUserGateways.GatewayList["+ i +"].RegionId");
				gateway.GatewayId = _ctx.StringValue("GetUserGateways.GatewayList["+ i +"].GatewayId");
				gateway.Status = _ctx.StringValue("GetUserGateways.GatewayList["+ i +"].Status");
				gateway.UserId = _ctx.StringValue("GetUserGateways.GatewayList["+ i +"].UserId");
				gateway.CreatorId = _ctx.StringValue("GetUserGateways.GatewayList["+ i +"].CreatorId");
				gateway.DgVersion = _ctx.StringValue("GetUserGateways.GatewayList["+ i +"].DgVersion");
				gateway.ExceptionMsg = _ctx.StringValue("GetUserGateways.GatewayList["+ i +"].ExceptionMsg");
				gateway.NumOfExceptionInstance = _ctx.IntegerValue("GetUserGateways.GatewayList["+ i +"].NumOfExceptionInstance");
				gateway.NumOfRunningInstance = _ctx.IntegerValue("GetUserGateways.GatewayList["+ i +"].NumOfRunningInstance");

				getUserGatewaysResponse_gatewayList.Add(gateway);
			}
			getUserGatewaysResponse.GatewayList = getUserGatewaysResponse_gatewayList;
        
			return getUserGatewaysResponse;
        }
    }
}
