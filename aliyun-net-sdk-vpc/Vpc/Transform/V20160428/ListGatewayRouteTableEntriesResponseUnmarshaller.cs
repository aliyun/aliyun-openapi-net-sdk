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
    public class ListGatewayRouteTableEntriesResponseUnmarshaller
    {
        public static ListGatewayRouteTableEntriesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListGatewayRouteTableEntriesResponse listGatewayRouteTableEntriesResponse = new ListGatewayRouteTableEntriesResponse();

			listGatewayRouteTableEntriesResponse.HttpResponse = _ctx.HttpResponse;
			listGatewayRouteTableEntriesResponse.NextToken = _ctx.StringValue("ListGatewayRouteTableEntries.NextToken");
			listGatewayRouteTableEntriesResponse.RequestId = _ctx.StringValue("ListGatewayRouteTableEntries.RequestId");
			listGatewayRouteTableEntriesResponse.TotalCount = _ctx.StringValue("ListGatewayRouteTableEntries.TotalCount");

			List<ListGatewayRouteTableEntriesResponse.ListGatewayRouteTableEntries_GatewayRouteEntryModelsItem> listGatewayRouteTableEntriesResponse_gatewayRouteEntryModels = new List<ListGatewayRouteTableEntriesResponse.ListGatewayRouteTableEntries_GatewayRouteEntryModelsItem>();
			for (int i = 0; i < _ctx.Length("ListGatewayRouteTableEntries.GatewayRouteEntryModels.Length"); i++) {
				ListGatewayRouteTableEntriesResponse.ListGatewayRouteTableEntries_GatewayRouteEntryModelsItem gatewayRouteEntryModelsItem = new ListGatewayRouteTableEntriesResponse.ListGatewayRouteTableEntries_GatewayRouteEntryModelsItem();
				gatewayRouteEntryModelsItem.Status = _ctx.StringValue("ListGatewayRouteTableEntries.GatewayRouteEntryModels["+ i +"].Status");
				gatewayRouteEntryModelsItem.NextHopId = _ctx.StringValue("ListGatewayRouteTableEntries.GatewayRouteEntryModels["+ i +"].NextHopId");
				gatewayRouteEntryModelsItem.Description = _ctx.StringValue("ListGatewayRouteTableEntries.GatewayRouteEntryModels["+ i +"].Description");
				gatewayRouteEntryModelsItem.NextHopType = _ctx.StringValue("ListGatewayRouteTableEntries.GatewayRouteEntryModels["+ i +"].NextHopType");
				gatewayRouteEntryModelsItem.DestinationCidrBlock = _ctx.StringValue("ListGatewayRouteTableEntries.GatewayRouteEntryModels["+ i +"].DestinationCidrBlock");
				gatewayRouteEntryModelsItem.Name = _ctx.StringValue("ListGatewayRouteTableEntries.GatewayRouteEntryModels["+ i +"].Name");

				listGatewayRouteTableEntriesResponse_gatewayRouteEntryModels.Add(gatewayRouteEntryModelsItem);
			}
			listGatewayRouteTableEntriesResponse.GatewayRouteEntryModels = listGatewayRouteTableEntriesResponse_gatewayRouteEntryModels;
        
			return listGatewayRouteTableEntriesResponse;
        }
    }
}
