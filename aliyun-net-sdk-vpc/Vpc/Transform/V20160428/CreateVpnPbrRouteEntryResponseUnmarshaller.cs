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
    public class CreateVpnPbrRouteEntryResponseUnmarshaller
    {
        public static CreateVpnPbrRouteEntryResponse Unmarshall(UnmarshallerContext context)
        {
			CreateVpnPbrRouteEntryResponse createVpnPbrRouteEntryResponse = new CreateVpnPbrRouteEntryResponse();

			createVpnPbrRouteEntryResponse.HttpResponse = context.HttpResponse;
			createVpnPbrRouteEntryResponse.RequestId = context.StringValue("CreateVpnPbrRouteEntry.RequestId");
			createVpnPbrRouteEntryResponse.VpnInstanceId = context.StringValue("CreateVpnPbrRouteEntry.VpnInstanceId");
			createVpnPbrRouteEntryResponse.RouteSource = context.StringValue("CreateVpnPbrRouteEntry.RouteSource");
			createVpnPbrRouteEntryResponse.RouteDest = context.StringValue("CreateVpnPbrRouteEntry.RouteDest");
			createVpnPbrRouteEntryResponse.NextHop = context.StringValue("CreateVpnPbrRouteEntry.NextHop");
			createVpnPbrRouteEntryResponse.Weight = context.IntegerValue("CreateVpnPbrRouteEntry.Weight");
			createVpnPbrRouteEntryResponse.OverlayMode = context.StringValue("CreateVpnPbrRouteEntry.OverlayMode");
			createVpnPbrRouteEntryResponse.Description = context.StringValue("CreateVpnPbrRouteEntry.Description");
			createVpnPbrRouteEntryResponse.State = context.StringValue("CreateVpnPbrRouteEntry.State");
			createVpnPbrRouteEntryResponse.CreateTime = context.LongValue("CreateVpnPbrRouteEntry.CreateTime");
        
			return createVpnPbrRouteEntryResponse;
        }
    }
}
