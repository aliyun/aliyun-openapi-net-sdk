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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class QueryEdgeInstanceGatewayResponseUnmarshaller
    {
        public static QueryEdgeInstanceGatewayResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryEdgeInstanceGatewayResponse queryEdgeInstanceGatewayResponse = new QueryEdgeInstanceGatewayResponse();

			queryEdgeInstanceGatewayResponse.HttpResponse = _ctx.HttpResponse;
			queryEdgeInstanceGatewayResponse.RequestId = _ctx.StringValue("QueryEdgeInstanceGateway.RequestId");
			queryEdgeInstanceGatewayResponse.Success = _ctx.BooleanValue("QueryEdgeInstanceGateway.Success");
			queryEdgeInstanceGatewayResponse.Code = _ctx.StringValue("QueryEdgeInstanceGateway.Code");
			queryEdgeInstanceGatewayResponse.ErrorMessage = _ctx.StringValue("QueryEdgeInstanceGateway.ErrorMessage");

			List<QueryEdgeInstanceGatewayResponse.QueryEdgeInstanceGateway_Gateway> queryEdgeInstanceGatewayResponse_gatewayList = new List<QueryEdgeInstanceGatewayResponse.QueryEdgeInstanceGateway_Gateway>();
			for (int i = 0; i < _ctx.Length("QueryEdgeInstanceGateway.GatewayList.Length"); i++) {
				QueryEdgeInstanceGatewayResponse.QueryEdgeInstanceGateway_Gateway gateway = new QueryEdgeInstanceGatewayResponse.QueryEdgeInstanceGateway_Gateway();
				gateway.ProductKey = _ctx.StringValue("QueryEdgeInstanceGateway.GatewayList["+ i +"].ProductKey");
				gateway.DeviceName = _ctx.StringValue("QueryEdgeInstanceGateway.GatewayList["+ i +"].DeviceName");
				gateway.IotId = _ctx.StringValue("QueryEdgeInstanceGateway.GatewayList["+ i +"].IotId");
				gateway.EdgeVersion = _ctx.StringValue("QueryEdgeInstanceGateway.GatewayList["+ i +"].EdgeVersion");

				queryEdgeInstanceGatewayResponse_gatewayList.Add(gateway);
			}
			queryEdgeInstanceGatewayResponse.GatewayList = queryEdgeInstanceGatewayResponse_gatewayList;
        
			return queryEdgeInstanceGatewayResponse;
        }
    }
}
