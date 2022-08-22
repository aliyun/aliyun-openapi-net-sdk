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
    public class ListIpv4GatewaysResponseUnmarshaller
    {
        public static ListIpv4GatewaysResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListIpv4GatewaysResponse listIpv4GatewaysResponse = new ListIpv4GatewaysResponse();

			listIpv4GatewaysResponse.HttpResponse = _ctx.HttpResponse;
			listIpv4GatewaysResponse.NextToken = _ctx.StringValue("ListIpv4Gateways.NextToken");
			listIpv4GatewaysResponse.RequestId = _ctx.StringValue("ListIpv4Gateways.RequestId");
			listIpv4GatewaysResponse.TotalCount = _ctx.StringValue("ListIpv4Gateways.TotalCount");

			List<ListIpv4GatewaysResponse.ListIpv4Gateways_Ipv4GatewayModelsItem> listIpv4GatewaysResponse_ipv4GatewayModels = new List<ListIpv4GatewaysResponse.ListIpv4Gateways_Ipv4GatewayModelsItem>();
			for (int i = 0; i < _ctx.Length("ListIpv4Gateways.Ipv4GatewayModels.Length"); i++) {
				ListIpv4GatewaysResponse.ListIpv4Gateways_Ipv4GatewayModelsItem ipv4GatewayModelsItem = new ListIpv4GatewaysResponse.ListIpv4Gateways_Ipv4GatewayModelsItem();
				ipv4GatewayModelsItem.VpcId = _ctx.StringValue("ListIpv4Gateways.Ipv4GatewayModels["+ i +"].VpcId");
				ipv4GatewayModelsItem.Status = _ctx.StringValue("ListIpv4Gateways.Ipv4GatewayModels["+ i +"].Status");
				ipv4GatewayModelsItem.Ipv4GatewayId = _ctx.StringValue("ListIpv4Gateways.Ipv4GatewayModels["+ i +"].Ipv4GatewayId");
				ipv4GatewayModelsItem.Ipv4GatewayDescription = _ctx.StringValue("ListIpv4Gateways.Ipv4GatewayModels["+ i +"].Ipv4GatewayDescription");
				ipv4GatewayModelsItem.Enabled = _ctx.BooleanValue("ListIpv4Gateways.Ipv4GatewayModels["+ i +"].Enabled");
				ipv4GatewayModelsItem.GmtCreate = _ctx.StringValue("ListIpv4Gateways.Ipv4GatewayModels["+ i +"].GmtCreate");
				ipv4GatewayModelsItem.Ipv4GatewayRouteTableId = _ctx.StringValue("ListIpv4Gateways.Ipv4GatewayModels["+ i +"].Ipv4GatewayRouteTableId");
				ipv4GatewayModelsItem.Ipv4GatewayName = _ctx.StringValue("ListIpv4Gateways.Ipv4GatewayModels["+ i +"].Ipv4GatewayName");

				listIpv4GatewaysResponse_ipv4GatewayModels.Add(ipv4GatewayModelsItem);
			}
			listIpv4GatewaysResponse.Ipv4GatewayModels = listIpv4GatewaysResponse_ipv4GatewayModels;
        
			return listIpv4GatewaysResponse;
        }
    }
}
