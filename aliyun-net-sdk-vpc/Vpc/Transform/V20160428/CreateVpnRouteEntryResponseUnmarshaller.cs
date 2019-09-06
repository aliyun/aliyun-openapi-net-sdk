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
    public class CreateVpnRouteEntryResponseUnmarshaller
    {
        public static CreateVpnRouteEntryResponse Unmarshall(UnmarshallerContext context)
        {
			CreateVpnRouteEntryResponse createVpnRouteEntryResponse = new CreateVpnRouteEntryResponse();

			createVpnRouteEntryResponse.HttpResponse = context.HttpResponse;
			createVpnRouteEntryResponse.RequestId = context.StringValue("CreateVpnRouteEntry.RequestId");
			createVpnRouteEntryResponse.VpnInstanceId = context.StringValue("CreateVpnRouteEntry.VpnInstanceId");
			createVpnRouteEntryResponse.RouteDest = context.StringValue("CreateVpnRouteEntry.RouteDest");
			createVpnRouteEntryResponse.NextHop = context.StringValue("CreateVpnRouteEntry.NextHop");
			createVpnRouteEntryResponse.Weight = context.IntegerValue("CreateVpnRouteEntry.Weight");
			createVpnRouteEntryResponse.OverlayMode = context.StringValue("CreateVpnRouteEntry.OverlayMode");
			createVpnRouteEntryResponse.Description = context.StringValue("CreateVpnRouteEntry.Description");
			createVpnRouteEntryResponse.State = context.StringValue("CreateVpnRouteEntry.State");
			createVpnRouteEntryResponse.CreateTime = context.LongValue("CreateVpnRouteEntry.CreateTime");
        
			return createVpnRouteEntryResponse;
        }
    }
}
