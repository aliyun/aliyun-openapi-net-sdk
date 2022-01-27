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
        public static CreateVpnPbrRouteEntryResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateVpnPbrRouteEntryResponse createVpnPbrRouteEntryResponse = new CreateVpnPbrRouteEntryResponse();

			createVpnPbrRouteEntryResponse.HttpResponse = _ctx.HttpResponse;
			createVpnPbrRouteEntryResponse.RequestId = _ctx.StringValue("CreateVpnPbrRouteEntry.RequestId");
			createVpnPbrRouteEntryResponse.VpnInstanceId = _ctx.StringValue("CreateVpnPbrRouteEntry.VpnInstanceId");
			createVpnPbrRouteEntryResponse.RouteSource = _ctx.StringValue("CreateVpnPbrRouteEntry.RouteSource");
			createVpnPbrRouteEntryResponse.RouteDest = _ctx.StringValue("CreateVpnPbrRouteEntry.RouteDest");
			createVpnPbrRouteEntryResponse.NextHop = _ctx.StringValue("CreateVpnPbrRouteEntry.NextHop");
			createVpnPbrRouteEntryResponse.Weight = _ctx.IntegerValue("CreateVpnPbrRouteEntry.Weight");
			createVpnPbrRouteEntryResponse.OverlayMode = _ctx.StringValue("CreateVpnPbrRouteEntry.OverlayMode");
			createVpnPbrRouteEntryResponse.Description = _ctx.StringValue("CreateVpnPbrRouteEntry.Description");
			createVpnPbrRouteEntryResponse.State = _ctx.StringValue("CreateVpnPbrRouteEntry.State");
			createVpnPbrRouteEntryResponse.CreateTime = _ctx.LongValue("CreateVpnPbrRouteEntry.CreateTime");
        
			return createVpnPbrRouteEntryResponse;
        }
    }
}
