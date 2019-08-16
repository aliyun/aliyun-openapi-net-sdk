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
        public static QueryEdgeInstanceGatewayResponse Unmarshall(UnmarshallerContext context)
        {
			QueryEdgeInstanceGatewayResponse queryEdgeInstanceGatewayResponse = new QueryEdgeInstanceGatewayResponse();

			queryEdgeInstanceGatewayResponse.HttpResponse = context.HttpResponse;
			queryEdgeInstanceGatewayResponse.RequestId = context.StringValue("QueryEdgeInstanceGateway.RequestId");
			queryEdgeInstanceGatewayResponse.Success = context.BooleanValue("QueryEdgeInstanceGateway.Success");
			queryEdgeInstanceGatewayResponse.Code = context.StringValue("QueryEdgeInstanceGateway.Code");
			queryEdgeInstanceGatewayResponse.ErrorMessage = context.StringValue("QueryEdgeInstanceGateway.ErrorMessage");

			List<QueryEdgeInstanceGatewayResponse.QueryEdgeInstanceGateway_Gateway> queryEdgeInstanceGatewayResponse_gatewayList = new List<QueryEdgeInstanceGatewayResponse.QueryEdgeInstanceGateway_Gateway>();
			for (int i = 0; i < context.Length("QueryEdgeInstanceGateway.GatewayList.Length"); i++) {
				QueryEdgeInstanceGatewayResponse.QueryEdgeInstanceGateway_Gateway gateway = new QueryEdgeInstanceGatewayResponse.QueryEdgeInstanceGateway_Gateway();
				gateway.ProductKey = context.StringValue("QueryEdgeInstanceGateway.GatewayList["+ i +"].ProductKey");
				gateway.DeviceName = context.StringValue("QueryEdgeInstanceGateway.GatewayList["+ i +"].DeviceName");
				gateway.IotId = context.StringValue("QueryEdgeInstanceGateway.GatewayList["+ i +"].IotId");
				gateway.EdgeVersion = context.StringValue("QueryEdgeInstanceGateway.GatewayList["+ i +"].EdgeVersion");

				queryEdgeInstanceGatewayResponse_gatewayList.Add(gateway);
			}
			queryEdgeInstanceGatewayResponse.GatewayList = queryEdgeInstanceGatewayResponse_gatewayList;
        
			return queryEdgeInstanceGatewayResponse;
        }
    }
}
