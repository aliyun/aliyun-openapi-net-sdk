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
    public class GetUserGatewayInstancesResponseUnmarshaller
    {
        public static GetUserGatewayInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetUserGatewayInstancesResponse getUserGatewayInstancesResponse = new GetUserGatewayInstancesResponse();

			getUserGatewayInstancesResponse.HttpResponse = _ctx.HttpResponse;
			getUserGatewayInstancesResponse.Code = _ctx.StringValue("GetUserGatewayInstances.Code");
			getUserGatewayInstancesResponse.ErrorMsg = _ctx.StringValue("GetUserGatewayInstances.ErrorMsg");
			getUserGatewayInstancesResponse.RequestId = _ctx.StringValue("GetUserGatewayInstances.RequestId");
			getUserGatewayInstancesResponse.Success = _ctx.BooleanValue("GetUserGatewayInstances.Success");

			List<GetUserGatewayInstancesResponse.GetUserGatewayInstances_GatewayInstance> getUserGatewayInstancesResponse_gatewayInstanceList = new List<GetUserGatewayInstancesResponse.GetUserGatewayInstances_GatewayInstance>();
			for (int i = 0; i < _ctx.Length("GetUserGatewayInstances.GatewayInstanceList.Length"); i++) {
				GetUserGatewayInstancesResponse.GetUserGatewayInstances_GatewayInstance gatewayInstance = new GetUserGatewayInstancesResponse.GetUserGatewayInstances_GatewayInstance();
				gatewayInstance.GatewayInstanceId = _ctx.StringValue("GetUserGatewayInstances.GatewayInstanceList["+ i +"].GatewayInstanceId");
				gatewayInstance.GatewayId = _ctx.StringValue("GetUserGatewayInstances.GatewayInstanceList["+ i +"].GatewayId");
				gatewayInstance.LastUpdateTime = _ctx.LongValue("GetUserGatewayInstances.GatewayInstanceList["+ i +"].LastUpdateTime");
				gatewayInstance.LocalIP = _ctx.StringValue("GetUserGatewayInstances.GatewayInstanceList["+ i +"].LocalIP");
				gatewayInstance.OutputIP = _ctx.StringValue("GetUserGatewayInstances.GatewayInstanceList["+ i +"].OutputIP");
				gatewayInstance.Message = _ctx.StringValue("GetUserGatewayInstances.GatewayInstanceList["+ i +"].Message");
				gatewayInstance.EndPoint = _ctx.StringValue("GetUserGatewayInstances.GatewayInstanceList["+ i +"].EndPoint");
				gatewayInstance.CurrentDaemonVersion = _ctx.StringValue("GetUserGatewayInstances.GatewayInstanceList["+ i +"].CurrentDaemonVersion");
				gatewayInstance.CurrentVersion = _ctx.StringValue("GetUserGatewayInstances.GatewayInstanceList["+ i +"].CurrentVersion");
				gatewayInstance.RegionId = _ctx.StringValue("GetUserGatewayInstances.GatewayInstanceList["+ i +"].RegionId");
				gatewayInstance.ConnectEndpointType = _ctx.StringValue("GetUserGatewayInstances.GatewayInstanceList["+ i +"].ConnectEndpointType");
				gatewayInstance.GatewayInstanceStatus = _ctx.StringValue("GetUserGatewayInstances.GatewayInstanceList["+ i +"].GatewayInstanceStatus");

				getUserGatewayInstancesResponse_gatewayInstanceList.Add(gatewayInstance);
			}
			getUserGatewayInstancesResponse.GatewayInstanceList = getUserGatewayInstancesResponse_gatewayInstanceList;
        
			return getUserGatewayInstancesResponse;
        }
    }
}
